using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class CatalogDependencyGroupImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogDependencyGroupImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogDependencyGroupImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogDependencyGroupImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogDependencyGroupImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogDependencyGroupImpl>{ GetInstance() }; }

    partial void GetAllDependencies_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance);
    partial void GetAllDependencies_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetAllDependencies_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
        },
        (instance) =>
        {
          GetAllDependencies_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetAllDependencies();
       },
      (instance) =>
      {
              GetAllDependencies_PostValidate(instance);
      });
  }
    partial void SetSingletonDependency_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, ref System.String key, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode node);
    partial void SetSingletonDependency_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, System.String key, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode node);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetSingletonDependency_UnitTest()
  {
    System.String key = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode node = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
        },
        (instance) =>
        {
          key = default(System.String); //No Constructor
          node = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.CatalogNodeImpl_UnitTests.GetInstance();
          SetSingletonDependency_PreCondition(ref instance, ref key, ref node);
        },
       (instance) =>
       {
             instance.SetSingletonDependency(key,node);
       },
      (instance) =>
      {
              SetSingletonDependency_PostValidate(instance, key, node);
      });
  }
    partial void RemoveSingletonDependency_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, ref System.String key);
    partial void RemoveSingletonDependency_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, System.String key);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveSingletonDependency_UnitTest()
  {
    System.String key = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
        },
        (instance) =>
        {
          key = default(System.String); //No Constructor
          RemoveSingletonDependency_PreCondition(ref instance, ref key);
        },
       (instance) =>
       {
             instance.RemoveSingletonDependency(key);
       },
      (instance) =>
      {
              RemoveSingletonDependency_PostValidate(instance, key);
      });
  }
    partial void GetSingletonDependency_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, ref System.String key);
    partial void GetSingletonDependency_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, System.String key);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetSingletonDependency_UnitTest()
  {
    System.String key = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
        },
        (instance) =>
        {
          key = default(System.String); //No Constructor
          GetSingletonDependency_PreCondition(ref instance, ref key);
        },
       (instance) =>
       {
             instance.GetSingletonDependency(key);
       },
      (instance) =>
      {
              GetSingletonDependency_PostValidate(instance, key);
      });
  }
    partial void AddSetDependency_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, ref System.String key, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode node);
    partial void AddSetDependency_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, System.String key, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode node);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AddSetDependency_UnitTest()
  {
    System.String key = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode node = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
        },
        (instance) =>
        {
          key = default(System.String); //No Constructor
          node = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.CatalogNodeImpl_UnitTests.GetInstance();
          AddSetDependency_PreCondition(ref instance, ref key, ref node);
        },
       (instance) =>
       {
             instance.AddSetDependency(key,node);
       },
      (instance) =>
      {
              AddSetDependency_PostValidate(instance, key, node);
      });
  }
    partial void RemoveSetDependency_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, ref System.String key);
    partial void RemoveSetDependency_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, System.String key);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveSetDependency_UnitTest()
  {
    System.String key = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
        },
        (instance) =>
        {
          key = default(System.String); //No Constructor
          RemoveSetDependency_PreCondition(ref instance, ref key);
        },
       (instance) =>
       {
             instance.RemoveSetDependency(key);
       },
      (instance) =>
      {
              RemoveSetDependency_PostValidate(instance, key);
      });
  }
    partial void GetDependencySet_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, ref System.String key);
    partial void GetDependencySet_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, System.String key);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetDependencySet_UnitTest()
  {
    System.String key = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
        },
        (instance) =>
        {
          key = default(System.String); //No Constructor
          GetDependencySet_PreCondition(ref instance, ref key);
        },
       (instance) =>
       {
             instance.GetDependencySet(key);
       },
      (instance) =>
      {
              GetDependencySet_PostValidate(instance, key);
      });
  }
    partial void ClearSingletonDependencies_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance);
    partial void ClearSingletonDependencies_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ClearSingletonDependencies_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
        },
        (instance) =>
        {
          ClearSingletonDependencies_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.ClearSingletonDependencies();
       },
      (instance) =>
      {
              ClearSingletonDependencies_PostValidate(instance);
      });
  }
    partial void ClearDependencySets_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance);
    partial void ClearDependencySets_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ClearDependencySets_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
        },
        (instance) =>
        {
          ClearDependencySets_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.ClearDependencySets();
       },
      (instance) =>
      {
              ClearDependencySets_PostValidate(instance);
      });
  }
   partial void Singletons_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, ref System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode>> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Singletons_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Singletons;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Sets_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup instance, ref System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IList<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode>>> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Sets_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Sets;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
