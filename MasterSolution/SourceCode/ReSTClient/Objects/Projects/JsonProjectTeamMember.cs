using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Projects
{
    /// <summary>
    ///     Class JsonProjectTeamMember.
    /// </summary>
    internal class JsonProjectTeamMember : JsonBackedObjectBase 
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonProjectTeamMember.</returns>
        public static JsonProjectTeamMember FromToken(JToken token)
        {
            var instance = new JsonProjectTeamMember(token);
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
        public Guid Id { get { return sr_Id.Eval(this); } }

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
        ///     Initializes a new instance of the <see cref="JsonProjectTeamMember" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonProjectTeamMember(JToken json) : base(json) { }

        /// <summary>
        ///     The SR_ display name
        /// </summary>
        private static readonly JsonBackedField<string> sr_DisplayName = new JsonBackedField<string>("displayName");

        /// <summary>
        ///     The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<Guid> sr_Id = new JsonBackedField<Guid>("id");

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