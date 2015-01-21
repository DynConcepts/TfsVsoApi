using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonAgileAPI_UnitTests : DynTestClassBase
    {
        partial void GetBacklogs_PostValidate(JsonAgileAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { if (!_retVal.IsCompleted) throw new Exception(); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
           "GetBacklogs_UnitTest",
        };
    }
}