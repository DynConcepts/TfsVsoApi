using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    public interface IIWorkItemOpenFieldDataHelper
    {
        Int32 GetFieldId(String fieldName);
        Boolean HasField(Int32 fieldId);
        void SetLatestData(Dictionary<Int32, Object> latestData);
        void SetRevisionData(List<Dictionary<Int32, Object>> revisionData);
    }
}