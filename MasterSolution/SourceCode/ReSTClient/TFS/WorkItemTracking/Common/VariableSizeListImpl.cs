using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common
{
    internal class VariableSizeListImpl : IVariableSizeList, IEnumerable, IIVersionTag
    {
        void IVariableSizeList.Clear() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IVariableSizeList.CopyTo(Array array, Int32 index) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IVariableSizeList.Count { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IEnumerator IEnumerable.GetEnumerator() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IVariableSizeList.IsFixedSize { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IVariableSizeList.IsReadOnly { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IVariableSizeList.IsSynchronized { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IVariableSizeList.RemoveAt(Int32 index) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Object IVariableSizeList.SyncRoot { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IIVersionTag.VersionTag { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
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

