using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    ///     Implements Functionallity of a JSON Backed TFS/VSO Area.
    /// </summary>
    internal class JsonArea : JsonClassificationNode, IArea
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>IArea.</returns>
        public static IArea FromToken(JToken content)
        {
            var area = new JsonArea();
            foreach (JProperty property in content)
            {
                switch (property.Name)
                {
                    case "children":
                        foreach (JToken child in ((JArray) property.Value))
                        {
                            IArea childArea = FromToken(child);
                            ((JsonArea) childArea).Parent = area;
                            area.Children.Add(childArea);
                        }
                        break;
                    default:
                        ProcessProperty(area, property);
                        break;
                }
            }
            return area;
        }

        /// <summary>
        ///     Gets the children.
        /// </summary>
        /// <value>The children.</value>
        public IList<IArea> Children { get { return r_Children; } }

        /// <summary>
        ///     Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        public IArea Parent { get; private set; }

        /// <summary>
        ///     The _children
        /// </summary>
        private readonly List<IArea> r_Children = new List<IArea>();
    }
}