using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class FieldDefinitionCollectionImpl_UnitTests : DynTestClassBase
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
                    GetById_PreCondition(ref instance, ref id);
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
                    TryGetById_PreCondition(ref instance, ref id);
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
                    TryGetByName_PreCondition(ref instance, ref name);
                },
                instance => { instance.TryGetByName(name); },
                instance => { TryGetByName_PostValidate(instance, name); });
        }

        partial void GetById_PostValidate(IFieldDefinitionCollection instance, Int32 id);
        partial void GetById_PreCondition(ref IFieldDefinitionCollection instance, ref Int32 id);
        internal static IEnumerable<FieldDefinitionCollectionImpl> GetIEnumerableInstance() { return new List<FieldDefinitionCollectionImpl> {GetInstance()}; }

        internal static FieldDefinitionCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            FieldDefinitionCollectionImpl instance = FieldDefinitionCollectionImpl.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref FieldDefinitionCollectionImpl instance, [CallerMemberName] string callerName = "");

        static partial void JsonSource(ref JToken json);
        partial void TryGetById_PostValidate(IFieldDefinitionCollection instance, Int32 id);
        partial void TryGetById_PreCondition(ref IFieldDefinitionCollection instance, ref Int32 id);

        partial void TryGetByName_PostValidate(IFieldDefinitionCollection instance, String name);
        partial void TryGetByName_PreCondition(ref IFieldDefinitionCollection instance, ref String name);
    }
}