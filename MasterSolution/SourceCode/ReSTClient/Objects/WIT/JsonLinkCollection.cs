using System;
using System.Collections.Generic;
using System.Globalization;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using Newtonsoft.Json.Linq;


namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Class JsonLinkCollection.
    /// </summary>
    public class JsonLinkCollection : JsonListBase<JsonLink>
    {

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
        protected override IReadOnlyList<JsonLink> ItemSource { get { return sr_Fields.Eval(this); } }
        /// <summary>
        /// The SR_ fields
        /// </summary>
        private static readonly JsonBackedList<JsonLink> sr_Fields = new JsonBackedList<JsonLink>(token => JsonParsers.JArrayToObjects((JArray)token, JsonLink.FromToken));

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
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public JsonWorkItem WorkItem { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public int Add(JsonExternalLink link) 
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
                base.Add(link);
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
        /// Refreshes this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public void Refresh() { throw new NoReStAPIEquivilantException(); }

        /// <summary>
        /// Gets the version tag.
        /// </summary>
        /// <value>The version tag.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public int VersionTag { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Gets a value indicating whether this instance is synchronized.
        /// </summary>
        /// <value><c>true</c> if this instance is synchronized; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool IsSynchronized { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Gets the synchronize root.
        /// </summary>
        /// <value>The synchronize root.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public object SyncRoot { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Gets a value indicating whether this instance is fixed size.
        /// </summary>
        /// <value><c>true</c> if this instance is fixed size; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool IsFixedSize { get { throw new NotImplementedException(); } }
    }

    /// <summary>
    /// Class JsonRelatedLink.
    /// </summary>
    public class JsonRelatedLink : JsonLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonRelatedLink(JToken json) : base(json) {
        }
    }

    /// <summary>
    /// Class JsonHyperlink.
    /// </summary>
    public class JsonHyperlink : JsonLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonHyperlink(JToken json) : base(json) {
        }
    }

    /// <summary>
    /// Class JsonExternalLink.
    /// </summary>
    public class JsonExternalLink :JsonLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonExternalLink(JToken json) : base(json) {
        }
    }
}