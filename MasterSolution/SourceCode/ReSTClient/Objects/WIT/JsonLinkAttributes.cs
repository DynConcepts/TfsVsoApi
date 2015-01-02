using System;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Class JsonLink.
    /// </summary>
    public class JsonLinkAttributes : JsonBackedObjectBase, ILinkImpl
    {
        private JsonLinkAttributes(JToken content) : base(content) {  }

        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonLink.</returns>
        public static JsonLinkAttributes FromToken(JToken content)
        {
            var instance = new JsonLinkAttributes(content);
            return instance;
        }

    }
}