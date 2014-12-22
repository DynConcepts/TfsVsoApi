using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemFieldDataImpl : IWorkItemFieldData, IIWorkItemOpenFieldDataHelper, IIWorkItemSaveFieldDataHelper
    {
        public bool HasField(int fieldId) { throw new NotImplementedException(); }
        Dictionary<Int32, Object> IIWorkItemSaveFieldDataHelper.FieldUpdates { get { throw new ToBeImplementedException(); } }
        Int32 IIWorkItemOpenFieldDataHelper.GetFieldId(String fieldName) { throw new ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.GetFieldName(Int32 fieldId) { throw new ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.GetFieldReferenceName(Int32 fieldId) { throw new ToBeImplementedException(); }
        IWorkItemFieldData_FieldInfo IWorkItemFieldData.GetFieldState(Int32 id) { throw new ToBeImplementedException(); }
        Type IIWorkItemSaveFieldDataHelper.GetFieldSystemType(Int32 fieldId) { throw new ToBeImplementedException(); }
        Boolean IWorkItemFieldData.GetUpdateFieldValue(Int32 id, out IWorkItemFieldData_FieldUpdate fu) { throw new ToBeImplementedException(); }
        Boolean IIWorkItemOpenFieldDataHelper.HasField(Int32 fieldId) { throw new ToBeImplementedException(); }
        Boolean IWorkItemFieldData.IsDirty() { throw new ToBeImplementedException(); }
        Boolean IIWorkItemSaveFieldDataHelper.IsDirty { get { throw new ToBeImplementedException(); } }

        Boolean IIWorkItemSaveFieldDataHelper.IsLongTextField(Int32 fieldId) { throw new ToBeImplementedException(); }
        void IIWorkItemOpenFieldDataHelper.SetLatestData(Dictionary<Int32, Object> latestData) { throw new ToBeImplementedException(); }
        void IIWorkItemOpenFieldDataHelper.SetRevisionData(List<Dictionary<Int32, Object>> revisionData) { throw new ToBeImplementedException(); }
        Boolean IWorkItemFieldData.SetUpdateFieldValue(Int32 id, Object value, IWorkItemFieldData_FieldFlags flags) { throw new ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.UserDisplayName { get { throw new ToBeImplementedException(); } }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal static class WorkItemFieldData_FieldFlagsImpl
    {
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItemFieldData_FieldInfoImpl : IWorkItemFieldData_FieldInfo
    {
        Boolean IWorkItemFieldData_FieldInfo.IsEmpty() { throw new ToBeImplementedException(); }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItemFieldData_FieldUpdateImpl : IWorkItemFieldData_FieldUpdate
    {
    }
}