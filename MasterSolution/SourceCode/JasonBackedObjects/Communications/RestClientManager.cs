using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.Core;
using DynCon.OSI.Core.AdvancedEvents;
using DynCon.OSI.VSO.SharedInterfaces.ReSTHelpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects.Communications
{
    /// <summary>
    /// Class RestClientManager.
    /// </summary>
    public class RestClientManager
    {
  
        /// <summary>
        /// Gets or sets the Basic Authorization username.
        /// </summary>
        /// <value>The username.</value>
        public static string BasicAuthorizationUsername { get; set; }

        /// <summary>
        /// Gets or sets the BasicAuthorization password.
        /// </summary>
        /// <value>The password.</value>
        public static string BasicAuthorizationPassword { get; set; }


        /// <summary>
        /// Creates the client.
        /// </summary>
        private void CreateClient()
        {
            lock (r_SyncRoot)
            {
                if (_client == null)
                {
                    _client = new HttpClientLive();
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    Fire_OnClientCreated(_client);

                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(
                            Encoding.ASCII.GetBytes(string.Format("{0}:{1}", BasicAuthorizationUsername, BasicAuthorizationPassword))));

                    _deadman = TaskHelpers.DeadmanAction(TimeSpan.FromMilliseconds(1000), FreeClient);

                }
            }
        }

        public static event EventHandler<GenericEventArgs<IHttpClient>>  OnClientCreated;

        private void Fire_OnClientCreated(IHttpClient client)
        {
            var shadow = OnClientCreated;
            if (shadow != null)
                shadow(this, new GenericEventArgs<IHttpClient>(client));
        }

        /// <summary>
        /// Frees the client.
        /// </summary>
        private void FreeClient()
        {
            lock (r_SyncRoot)
            {
                if (_client != null)
                {
                    _client.Dispose();
                    _client = null;
                }
            }
        }

  
#pragma warning disable 1998
        /// <summary>
        /// Processes the request stream.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        internal async Task<T> ProcessRequestStream<T>(HttpRequestMessage request, Func<Stream, T> xform)
#pragma warning restore 1998
        {
            T result = default(T);
            UseClient(async client =>
            {
                try
                {
                    using (HttpResponseMessage response = client.SendAsync(request).Result)
                    {
                        response.EnsureSuccessStatusCode();
                        Stream responseBody = await response.Content.ReadAsStreamAsync();
                        result = xform(responseBody);
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    throw;
                }

            });
            return result;
        }

        /// <summary>
        /// Processes the request j object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        internal async Task<T> ProcessRequestJObject<T>(HttpRequestMessage request, Func<JObject, T> xform)
        {
            T result = default(T);
            await ProcessRequestStream(request, stream =>
            {
                //var x = new StreamReader(stream);
                //var content = x.ReadToEnd();
                //using (var w = new StreamWriter("Debug.xml"))
                //{
                //    w.Write(content);
                //}
                var reader = new JsonTextReader(new StreamReader(stream));
                var jObject = JObject.Load(reader);
                result = xform(jObject);
                return result;
            });
            return result;
        }


        /// <summary>
        /// Uses the client.
        /// </summary>
        /// <param name="action">The action.</param>
        private void UseClient(Action<IHttpClient> action)
        {
            lock (r_SyncRoot)
            {
                if (_client == null)
                {
                    CreateClient();
                }
                else
                {
                    _deadman.ReTrigger();
                }
                action(_client);
            }
        }

        /// <summary>
        /// The r_ synchronize root
        /// </summary>
        private readonly object r_SyncRoot = new object();

        /// <summary>
        /// The _client
        /// </summary>
        private IHttpClient _client;
        /// <summary>
        /// The _deadman
        /// </summary>
        private TaskHelpers.DeadmanHandle _deadman;
    }
}
