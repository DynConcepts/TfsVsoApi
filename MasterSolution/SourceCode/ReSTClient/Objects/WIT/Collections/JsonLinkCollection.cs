using System;
using System.Collections.Generic;
using System.Globalization;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections
{
    /// <summary>
    /// Class JsonLinkCollection.
    /// </summary>
    public class JsonLinkCollection : JsonListBase<JsonLink>
    {
        protected override bool HasKey { get { return false; } }

        /// <summary>
        /// Extracts the key.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.String.</returns>
        protected override string ExtractKey(JsonLink item) { return item.GetHashCode().ToString(CultureInfo.InvariantCulture); }

        /// <summary>
        /// Gets the item source.
        /// </summary>
        /// <value>The item source.</value>
        protected override IReadOnlyList<JsonLink> ItemSource
        {
            get
            {
                var result = sr_Links.Eval(this);
                return result;
            }
        }

        /// <summary>
        /// The SR_ fields
        /// </summary>
        private static readonly JsonBackedList<JsonLink> sr_Links = new JsonBackedList<JsonLink>(token => JsonParsers.JArrayToObjects((JArray)token, JsonLink.FromToken));

        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>JsonLinkCollection.</returns>
        public static JsonLinkCollection FromToken(JArray value)
        {
            var instance = new JsonLinkCollection(value);
            return instance;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonLinkCollection(JToken json) : base(json) { }
    
        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public int Add(JsonHyperlink link)
        {
            base.Add(link);
            return IndexOf(link);
        }

        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public int Add(JsonRelatedLink link)
        {
            base.Add(link);
            return IndexOf(link);
        }

    
        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public int AddItem(object value)
        {
            {
                var link = (JsonLink) value;
                Add(link);
                return IndexOf(link);
            }
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public object GetItem(int index) { return base[index]; }
      
        /// <summary>
        /// Gets a value indicating whether this instance is synchronized.
        /// </summary>
        /// <value><c>true</c> if this instance is synchronized; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool IsSynchronized { get { return false; } }

        /// <summary>
        /// Gets the synchronize root.
        /// </summary>
        /// <value>The synchronize root.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public object SyncRoot
        {
            get { return m_SyncRoot ?? (m_SyncRoot = new object()); }
        }

        private object m_SyncRoot;

        /// <summary>
        /// Gets a value indicating whether this instance is fixed size.
        /// </summary>
        /// <value><c>true</c> if this instance is fixed size; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool IsFixedSize { get { return false; } }
    }
}