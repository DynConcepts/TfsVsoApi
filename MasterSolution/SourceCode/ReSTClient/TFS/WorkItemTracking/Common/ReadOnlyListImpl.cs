using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common
{
    internal class ReadOnlyListImpl : IReadOnlyList, IEnumerable
    {
        void IReadOnlyList.CopyTo(Array array, Int32 index) { throw new ToBeImplementedException(); }
        Int32 IReadOnlyList.Count { get { throw new ToBeImplementedException(); } }
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }
        Boolean IReadOnlyList.IsFixedSize { get { throw new ToBeImplementedException(); } }
        Boolean IReadOnlyList.IsReadOnly { get { throw new ToBeImplementedException(); } }
        Boolean IReadOnlyList.IsSynchronized { get { throw new ToBeImplementedException(); } }
        Object IReadOnlyList.SyncRoot { get { throw new ToBeImplementedException(); } }
    }

    internal class ReadOnlyListImpl<T> : ReadOnlyListImpl, IEnumerable
    {
        private readonly List<T> r_Items = new List<T>();

        protected ReadOnlyListImpl(IReadOnlyList<T> items)
        {
            foreach (var item in items)
                r_Items.Add(item);
        }

        protected IList<T> Items { get { return r_Items; } }

        IEnumerator IEnumerable.GetEnumerator() { return r_Items.GetEnumerator(); }

    }
}