using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Build
{
    /// <summary>
    ///     Class JsonBuild.
    /// </summary>
    internal class JsonIdentity : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonBuildDefinition.</returns>
        public static JsonIdentity FromToken(JToken token)
        {
            var instance = new JsonIdentity(token);
            return instance;
        }


        /// <summary>
        ///     Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName { get { return sr_DisplayName.Eval(this); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        ///     Gets the image URL.
        /// </summary>
        /// <value>The image URL.</value>
        public string ImageUrl { get { return sr_ImageUrl.Eval(this); } }


        /// <summary>
        ///     Gets the name of the unique.
        /// </summary>
        /// <value>The name of the unique.</value>
        public string UniqueName { get { return sr_UniqueName.Eval(this); } }


        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }


        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonIdentity" /> class.
        /// </summary>
        /// <param name="token">The token.</param>
        private JsonIdentity(JToken token) : base(token) { }

        /// <summary>
        ///     The SR_ display name
        /// </summary>
        private static readonly JsonBackedField<string> sr_DisplayName = new JsonBackedField<string>("displayName");

        /// <summary>
        ///     The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<string> sr_Id = new JsonBackedField<string>("id");

        /// <summary>
        ///     The SR_ image URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_ImageUrl = new JsonBackedField<string>("imageUrl");

        /// <summary>
        ///     The SR_ unique name
        /// </summary>
        private static readonly JsonBackedField<string> sr_UniqueName = new JsonBackedField<string>("uniqueName");

        /// <summary>
        ///     The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}