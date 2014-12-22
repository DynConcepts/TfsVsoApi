using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemFieldDataWrapper : WorkItemFieldDataWrapper<IWorkItemFieldData, WorkItemFieldData>, IWorkItemFieldData, IIWorkItemOpenFieldDataHelper, IIWorkItemSaveFieldDataHelper
    {
        protected WorkItemFieldDataWrapper(WorkItemFieldData instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemFieldData, WorkItemFieldData>(src => src == null ? null : ((WorkItemFieldDataWrapper) src).r_Instance, src => new WorkItemFieldDataWrapper(src)); }
    }


    internal class WorkItemFieldDataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemFieldData where TInterface : class where TWrapper : class
    {
        public bool HasField(int fieldId) { throw new NotImplementedException(); }

        Dictionary<Int32, Object> IIWorkItemSaveFieldDataHelper.FieldUpdates
        {
            get
            {
                Dictionary<int, object> nativeCallResult = ((IWorkItemSaveFieldDataHelper) r_Instance).FieldUpdates;
                return nativeCallResult;
            }
        }

        Int32 IIWorkItemOpenFieldDataHelper.GetFieldId(String fieldName)
        {
            int nativeCallResult = ((IWorkItemOpenFieldDataHelper) r_Instance).GetFieldId(fieldName);
            return nativeCallResult;
        }

        String IIWorkItemSaveFieldDataHelper.GetFieldName(Int32 fieldId)
        {
            string nativeCallResult = ((IWorkItemSaveFieldDataHelper) r_Instance).GetFieldName(fieldId);
            return nativeCallResult;
        }

        String IIWorkItemSaveFieldDataHelper.GetFieldReferenceName(Int32 fieldId)
        {
            string nativeCallResult = ((IWorkItemSaveFieldDataHelper) r_Instance).GetFieldReferenceName(fieldId);
            return nativeCallResult;
        }

        IWorkItemFieldData_FieldInfo IWorkItemFieldData.GetFieldState(Int32 id)
        {
            WorkItemFieldData.FieldInfo nativeCallResult = r_Instance.GetFieldState(id);
            WorkItemFieldData_FieldInfoWrapper wrappedCallResult = WorkItemFieldData_FieldInfoWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Type IIWorkItemSaveFieldDataHelper.GetFieldSystemType(Int32 fieldId)
        {
            Type nativeCallResult = ((IWorkItemSaveFieldDataHelper) r_Instance).GetFieldSystemType(fieldId);
            return nativeCallResult;
        }


        Boolean IWorkItemFieldData.GetUpdateFieldValue(Int32 id, out IWorkItemFieldData_FieldUpdate fu)
        {
            WorkItemFieldData.FieldUpdate tmp_fu;
            bool nativeCallResult = r_Instance.GetUpdateFieldValue(id, out tmp_fu);
            fu = WorkItemFieldData_FieldUpdateWrapper.GetWrapper(tmp_fu);
            return nativeCallResult;
        }


        Boolean IIWorkItemOpenFieldDataHelper.HasField(Int32 fieldId)
        {
            bool nativeCallResult = ((IWorkItemOpenFieldDataHelper) r_Instance).HasField(fieldId);
            return nativeCallResult;
        }

        Boolean IWorkItemFieldData.IsDirty()
        {
            bool nativeCallResult = r_Instance.IsDirty();
            return nativeCallResult;
        }

        Boolean IIWorkItemSaveFieldDataHelper.IsDirty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDirty();
                return nativeCallResult;
            }
        }


        Boolean IIWorkItemSaveFieldDataHelper.IsLongTextField(Int32 fieldId)
        {
            bool nativeCallResult = ((IWorkItemSaveFieldDataHelper) r_Instance).IsLongTextField(fieldId);
            return nativeCallResult;
        }

        void IIWorkItemOpenFieldDataHelper.SetLatestData(Dictionary<Int32, Object> latestData) { ((IWorkItemOpenFieldDataHelper) r_Instance).SetLatestData(latestData); }

        void IIWorkItemOpenFieldDataHelper.SetRevisionData(List<Dictionary<Int32, Object>> revisionData) { ((IWorkItemOpenFieldDataHelper) r_Instance).SetRevisionData(revisionData); }

        Boolean IWorkItemFieldData.SetUpdateFieldValue(Int32 id, Object value, IWorkItemFieldData_FieldFlags flags)
        {
            bool nativeCallResult = r_Instance.SetUpdateFieldValue(id, value, WorkItemFieldData_FieldFlagsWrapper.GetInstance(flags));
            return nativeCallResult;
        }


        String IIWorkItemSaveFieldDataHelper.UserDisplayName
        {
            get
            {
                string nativeCallResult = ((IWorkItemSaveFieldDataHelper) r_Instance).UserDisplayName;
                return nativeCallResult;
            }
        }

        protected WorkItemFieldDataWrapper(WorkItemFieldData instance) { r_Instance = instance; }
        protected readonly WorkItemFieldData r_Instance;
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class WorkItemFieldData_FieldFlagsWrapper
    {
        public static WorkItemFieldData.FieldFlags GetInstance(IWorkItemFieldData_FieldFlags src) { return default(WorkItemFieldData.FieldFlags); }

        public static WorkItemFieldData.FieldFlags[] GetInstance(IWorkItemFieldData_FieldFlags[] src) { return null; }
        public static IWorkItemFieldData_FieldFlags GetWrapper(WorkItemFieldData.FieldFlags src) { return default(IWorkItemFieldData_FieldFlags); }
        public static IWorkItemFieldData_FieldFlags[] GetWrapper(WorkItemFieldData.FieldFlags[] src) { return null; }
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItemFieldData_FieldInfoWrapper : IWorkItemFieldData_FieldInfo
    {
        public static WorkItemFieldData.FieldInfo GetInstance(IWorkItemFieldData_FieldInfo src) { return default(WorkItemFieldData.FieldInfo); }
        public static WorkItemFieldData.FieldInfo[] GetInstance(IWorkItemFieldData_FieldInfo[] src) { return null; }
        public static WorkItemFieldData_FieldInfoWrapper GetWrapper(WorkItemFieldData.FieldInfo src) { return default(WorkItemFieldData_FieldInfoWrapper); }
        public static IWorkItemFieldData_FieldInfo[] GetWrapper(WorkItemFieldData.FieldInfo[] src) { return null; }

        Boolean IWorkItemFieldData_FieldInfo.IsEmpty()
        {
            bool nativeCallResult = r_Instance.IsEmpty();
            return nativeCallResult;
        }

        private WorkItemFieldData_FieldInfoWrapper(WorkItemFieldData.FieldInfo instance) { r_Instance = instance; }
        private WorkItemFieldData.FieldInfo r_Instance;
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItemFieldData_FieldUpdateWrapper : IWorkItemFieldData_FieldUpdate
    {
        public static WorkItemFieldData.FieldUpdate GetInstance(IWorkItemFieldData_FieldUpdate src) { return default(WorkItemFieldData.FieldUpdate); }
        public static WorkItemFieldData.FieldUpdate[] GetInstance(IWorkItemFieldData_FieldUpdate[] src) { return null; }
        public static WorkItemFieldData_FieldUpdateWrapper GetWrapper(WorkItemFieldData.FieldUpdate src) { return default(WorkItemFieldData_FieldUpdateWrapper); }
        public static IWorkItemFieldData_FieldUpdate[] GetWrapper(WorkItemFieldData.FieldUpdate[] src) { return null; }
        private WorkItemFieldData_FieldUpdateWrapper(WorkItemFieldData.FieldUpdate instance) { r_Instance = instance; }
        private WorkItemFieldData.FieldUpdate r_Instance;
    }
}