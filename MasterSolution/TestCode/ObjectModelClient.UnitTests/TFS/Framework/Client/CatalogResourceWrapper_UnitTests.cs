using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class CatalogResourceWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref CatalogResource real, string callerName)
        {
            real = (CatalogResource)FormatterServices.GetUninitializedObject(typeof(CatalogResource));
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "NodeReferences_UnitTest",
            "ServiceReferences_UnitTest",
        };
    }
}