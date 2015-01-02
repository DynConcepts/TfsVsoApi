using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    /// Class JsonProjectInfo.
    /// </summary>
    internal class JsonProjectInfo : JsonBackedObjectBase
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonProjectInfo.</returns>
        public static JsonProjectInfo FromToken(JToken token)
        {
            var instance = new JsonProjectInfo(token);
            return instance;
        }

        /// <summary>
        /// Gets the project.
        /// </summary>
        /// <value>The project.</value>
        public JsonProject Project { get { return sr_Project.Value(JsonValue["project"]); } }

        /// <summary>
        /// Gets a value indicating whether [supports TFVC].
        /// </summary>
        /// <value><c>true</c> if [supports TFVC]; otherwise, <c>false</c>.</value>
        public bool SupportsTfvc { get { return sr_SupportsTfvc.Eval(this); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonProjectInfo" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonProjectInfo(JToken json)
            : base(json) { }

        /// <summary>
        /// The SR_ project
        /// </summary>
        private static readonly ParameterizedLazyWithReset<JToken,JsonProject> sr_Project = new ParameterizedLazyWithReset<JToken,JsonProject>(JsonProject.FromToken);

        /// <summary>
        /// The SR_ supports TFVC
        /// </summary>
        private static readonly JsonBackedField<bool> sr_SupportsTfvc = new JsonBackedField<bool>("supportsTFVC");
    }
}