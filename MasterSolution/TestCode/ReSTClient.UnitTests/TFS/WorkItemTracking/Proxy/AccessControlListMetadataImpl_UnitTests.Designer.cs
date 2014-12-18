using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class AccessControlListMetadataImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.AccessControlListMetadataImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.AccessControlListMetadataImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.AccessControlListMetadataImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.AccessControlListMetadataImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.AccessControlListMetadataImpl>{ GetInstance() }; }

   partial void FullSelectionPermission_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FullSelectionPermission_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          FullSelectionPermission_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.FullSelectionPermission = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.FullSelectionPermission;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IrrevocableAdminPermissions_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata instance, ref System.String[] setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IrrevocableAdminPermissions_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String[]);
          IrrevocableAdminPermissions_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.IrrevocableAdminPermissions = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.IrrevocableAdminPermissions;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ObjectClassId_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ObjectClassId_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          ObjectClassId_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.ObjectClassId = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.ObjectClassId;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void PermissionDescriptions_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata instance, ref System.String[] setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void PermissionDescriptions_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String[]);
          PermissionDescriptions_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.PermissionDescriptions = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.PermissionDescriptions;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void PermissionDisplayStrings_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata instance, ref System.String[] setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void PermissionDisplayStrings_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String[]);
          PermissionDisplayStrings_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.PermissionDisplayStrings = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.PermissionDisplayStrings;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void PermissionNames_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata instance, ref System.String[] setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void PermissionNames_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String[]);
          PermissionNames_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.PermissionNames = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.PermissionNames;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void PermissionRequirements_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRequiredPermissions[] setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void PermissionRequirements_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRequiredPermissions[]);
          PermissionRequirements_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.PermissionRequirements = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.PermissionRequirements;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
