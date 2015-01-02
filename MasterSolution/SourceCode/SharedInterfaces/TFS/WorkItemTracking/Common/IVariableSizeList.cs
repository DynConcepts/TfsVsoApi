using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common
{
    /// <summary>
    /// Interface IVariableSizeList
    /// </summary>
    public interface IVariableSizeList : IEnumerable, IIVersionTag
    {
        /// <summary>
        /// Clears this instance.
        /// </summary>
        void Clear();
        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        void CopyTo(Array array, Int32 index);
        /// <summary>
        /// Removes at.
        /// </summary>
        /// <param name="index">The index.</param>
        void RemoveAt(Int32 index);
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        Int32 Count { get; }
        /// <summary>
        /// Gets the size of the is fixed.
        /// </summary>
        /// <value>The size of the is fixed.</value>
        Boolean IsFixedSize { get; }
        /// <summary>
        /// Gets the is read only.
        /// </summary>
        /// <value>The is read only.</value>
        Boolean IsReadOnly { get; }
        /// <summary>
        /// Gets the is synchronized.
        /// </summary>
        /// <value>The is synchronized.</value>
        Boolean IsSynchronized { get; }
        /// <summary>
        /// Gets the synchronize root.
        /// </summary>
        /// <value>The synchronize root.</value>
        Object SyncRoot { get; }
    }
}