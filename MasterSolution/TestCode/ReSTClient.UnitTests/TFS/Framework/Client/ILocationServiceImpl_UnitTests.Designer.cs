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
  public partial class ILocationServiceImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ILocationServiceImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ILocationServiceImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ILocationServiceImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ILocationServiceImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.ILocationServiceImpl>{ GetInstance() }; }

    partial void FindServiceDefinition_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String serviceType, ref System.Guid serviceIdentifier);
    partial void FindServiceDefinition_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.String serviceType, System.Guid serviceIdentifier);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FindServiceDefinition_UnitTest()
  {
    System.String serviceType = default(System.String);
    System.Guid serviceIdentifier = default(System.Guid);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          serviceType = default(System.String); //No Constructor
          serviceIdentifier = default(System.Guid); //No Constructor
          FindServiceDefinition_PreCondition(ref instance, ref serviceType, ref serviceIdentifier);
        },
       (instance) =>
       {
             instance.FindServiceDefinition(serviceType,serviceIdentifier);
       },
      (instance) =>
      {
              FindServiceDefinition_PostValidate(instance, serviceType, serviceIdentifier);
      });
  }
    partial void LocationForCurrentConnection_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String serviceType, ref System.Guid serviceIdentifier);
    partial void LocationForCurrentConnection_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.String serviceType, System.Guid serviceIdentifier);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void LocationForCurrentConnection_UnitTest()
  {
    System.String serviceType = default(System.String);
    System.Guid serviceIdentifier = default(System.Guid);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          serviceType = default(System.String); //No Constructor
          serviceIdentifier = default(System.Guid); //No Constructor
          LocationForCurrentConnection_PreCondition(ref instance, ref serviceType, ref serviceIdentifier);
        },
       (instance) =>
       {
             instance.LocationForCurrentConnection(serviceType,serviceIdentifier);
       },
      (instance) =>
      {
              LocationForCurrentConnection_PostValidate(instance, serviceType, serviceIdentifier);
      });
  }
    partial void SaveServiceDefinition_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition serviceDefinition);
    partial void SaveServiceDefinition_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition serviceDefinition);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SaveServiceDefinition_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition serviceDefinition = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          serviceDefinition = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.ServiceDefinitionImpl_UnitTests.GetInstance();
          SaveServiceDefinition_PreCondition(ref instance, ref serviceDefinition);
        },
       (instance) =>
       {
             instance.SaveServiceDefinition(serviceDefinition);
       },
      (instance) =>
      {
              SaveServiceDefinition_PostValidate(instance, serviceDefinition);
      });
  }
    partial void SaveServiceDefinitions_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> serviceDefinitions);
    partial void SaveServiceDefinitions_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> serviceDefinitions);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SaveServiceDefinitions_UnitTest()
  {
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> serviceDefinitions = default(System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition>);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          serviceDefinitions = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.ServiceDefinitionImpl_UnitTests.GetIEnumerableInstance();
          SaveServiceDefinitions_PreCondition(ref instance, ref serviceDefinitions);
        },
       (instance) =>
       {
             instance.SaveServiceDefinitions(serviceDefinitions);
       },
      (instance) =>
      {
              SaveServiceDefinitions_PostValidate(instance, serviceDefinitions);
      });
  }
    partial void RemoveServiceDefinition_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String serviceType, ref System.Guid serviceIdentifier);
    partial void RemoveServiceDefinition_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.String serviceType, System.Guid serviceIdentifier);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveServiceDefinition_UnitTest()
  {
    System.String serviceType = default(System.String);
    System.Guid serviceIdentifier = default(System.Guid);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          serviceType = default(System.String); //No Constructor
          serviceIdentifier = default(System.Guid); //No Constructor
          RemoveServiceDefinition_PreCondition(ref instance, ref serviceType, ref serviceIdentifier);
        },
       (instance) =>
       {
             instance.RemoveServiceDefinition(serviceType,serviceIdentifier);
       },
      (instance) =>
      {
              RemoveServiceDefinition_PostValidate(instance, serviceType, serviceIdentifier);
      });
  }
    partial void RemoveServiceDefinitions_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> serviceDefinitions);
    partial void RemoveServiceDefinitions_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> serviceDefinitions);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveServiceDefinitions_UnitTest()
  {
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> serviceDefinitions = default(System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition>);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          serviceDefinitions = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.ServiceDefinitionImpl_UnitTests.GetIEnumerableInstance();
          RemoveServiceDefinitions_PreCondition(ref instance, ref serviceDefinitions);
        },
       (instance) =>
       {
             instance.RemoveServiceDefinitions(serviceDefinitions);
       },
      (instance) =>
      {
              RemoveServiceDefinitions_PostValidate(instance, serviceDefinitions);
      });
  }
    partial void FindServiceDefinitions_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String serviceType);
    partial void FindServiceDefinitions_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.String serviceType);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FindServiceDefinitions_UnitTest()
  {
    System.String serviceType = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          serviceType = default(System.String); //No Constructor
          FindServiceDefinitions_PreCondition(ref instance, ref serviceType);
        },
       (instance) =>
       {
             instance.FindServiceDefinitions(serviceType);
       },
      (instance) =>
      {
              FindServiceDefinitions_PostValidate(instance, serviceType);
      });
  }
    partial void FindServiceDefinitionsByToolType_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String toolType);
    partial void FindServiceDefinitionsByToolType_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.String toolType);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FindServiceDefinitionsByToolType_UnitTest()
  {
    System.String toolType = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          toolType = default(System.String); //No Constructor
          FindServiceDefinitionsByToolType_PreCondition(ref instance, ref toolType);
        },
       (instance) =>
       {
             instance.FindServiceDefinitionsByToolType(toolType);
       },
      (instance) =>
      {
              FindServiceDefinitionsByToolType_PostValidate(instance, toolType);
      });
  }
    partial void LocationForAccessMapping_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String serviceType, ref System.Guid serviceIdentifier, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
    partial void LocationForAccessMapping_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.String serviceType, System.Guid serviceIdentifier, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void LocationForAccessMapping_UnitTest()
  {
    System.String serviceType = default(System.String);
    System.Guid serviceIdentifier = default(System.Guid);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          serviceType = default(System.String); //No Constructor
          serviceIdentifier = default(System.Guid); //No Constructor
          accessMapping = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.AccessMappingImpl_UnitTests.GetInstance();
          LocationForAccessMapping_PreCondition(ref instance, ref serviceType, ref serviceIdentifier, ref accessMapping);
        },
       (instance) =>
       {
             instance.LocationForAccessMapping(serviceType,serviceIdentifier,accessMapping);
       },
      (instance) =>
      {
              LocationForAccessMapping_PostValidate(instance, serviceType, serviceIdentifier, accessMapping);
      });
  }
    partial void ConfigureAccessMapping_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String moniker, ref System.String displayName, ref System.String accessPoint, ref System.Boolean makeDefault);
    partial void ConfigureAccessMapping_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.String moniker, System.String displayName, System.String accessPoint, System.Boolean makeDefault);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ConfigureAccessMapping_UnitTest()
  {
    System.String moniker = default(System.String);
    System.String displayName = default(System.String);
    System.String accessPoint = default(System.String);
    System.Boolean makeDefault = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          moniker = default(System.String); //No Constructor
          displayName = default(System.String); //No Constructor
          accessPoint = default(System.String); //No Constructor
          makeDefault = default(System.Boolean); //No Constructor
          ConfigureAccessMapping_PreCondition(ref instance, ref moniker, ref displayName, ref accessPoint, ref makeDefault);
        },
       (instance) =>
       {
             instance.ConfigureAccessMapping(moniker,displayName,accessPoint,makeDefault);
       },
      (instance) =>
      {
              ConfigureAccessMapping_PostValidate(instance, moniker, displayName, accessPoint, makeDefault);
      });
  }
    partial void SetDefaultAccessMapping_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
    partial void SetDefaultAccessMapping_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetDefaultAccessMapping_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          accessMapping = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.AccessMappingImpl_UnitTests.GetInstance();
          SetDefaultAccessMapping_PreCondition(ref instance, ref accessMapping);
        },
       (instance) =>
       {
             instance.SetDefaultAccessMapping(accessMapping);
       },
      (instance) =>
      {
              SetDefaultAccessMapping_PostValidate(instance, accessMapping);
      });
  }
    partial void GetAccessMapping_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String moniker);
    partial void GetAccessMapping_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.String moniker);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetAccessMapping_UnitTest()
  {
    System.String moniker = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          moniker = default(System.String); //No Constructor
          GetAccessMapping_PreCondition(ref instance, ref moniker);
        },
       (instance) =>
       {
             instance.GetAccessMapping(moniker);
       },
      (instance) =>
      {
              GetAccessMapping_PostValidate(instance, moniker);
      });
  }
    partial void RemoveAccessMapping_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String moniker);
    partial void RemoveAccessMapping_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, System.String moniker);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveAccessMapping_UnitTest()
  {
    System.String moniker = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
        },
        (instance) =>
        {
          moniker = default(System.String); //No Constructor
          RemoveAccessMapping_PreCondition(ref instance, ref moniker);
        },
       (instance) =>
       {
             instance.RemoveAccessMapping(moniker);
       },
      (instance) =>
      {
              RemoveAccessMapping_PostValidate(instance, moniker);
      });
  }
   partial void ClientAccessMapping_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ClientAccessMapping_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ClientAccessMapping;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void DefaultAccessMapping_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DefaultAccessMapping_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.DefaultAccessMapping;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ConfiguredAccessMappings_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ConfiguredAccessMappings_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ConfiguredAccessMappings;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
