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
  public partial class CatalogResourceImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogResourceImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogResourceImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogResourceImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogResourceImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogResourceImpl>{ GetInstance() }; }

   partial void ResourceType_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResourceType setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ResourceType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ResourceType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Properties_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource instance, ref System.Collections.Generic.IDictionary<System.String,System.String> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Properties_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Properties;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ServiceReferences_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource instance, ref System.Collections.Generic.IDictionary<System.String,DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ServiceReferences_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ServiceReferences;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void NodeReferences_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource instance, ref System.Collections.ObjectModel.ReadOnlyCollection<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void NodeReferences_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.NodeReferences;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
