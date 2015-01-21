using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class AccessControlListWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref AccessControlList real, string callerName)
        {
            string token = String.Empty;
            bool inherit = false;
            real = new AccessControlList(token, inherit);
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "SetAccessControlEntries_UnitTest",
            "SetAccessControlEntry_UnitTest",
            "SetPermissions_UnitTest",
        };
    }
}