using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common
{
    /// <summary>
    ///     Class VariableSizeListImpl.
    /// </summary>
    internal class VariableSizeListImpl : IVariableSizeList, IEnumerable, IIVersionTag
    {
        /// <summary>
        ///     Clears this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IVariableSizeList.Clear() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IVariableSizeList.CopyTo(Array array, Int32 index) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IVariableSizeList.Count { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the size of the is fixed.
        /// </summary>
        /// <value>The size of the is fixed.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IVariableSizeList.IsFixedSize { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is read only.
        /// </summary>
        /// <value>The is read only.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IVariableSizeList.IsReadOnly { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is synchronized.
        /// </summary>
        /// <value>The is synchronized.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IVariableSizeList.IsSynchronized { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Removes at.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IVariableSizeList.RemoveAt(Int32 index) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the synchronize root.
        /// </summary>
        /// <value>The synchronize root.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object IVariableSizeList.SyncRoot { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the version tag.
        /// </summary>
        /// <value>The version tag.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IIVersionTag.VersionTag { get { throw new ToBeImplementedException(); } }
    }

    internal class VariableSizeListImpl<T> : VariableSizeListImpl, IEnumerable, IIVersionTag
    {
        IEnumerator IEnumerable.GetEnumerator() { return r_Items.GetEnumerator(); }

        protected VariableSizeListImpl(IReadOnlyList<T> items)
        {
            foreach (T item in items)
                r_Items.Add(item);
        }

        protected IList<T> Items { get { return r_Items; } }
        private readonly List<T> r_Items = new List<T>();
    }
}