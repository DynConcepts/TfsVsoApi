using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ServerInfoWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref ServerInfo real, string callerName)
        {
            real = (ServerInfo)FormatterServices.GetUninitializedObject(typeof(ServerInfo));
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "IsSupported_UnitTest",
        };
    }
}