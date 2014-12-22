using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonWitAPI_UnitTests : DynTestClassBase
    {
        partial void BuildWorkItem_PreCondition(ref JsonWitAPI instance, ref String projectName, ref String workItemTypeName, ref IReadOnlyList<KeyValuePair<String, Object>> fieldValues)
        {
            projectName = "RestPlaypen";
            workItemTypeName = "Task";
            var dictionary = new List<KeyValuePair<String, Object>>
            {
                new KeyValuePair<string, object>("System.Title", "Sample Title"),
            };
            fieldValues = dictionary;
        }

        partial void GetWorkItem_PreCondition(ref JsonWitAPI instance, ref Uri uri) { }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetWorkItem_UnitTest"
        };
    }
}