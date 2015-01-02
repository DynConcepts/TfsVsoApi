using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Implements Functionallity of a JSON Backed TFS/VSO ClassificationNode.
    /// </summary>
    public class JsonClassificationNode: JsonBackedObjectBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected JsonClassificationNode(JToken json) : base(json) 
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has children.
        /// </summary>
        /// <value><c>true</c> if this instance has children; otherwise, <c>false</c>.</value>
        public bool HasChildren { get; protected set; }


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; protected set; }

        /// <summary>
        /// Processes the property.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="property">The property.</param>
        protected static void ProcessProperty(JsonClassificationNode node, JProperty property)
        {
            switch (property.Name)
            {
                case "name":
                    node.Name = (string) property;
                    break;
                case "structureType":
                    break;
                case "hasChildren":
                    node.HasChildren = (bool) property;
                    break;
                case "_links":
                    //                        area.Links = (string) property;
                    break;
                case "url":
                    node.Url = (string) property;
                    break;
                default:
                    break;
            }
        }
    }
}