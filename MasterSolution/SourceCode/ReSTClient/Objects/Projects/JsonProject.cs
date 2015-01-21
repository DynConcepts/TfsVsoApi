using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Projects
{
    /// <summary>
    ///     Class JsonProject.
    /// </summary>
    public class JsonProject : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonProject.</returns>
        public static JsonProject FromToken(JToken token)
        {
            var instance = new JsonProject(token);
            return instance;
        }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get { return Guid.Parse(sr_Id.Eval(this)); } }

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
        public JsonProject(JToken json) : base(json) { }

        /// <summary>
        ///     The SR_ identifier
        /// </summary>
        protected static readonly JsonBackedField<string> sr_Id = new JsonBackedField<string>("id");

        /// <summary>
        ///     The SR_ name
        /// </summary>
        protected static readonly JsonBackedField<string> sr_Name = new JsonBackedField<string>("name");

        /// <summary>
        ///     The SR_ URL
        /// </summary>
        protected static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}