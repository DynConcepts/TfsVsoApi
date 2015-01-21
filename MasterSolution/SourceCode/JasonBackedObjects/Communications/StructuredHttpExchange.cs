using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using DynCon.OSI.Core.Helpers;

namespace DynCon.OSI.JasonBackedObjects.Communications
{
    /// <summary>
    ///     Class StructuredHttpExchange.
    /// </summary>
    public class StructuredHttpExchange
    {
        /// <summary>
        ///     Gets the specified spec.
        /// </summary>
        /// <param name="spec">The spec.</param>
        /// <returns>StructuredHttpExchange.</returns>
        public static StructuredHttpExchange Get(CallSpec spec)
        {
            var retVal = new StructuredHttpExchange(spec)
            {
                Method = HttpMethod.Get
            };
            return retVal;
        }

        /// <summary>
        ///     Gets the specified relative route.
        /// </summary>
        /// <param name="relativeRoute">The relative route.</param>
        /// <returns>StructuredHttpExchange.</returns>
        public static StructuredHttpExchange Get(string relativeRoute)
        {
            var retVal = new StructuredHttpExchange
            {
                RelativeRoute = relativeRoute,
                Method = HttpMethod.Get
            };
            return retVal;
        }

        /// <summary>
        ///     Gets the specified URI.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>StructuredHttpExchange.</returns>
        public static StructuredHttpExchange Get(Uri uri)
        {
            var retVal = new StructuredHttpExchange
            {
                BaseRoute = uri.AbsoluteUri,
                Method = HttpMethod.Get
            };
            return retVal;
        }

        /// <summary>
        ///     Optionses the specified relative route.
        /// </summary>
        /// <param name="relativeRoute">The relative route.</param>
        /// <returns>StructuredHttpExchange.</returns>
        public static StructuredHttpExchange Options(string relativeRoute)
        {
            var retVal = new StructuredHttpExchange
            {
                RelativeRoute = relativeRoute,
                Method = HttpMethod.Options
            };
            return retVal;
        }

        /// <summary>
        ///     Patches the specified relative route.
        /// </summary>
        /// <param name="relativeRoute">The relative route.</param>
        /// <param name="body">The body.</param>
        /// <returns>StructuredHttpExchange.</returns>
        public static StructuredHttpExchange Patch(string relativeRoute, string body)
        {
            var retVal = new StructuredHttpExchange
            {
                RelativeRoute = relativeRoute,
                Method = new HttpMethod("PATCH"),
                Body = body
            };
            return retVal;
        }

        /// <summary>
        ///     Patches the specified spec.
        /// </summary>
        /// <param name="spec">The spec.</param>
        /// <param name="body">The body.</param>
        /// <returns>StructuredHttpExchange.</returns>
        public static StructuredHttpExchange Patch(CallSpec spec, string body)
        {
            var retVal = new StructuredHttpExchange(spec)
            {
                Method = new HttpMethod("PATCH"),
                Body = body
            };
            return retVal;
        }

        /// <summary>
        ///     Posts the specified relative route.
        /// </summary>
        /// <param name="relativeRoute">The relative route.</param>
        /// <param name="body">The body.</param>
        /// <returns>StructuredHttpExchange.</returns>
        public static StructuredHttpExchange Post(string relativeRoute, string body)
        {
            var retVal = new StructuredHttpExchange
            {
                RelativeRoute = relativeRoute,
                Method = HttpMethod.Post,
                Body = body
            };
            return retVal;
        }


        /// <summary>
        ///     Posts the specified spec.
        /// </summary>
        /// <param name="spec">The spec.</param>
        /// <param name="body">The body.</param>
        /// <returns>StructuredHttpExchange.</returns>
        public static StructuredHttpExchange Post(CallSpec spec, string body)
        {
            var retVal = new StructuredHttpExchange(spec)
            {
                Method = HttpMethod.Post,
                Body = body
            };
            return retVal;
        }


        /// <summary>
        ///     Marks as complete.
        /// </summary>
        public void MarkAsComplete()
        {
            Fire_OnExchangeComplete(this);
        }

        /// <summary>
        ///     Records the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public void RecordException(Exception exception)
        {
            m_Exception = exception;
            MarkAsComplete();
        }

