using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    /// Class JsonRoom.
    /// </summary>
    internal class JsonRoom : JsonBackedObjectBase
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonRoom.</returns>
        public static JsonRoom FromToken(JToken token)
        {
            var instance = new JsonRoom(token);
            return instance;
        }

        /// <summary>
        /// Gets the created by.
        /// </summary>
        /// <value>The created by.</value>
        public string CreatedBy { get { return sr_CreatedBy.Eval(this); } }

        /// <summary>
        /// Gets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate { get { return sr_CreatedDate.Eval(this); } }


        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return sr_Description.Eval(this); } }

        /// <summary>
        /// Gets a value indicating whether this instance has admin permissions.
        /// </summary>
        /// <value><c>true</c> if this instance has admin permissions; otherwise, <c>false</c>.</value>
        public bool HasAdminPermissions { get { return sr_HasAdminPermissions.Eval(this); } }

        /// <summary>
        /// Gets a value indicating whether this instance has read write permissions.
        /// </summary>
        /// <value><c>true</c> if this instance has read write permissions; otherwise, <c>false</c>.</value>
        public bool HasReadWritePermissions { get { return sr_HasReadWritePermissions.Eval(this); } }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        /// Gets the last activity.
        /// </summary>
        /// <value>The last activity.</value>
        public string LastActivity { get { return sr_LastActivity.Eval(this); } }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return r_Name.Eval(this); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonRoom" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonRoom(JToken json)
            : base(json) { }

        /// <summary>
        /// The SR_ created by
        /// </summary>
        private static readonly JsonBackedField<string> sr_CreatedBy = new JsonBackedField<string>("createdBy");

        /// <summary>
        /// The SR_ created date
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_CreatedDate = new JsonBackedField<DateTime>("createdDate");

        /// <summary>
        /// The SR_ description
        /// </summary>
        private static readonly JsonBackedField<string> sr_Description = new JsonBackedField<string>("description");

        /// <summary>
        /// The SR_ has admin permissions
        /// </summary>
        private static readonly JsonBackedField<bool> sr_HasAdminPermissions = new JsonBackedField<bool>("hasAdminPermissions");

        /// <summary>
        /// The SR_ has read write permissions
        /// </summary>
        private static readonly JsonBackedField<bool> sr_HasReadWritePermissions = new JsonBackedField<bool>("hasReadWritePermissions");

        /// <summary>
        /// The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");

        /// <summary>
        /// The SR_ last activity
        /// </summary>
        private static readonly JsonBackedField<string> sr_LastActivity = new JsonBackedField<string>("lastActivity");

        /// <summary>
        /// The r_ name
        /// </summary>
        private readonly JsonBackedField<string> r_Name = new JsonBackedField<string>("name");
    }
}