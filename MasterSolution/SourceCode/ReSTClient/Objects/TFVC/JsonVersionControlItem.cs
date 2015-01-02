using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.TFVC
{
    /// <summary>
    /// Class JsonVersionControlItem.
    /// </summary>
    internal class JsonVersionControlItem : JsonBackedObjectBase
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonVersionControlItem.</returns>
        public static JsonVersionControlItem FromToken(JToken token)
        {
            var instance = new JsonVersionControlItem(token);
            return instance;
        }

        /// <summary>
        /// Gets the change date.
        /// </summary>
        /// <value>The change date.</value>
        public DateTime ChangeDate { get { return sr_ChangeDate.Eval(this); } }

        /// <summary>
        /// Gets a value indicating whether this instance is folder.
        /// </summary>
        /// <value><c>true</c> if this instance is folder; otherwise, <c>false</c>.</value>
        public bool IsFolder { get { return sr_IsFolder.Eval(this); } }

        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>The path.</value>
        public string Path { get { return sr_Path.Eval(this); } }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        public int Version { get { return sr_Version.Eval(this); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonVersionControlItem" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonVersionControlItem(JToken json)
            : base(json) { }

        /// <summary>
        /// The sr_ChangeDate date
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_ChangeDate = new JsonBackedField<DateTime>("changeDate");

        /// <summary>
        /// The sr_IsFolder folder
        /// </summary>
        private static readonly JsonBackedField<bool> sr_IsFolder = new JsonBackedField<bool>("isFolder");

        /// <summary>
        /// The sr_Path
        /// </summary>
        private static readonly JsonBackedField<string> sr_Path = new JsonBackedField<string>("path");

        /// <summary>
        /// The sr_Url
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");

        /// <summary>
        /// The sr_Version
        /// </summary>
        private static readonly JsonBackedField<int> sr_Version = new JsonBackedField<int>("version");
    }
}