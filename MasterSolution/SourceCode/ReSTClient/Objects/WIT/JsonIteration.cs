using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Implements Functionallity of a JSON Backed TFS/VSO Iteration.
    /// </summary>
    public class JsonIteration : JsonClassificationNode, IIteration
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>IIteration.</returns>
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
                            IIteration childIteration = FromToken(child);
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
        public IList<IIteration> Children { get { return r_Children; } }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        public IIteration Parent { get { return m_Parent; } private set { m_Parent = value; } }

        /// <summary>
        /// The _children
        /// </summary>
        private readonly List<IIteration> r_Children = new List<IIteration>();

        /// <summary>
        /// The m_ parent
        /// </summary>
        private IIteration m_Parent;
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonIteration"/> class.
        /// </summary>
        /// <param name="content">The content.</param>
        protected JsonIteration(JToken content) : base(content) { }
    }
}