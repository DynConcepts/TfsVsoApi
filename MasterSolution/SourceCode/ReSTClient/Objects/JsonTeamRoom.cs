using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    ///     Implements Functionallity of a JSON Backed TFS/VSO TeamRoom.
    /// </summary>
    public class JsonTeamRoom : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <returns>ITeamRoom.</returns>
        public static JsonTeamRoom FromToken(JToken arg)
        {
            var teamRoom = new JsonTeamRoom(arg);
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
        public int Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        ///     Gets the last activity.
        /// </summary>
        /// <value>The last activity.</value>
        public DateTime LastActivity { get { return sr_LastActivity.Eval(this); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonTeamRoom" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonTeamRoom(JToken json) : base(json) { }

        /// <summary>
        ///     The _description
        /// </summary>
        private static readonly JsonBackedField<string> sr_Description = new JsonBackedField<string>("description");

        /// <summary>
        ///     The _id
        /// </summary>
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");

        /// <summary>
        ///     The _last activity
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_LastActivity = new JsonBackedField<DateTime>("lastActivity");

        /// <summary>
        ///     The _name
        /// </summary>
        private static readonly JsonBackedField<string> sr_Name = new JsonBackedField<string>("name");
    }
}