using System;
using System.Collections.Generic;
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
    public partial class CatalogDependencyGroupWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AddSetDependency_UnitTest()
        {
            String key = default(String);
            ICatalogNode node = default(ICatalogNode);
            ExecuteMethod(
                () => { return (ICatalogDependencyGroup) GetInstance(); },
                instance =>
                {
                    key = default(String); //No Constructor
                    node = CatalogNodeWrapper_UnitTests.GetInstance();
                    AddSetDependency_PreCondition(ref instance, ref key, ref node);
                },
                instance => { instance.AddSetDependency(key, node); },
                instance => { AddSetDependency_PostValidate(instance, key, node); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ClearDependencySets_UnitTest()
        {
            ExecuteMethod(
                () => { return (ICatalogDependencyGroup) GetInstance(); },
                instance => { ClearDependencySets_PreCondition(ref instance); },
                instance => { instance.ClearDependencySets(); },
                instance => { ClearDependencySets_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ClearSingletonDependencies_UnitTest()
        {
            ExecuteMethod(
                () => { return (ICatalogDependencyGroup) GetInstance(); },
                instance => { ClearSingletonDependencies_PreCondition(ref instance); },
                instance => { instance.ClearSingletonDependencies(); },
                instance => { ClearSingletonDependencies_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetAllDependencies_UnitTest()
        {
            ExecuteMethod(
                () => { return (ICatalogDependencyGroup) GetInstance(); },
                instance => { GetAllDependencies_PreCondition(ref instance); },
                instance => { instance.GetAllDependencies(); },
                instance => { GetAllDependencies_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetDependencySet_UnitTest()
        {
            String key = default(String);
            ExecuteMethod(
                () => { return (ICatalogDependencyGroup) GetInstance(); },
                instance =>
                {
                    key = default(String); //No Constructor
                    GetDependencySet_PreCondition(ref instance, ref key);
                },
                instance => { instance.GetDependencySet(key); },
                instance => { GetDependencySet_PostValidate(instance, key); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetSingletonDependency_UnitTest()
        {
            String key = default(String);
            ExecuteMethod(
                () => { return (ICatalogDependencyGroup) GetInstance(); },
                instance =>
                {
                    key = default(String); //No Constructor
                    GetSingletonDependency_PreCondition(ref instance, ref key);
                },
                instance => { instance.GetSingletonDependency(key); },
                instance => { GetSingletonDependency_PostValidate(instance, key); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveSetDependency_UnitTest()
        {
            String key = default(String);
            ExecuteMethod(
                () => { return (ICatalogDependencyGroup) GetInstance(); },
                instance =>
                {
                    key = default(String); //No Constructor
                    RemoveSetDependency_PreCondition(ref instance, ref key);
                },
                instance => { instance.RemoveSetDependency(key); },
                instance => { RemoveSetDependency_PostValidate(instance, key); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveSingletonDependency_UnitTest()
        {
            String key = default(String);
            ExecuteMethod(
                () => { return (ICatalogDependencyGroup) GetInstance(); },
                instance =>
                {
                    key = default(String); //No Constructor
                    RemoveSingletonDependency_PreCondition(ref instance, ref key);
                },
                instance => { instance.RemoveSingletonDependency(key); },
                instance => { RemoveSingletonDependency_PostValidate(instance, key); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetSingletonDependency_UnitTest()
        {
            String key = default(String);
            ICatalogNode node = default(ICatalogNode);
            ExecuteMethod(
                () => { return (ICatalogDependencyGroup) GetInstance(); },
                instance =>
                {
                    key = default(String); //No Constructor
                    node = CatalogNodeWrapper_UnitTests.GetInstance();
                    SetSingletonDependency_PreCondition(ref instance, ref key, ref node);
                },
                instance => { instance.SetSingletonDependency(key, node); },
                instance => { SetSingletonDependency_PostValidate(instance, key, node); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Sets_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogDependencyGroup) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Sets; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Singletons_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICatalogDependencyGroup) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Singletons; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AddSetDependency_PostValidate(ICatalogDependencyGroup instance, String key, ICatalogNode node);
        partial void AddSetDependency_PreCondition(ref ICatalogDependencyGroup instance, ref String key, ref ICatalogNode node);
        partial void ClearDependencySets_PostValidate(ICatalogDependencyGroup instance);
        partial void ClearDependencySets_PreCondition(ref ICatalogDependencyGroup instance);
        partial void ClearSingletonDependencies_PostValidate(ICatalogDependencyGroup instance);
        partial void ClearSingletonDependencies_PreCondition(ref ICatalogDependencyGroup instance);
        partial void GetAllDependencies_PostValidate(ICatalogDependencyGroup instance);
        partial void GetAllDependencies_PreCondition(ref ICatalogDependencyGroup instance);
        partial void GetDependencySet_PostValidate(ICatalogDependencyGroup instance, String key);
        partial void GetDependencySet_PreCondition(ref ICatalogDependencyGroup instance, ref String key);
        internal static IEnumerable<CatalogDependencyGroupWrapper> GetIEnumerableInstance() { return new List<CatalogDependencyGroupWrapper> {GetInstance()}; }

        internal static CatalogDependencyGroupWrapper GetInstance()
        {
            var real = new CatalogDependencyGroup();
            RealInstanceFactory(ref real);
            var instance = (CatalogDependencyGroupWrapper) CatalogDependencyGroupWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetSingletonDependency_PostValidate(ICatalogDependencyGroup instance, String key);
        partial void GetSingletonDependency_PreCondition(ref ICatalogDependencyGroup instance, ref String key);
        static partial void InstanceFactory(ref CatalogDependencyGroupWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref CatalogDependencyGroup real, [CallerMemberName] string callerName = "");
        partial void RemoveSetDependency_PostValidate(ICatalogDependencyGroup instance, String key);
        partial void RemoveSetDependency_PreCondition(ref ICatalogDependencyGroup instance, ref String key);
        partial void RemoveSingletonDependency_PostValidate(ICatalogDependencyGroup instance, String key);
        partial void RemoveSingletonDependency_PreCondition(ref ICatalogDependencyGroup instance, ref String key);
        partial void SetSingletonDependency_PostValidate(ICatalogDependencyGroup instance, String key, ICatalogNode node);
        partial void SetSingletonDependency_PreCondition(ref ICatalogDependencyGroup instance, ref String key, ref ICatalogNode node);

        partial void Sets_SetCondition(ref ICatalogDependencyGroup instance, ref IEnumerable<KeyValuePair<String, IList<ICatalogNode>>> setValue);
        partial void Singletons_SetCondition(ref ICatalogDependencyGroup instance, ref IEnumerable<KeyValuePair<String, ICatalogNode>> setValue);
    }
}