using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Class JsonAttachedFileLink.
    /// </summary>
    internal class JsonAttachedFileLink : JsonLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonAttachedFileLink(JToken json)
            : base(json) { }
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonAttachedFileLink.</returns>
        public new static JsonAttachedFileLink FromToken(JToken token) { return (JsonAttachedFileLink)JsonLink.FromToken(token); }
    }
}