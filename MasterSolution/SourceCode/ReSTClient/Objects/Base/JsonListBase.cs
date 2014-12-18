using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Base
{
    /// <summary>
    /// Class JsonListBase.
    /// </summary>
    /// <typeparam name="TItem">The type of the t item.</typeparam>
    public abstract class JsonListBase<TItem> : JsonReadOnlyListBase<TItem>, IList<TItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonListBase{TItem}"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected JsonListBase(JToken json) : base(json) { }

        /// <summary>
        /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        public void Add(TItem item)
        {
            ItemDictionary.Add(ExtractKey(item), item);
            ItemList.Add(item);
        }

        /// <summary>
        /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        public void Clear()
        {
            ItemDictionary.Clear();
            ItemList.Clear();
        }

        /// <summary>
        /// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1" /> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>true if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false.</returns>
        public bool Contains(TItem item) { return ItemList.Contains(item); }

        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="arrayIndex">Index of the array.</param>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public void CopyTo(TItem[] array, int arrayIndex) { ItemList.CopyTo(array, arrayIndex); }

        /// <summary>
        /// Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>true if <paramref name="item" /> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false. This method also returns false if <paramref name="item" /> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
        public bool Remove(TItem item)
        {
            ItemDictionary.Remove(ExtractKey(item));
            return ItemList.Remove(item);
        }

        /// <summary>
        /// Inserts an item to the <see cref="T:System.Collections.Generic.IList`1" /> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
        /// <param name="item">The object to insert into the <see cref="T:System.Collections.Generic.IList`1" />.</param>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public void Insert(int index, TItem item)
        {
            ItemList.Insert(index, item);
            ItemDictionary.Add(ExtractKey(item), item);
        }

        /// <summary>
        /// Removes the <see cref="T:System.Collections.Generic.IList`1" /> item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to remove.</param>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public void RemoveAt(int index)
        {
            var item = ItemList[index];
            ItemDictionary.Remove(ExtractKey(item));
            ItemList.RemoveAt(index);
        }

        /// <summary>
        /// Gets or Sets the element at the specified index in the list.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>TItem.</returns>
        public new TItem this[int index]
        {
            get { return ItemList[index]; }
            set
            {
                var existing = ItemList[index];
                ItemDictionary.Remove(ExtractKey(existing));
                ItemList[index] = value;
                ItemDictionary.Add(ExtractKey(value), value);
            }
        }
    }
}