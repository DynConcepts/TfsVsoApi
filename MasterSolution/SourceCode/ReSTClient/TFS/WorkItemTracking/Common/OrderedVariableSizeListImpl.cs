using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common
{
    internal class OrderedVariableSizeListImpl : IOrderedVariableSizeList, IEnumerable, IIVersionTag
    {
        void IOrderedVariableSizeList.Clear() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IOrderedVariableSizeList.CopyTo(Array array, Int32 index) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IOrderedVariableSizeList.Count { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IEnumerator IEnumerable.GetEnumerator() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IOrderedVariableSizeList.IsFixedSize { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IOrderedVariableSizeList.IsReadOnly { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IOrderedVariableSizeList.IsSynchronized { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IOrderedVariableSizeList.RemoveAt(Int32 index) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Object IOrderedVariableSizeList.SyncRoot { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IIVersionTag.VersionTag { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}