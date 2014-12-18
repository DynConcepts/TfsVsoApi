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
  public partial class ServiceDefinitionImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ServiceDefinitionImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ServiceDefinitionImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ServiceDefinitionImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ServiceDefinitionImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ServiceDefinitionImpl>{ GetInstance() }; }

    partial void AddLocationMapping_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping, ref System.String location);
    partial void AddLocationMapping_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping, System.String location);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AddLocationMapping_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping);
    System.String location = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition) GetInstance();
        },
        (instance) =>
        {
          accessMapping = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.AccessMappingImpl_UnitTests.GetInstance();
          location = default(System.String); //No Constructor
          AddLocationMapping_PreCondition(ref instance, ref accessMapping, ref location);
        },
       (instance) =>
       {
             instance.AddLocationMapping(accessMapping,location);
       },
      (instance) =>
      {
              AddLocationMapping_PostValidate(instance, accessMapping, location);
      });
  }
    partial void RemoveLocationMapping_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
    partial void RemoveLocationMapping_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveLocationMapping_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition) GetInstance();
        },
        (instance) =>
        {
          accessMapping = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.AccessMappingImpl_UnitTests.GetInstance();
          RemoveLocationMapping_PreCondition(ref instance, ref accessMapping);
        },
       (instance) =>
       {
             instance.RemoveLocationMapping(accessMapping);
       },
      (instance) =>
      {
              RemoveLocationMapping_PostValidate(instance, accessMapping);
      });
  }
    partial void GetLocationMapping_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
    partial void GetLocationMapping_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetLocationMapping_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition) GetInstance();
        },
        (instance) =>
        {
          accessMapping = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.AccessMappingImpl_UnitTests.GetInstance();
          GetLocationMapping_PreCondition(ref instance, ref accessMapping);
        },
       (instance) =>
       {
             instance.GetLocationMapping(accessMapping);
       },
      (instance) =>
      {
              GetLocationMapping_PostValidate(instance, accessMapping);
      });
  }
   partial void ServiceType_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ServiceType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          ServiceType_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.ServiceType = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.ServiceType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void RelativeToSetting_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IRelativeToSetting setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RelativeToSetting_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IRelativeToSetting);
          RelativeToSetting_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.RelativeToSetting = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.RelativeToSetting;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void RelativePath_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RelativePath_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          RelativePath_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.RelativePath = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.RelativePath;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Description_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Description_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          Description_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Description = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Description;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ToolType_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToolType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          ToolType_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.ToolType = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.ToolType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void LocationMappings_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition instance, ref System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ILocationMapping> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void LocationMappings_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.LocationMappings;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
