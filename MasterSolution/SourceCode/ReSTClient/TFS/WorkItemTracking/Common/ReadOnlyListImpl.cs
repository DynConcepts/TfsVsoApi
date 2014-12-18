using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common
{
    internal class ReadOnlyListImpl : IReadOnlyList, IEnumerable
    {
        void IReadOnlyList.CopyTo(Array array, Int32 index) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IReadOnlyList.Count { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IEnumerator IEnumerable.GetEnumerator() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IReadOnlyList.IsFixedSize { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IReadOnlyList.IsReadOnly { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IReadOnlyList.IsSynchronized { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Object IReadOnlyList.SyncRoot { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }

    internal class ReadOnlyListImpl<T> : ReadOnlyListImpl, IEnumerable
    {
        private readonly List<T> r_Items = new List<T>();

        protected internal ReadOnlyListImpl(IReadOnlyList<T> items)
        {
            foreach (var item in items)
                r_Items.Add(item);
        }

        protected IList<T> Items { get { return r_Items; } }

        IEnumerator IEnumerable.GetEnumerator() { return r_Items.GetEnumerator(); }

        public bool Contains(T item) { return r_Items.Contains(item); }
        public int IndexOf(T item) { return r_Items.IndexOf(item); }
        public T this[int index] { get { return r_Items[index]; } }
    }
}