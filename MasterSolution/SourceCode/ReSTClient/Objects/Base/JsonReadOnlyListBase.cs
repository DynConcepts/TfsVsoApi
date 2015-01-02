using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Base
{
    /// <summary>
    /// Class JsonReadOnlyListBase.
    /// </summary>
    /// <typeparam name="TItem">The type of the t item.</typeparam>
    public abstract class JsonReadOnlyListBase<TItem> : JsonBackedObjectBase, IReadOnlyList<TItem>
    {
        /// <summary>
        /// Gets a value indicating whether this instance has key.
        /// </summary>
        /// <value><c>true</c> if this instance has key; otherwise, <c>false</c>.</value>
        protected abstract bool HasKey { get; }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the
        /// collection.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public IEnumerator<TItem> GetEnumerator() { return ItemList.GetEnumerator(); }

        /// <summary>
        /// Gets the number of elements in the collection.
        /// </summary>
        /// <value>The count.</value>
        public virtual int Count { get { return ItemSource.Count; } }

        /// <summary>
        /// Gets the element at the specified index in the read-only list.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>TItem.</returns>
        public TItem this[int index] { get { return ItemList[index]; } }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
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
                if (HasKey)
                {
                    foreach (var item in r_ItemsList.Value)
                    {
                        var key = ExtractKey(item);
                        dictionary.Add(key, item);
                    }
                }
                return dictionary;
            });
        }

        /// <summary>
        /// Extracts the key.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.String.</returns>
        protected abstract string ExtractKey(TItem item);

        /// <summary>
        /// Gets the item source.
        /// </summary>
        /// <value>The item source.</value>
        protected abstract IReadOnlyList<TItem> ItemSource { get; }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>The items.</value>
        /// <exception cref="System.Exception">Collection does not have a Key Membewr!!!</exception>
        protected IDictionary<string, TItem> ItemDictionary {
            get
            {
                if (!HasKey)
                    throw new Exception("Collection does not have a Key Membewr!!!");
                return r_ItemsDictionary.Value;
            } }

        /// <summary>
        /// Gets the item list.
        /// </summary>
        /// <value>The item list.</value>
        protected IList<TItem> ItemList { get { return r_ItemsList.Value; } }

        /// <summary>
        /// Gets a value indicating whether this instance is read only.
        /// </summary>
        /// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
           public virtual bool IsReadOnly { get { return true; } }



           /// <summary>
           /// The r_ items dictionary
           /// </summary>
        private readonly LazyWithReset<Dictionary<string, TItem>> r_ItemsDictionary;

        /// <summary>
        /// The r_ items list
        /// </summary>
        private readonly LazyWithReset<IList<TItem>> r_ItemsList;


        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
          public void CopyTo(Array array, int index) {ItemList.CopyTo(((TItem[]) array), index) ; }

          /// <summary>
          /// Captures the json.
          /// </summary>
          /// <param name="newFields">The new fields.</param>
        public override void CaptureJson(JToken newFields) { base.CaptureJson(newFields); }

    }
}