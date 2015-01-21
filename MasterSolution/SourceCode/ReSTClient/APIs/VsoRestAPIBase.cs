using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    /// <summary>
    ///     Class VsoRestAPIBase.
    /// </summary>
    public class VsoRestAPIBase : RestAPIBase
    {
 


        private static StructuredHttpExchange MakeCollectionScopeRequestString(StructuredHttpExchange exchange)
        {
            if (exchange.BaseRoute == null)
               exchange.BaseRoute =  VSOClientManager.VsoCollection + "/_apis";
            else
            {
                exchange.BaseRoute = VSOClientManager.VsoCollection + "/_apis" + exchange.BaseRoute;
            }
            exchange.SetQuery("api-version", "1.0");
            return exchange;
        }

        /// <summary>
        /// Makes the project scope request string.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="exchange">The exchange.</param>
        /// <returns>StructuredHttpExchange.</returns>
        private static StructuredHttpExchange MakeProjectScopeRequestString(string project, StructuredHttpExchange exchange)
        {
            if (String.IsNullOrWhiteSpace(project))
                throw new Exception("Project Name must be Specified");
            exchange.BaseRoute = VSOClientManager.VsoCollection + "/" + project + "/_apis";
            exchange.SetQuery("api-version", "1.0");
            return exchange;
        }

        /// <summary>
        /// Processes the collection request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exchange">The exchange.</param>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;T&gt;&gt;.</returns>
        protected Task<IReadOnlyList<T>> ProcessCollectionRequest<T>(StructuredHttpExchange exchange, Func<JObject, IReadOnlyList<T>> func) { return ProcessRequest(MakeCollectionScopeRequestString(exchange), func); }

       
        /// <summary>
        /// Processes the collection request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exchange">The exchange.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected Task<T> ProcessCollectionRequest<T>(StructuredHttpExchange exchange, Func<JObject, T> xform)
        { return ProcessRequest(MakeCollectionScopeRequestString(exchange), xform); }

 
        /// <summary>
        /// Processes the project request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="project">The project.</param>
        /// <param name="exchange">The exchange.</param>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;T&gt;&gt;.</returns>
        protected Task<IReadOnlyList<T>> ProcessProjectRequest<T>(string project, StructuredHttpExchange exchange, Func<JObject, IReadOnlyList<T>> func) { return ProcessRequest(MakeProjectScopeRequestString(project, exchange), func); }
        /// <summary>
        /// Processes the project request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="project">The project.</param>
        /// <param name="exchange">The exchange.</param>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected Task<T> ProcessProjectRequest<T>(string project, StructuredHttpExchange exchange, Func<JObject, T> func) { return ProcessRequest(MakeProjectScopeRequestString(project, exchange), func); }

  
       }
}