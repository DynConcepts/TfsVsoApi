using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common
{
    internal class OrderedVariableSizeListWrapper : OrderedVariableSizeListWrapper<IOrderedVariableSizeList, OrderedVariableSizeList>, IOrderedVariableSizeList, IEnumerable, IIVersionTag
    {
        protected OrderedVariableSizeListWrapper(OrderedVariableSizeList instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IOrderedVariableSizeList, OrderedVariableSizeList>(src => ((OrderedVariableSizeListWrapper) src).r_Instance, src => new OrderedVariableSizeListWrapper(src)); }
    }


    internal abstract class OrderedVariableSizeListWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IOrderedVariableSizeList where TInterface : class where TWrapper : class
    {

        void IOrderedVariableSizeList.Clear() { r_Instance.Clear(); }



        void IOrderedVariableSizeList.CopyTo(Array array, Int32 index) { r_Instance.CopyTo(array, index); }

        Int32 IOrderedVariableSizeList.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = r_Instance.GetEnumerator();
            return nativeCallResult;
        }

        Boolean IOrderedVariableSizeList.IsFixedSize
        {
            get
            {
                bool nativeCallResult = r_Instance.IsFixedSize;
                return nativeCallResult;
            }
        }

        Boolean IOrderedVariableSizeList.IsReadOnly
        {
            get
            {
                bool nativeCallResult = r_Instance.IsReadOnly;
                return nativeCallResult;
            }
        }

        Boolean IOrderedVariableSizeList.IsSynchronized
        {
            get
            {
                bool nativeCallResult = r_Instance.IsSynchronized;
                return nativeCallResult;
            }
        }

        void IOrderedVariableSizeList.RemoveAt(Int32 index) { r_Instance.RemoveAt(index); }

        Object IOrderedVariableSizeList.SyncRoot
        {
            get
            {
                object nativeCallResult = r_Instance.SyncRoot;
                return nativeCallResult;
            }
        }

        Int32 IIVersionTag.VersionTag
        {
            get
            {
                int nativeCallResult = ((IVersionTag) r_Instance).VersionTag;
                return nativeCallResult;
            }
        }

        protected OrderedVariableSizeListWrapper(OrderedVariableSizeList instance) { r_Instance = instance; }
        protected readonly OrderedVariableSizeList r_Instance;
    }
}