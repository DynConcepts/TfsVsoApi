using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Projects
{
    /// <summary>
    ///     Class JsonProjectTeam.
    /// </summary>
    internal class JsonProjectTeam : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonProjectTeam.</returns>
        public static JsonProjectTeam FromToken(JToken token)
        {
            var instance = new JsonProjectTeam(token);
            return instance;
        }

        /// <summary>
        ///     Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return sr_Description.Eval(this); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        ///     Gets the identity URL.
        /// </summary>
        /// <value>The identity URL.</value>
        public string IdentityUrl { get { return sr_IdentityUrl.Eval(this); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonProjectTeam(JToken json) : base(json) { }

        /// <summary>
        ///     The SR_ description
        /// </summary>
        private static readonly JsonBackedField<string> sr_Description = new JsonBackedField<string>("description");

        /// <summary>
        ///     The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<Guid> sr_Id = new JsonBackedField<Guid>("id");

        /// <summary>
        ///     The SR_ identity URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_IdentityUrl = new JsonBackedField<string>("identityUrl");

        /// <summary>
        ///     The SR_ name
        /// </summary>
        private static readonly JsonBackedField<string> sr_Name = new JsonBackedField<string>("name");

        /// <summary>
        ///     The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}