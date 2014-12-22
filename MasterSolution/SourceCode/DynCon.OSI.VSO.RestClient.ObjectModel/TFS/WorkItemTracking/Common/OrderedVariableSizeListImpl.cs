using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common
{
    internal class OrderedVariableSizeListImpl : IOrderedVariableSizeList, IEnumerable, IIVersionTag
    {
        void IOrderedVariableSizeList.Clear() { throw new ToBeImplementedException(); }
        void IOrderedVariableSizeList.CopyTo(Array array, Int32 index) { throw new ToBeImplementedException(); }
        Int32 IOrderedVariableSizeList.Count { get { throw new ToBeImplementedException(); } }
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }
        Boolean IOrderedVariableSizeList.IsFixedSize { get { throw new ToBeImplementedException(); } }
        Boolean IOrderedVariableSizeList.IsReadOnly { get { throw new ToBeImplementedException(); } }
        Boolean IOrderedVariableSizeList.IsSynchronized { get { throw new ToBeImplementedException(); } }
        void IOrderedVariableSizeList.RemoveAt(Int32 index) { throw new ToBeImplementedException(); }
        Object IOrderedVariableSizeList.SyncRoot { get { throw new ToBeImplementedException(); } }
        Int32 IIVersionTag.VersionTag { get { throw new ToBeImplementedException(); } }
    }
}