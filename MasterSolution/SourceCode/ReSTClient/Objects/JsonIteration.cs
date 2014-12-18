using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    ///     Implements Functionallity of a JSON Backed TFS/VSO Iteration.
    /// </summary>
    internal class JsonIteration : JsonClassificationNode, IIteration
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>IIteration.</returns>
        public static IIteration FromToken(JToken content)
        {
            var iteration = new JsonIteration();
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
        ///     Gets the children.
        /// </summary>
        /// <value>The children.</value>
        public IList<IIteration> Children { get { return r_Children; } }

        /// <summary>
        ///     Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        public IIteration Parent { get; private set; }

        /// <summary>
        ///     The _children
        /// </summary>
        private readonly List<IIteration> r_Children = new List<IIteration>();
    }
}