using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class FieldDefinitionCollectionWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetById_UnitTest()
        {
            Int32 id = default(Int32);
            ExecuteMethod(
                () => { return (IFieldDefinitionCollection) GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    GetById_PreCondition(instance, ref id);
                },
                instance => { instance.GetById(id); },
                instance => { GetById_PostValidate(instance, id); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TryGetById_UnitTest()
        {
            Int32 id = default(Int32);
            ExecuteMethod(
                () => { return (IFieldDefinitionCollection) GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    TryGetById_PreCondition(instance, ref id);
                },
                instance => { instance.TryGetById(id); },
                instance => { TryGetById_PostValidate(instance, id); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TryGetByName_UnitTest()
        {
            String name = default(String);
            ExecuteMethod(
                () => { return (IFieldDefinitionCollection) GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    TryGetByName_PreCondition(instance, ref name);
                },
                instance => { instance.TryGetByName(name); },
                instance => { TryGetByName_PostValidate(instance, name); });
        }

        partial void GetById_PostValidate(IFieldDefinitionCollection instance, Int32 id);
        partial void GetById_PreCondition(IFieldDefinitionCollection instance, ref Int32 id);
        internal static IEnumerable<FieldDefinitionCollectionWrapper> GetIEnumerableInstance() { return new List<FieldDefinitionCollectionWrapper> {GetInstance()}; }

        internal static FieldDefinitionCollectionWrapper GetInstance()
        {
            FieldDefinitionCollection real = default(FieldDefinitionCollection);
            RealInstanceFactory(ref real);
            var instance = (FieldDefinitionCollectionWrapper) FieldDefinitionCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref FieldDefinitionCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref FieldDefinitionCollection real, [CallerMemberName] string callerName = "");
        partial void TryGetById_PostValidate(IFieldDefinitionCollection instance, Int32 id);
        partial void TryGetById_PreCondition(IFieldDefinitionCollection instance, ref Int32 id);

        partial void TryGetByName_PostValidate(IFieldDefinitionCollection instance, String name);
        partial void TryGetByName_PreCondition(IFieldDefinitionCollection instance, ref String name);
    }
}