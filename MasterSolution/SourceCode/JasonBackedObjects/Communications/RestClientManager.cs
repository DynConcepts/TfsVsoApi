using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.Core.AdvancedEvents;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.ReSTHelpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects.Communications
{
    /// <summary>
    ///     Class RestClientManager.
    /// </summary>
    public class RestClientManager
    {
        /// <summary>
        ///     Gets or sets the Basic Authorization username.
        /// </summary>
        /// <value>The username.</value>
        public static string BasicAuthorizationUsername { get; set; }

        /// <summary>
        ///     Gets or sets the BasicAuthorization password.
        /// </summary>
        /// <value>The password.</value>
        public static string BasicAuthorizationPassword { get; set; }


        /// <summary>
        ///     Creates the client.
        /// </summary>
        private void CreateClient()
        {
            lock (r_SyncRoot)
            {
                if (m_Client == null)
                {
                    m_Client = new HttpClientLive();
                    m_Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    Fire_OnClientCreated(m_Client);

                    m_Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(
                            Encoding.ASCII.GetBytes(string.Format("{0}:{1}", BasicAuthorizationUsername, BasicAuthorizationPassword))));

                    m_Deadman = TaskHelpers.DeadmanAction(TimeSpan.FromMilliseconds(1000), FreeClient);
                }
            }
        }

        /// <summary>
        ///     Occurs when [on client created].
        /// </summary>
        public static event EventHandler<GenericEventArgs<IHttpClient>> OnClientCreated;

        private void Fire_OnClientCreated(IHttpClient client)
        {
            EventHandler<GenericEventArgs<IHttpClient>> shadow = OnClientCreated;
            if (shadow != null)
                shadow(this, new GenericEventArgs<IHttpClient>(client));
        }

        /// <summary>
        ///     Frees the client.
        /// </summary>
        private void FreeClient()
        {
            lock (r_SyncRoot)
            {
                if (m_Client != null)
                {
                    m_Client.Dispose();
                    m_Client = null;
                }
            }
        }


        public static bool ConsoleLogEnabled = true;


#pragma warning disable 1998
        internal async Task<T> ProcessRequestStream<T>(StructuredHttpExchange exchange, Func<Stream, T> xform)
#pragma warning restore 1998
        {
            var sw = new Stopwatch();
            sw.Start();
            Exception thrownException = null;
            var task = UseClientFunc<T>(async client =>
            {
                try
                {
                    HttpRequestMessage httpRequestMessage = exchange.RequestMessage;
                    using (HttpResponseMessage response = client.SendAsync(httpRequestMessage).Result)
                    {
                        CheckForSuccess<T>(httpRequestMessage, response);
                        Stream responseBody = await response.Content.ReadAsStreamAsync();
                        exchange.NetworkTime = sw.Elapsed;
                        var retVal = xform(responseBody);
                        exchange.TotalTime = sw.Elapsed;
                        exchange.MarkAsComplete();
                        return retVal;
                    }
                }
                catch (AggregateException ex)
                {
                    exchange.RecordException(ex);
                    thrownException = ex;
                    if (ex.InnerExceptions.Count == 1)
                        throw ex.InnerException;
                    throw;
                }
                catch (Exception ex)
                {
                    exchange.RecordException(ex);
                    Debug.WriteLine(ex.Message);
                    thrownException = ex;
                    throw;
                }
            });
            if (thrownException != null)
            {
                throw thrownException;
            }
            return task.Result;
        }

        ////#pragma warning disable 1998
        ////        /// <summary>
        ////        ///     Processes the request stream.
        ////        /// </summary>
        ////        /// <typeparam name="T"></typeparam>
        ////        /// <param name="request">The request.</param>
        ////        /// <param name="xform">The xform.</param>
        ////        /// <returns>Task&lt;T&gt;.</returns>
        ////        internal async Task<T> ProcessRequestStream<T>(HttpRequestMessage request, Func<Stream, T> xform)
        ////#pragma warning restore 1998
        ////        {
        ////            T result = default(T);
        ////            int correlationId = ++s_CorrelationId;
        ////            if (ConsoleLogEnabled)
        ////            {
        ////                Console.WriteLine("{0}, Request [{1}]: {2}", correlationId, request.Method, request.RequestUri);
        ////            }
        ////            var sw = new Stopwatch();
        ////            sw.Start();
        ////            var timing = new Timing();
        ////            Exception thrownException = null;
        ////            UseClient(async client =>
        ////            {
        ////                try
        ////                {
        ////                    using (HttpResponseMessage response = client.SendAsync(request).Result)
        ////                    {
        ////                        CheckForSuccess<T>(request, response);
        ////                        Stream responseBody = await response.Content.ReadAsStreamAsync();
        ////                        timing.NetworkTime = sw.Elapsed;
        ////                        result = xform(responseBody);
        ////                        timing.TotalTime = sw.Elapsed;
        ////                    }
        ////                }
        ////                catch (AggregateException ex)
        ////                {
        ////                    thrownException = ex;
        ////                    if (ex.InnerExceptions.Count == 1)
        ////                        throw ex.InnerException;
        ////                    throw;
        ////                }
        ////                catch (Exception ex)
        ////                {
        ////                    Debug.WriteLine(ex.Message);
        ////                    thrownException = ex;
        ////                    throw;
        ////                }
        ////            });
        ////            if (thrownException != null)
        ////            {
        ////                throw thrownException;
        ////            }
        ////            if (ConsoleLogEnabled)
        ////            {
        ////                Console.WriteLine("{0}, Timing -  Net:{1}mS,     Total:{2}mS       Process:{3}mS", correlationId, timing.NetworkTime.TotalMilliseconds, timing.TotalTime.TotalMilliseconds, (timing.TotalTime - timing.NetworkTime).TotalMilliseconds);
        ////            }
        ////            return result;
        ////        }

        private static void CheckForSuccess<T>(HttpRequestMessage request, HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                string message = String.Format("Response Code: {0} on {1}", response.StatusCode, request.RequestUri);
                throw new Exception(message);
            }
        }

        internal async Task<T> ProcessRequestJObject<T>(StructuredHttpExchange exchange, Func<JObject, T> xform)
        {
            T result = await ProcessRequestStream(exchange, stream =>
            {
                JObject jObject;
                try
                {
                    var reader = new JsonTextReader(new StreamReader(stream));
                    jObject = JObject.Load(reader);
                    exchange.Response = jObject.ToString();
                }
                catch (Exception ex)
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    var reader = new StreamReader(stream);
                    string content = reader.ReadToEnd();
                    exchange.Response = content;
                    throw new Exception(content, ex);
                }
                result = xform(jObject);
                return result;
            });
            return result;
        }


        /// <summary>
        ///     Uses the client.
        /// </summary>
        /// <param name="action">The action.</param>
        private void UseClient(Action<IHttpClient> action)
        {
            lock (r_SyncRoot)
            {
                if (m_Client == null)
                {
                    CreateClient();
                }
                else
                {
                    m_Deadman.ReTrigger();
                }
                action(m_Client);
            }
        }

        private Task<TResult> UseClientFunc<TResult>(Func<IHttpClient, Task<TResult>> action)
        {
            lock (r_SyncRoot)
            {
                if (m_Client == null)
                {
                    CreateClient();
                }
                else
                {
                    m_Deadman.ReTrigger();
                }
                return action(m_Client);
            }
        }

        /// <summary>
        ///     The r_ synchronize root
        /// </summary>
        private readonly object r_SyncRoot = new object();

        /// <summary>
        ///     The _client
        /// </summary>
        private IHttpClient m_Client;

        /// <summary>
        ///     The _deadman
        /// </summary>
        private TaskHelpers.DeadmanHandle m_Deadman;
    }
}