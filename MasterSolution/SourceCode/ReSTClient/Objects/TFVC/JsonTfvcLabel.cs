using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.TFVC
{
    /// <summary>
    ///     Class JsonTfvcLabel.
    /// </summary>
    internal class JsonTfvcLabel : JsonBackedObjectBase  
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonTfvcLabel.</returns>
        public static JsonTfvcLabel FromToken(JToken token)
        {
            var instance = new JsonTfvcLabel(token);
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
        public int Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        ///     Gets the label scope.
        /// </summary>
        /// <value>The label scope.</value>
        public string LabelScope { get { return sr_LabelScope.Eval(this); } }

        /// <summary>
        ///     Gets the modified date.
        /// </summary>
        /// <value>The modified date.</value>
        public DateTime ModifiedDate { get { return sr_ModifiedDate.Eval(this); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }

        /// <summary>
        ///     Gets the owner.
        /// </summary>
        /// <value>The owner.</value>
        public string Owner { get { return sr_Owner.Eval(this); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonTfvcLabel" /> class.
        /// </summary>
        /// <param name="token">The token.</param>
        private JsonTfvcLabel(JToken token)
            : base(token)
        {
        }

        /// <summary>
        ///     The SR_ description
        /// </summary>
        private static readonly JsonBackedField<string> sr_Description = new JsonBackedField<string>("description");

        /// <summary>
        ///     The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");

        /// <summary>
        ///     The SR_ label scope
        /// </summary>
        private static readonly JsonBackedField<string> sr_LabelScope = new JsonBackedField<string>("labelScope");

        /// <summary>
        ///     The SR_ modified date
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_ModifiedDate = new JsonBackedField<DateTime>("modifiedDate");

        /// <summary>
        ///     The SR_ name
        /// </summary>
        private static readonly JsonBackedField<string> sr_Name = new JsonBackedField<string>("name");

        /// <summary>
        ///     The SR_ owner
        /// </summary>
        private static readonly JsonBackedField<string> sr_Owner = new JsonBackedField<string>("owner");

        /// <summary>
        ///     The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}