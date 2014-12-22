using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CatalogResourceWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void NodeReferences_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogResource) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.NodeReferences; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Properties_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogResource) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Properties; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ResourceType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogResource) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ResourceType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ServiceReferences_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogResource) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ServiceReferences; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<CatalogResourceWrapper> GetIEnumerableInstance() { return new List<CatalogResourceWrapper> {GetInstance()}; }

        internal static CatalogResourceWrapper GetInstance()
        {
            CatalogResource real = default(CatalogResource);
            RealInstanceFactory(ref real);
            var instance = (CatalogResourceWrapper) CatalogResourceWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref CatalogResourceWrapper instance, [CallerMemberName] string callerName = "");
        partial void NodeReferences_SetCondition(ref ICatalogResource instance, ref ReadOnlyCollection<ICatalogNode> setValue);
        partial void Properties_SetCondition(ref ICatalogResource instance, ref IDictionary<String, String> setValue);

        static partial void RealInstanceFactory(ref CatalogResource real, [CallerMemberName] string callerName = "");

        partial void ResourceType_SetCondition(ref ICatalogResource instance, ref ICatalogResourceType setValue);

        partial void ServiceReferences_SetCondition(ref ICatalogResource instance, ref IDictionary<String, IServiceDefinition> setValue);
    }
}