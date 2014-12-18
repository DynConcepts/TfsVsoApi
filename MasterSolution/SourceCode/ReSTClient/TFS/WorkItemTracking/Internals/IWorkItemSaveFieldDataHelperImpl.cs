using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals
{
    internal class IWorkItemSaveFieldDataHelperImpl : IIWorkItemSaveFieldDataHelper
    {
        Dictionary<Int32, Object> IIWorkItemSaveFieldDataHelper.FieldUpdates { get { throw new ToBeImplementedException(); } }
        String IIWorkItemSaveFieldDataHelper.GetFieldName(Int32 fieldId) { throw new ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.GetFieldReferenceName(Int32 fieldId) { throw new ToBeImplementedException(); }
        Type IIWorkItemSaveFieldDataHelper.GetFieldSystemType(Int32 fieldId) { throw new ToBeImplementedException(); }
        Boolean IIWorkItemSaveFieldDataHelper.HasField(Int32 fieldId) { throw new ToBeImplementedException(); }
        Boolean IIWorkItemSaveFieldDataHelper.IsDirty { get { throw new ToBeImplementedException(); } }
        Boolean IIWorkItemSaveFieldDataHelper.IsLongTextField(Int32 fieldId) { throw new ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.UserDisplayName { get { throw new ToBeImplementedException(); } }
    }
}