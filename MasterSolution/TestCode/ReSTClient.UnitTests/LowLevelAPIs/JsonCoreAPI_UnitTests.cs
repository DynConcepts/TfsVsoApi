using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonCoreAPI_UnitTests : DynTestClassBase
    {
        partial void GetConnectedServices_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetDetails_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetIdentityMru_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetMembers_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetProjects_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonProject>> _retVal) { _retVal.Wait(); }
        partial void GetProxies_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonProxy>> _retVal) { _retVal.Wait(); }
        partial void GetTeams_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetConnectedServices_UnitTest",
            "GetDetails_UnitTest",
            "GetIdentityMru_UnitTest",
            "GetMembers_UnitTest",
            "GetTeams_UnitTest",
        };
    }
}