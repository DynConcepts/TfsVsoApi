using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    /// Class JsonProxy.
    /// </summary>
    class JsonProxy : JsonBackedObjectBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
       public JsonProxy(JToken json) : base(json) {
        }

       /// <summary>
       /// Froms the token.
       /// </summary>
       /// <param name="token">The token.</param>
       /// <returns>JsonProxy.</returns>
        public static JsonProxy FromToken(JToken token)
        {
            var instance = new JsonProxy(token);
            return instance;
        }
    }
}
