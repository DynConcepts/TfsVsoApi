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
        Dictionary<Int32, Object> IIWorkItemSaveFieldDataHelper.FieldUpdates { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IIWorkItemOpenFieldDataHelper.GetFieldId(String fieldName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.GetFieldName(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.GetFieldReferenceName(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWorkItemFieldData_FieldInfo IWorkItemFieldData.GetFieldState(Int32 id) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Type IIWorkItemSaveFieldDataHelper.GetFieldSystemType(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IWorkItemFieldData.GetUpdateFieldValue(Int32 id, out IWorkItemFieldData_FieldUpdate fu) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IIWorkItemOpenFieldDataHelper.HasField(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IWorkItemFieldData.IsDirty() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IIWorkItemSaveFieldDataHelper.IsDirty { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }

        Boolean IIWorkItemSaveFieldDataHelper.IsLongTextField(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IIWorkItemOpenFieldDataHelper.SetLatestData(Dictionary<Int32, Object> latestData) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IIWorkItemOpenFieldDataHelper.SetRevisionData(List<Dictionary<Int32, Object>> revisionData) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IWorkItemFieldData.SetUpdateFieldValue(Int32 id, Object value, IWorkItemFieldData_FieldFlags flags) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.UserDisplayName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
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
        Boolean IWorkItemFieldData_FieldInfo.IsEmpty() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItemFieldData_FieldUpdateImpl : IWorkItemFieldData_FieldUpdate
    {
    }
}