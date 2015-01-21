using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Build
{
    /// <summary>
    ///     Class JsonBuild.
    /// </summary>
    internal class JsonBuildDrop : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonBuildDefinition.</returns>
        public static JsonBuildDrop FromToken(JToken token)
        {
            var instance = new JsonBuildDrop(token);
            return instance;
        }

        /// <summary>
        ///     Gets the download URL.
        /// </summary>
        /// <value>The download URL.</value>
        public string DownloadUrl { get { return sr_DownloadUrl.Eval(this); } }


        /// <summary>
        ///     Gets the type of the drop.
        /// </summary>
        /// <value>The type of the drop.</value>
        public string DropType { get { return sr_DropType.Eval(this); } }

        /// <summary>
        ///     Gets the location.
        /// </summary>
        /// <value>The location.</value>
        public string Location { get { return sr_Location.Eval(this); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBuildDrop" /> class.
        /// </summary>
        /// <param name="token">The token.</param>
        private JsonBuildDrop(JToken token) : base(token) { }

        /// <summary>
        ///     The SR_ download URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_DownloadUrl = new JsonBackedField<string>("downloadUrl");

        /// <summary>
        ///     The SR_ drop type
        /// </summary>
        private static readonly JsonBackedField<string> sr_DropType = new JsonBackedField<string>("type");

        /// <summary>
        ///     The SR_ location
        /// </summary>
        private static readonly JsonBackedField<string> sr_Location = new JsonBackedField<string>("location");

        /// <summary>
        ///     The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}