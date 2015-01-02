using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Implements Functionallity of a JSON Backed TFS/VSO Area.
    /// </summary>
    public class JsonArea : JsonClassificationNode
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>IArea.</returns>
        public static JsonArea FromToken(JToken content)
        {
            var area = new JsonArea(content);
            foreach (JProperty property in content)
            {
                switch (property.Name)
                {
                    case "children":
                        foreach (JToken child in ((JArray) property.Value))
                        {
                            JsonArea childArea = FromToken(child);
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
        /// Gets the children.
        /// </summary>
        /// <value>The children.</value>
        public IList<JsonArea> Children { get { return r_Children; } }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        public JsonArea Parent { get { return m_Parent; } private set { m_Parent = value; } }

        /// <summary>
        /// The _children
        /// </summary>
        private readonly List<JsonArea> r_Children = new List<JsonArea>();

        /// <summary>
        /// The m_ parent
        /// </summary>
        private JsonArea m_Parent;
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonArea" /> class.
        /// </summary>
        /// <param name="content">The content.</param>
        protected JsonArea(JToken content) : base(content) {  }
    }
}