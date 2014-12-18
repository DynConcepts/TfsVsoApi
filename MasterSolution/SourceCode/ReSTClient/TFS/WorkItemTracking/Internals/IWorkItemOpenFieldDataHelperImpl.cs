using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals
{
    internal class IWorkItemOpenFieldDataHelperImpl : IIWorkItemOpenFieldDataHelper
    {
        Int32 IIWorkItemOpenFieldDataHelper.GetFieldId(String fieldName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IIWorkItemOpenFieldDataHelper.HasField(Int32 fieldId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IIWorkItemOpenFieldDataHelper.SetLatestData(Dictionary<Int32, Object> latestData) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IIWorkItemOpenFieldDataHelper.SetRevisionData(List<Dictionary<Int32, Object>> revisionData) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}