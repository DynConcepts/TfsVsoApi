using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals
{
    internal class IWorkItemOpenFieldDataHelperWrapper : IWorkItemOpenFieldDataHelperWrapper<IIWorkItemOpenFieldDataHelper, IWorkItemOpenFieldDataHelper>, IIWorkItemOpenFieldDataHelper
    {
        protected IWorkItemOpenFieldDataHelperWrapper(IWorkItemOpenFieldDataHelper instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIWorkItemOpenFieldDataHelper, IWorkItemOpenFieldDataHelper>(src => src==null ? null : ((IWorkItemOpenFieldDataHelperWrapper) src).r_Instance, src => new IWorkItemOpenFieldDataHelperWrapper(src)); }
    }


    internal abstract class IWorkItemOpenFieldDataHelperWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIWorkItemOpenFieldDataHelper where TInterface : class where TWrapper : class
    {

        Int32 IIWorkItemOpenFieldDataHelper.GetFieldId(String fieldName)
        {
            int nativeCallResult = r_Instance.GetFieldId(fieldName);
            return nativeCallResult;
        }


        Boolean IIWorkItemOpenFieldDataHelper.HasField(Int32 fieldId)
        {
            bool nativeCallResult = r_Instance.HasField(fieldId);
            return nativeCallResult;
        }

        void IIWorkItemOpenFieldDataHelper.SetLatestData(Dictionary<Int32, Object> latestData) { r_Instance.SetLatestData(latestData); }

        void IIWorkItemOpenFieldDataHelper.SetRevisionData(List<Dictionary<Int32, Object>> revisionData) { r_Instance.SetRevisionData(revisionData); }
        protected IWorkItemOpenFieldDataHelperWrapper(IWorkItemOpenFieldDataHelper instance) { r_Instance = instance; }
        protected readonly IWorkItemOpenFieldDataHelper r_Instance;
    }
}