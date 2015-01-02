using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Class JsonHyperlink.
    /// </summary>
    public class JsonHyperlink : JsonLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonHyperlink(JToken json) : base(json) {
        }
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonHyperlink.</returns>
        public new static JsonHyperlink FromToken(JToken token) { return (JsonHyperlink)JsonLink.FromToken(token); }
    }
}