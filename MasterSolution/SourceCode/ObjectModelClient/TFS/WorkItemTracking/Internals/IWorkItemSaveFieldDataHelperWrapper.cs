using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals
{
    internal class IWorkItemSaveFieldDataHelperWrapper : IWorkItemSaveFieldDataHelperWrapper<IIWorkItemSaveFieldDataHelper, IWorkItemSaveFieldDataHelper>, IIWorkItemSaveFieldDataHelper
    {
        protected IWorkItemSaveFieldDataHelperWrapper(IWorkItemSaveFieldDataHelper instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIWorkItemSaveFieldDataHelper, IWorkItemSaveFieldDataHelper>(src => src == null ? null : ((IWorkItemSaveFieldDataHelperWrapper) src).r_Instance, src => new IWorkItemSaveFieldDataHelperWrapper(src)); }
    }


    internal abstract class IWorkItemSaveFieldDataHelperWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIWorkItemSaveFieldDataHelper where TInterface : class where TWrapper : class
    {
        Dictionary<Int32, Object> IIWorkItemSaveFieldDataHelper.FieldUpdates
        {
            get
            {
                Dictionary<int, object> nativeCallResult = r_Instance.FieldUpdates;
                return nativeCallResult;
            }
        }

        String IIWorkItemSaveFieldDataHelper.GetFieldName(Int32 fieldId)
        {
            string nativeCallResult = r_Instance.GetFieldName(fieldId);
            return nativeCallResult;
        }

        String IIWorkItemSaveFieldDataHelper.GetFieldReferenceName(Int32 fieldId)
        {
            string nativeCallResult = r_Instance.GetFieldReferenceName(fieldId);
            return nativeCallResult;
        }


        Type IIWorkItemSaveFieldDataHelper.GetFieldSystemType(Int32 fieldId)
        {
            Type nativeCallResult = r_Instance.GetFieldSystemType(fieldId);
            return nativeCallResult;
        }

        Boolean IIWorkItemSaveFieldDataHelper.HasField(Int32 fieldId)
        {
            bool nativeCallResult = r_Instance.HasField(fieldId);
            return nativeCallResult;
        }

        Boolean IIWorkItemSaveFieldDataHelper.IsDirty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDirty;
                return nativeCallResult;
            }
        }

        Boolean IIWorkItemSaveFieldDataHelper.IsLongTextField(Int32 fieldId)
        {
            bool nativeCallResult = r_Instance.IsLongTextField(fieldId);
            return nativeCallResult;
        }

        String IIWorkItemSaveFieldDataHelper.UserDisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.UserDisplayName;
                return nativeCallResult;
            }
        }

        protected IWorkItemSaveFieldDataHelperWrapper(IWorkItemSaveFieldDataHelper instance) { r_Instance = instance; }
        protected readonly IWorkItemSaveFieldDataHelper r_Instance;
    }
}