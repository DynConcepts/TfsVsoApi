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
        public static StructuredHttpExchange Get(CallSpec spec)
        {
            var retVal = new StructuredHttpExchange(spec)
            {
                Method = HttpMethod.Get
            };
            return retVal;
        }

        public static StructuredHttpExchange Get(string relativeRoute)
        {
            var retVal = new StructuredHttpExchange
            {
                RelativeRoute = relativeRoute,
                Method = HttpMethod.Get
            };
            return retVal;
        }

        public static StructuredHttpExchange Get(Uri uri)
        {
            var retVal = new StructuredHttpExchange
            {
                BaseRoute = uri.AbsoluteUri,
                Method = HttpMethod.Get
            };
            return retVal;
        }

        public static StructuredHttpExchange Options(string relativeRoute)
        {
            var retVal = new StructuredHttpExchange
            {
                RelativeRoute = relativeRoute,
                Method = HttpMethod.Options
            };
            return retVal;
        }

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

        public static StructuredHttpExchange Patch(CallSpec  spec, string body)
        {
            var retVal = new StructuredHttpExchange(spec)
            {
                Method = new HttpMethod("PATCH"),
                Body = body
            };
            return retVal;
        }

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


        public void MarkAsComplete() { Fire_OnExchangeComplete(this); }

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
        public void SetParameter(int position, object value) { r_RequestPositionalParameters[position] = value; }

        /// <summary>
        /// Sets the route.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="System.Exception">Illagal Key</exception>
        public void SetRoute(string key, object value)
        {
            if (!m_RouteDictionary.ContainsKey(key))
            {
                throw new Exception("Illagal Key");
            }
            m_RouteDictionary[key] = value.ToString();

        }

        /// <summary>
        ///     Sets the query.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void SetQuery(string key, object value) { r_QueryStringParameters[key] = value.ToString(); }

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

        public string Body { get; set; }
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
                if (m_RouteDictionary != null)
                    relative = StringFormatter.Build(relative, m_RouteDictionary);
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

        public string Host { get; set; }
        public HttpMethod Method { get; set; }
        public TimeSpan NetworkTime { get; set; }
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

        public string Response { get; set; }
        public DateTime TimeStamp { get { return r_TimeStamp; } }
        public TimeSpan TotalTime { get; set; }
        private StructuredHttpExchange() { }

        private StructuredHttpExchange(CallSpec spec)
        {
            var temp = spec.Template;
            if (temp.StartsWith("{project}/_apis")) temp = temp.Replace("{project}/_apis", "");
            if (temp.StartsWith("_apis")) temp = temp.Replace("_apis", "");
            RelativeRoute = temp;
            m_RouteDictionary = StringFormatter.Parse(RelativeRoute);
        }

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

        private readonly DateTime r_TimeStamp = DateTime.UtcNow;

        private string m_BaseRoute;

        private Exception m_Exception;
        private Dictionary<string, string> m_RouteDictionary;

        public static event EventHandler OnExchangeComplete;
    }
}