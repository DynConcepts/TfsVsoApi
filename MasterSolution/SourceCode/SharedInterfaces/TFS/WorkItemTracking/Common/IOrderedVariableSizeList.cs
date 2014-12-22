using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common
{
    public interface IOrderedVariableSizeList : IEnumerable, IIVersionTag
    {
        void Clear();
        void CopyTo(Array array, Int32 index);
        void RemoveAt(Int32 index);
        Int32 Count { get; }
        Boolean IsFixedSize { get; }
        Boolean IsReadOnly { get; }
        Boolean IsSynchronized { get; }
        Object SyncRoot { get; }
    }
}