using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common
{
    internal class ReadOnlyListWrapper<TNativeElement, TWrappedElement> : ReadOnlyListWrapper<IReadOnlyList, ReadOnlyList, TNativeElement, TWrappedElement>, IReadOnlyList, IEnumerable
    {
        protected ReadOnlyListWrapper(ReadOnlyList instance) : base(instance, o => default(TWrappedElement)) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IReadOnlyList, ReadOnlyList>(src => src == null ? null : ((ReadOnlyListWrapper<TNativeElement, TWrappedElement>) src).r_Instance, src => new ReadOnlyListWrapper<TNativeElement, TWrappedElement>(src)); }
    }


    internal abstract class ReadOnlyListWrapper<TWrapper, TInterface, TNativeElement, TWrappedElement> : MappedObjectBase<TWrapper, TInterface>, IReadOnlyList
        where TInterface : class
        where TWrapper : class
    {
        void IReadOnlyList.CopyTo(Array array, Int32 index) { r_Instance.CopyTo(array, index); }

        Int32 IReadOnlyList.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var nativeCallResult = new EnumeratorWrapper<TWrappedElement>(r_Instance.GetEnumerator(), r_ItemEncapsulator);
            return nativeCallResult;
        }

        Boolean IReadOnlyList.IsFixedSize
        {
            get
            {
                bool nativeCallResult = r_Instance.IsFixedSize;
                return nativeCallResult;
            }
        }

        Boolean IReadOnlyList.IsReadOnly
        {
            get
            {
                bool nativeCallResult = r_Instance.IsReadOnly;
                return nativeCallResult;
            }
        }

        Boolean IReadOnlyList.IsSynchronized
        {
            get
            {
                bool nativeCallResult = r_Instance.IsSynchronized;
                return nativeCallResult;
            }
        }

        Object IReadOnlyList.SyncRoot
        {
            get
            {
                object nativeCallResult = r_Instance.SyncRoot;
                return nativeCallResult;
            }
        }

        protected ReadOnlyListWrapper(ReadOnlyList instance, Func<Object, TWrappedElement> itemEncapsulator)
        {
            r_Instance = instance;
            r_ItemEncapsulator = itemEncapsulator;
        }

        protected readonly ReadOnlyList r_Instance;
        private readonly Func<Object, TWrappedElement> r_ItemEncapsulator;
    }
}