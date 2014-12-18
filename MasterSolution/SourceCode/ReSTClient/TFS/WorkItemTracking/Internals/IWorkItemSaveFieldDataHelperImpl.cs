using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals
{
    internal class IWorkItemSaveFieldDataHelperImpl : IIWorkItemSaveFieldDataHelper
    {
        Dictionary<Int32, Object> IIWorkItemSaveFieldDataHelper.FieldUpdates { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IIWorkItemSaveFieldDataHelper.GetFieldName(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.GetFieldReferenceName(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Type IIWorkItemSaveFieldDataHelper.GetFieldSystemType(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IIWorkItemSaveFieldDataHelper.HasField(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IIWorkItemSaveFieldDataHelper.IsDirty { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IIWorkItemSaveFieldDataHelper.IsLongTextField(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IIWorkItemSaveFieldDataHelper.UserDisplayName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}