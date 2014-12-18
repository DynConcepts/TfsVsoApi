using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Base
{
    /// <summary>
    ///     Class JsonReadOnlyListBase.
    /// </summary>
    /// <typeparam name="TItem">The type of the t item.</typeparam>
    public abstract class JsonReadOnlyListBase<TItem> : JsonBackedObjectBase, IReadOnlyList<TItem>, IReadOnlyList
    {
        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the
        ///     collection.
        /// </returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public IEnumerator<TItem> GetEnumerator() { return ItemList.GetEnumerator(); }

        /// <summary>
        ///     Gets the number of elements in the collection.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get { return ItemSource.Count; } }

        /// <summary>
        /// Gets the element at the specified index in the read-only list.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>TItem.</returns>
        public TItem this[int index] { get { return ItemDictionary.Values.ToList()[index]; } }

        /// <summary>
        ///     Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected JsonReadOnlyListBase(JToken json) : base(json)
        {
            r_ItemsList = new LazyWithReset<IList<TItem>>(() =>
            {
                var list = ItemSource != null ? new List<TItem>(ItemSource) : new List<TItem>();
                return list;
            });

            r_ItemsDictionary = new LazyWithReset<Dictionary<string, TItem>>(() =>
            {
                var dictionary = new Dictionary<string, TItem>();
                foreach (var item in r_ItemsList.Value)
                {
                    var key = ExtractKey(item);
                    dictionary.Add(key, item);
                }
                return dictionary;
            });
        }

        /// <summary>
        ///     Extracts the key.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.String.</returns>
        protected abstract string ExtractKey(TItem item);

        /// <summary>
        ///     Gets the item source.
        /// </summary>
        /// <value>The item source.</value>
        protected abstract IReadOnlyList<TItem> ItemSource { get; }

        /// <summary>
        ///     Gets the items.
        /// </summary>
        /// <value>The items.</value>
        protected IDictionary<string, TItem> ItemDictionary { get { return r_ItemsDictionary.Value; } }

        /// <summary>
        /// Gets the item list.
        /// </summary>
        /// <value>The item list.</value>
        protected IList<TItem> ItemList { get { return r_ItemsList.Value; } }

        object IReadOnlyList.SyncRoot { get { throw new NotImplementedException(); } }
        bool IReadOnlyList.IsFixedSize { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.
        /// </summary>
        /// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public bool IsReadOnly { get { throw new NoReStAPIEquivilantException(); } }

        bool IReadOnlyList.IsSynchronized { get { throw new NotImplementedException(); } }

        /// <summary>
        /// The r_ items dictionary
        /// </summary>
        private readonly LazyWithReset<Dictionary<string, TItem>> r_ItemsDictionary;

        /// <summary>
        /// The r_ items list
        /// </summary>
        private readonly LazyWithReset<IList<TItem>> r_ItemsList;

        /// <summary>
        ///     Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if [contains] [the specified identifier]; otherwise, <c>false</c>.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public bool Contains(int id) { throw new NoReStAPIEquivilantException(); }

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>JsonField.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public JsonField GetById(int id) { throw new NoReStAPIEquivilantException(); }

        /// <summary>
        ///     Determines the index of a specific item in the <see cref="T:System.Collections.Generic.IList`1" />.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.IList`1" />.</param>
        /// <returns>The index of <paramref name="item" /> if found in the list; otherwise, -1.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public int IndexOf(TItem item) { throw new NoReStAPIEquivilantException(); }

        public void CopyTo(Array array, int index) { throw new NotImplementedException(); }

        public override void CaptureJson(JToken newFields) { base.CaptureJson(newFields); }

    }
}