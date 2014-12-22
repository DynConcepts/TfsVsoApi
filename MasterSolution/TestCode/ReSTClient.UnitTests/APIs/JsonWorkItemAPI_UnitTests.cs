using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonWorkItemAPI_UnitTests : DynTestClassBase
    {
        partial void GetWorkItem_PreCondition(ref JsonWitAPI instance, ref Uri uri) { uri = new Uri("https://davidvcorbin.visualstudio.com/defaultcollection/_apis/wit/workitems/348/revisions/1/?$expand=relations&api-version=1.0"); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "BuildWorkItem_UnitTest",
        };
    }
}