        /// <summary>
        ///     Sets the parameter.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="value">The value.</param>
        public void SetParameter(int position, object value)
        {
            r_RequestPositionalParameters[position] = value;
        }

        /// <summary>
        ///     Sets the query.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void SetQuery(string key, object value)
        {
            r_QueryStringParameters[key] = value.ToString();
        }

        /// <summary>
        ///     Sets the route.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="System.Exception">Illegal Key</exception>
        public void SetRoute(string key, object value)
        {
            if (!r_RouteDictionary.ContainsKey(key))
            {
                throw new Exception("Illegal Key");
            }
            r_RouteDictionary[key] = value.ToString();
        }

        /// <summary>
        ///     Gets or sets the base route.
        /// </summary>
        /// <value>The base route.</value>
        public string BaseRoute
        {
            get { return m_BaseRoute; }
            set
            {
                if (value.StartsWith("http"))
                {
                    var uri = new Uri(value);
                    string full = uri.AbsolutePath;
                    int hIndex = uri.AbsoluteUri.IndexOf(full, StringComparison.Ordinal);
                    if (hIndex >= 0)
                    {
                        Host = uri.AbsoluteUri.Substring(0, hIndex);
                        m_BaseRoute = full;
                    }
                    else
                    {
                        m_BaseRoute = value;
                    }
                }
                else
                {
                    m_BaseRoute = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the body.
        /// </summary>
        /// <value>The body.</value>
        public string Body { get; set; }

        /// <summary>
        ///     Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        public Exception Exception { get { return m_Exception; } }

        /// <summary>
        ///     Gets the formatted request.
        /// </summary>
        /// <value>The formatted request.</value>
        public string FormattedRequest
        {
            get
            {
                var sb = new StringBuilder();
                var list = new List<object>();
                foreach (KeyValuePair<int, object> pair in r_RequestPositionalParameters)
                {
                    while (list.Count <= pair.Key)
                        list.Add(null);
                    list[pair.Key] = pair.Value;
                }
                sb.Append(Host);
                sb.Append(BaseRoute);
                string relative = RelativeRoute;
                if (r_RouteDictionary != null)
                    relative = StringFormatter.Build(relative, r_RouteDictionary);
                if (!string.IsNullOrWhiteSpace(relative))
                {
                    string routeBase = String.Format(relative, list.ToArray());
                    sb.Append(routeBase);
                }
                bool first = true;
                foreach (KeyValuePair<string, object> pair in r_QueryStringParameters)
                {
                    if (first)
                    {
                        sb.Append("?");
                        first = false;
                    }
                    else sb.Append("&");
                    sb.Append(pair.Key);
                    sb.Append("=");
                    sb.Append(pair.Value);
                }
                return sb.ToString();
            }
        }

        /// <summary>
        ///     Gets or sets the host.
        /// </summary>
        /// <value>The host.</value>
        public string Host { get; set; }

        /// <summary>
        ///     Gets or sets the method.
        /// </summary>
        /// <value>The method.</value>
        public HttpMethod Method { get; set; }

        /// <summary>
        ///     Gets or sets the network time.
        /// </summary>
        /// <value>The network time.</value>
        public TimeSpan NetworkTime { get; set; }

        /// <summary>
        ///     Gets the processing time.
        /// </summary>
        /// <value>The processing time.</value>
        public object ProcessingTime { get { return TotalTime - NetworkTime; } }

        /// <summary>
        ///     Gets the query string parameters.
        /// </summary>
        /// <value>The query string parameters.</value>
        public Dictionary<string, object> QueryStringParameters { get { return r_QueryStringParameters; } }

        /// <summary>
        ///     Gets or sets the request template.
        /// </summary>
        /// <value>The request template.</value>
        public string RelativeRoute { get; set; }

        /// <summary>
        ///     Gets the request message.
        /// </summary>
        /// <value>The request message.</value>
        public HttpRequestMessage RequestMessage
        {
            get
            {
                var httpRequestMessage = new HttpRequestMessage(Method, FormattedRequest);
                if (!String.IsNullOrWhiteSpace(Body))
                {
                    var content = new StringContent(Body);
                    switch (Method.Method)
                    {
                        case "PATCH":
                            content.Headers.ContentType = new MediaTypeHeaderValue("application/json-patch+json");
                            break;
                        default:
                            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                            break;
                    }
                    httpRequestMessage.Content = content;
                }
                return httpRequestMessage;
            }
        }

        /// <summary>
        ///     Gets the request positional parameters.
        /// </summary>
        /// <value>The request positional parameters.</value>
        public Dictionary<int, object> RequestPositionalParameters { get { return r_RequestPositionalParameters; } }

        /// <summary>
        ///     Gets or sets the response.
        /// </summary>
        /// <value>The response.</value>
        public string Response { get; set; }

        /// <summary>
        ///     Gets the time stamp.
        /// </summary>
        /// <value>The time stamp.</value>
        public DateTime TimeStamp { get { return r_TimeStamp; } }

        /// <summary>
        ///     Gets or sets the total time.
        /// </summary>
        /// <value>The total time.</value>
        public TimeSpan TotalTime { get; set; }

        /// <summary>
        ///     Prevents a default instance of the <see cref="StructuredHttpExchange" /> class from being created.
        /// </summary>
        private StructuredHttpExchange()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="StructuredHttpExchange" /> class.
        /// </summary>
        /// <param name="spec">The spec.</param>
        private StructuredHttpExchange(CallSpec spec)
        {
            string temp = spec.Template;
            if (temp.StartsWith("{project}/_apis")) temp = temp.Replace("{project}/_apis", "");
            if (temp.StartsWith("_apis")) temp = temp.Replace("_apis", "");
            RelativeRoute = temp;
            r_RouteDictionary = StringFormatter.Parse(RelativeRoute);
        }

        /// <summary>
        ///     Fire_s the on exchange complete.
        /// </summary>
        /// <param name="instance">The instance.</param>
        private static void Fire_OnExchangeComplete(StructuredHttpExchange instance)
        {
            EventHandler shadow = OnExchangeComplete;
            if (shadow != null)
            {
                shadow(instance, new EventArgs());
            }
        }

        ////[Obsolete]
        ////private static StructuredHttpExchange Parse(HttpRequestMessage request)
        ////{
        ////    var retVal = new StructuredHttpExchange();
        ////    retVal.Method = request.Method;
        ////    string full = request.RequestUri.AbsolutePath;
        ////    int hIndex = request.RequestUri.AbsoluteUri.IndexOf(full);
        ////    retVal.Host = request.RequestUri.AbsoluteUri.Substring(0, hIndex);
        ////    int qIndex = full.IndexOf("?", StringComparison.Ordinal);
        ////    string path;
        ////    if (qIndex >= 0)
        ////    {
        ////        path = full.Substring(0, qIndex);

        ////        string[] queries = full.Substring(qIndex + 1).Split('&');
        ////        foreach (string query in queries)
        ////        {
        ////            string[] parts = query.Split('=');
        ////            retVal.SetQuery(parts[0], parts[1]);
        ////        }
        ////    }
        ////    else
        ////    {
        ////        path = full;
        ////    }
        ////    int apiIndex = path.IndexOf("_apis/", System.StringComparison.Ordinal);
        ////    retVal.BaseRoute = path.Substring(0, apiIndex + 5);
        ////    retVal.RelativeRoute = path.Substring(apiIndex + 5);
        ////    return retVal;
        ////}

        /// <summary>
        ///     The m_ query string parameters
        /// </summary>
        private readonly Dictionary<string, object> r_QueryStringParameters = new Dictionary<string, object>();

        /// <summary>
        ///     The m_ request positional parameters
        /// </summary>
        private readonly Dictionary<int, object> r_RequestPositionalParameters = new Dictionary<int, object>();

        /// <summary>
        ///     The r_ route dictionary
        /// </summary>
        private readonly Dictionary<string, object> r_RouteDictionary;

        /// <summary>
        ///     The r_ time stamp
        /// </summary>
        private readonly DateTime r_TimeStamp = DateTime.UtcNow;

        /// <summary>
        ///     The m_ base route
        /// </summary>
        private string m_BaseRoute;

        /// <summary>
        ///     The m_ exception
        /// </summary>
        private Exception m_Exception;

        /// <summary>
        ///     Occurs when [on exchange complete].
        /// </summary>
        public static event EventHandler OnExchangeComplete;
    }
}