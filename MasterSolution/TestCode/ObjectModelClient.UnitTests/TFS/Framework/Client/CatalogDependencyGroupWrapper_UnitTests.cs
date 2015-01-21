using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class CatalogDependencyGroupWrapper_UnitTests
    {
        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "Singletons_UnitTest",
            "RemoveSetDependency_UnitTest",
            "RemoveSingletonDependency_UnitTest",
            "GetDependencySet_UnitTest",
            "GetSingletonDependency_UnitTest",
            "SetSingletonDependency_UnitTest"
        };

        partial void AddSetDependency_PreCondition(ICatalogDependencyGroup instance, ref String key, ref ICatalogNode node) { key = "TestKey"; }

    }
}