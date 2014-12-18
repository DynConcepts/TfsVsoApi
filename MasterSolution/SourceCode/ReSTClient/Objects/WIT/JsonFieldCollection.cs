using System;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    ///     Class JsonFieldCollection.
    /// </summary>
    public class JsonFieldCollection : JsonReadOnlyListBase<JsonField>
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonFieldDefinitionCollection.</returns>
        internal static JsonFieldCollection FromToken(JToken token)
        {
            var instance = new JsonFieldCollection(token);
            return instance;
        }

        /// <summary>
        ///     Gets the <see cref="JsonField" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IField.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public JsonField this[string name] { get { return ItemDictionary[name]; } }

        /// <summary>
        /// Gets the <see cref="JsonField"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>JsonField.</returns>
        public new JsonField this[int index] { get { return ItemList[index]; } }


        /// <summary>
        /// Determines whether [contains] [the specified field name].
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns><c>true</c> if [contains] [the specified field name]; otherwise, <c>false</c>.</returns>
        public bool Contains(string fieldName) { return ItemDictionary.ContainsKey(fieldName); }

 
        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected JsonFieldCollection(JToken json) : base(json) { }

        /// <summary>
        ///     Extracts the key.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.String.</returns>
        protected override string ExtractKey(JsonField item) 
        { 
            var key = item.ReferenceName;
            if (key == null)
                throw new Exception("Could not Locate Key");
            return key;
        }

        /// <summary>
        ///     Gets the item source.
        /// </summary>
        /// <value>The item source.</value>
        protected override IReadOnlyList<JsonField> ItemSource { get { return sr_Fields.Eval(this).Values.ToList(); } }

        /// <summary>
        ///     The SR_ fields
        /// </summary>
        private static readonly JsonBackedDictionary<JsonField> sr_Fields = new JsonBackedDictionary<JsonField>(String.Empty, JsonField.FromToken);
    }

    enum CoreField
    {
    }

}