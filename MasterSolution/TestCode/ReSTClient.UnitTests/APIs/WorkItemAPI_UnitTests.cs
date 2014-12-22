using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.APIs;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemAPI_UnitTests : DynTestClassBase
    {
        partial void BuildWorkItem_PreCondition(ref WorkItemAPI instance, ref String projectName, ref String workItemType, ref IReadOnlyList<KeyValuePair<String, Object>> fieldValues)
        {
            projectName = "RestPlaypen";
            workItemType = "Task";
            var values = new List<KeyValuePair<string, object>>();
            values.Add(new KeyValuePair<string, object>("System.Title", "Task Created from UnitTest"));
            fieldValues = values;
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>();
    }
}