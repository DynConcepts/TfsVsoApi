using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    ///     Class JsonWorkItemLink.
    /// </summary>
    public class JsonWorkItemLink : JsonLink
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonWorkItemLink.</returns>
        public new static JsonWorkItemLink FromToken(JToken content)
        {
            var instance = new JsonWorkItemLink(content);
            return instance;
        }



         /// <summary>
        ///     Gets or sets the changed date.
        /// </summary>
        /// <value>The changed date.</value>
        public DateTime? ChangedDate { get; set; }

 
        /// <summary>
        ///     Gets the other work item.
        /// </summary>
        /// <value>The other work item.</value>
        public JsonWorkItem OtherWorkItem { get { return r_OtherItem.Value; } }

 
 
  
        /// <summary>
        ///     Gets or sets the source identifier.
        /// </summary>
        /// <value>The source identifier.</value>
        public int SourceId { get; set; }

        /// <summary>
        ///     Gets or sets the target identifier.
        /// </summary>
        /// <value>The target identifier.</value>
        public int TargetId { get; set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonWorkItemLink(JToken json)
            : base(json)
        {
            r_OtherItem = new Lazy<JsonWorkItem>(() =>
            {
                JsonWorkItem retVal = JsonWorkItem.APIFactory().GetWorkItem(new Uri(sr_Url.Eval(this)));
                return retVal;
            });
        }

        /// <summary>
        ///     The r_ other item
        /// </summary>
        private readonly Lazy<JsonWorkItem> r_OtherItem;
    }

    /// <summary>
    /// Enum BaseLinkType
    /// </summary>
    public enum BaseLinkType
    {
    }

    /// <summary>
    /// Enum RegisteredLinkType
    /// </summary>
    public enum RegisteredLinkType
    {
    }

}