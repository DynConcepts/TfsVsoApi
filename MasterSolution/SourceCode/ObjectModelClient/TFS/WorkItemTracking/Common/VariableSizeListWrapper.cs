using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common
{
    internal class VariableSizeListWrapper : VariableSizeListWrapper<IVariableSizeList, VariableSizeList>, IVariableSizeList, IEnumerable, IIVersionTag
    {
        protected VariableSizeListWrapper(VariableSizeList instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IVariableSizeList, VariableSizeList>(src => src == null ? null : ((VariableSizeListWrapper) src).r_Instance, src => new VariableSizeListWrapper(src)); }
    }


    internal abstract class VariableSizeListWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IVariableSizeList where TInterface : class where TWrapper : class
    {
        void IVariableSizeList.Clear() { r_Instance.Clear(); }


        void IVariableSizeList.CopyTo(Array array, Int32 index) { r_Instance.CopyTo(array, index); }

        Int32 IVariableSizeList.Count
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

        Boolean IVariableSizeList.IsFixedSize
        {
            get
            {
                bool nativeCallResult = r_Instance.IsFixedSize;
                return nativeCallResult;
            }
        }

        Boolean IVariableSizeList.IsReadOnly
        {
            get
            {
                bool nativeCallResult = r_Instance.IsReadOnly;
                return nativeCallResult;
            }
        }

        Boolean IVariableSizeList.IsSynchronized
        {
            get
            {
                bool nativeCallResult = r_Instance.IsSynchronized;
                return nativeCallResult;
            }
        }

        void IVariableSizeList.RemoveAt(Int32 index) { r_Instance.RemoveAt(index); }

        Object IVariableSizeList.SyncRoot
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

        protected VariableSizeListWrapper(VariableSizeList instance) { r_Instance = instance; }
        protected readonly VariableSizeList r_Instance;
    }
}