using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Build
{
    /// <summary>
    ///     Class JsonBuildQuality.
    /// </summary>
    internal class JsonBuildQuality : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonBuildQuality.</returns>
        public static JsonBuildQuality FromToken(JToken token)
        {
            var instance = new JsonBuildQuality(token);
            return instance;
        }

        /// <summary>
        ///     Gets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public string CreatedDate { get { return JsonValue.Value<string>(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonBuildQuality(JToken json)
            : base(json) { }
    }
}