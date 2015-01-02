using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Implements Functionallity of a JSON Backed TFS/VSO Iteration.
    /// </summary>
    public class JsonIteration : JsonClassificationNode
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonIteration.</returns>
        public static JsonIteration FromToken(JToken content)
        {
            var iteration = new JsonIteration(content);
            foreach (JProperty property in content)
            {
                switch (property.Name)
                {
                    case "children":
                        foreach (JToken child in ((JArray) property.Value))
                        {
                            JsonIteration childIteration = FromToken(child);
                            ((JsonIteration) childIteration).Parent = iteration;
                            iteration.Children.Add(childIteration);
                        }
                        break;
                    default:
                        ProcessProperty(iteration, property);
                        break;
                }
            }
            return iteration;
        }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <value>The children.</value>
        public IList<JsonIteration> Children { get { return r_Children; } }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        public JsonIteration Parent { get { return m_Parent; } private set { m_Parent = value; } }

        /// <summary>
        /// The _children
        /// </summary>
        private readonly List<JsonIteration> r_Children = new List<JsonIteration>();

        /// <summary>
        /// The m_ parent
        /// </summary>
        private JsonIteration m_Parent;
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonIteration" /> class.
        /// </summary>
        /// <param name="content">The content.</param>
        protected JsonIteration(JToken content) : base(content) { }

        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public string Links { get { throw new System.NotImplementedException(); } }
    }
}