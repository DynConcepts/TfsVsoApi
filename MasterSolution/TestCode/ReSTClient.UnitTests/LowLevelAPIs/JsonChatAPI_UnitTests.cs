using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonChatAPI_UnitTests : DynTestClassBase
    {
        partial void GetMessages_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetRooms_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonRoom>> _retVal) { _retVal.Wait(); }
        partial void GetUsers_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetMessages_UnitTest",
            "GetUsers_UnitTest",
        };
    }
}