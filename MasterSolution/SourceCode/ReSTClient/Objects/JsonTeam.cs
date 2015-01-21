using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    ///     Implements Functionallity of a JSON Backed TFS/VSO TeamRoom.
    /// </summary>
    public class JsonTeam : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <returns>ITeamRoom.</returns>
        public static JsonTeam FromToken(JToken arg)
        {
            var teamRoom = new JsonTeam(arg);
            return teamRoom;
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
        public string Id { get { return sr_Id.Eval(this); } }

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
        ///     Initializes a new instance of the <see cref="JsonTeam" /> class.
        /// </summary>
        /// <param name="token">The token.</param>
        private JsonTeam(JToken token)
            : base(token)
        {
        }

        /// <summary>
        ///     The sr_description
        /// </summary>
        private static readonly JsonBackedField<string> sr_Description = new JsonBackedField<string>("description");

        /// <summary>
        ///     The sr_id
        /// </summary>
        private static readonly JsonBackedField<string> sr_Id = new JsonBackedField<string>("id");

        /// <summary>
        ///     The sr_identity URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_IdentityUrl = new JsonBackedField<string>("identityUrl");

        /// <summary>
        ///     The sr_name
        /// </summary>
        private static readonly JsonBackedField<string> sr_Name = new JsonBackedField<string>("name");

        /// <summary>
        ///     The sr_url
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}