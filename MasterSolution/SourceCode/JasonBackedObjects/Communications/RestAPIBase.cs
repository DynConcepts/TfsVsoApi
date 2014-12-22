using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects.Communications
{
    /// <summary>
    ///     Class RestAPIBase.
    /// </summary>
    public class RestAPIBase
    {
        protected async Task<T> ProcessRequest<T>(StructuredHttpExchange exchange, Func<JObject, T> xform) { return await r_ClientManager.ProcessRequestJObject(exchange, xform); }


        /// <summary>
        ///     To the comma list.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>System.String.</returns>
        protected static string ToCommaList(IEnumerable<int> ids)
        {
            string result = String.Empty;
            foreach (int id in ids)
            {
                if (!String.IsNullOrEmpty(result))
                    result += ",";
                result += id;
            }
            return result;
        }

        /// <summary>
        ///     To the json string.
        /// </summary>
        /// <param name="elements">The elements.</param>
        /// <returns>System.String.</returns>
        protected static string ToJsonString(JArray elements)
        {
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);
            using (JsonWriter jsonWriter = new JsonTextWriter(sw))
            {
                elements.WriteTo(jsonWriter);
            }
            string body = sb.ToString();
            return body;
        }

        /// <summary>
        ///     The _client manager
        /// </summary>
        private readonly RestClientManager r_ClientManager = new RestClientManager();
    }
}