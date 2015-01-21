using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using DynCon.OSI.VSO.ReSTClient.Objects.Projects;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>
    ///     Generated Test Template
    /// </summary>
    public partial class JsonCoreAPI_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Gets the connected services_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetConnectedServices_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the details_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetDetails_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the identity mru_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetIdentityMru_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the members_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetMembers_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonIdentity>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the projects_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetProjects_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonProject>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the proxies_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetProxies_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonProxy>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the teams_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetTeams_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonTeam>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        /// <summary>
        ///     The SR_ disabled tests
        /// </summary>
        private static readonly List<String> sr_DisabledTests = new List<string>
        {
//            "GetConnectedServices_UnitTest",
            "GetDetails_UnitTest",
            "GetIdentityMru_UnitTest",
//            "GetMembers_UnitTest",
//            "GetTeams_UnitTest",
        };
    }
}