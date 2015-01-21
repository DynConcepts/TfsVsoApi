using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.TFVC
{
    /// <summary>
    ///     Class JsonTfvcLabelItem.
    /// </summary>
    internal class JsonTfvcLabelItem : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonTfvcLabel.</returns>
        public static JsonTfvcLabelItem FromToken(JToken token)
        {
            var instance = new JsonTfvcLabelItem(token);
            return instance;
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is folder.
        /// </summary>
        /// <value><c>true</c> if this instance is folder; otherwise, <c>false</c>.</value>
        public bool IsFolder { get { return sr_IsFolder.Eval(this); } }

        /// <summary>
        ///     Gets the path.
        /// </summary>
        /// <value>The path.</value>
        public string Path { get { return sr_Path.Eval(this); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        ///     Gets the version.
        /// </summary>
        /// <value>The version.</value>
        public string Version { get { return sr_Version.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonTfvcLabelItem(JToken json) : base(json)
        {
        }

        /// <summary>
        ///     The SR_ is folder
        /// </summary>
        private static readonly JsonBackedField<bool> sr_IsFolder = new JsonBackedField<bool>("isFolder");

        /// <summary>
        ///     The SR_ path
        /// </summary>
        private static readonly JsonBackedField<string> sr_Path = new JsonBackedField<string>("path");

        /// <summary>
        ///     The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");

        /// <summary>
        ///     The SR_ version
        /// </summary>
        private static readonly JsonBackedField<string> sr_Version = new JsonBackedField<string>("version");
    }
}