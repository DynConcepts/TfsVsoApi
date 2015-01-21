using System;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    ///     Class JsonRoomMember.
    /// </summary>
    internal class JsonRoomMember : JsonBackedObjectBase
    {
        /// <summary>
        ///     Jsons the room member.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonRoomMember.</returns>
        public static JsonRoomMember FromToken(JToken token)
        {
            var instance = new JsonRoomMember(token);
            return instance;
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is online.
        /// </summary>
        /// <value><c>true</c> if this instance is online; otherwise, <c>false</c>.</value>
        public bool IsOnline { get { return sr_IsOnline.Eval(this); } }

        /// <summary>
        ///     Gets the joined date.
        /// </summary>
        /// <value>The joined date.</value>
        public DateTime JoinedDate { get { return sr_JoinedDate.Eval(this); } }

        /// <summary>
        ///     Gets the last activity.
        /// </summary>
        /// <value>The last activity.</value>
        public DateTime LastActivity { get { return sr_LastActivity.Eval(this); } }

        /// <summary>
        ///     Gets the room identifier.
        /// </summary>
        /// <value>The room identifier.</value>
        public string RoomId { get { return sr_RoomId.Eval(this); } }

        /// <summary>
        ///     Gets the user.
        /// </summary>
        /// <value>The user.</value>
        public JsonIdentity User { get { return sr_User.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonRoomMember(JToken json) : base(json)
        {
        }

        /// <summary>
        ///     The SR_ is online
        /// </summary>
        private static readonly JsonBackedField<bool> sr_IsOnline = new JsonBackedField<bool>("isOnline");

        /// <summary>
        ///     The SR_ joined date
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_JoinedDate = new JsonBackedField<DateTime>("joinedDate");

        /// <summary>
        ///     The SR_ last activity
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_LastActivity = new JsonBackedField<DateTime>("lastActivity");

        /// <summary>
        ///     The SR_ room identifier
        /// </summary>
        private static readonly JsonBackedField<string> sr_RoomId = new JsonBackedField<string>("roomId");

        /// <summary>
        ///     The SR_ user
        /// </summary>
        private static readonly JsonBackedField<JsonIdentity> sr_User = new JsonBackedField<JsonIdentity>("user");
    }
}