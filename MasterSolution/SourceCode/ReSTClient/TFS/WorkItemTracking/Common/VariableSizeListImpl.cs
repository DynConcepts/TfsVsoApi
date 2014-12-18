using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common
{
    internal class VariableSizeListImpl : IVariableSizeList, IEnumerable, IIVersionTag
    {
        void IVariableSizeList.Clear() { throw new ToBeImplementedException(); }
        void IVariableSizeList.CopyTo(Array array, Int32 index) { throw new ToBeImplementedException(); }
        Int32 IVariableSizeList.Count { get { throw new ToBeImplementedException(); } }
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }
        Boolean IVariableSizeList.IsFixedSize { get { throw new ToBeImplementedException(); } }
        Boolean IVariableSizeList.IsReadOnly { get { throw new ToBeImplementedException(); } }
        Boolean IVariableSizeList.IsSynchronized { get { throw new ToBeImplementedException(); } }
        void IVariableSizeList.RemoveAt(Int32 index) { throw new ToBeImplementedException(); }
        Object IVariableSizeList.SyncRoot { get { throw new ToBeImplementedException(); } }
        Int32 IIVersionTag.VersionTag { get { throw new ToBeImplementedException(); } }
    }

        internal class VariableSizeListImpl<T> : VariableSizeListImpl,  IEnumerable, IIVersionTag
        {
            private readonly List<T> r_Items = new List<T>();

            protected VariableSizeListImpl(IReadOnlyList<T> items)
            {
                foreach (var item in items)
                    r_Items.Add(item);
            }

            protected IList<T> Items { get { return r_Items; } }

            IEnumerator IEnumerable.GetEnumerator() { return r_Items.GetEnumerator(); }

        }
    }

