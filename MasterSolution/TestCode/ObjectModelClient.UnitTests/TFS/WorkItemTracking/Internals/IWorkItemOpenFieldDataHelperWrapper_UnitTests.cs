using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    // [Ignore] // Cant find detqiled information
    public partial class IWorkItemOpenFieldDataHelperWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref IWorkItemOpenFieldDataHelper real, string callerName)
        {
            var workitem = WorkItemWrapper_UnitTests.GetRealInstance();
            var fieldData = workitem.FieldData;
            real = fieldData;
        }

        partial void GetFieldId_PreCondition(IIWorkItemOpenFieldDataHelper instance, ref String fieldName)
        {
            fieldName = "Title";
        }

        partial void SetLatestData_PreCondition(IIWorkItemOpenFieldDataHelper instance, ref Dictionary<Int32, Object> latestData)
        {
           latestData = new Dictionary<int, object>();
        }

        partial void SetRevisionData_PreCondition(IIWorkItemOpenFieldDataHelper instance, ref List<Dictionary<Int32, Object>> revisionData)
        {
            revisionData = new List<Dictionary<int, object>>();
        }


    }
}