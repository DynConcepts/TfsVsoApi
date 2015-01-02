using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.TFVC
{
    /// <summary>
    /// Class JsonChangeSetChanges.
    /// </summary>
    internal class JsonChangeSetChanges : JsonBackedObjectBase
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonChangeSetChanges.</returns>
        public static JsonChangeSetChanges FromToken(JToken token)
        {
            var instance = new JsonChangeSetChanges(token);
            return instance;
        }

        /// <summary>
        /// Gets the type of the change.
        /// </summary>
        /// <value>The type of the change.</value>
        public string ChangeType { get { return sr_ChangeType.Eval(this); } }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <value>The item.</value>
        public JsonVersionControlItem Item { get { return sr_Item.Eval(this); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonChangeSetChanges" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonChangeSetChanges(JToken json)
            : base(json) { }

        /// <summary>
        /// The SR_ change type
        /// </summary>
        private static readonly JsonBackedField<string> sr_ChangeType = new JsonBackedField<string>("changeType");

        /// <summary>
        /// The SR_ item
        /// </summary>
        private static readonly JsonBackedField<JsonVersionControlItem> sr_Item = new JsonBackedField<JsonVersionControlItem>("item");
    }
}