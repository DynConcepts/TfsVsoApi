using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class FieldFilterListWrapper : FieldFilterListWrapper<IFieldFilterList, FieldFilterList>, IFieldFilterList
    {
        protected FieldFilterListWrapper(FieldFilterList instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldFilterList, FieldFilterList>(src => src == null ? null : ((FieldFilterListWrapper) src).r_Instance, src => new FieldFilterListWrapper(src)); }
    }


    internal class FieldFilterListWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, IFieldFilterList where TInterface : class where TWrapper : class
    {
        Int32 IFieldFilterList.Add(IFieldFilter filter)
        {
            int nativeCallResult = r_Instance.Add(FieldFilterWrapper.GetInstance(filter));
            return nativeCallResult;
        }


        Boolean IFieldFilterList.Contains(IFieldFilter value)
        {
            bool nativeCallResult = r_Instance.Contains(FieldFilterWrapper.GetInstance(value));
            return nativeCallResult;
        }

        Int32 IFieldFilterList.IndexOf(IFieldFilter filter)
        {
            int nativeCallResult = r_Instance.IndexOf(FieldFilterWrapper.GetInstance(filter));
            return nativeCallResult;
        }

        Int32 IFieldFilterList.IndexOfFieldId(Int32 id)
        {
            int nativeCallResult = r_Instance.IndexOfFieldId(id);
            return nativeCallResult;
        }


        IFieldFilter IFieldFilterList.this[Int32 index]
        {
            get
            {
                FieldFilter nativeCallResult = r_Instance[index];
                IFieldFilter wrappedCallResult = FieldFilterWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IFieldFilterList.Remove(IFieldFilter value) { r_Instance.Remove(FieldFilterWrapper.GetInstance(value)); }
        protected FieldFilterListWrapper(FieldFilterList instance) : base(instance) { r_Instance = instance; }
        protected new readonly FieldFilterList r_Instance;
    }
}