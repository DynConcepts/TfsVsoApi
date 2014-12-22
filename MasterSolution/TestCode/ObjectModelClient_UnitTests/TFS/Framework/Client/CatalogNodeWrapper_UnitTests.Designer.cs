using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CatalogNodeWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CatalogTree_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogNode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CatalogTree; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreateChild_UnitTest()
        {
            Guid resourceTypeIdentifier = default(Guid);
            String resourceDisplayName = default(String);
            ExecuteMethod(
                () => { return (ICatalogNode) GetInstance(); },
                instance =>
                {
                    resourceTypeIdentifier = default(Guid); //No Constructor
                    resourceDisplayName = default(String); //No Constructor
                    CreateChild_PreCondition(ref instance, ref resourceTypeIdentifier, ref resourceDisplayName);
                },
                instance => { instance.CreateChild(resourceTypeIdentifier, resourceDisplayName); },
                instance => { CreateChild_PostValidate(instance, resourceTypeIdentifier, resourceDisplayName); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Dependencies_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogNode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Dependencies; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ExpandDependencies_UnitTest()
        {
            ExecuteMethod(
                () => { return (ICatalogNode) GetInstance(); },
                instance => { ExpandDependencies_PreCondition(ref instance); },
                instance => { instance.ExpandDependencies(); },
                instance => { ExpandDependencies_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FullPath_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogNode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FullPath; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsDefault_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogNode) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    IsDefault_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.IsDefault = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.IsDefault; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ParentNode_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogNode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ParentNode; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ParentPath_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogNode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ParentPath; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryChildren_UnitTest()
        {
            IEnumerable<Guid> resourceTypeFilters = default(IEnumerable<Guid>);
            IEnumerable<KeyValuePair<String, String>> propertyFilters = default(IEnumerable<KeyValuePair<String, String>>);
            Boolean recurse = default(Boolean);
            ICatalogQueryOptions queryOptions = default(ICatalogQueryOptions);
            ExecuteMethod(
                () => { return (ICatalogNode) GetInstance(); },
                instance =>
                {
                    resourceTypeFilters = default(IEnumerable<Guid>); //No Type
                    propertyFilters = default(IEnumerable<KeyValuePair<String, String>>); //No Type
                    recurse = default(Boolean); //No Constructor
                    queryOptions = CatalogQueryOptionsWrapper_UnitTests.GetInstance();
                    QueryChildren_PreCondition(ref instance, ref resourceTypeFilters, ref propertyFilters, ref recurse, ref queryOptions);
                },
                instance => { instance.QueryChildren(resourceTypeFilters, propertyFilters, recurse, queryOptions); },
                instance => { QueryChildren_PostValidate(instance, resourceTypeFilters, propertyFilters, recurse, queryOptions); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryDependents_UnitTest()
        {
            ICatalogQueryOptions queryOptions = default(ICatalogQueryOptions);
            ExecuteMethod(
                () => { return (ICatalogNode) GetInstance(); },
                instance =>
                {
                    queryOptions = CatalogQueryOptionsWrapper_UnitTests.GetInstance();
                    QueryDependents_PreCondition(ref instance, ref queryOptions);
                },
                instance => { instance.QueryDependents(queryOptions); },
                instance => { QueryDependents_PostValidate(instance, queryOptions); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryParents_UnitTest()
        {
            IEnumerable<Guid> resourceTypeFilters = default(IEnumerable<Guid>);
            Boolean recurseToRoot = default(Boolean);
            ICatalogQueryOptions queryOptions = default(ICatalogQueryOptions);
            ExecuteMethod(
                () => { return (ICatalogNode) GetInstance(); },
                instance =>
                {
                    resourceTypeFilters = default(IEnumerable<Guid>); //No Type
                    recurseToRoot = default(Boolean); //No Constructor
                    queryOptions = CatalogQueryOptionsWrapper_UnitTests.GetInstance();
                    QueryParents_PreCondition(ref instance, ref resourceTypeFilters, ref recurseToRoot, ref queryOptions);
                },
                instance => { instance.QueryParents(resourceTypeFilters, recurseToRoot, queryOptions); },
                instance => { QueryParents_PostValidate(instance, resourceTypeFilters, recurseToRoot, queryOptions); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Resource_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogNode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Resource; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void CatalogTree_SetCondition(ref ICatalogNode instance, ref ICatalogTree setValue);
        partial void CreateChild_PostValidate(ICatalogNode instance, Guid resourceTypeIdentifier, String resourceDisplayName);
        partial void CreateChild_PreCondition(ref ICatalogNode instance, ref Guid resourceTypeIdentifier, ref String resourceDisplayName);
        partial void Dependencies_SetCondition(ref ICatalogNode instance, ref ICatalogDependencyGroup setValue);
        partial void ExpandDependencies_PostValidate(ICatalogNode instance);
        partial void ExpandDependencies_PreCondition(ref ICatalogNode instance);
        partial void FullPath_SetCondition(ref ICatalogNode instance, ref String setValue);
        internal static IEnumerable<CatalogNodeWrapper> GetIEnumerableInstance() { return new List<CatalogNodeWrapper> {GetInstance()}; }

        internal static CatalogNodeWrapper GetInstance()
        {
            CatalogNode real = default(CatalogNode);
            RealInstanceFactory(ref real);
            var instance = (CatalogNodeWrapper) CatalogNodeWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref CatalogNodeWrapper instance, [CallerMemberName] string callerName = "");
        partial void IsDefault_SetCondition(ref ICatalogNode instance, ref Boolean setValue);
        partial void ParentNode_SetCondition(ref ICatalogNode instance, ref ICatalogNode setValue);
        partial void ParentPath_SetCondition(ref ICatalogNode instance, ref String setValue);
        partial void QueryChildren_PostValidate(ICatalogNode instance, IEnumerable<Guid> resourceTypeFilters, IEnumerable<KeyValuePair<String, String>> propertyFilters, Boolean recurse, ICatalogQueryOptions queryOptions);
        partial void QueryChildren_PreCondition(ref ICatalogNode instance, ref IEnumerable<Guid> resourceTypeFilters, ref IEnumerable<KeyValuePair<String, String>> propertyFilters, ref Boolean recurse, ref ICatalogQueryOptions queryOptions);
        partial void QueryDependents_PostValidate(ICatalogNode instance, ICatalogQueryOptions queryOptions);
        partial void QueryDependents_PreCondition(ref ICatalogNode instance, ref ICatalogQueryOptions queryOptions);
        partial void QueryParents_PostValidate(ICatalogNode instance, IEnumerable<Guid> resourceTypeFilters, Boolean recurseToRoot, ICatalogQueryOptions queryOptions);
        partial void QueryParents_PreCondition(ref ICatalogNode instance, ref IEnumerable<Guid> resourceTypeFilters, ref Boolean recurseToRoot, ref ICatalogQueryOptions queryOptions);
        static partial void RealInstanceFactory(ref CatalogNode real, [CallerMemberName] string callerName = "");
        partial void Resource_SetCondition(ref ICatalogNode instance, ref ICatalogResource setValue);
    }
}