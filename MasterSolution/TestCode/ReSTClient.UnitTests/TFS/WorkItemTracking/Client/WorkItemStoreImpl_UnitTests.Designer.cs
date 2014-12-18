using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemStoreImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemStoreImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemStoreImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemStoreImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemStoreImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemStoreImpl>{ GetInstance() }; }

    partial void InvalidateCacheStamp_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
    partial void InvalidateCacheStamp_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void InvalidateCacheStamp_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          InvalidateCacheStamp_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.InvalidateCacheStamp();
       },
      (instance) =>
      {
              InvalidateCacheStamp_PostValidate(instance);
      });
  }
    partial void Query_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String wiql);
    partial void Query_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.String wiql);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Query_UnitTest()
  {
    System.String wiql = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          wiql = default(System.String); //No Constructor
          Query_PreCondition(ref instance, ref wiql);
        },
       (instance) =>
       {
             instance.Query(wiql);
       },
      (instance) =>
      {
              Query_PostValidate(instance, wiql);
      });
  }
    partial void QueryCount_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String wiql);
    partial void QueryCount_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.String wiql);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryCount_UnitTest()
  {
    System.String wiql = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          wiql = default(System.String); //No Constructor
          QueryCount_PreCondition(ref instance, ref wiql);
        },
       (instance) =>
       {
             instance.QueryCount(wiql);
       },
      (instance) =>
      {
              QueryCount_PostValidate(instance, wiql);
      });
  }
    partial void GetReferencingWorkItemUris_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Uri referencedUri);
    partial void GetReferencingWorkItemUris_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.Uri referencedUri);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetReferencingWorkItemUris_UnitTest()
  {
    System.Uri referencedUri = default(System.Uri);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          referencedUri = default(System.Uri); //No Type
          GetReferencingWorkItemUris_PreCondition(ref instance, ref referencedUri);
        },
       (instance) =>
       {
             instance.GetReferencingWorkItemUris(referencedUri);
       },
      (instance) =>
      {
              GetReferencingWorkItemUris_PostValidate(instance, referencedUri);
      });
  }
    partial void BatchSave_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem[] workitems);
    partial void BatchSave_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem[] workitems);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BatchSave_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem[] workitems = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem[]);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          workitems = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem)DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client.WorkItemImpl_UnitTests.GetInstance()};
          BatchSave_PreCondition(ref instance, ref workitems);
        },
       (instance) =>
       {
             instance.BatchSave(workitems);
       },
      (instance) =>
      {
              BatchSave_PostValidate(instance, workitems);
      });
  }
    partial void RefreshCache_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Boolean forceRefresh);
    partial void RefreshCache_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.Boolean forceRefresh);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RefreshCache_UnitTest()
  {
    System.Boolean forceRefresh = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          forceRefresh = default(System.Boolean); //No Constructor
          RefreshCache_PreCondition(ref instance, ref forceRefresh);
        },
       (instance) =>
       {
             instance.RefreshCache(forceRefresh);
       },
      (instance) =>
      {
              RefreshCache_PostValidate(instance, forceRefresh);
      });
  }
    partial void SyncToCache_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
    partial void SyncToCache_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SyncToCache_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          SyncToCache_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.SyncToCache();
       },
      (instance) =>
      {
              SyncToCache_PostValidate(instance);
      });
  }
    partial void ImportGlobalLists_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String lists);
    partial void ImportGlobalLists_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.String lists);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ImportGlobalLists_UnitTest()
  {
    System.String lists = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          lists = default(System.String); //No Constructor
          ImportGlobalLists_PreCondition(ref instance, ref lists);
        },
       (instance) =>
       {
             instance.ImportGlobalLists(lists);
       },
      (instance) =>
      {
              ImportGlobalLists_PostValidate(instance, lists);
      });
  }
    partial void ExportGlobalLists_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
    partial void ExportGlobalLists_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ExportGlobalLists_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          ExportGlobalLists_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.ExportGlobalLists();
       },
      (instance) =>
      {
              ExportGlobalLists_PostValidate(instance);
      });
  }
    partial void DestroyWorkItems_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Collections.Generic.IEnumerable<System.Int32> ids);
    partial void DestroyWorkItems_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.Collections.Generic.IEnumerable<System.Int32> ids);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DestroyWorkItems_UnitTest()
  {
    System.Collections.Generic.IEnumerable<System.Int32> ids = default(System.Collections.Generic.IEnumerable<System.Int32>);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          ids = default(System.Collections.Generic.IEnumerable<System.Int32>); //No Type
          DestroyWorkItems_PreCondition(ref instance, ref ids);
        },
       (instance) =>
       {
             instance.DestroyWorkItems(ids);
       },
      (instance) =>
      {
              DestroyWorkItems_PostValidate(instance, ids);
      });
  }
    partial void ResetCachedData_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
    partial void ResetCachedData_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ResetCachedData_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          ResetCachedData_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.ResetCachedData();
       },
      (instance) =>
      {
              ResetCachedData_PostValidate(instance);
      });
  }
    partial void TreeIdToPath_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Int32 id);
    partial void TreeIdToPath_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.Int32 id);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TreeIdToPath_UnitTest()
  {
    System.Int32 id = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Int32); //No Constructor
          TreeIdToPath_PreCondition(ref instance, ref id);
        },
       (instance) =>
       {
             instance.TreeIdToPath(id);
       },
      (instance) =>
      {
              TreeIdToPath_PostValidate(instance, id);
      });
  }
    partial void GetPersonNameById_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Int32 id);
    partial void GetPersonNameById_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.Int32 id);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetPersonNameById_UnitTest()
  {
    System.Int32 id = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Int32); //No Constructor
          GetPersonNameById_PreCondition(ref instance, ref id);
        },
       (instance) =>
       {
             instance.GetPersonNameById(id);
       },
      (instance) =>
      {
              GetPersonNameById_PostValidate(instance, id);
      });
  }
    partial void GetNodePermissions_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Int32 nodeId);
    partial void GetNodePermissions_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.Int32 nodeId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetNodePermissions_UnitTest()
  {
    System.Int32 nodeId = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          nodeId = default(System.Int32); //No Constructor
          GetNodePermissions_PreCondition(ref instance, ref nodeId);
        },
       (instance) =>
       {
             instance.GetNodePermissions(nodeId);
       },
      (instance) =>
      {
              GetNodePermissions_PostValidate(instance, nodeId);
      });
  }
    partial void CacheConstantStrings_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
    partial void CacheConstantStrings_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CacheConstantStrings_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          CacheConstantStrings_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.CacheConstantStrings();
       },
      (instance) =>
      {
              CacheConstantStrings_PostValidate(instance);
      });
  }
    partial void ResetConstantStringCache_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
    partial void ResetConstantStringCache_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ResetConstantStringCache_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          ResetConstantStringCache_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.ResetConstantStringCache();
       },
      (instance) =>
      {
              ResetConstantStringCache_PostValidate(instance);
      });
  }
    partial void SendUpdatePackage_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Xml.XmlElement package, ref System.Xml.XmlElement result, ref System.Boolean bulk);
    partial void SendUpdatePackage_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.Xml.XmlElement package, System.Xml.XmlElement result, System.Boolean bulk);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SendUpdatePackage_UnitTest()
  {
    System.Xml.XmlElement package = default(System.Xml.XmlElement);
    System.Xml.XmlElement result = default(System.Xml.XmlElement);
    System.Boolean bulk = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          package = default(System.Xml.XmlElement); //No Type
          result = default(System.Xml.XmlElement); //No Type
          bulk = default(System.Boolean); //No Constructor
          SendUpdatePackage_PreCondition(ref instance, ref package, ref result, ref bulk);
        },
       (instance) =>
       {
             instance.SendUpdatePackage(package, out result,bulk);
       },
      (instance) =>
      {
              SendUpdatePackage_PostValidate(instance, package, result, bulk);
      });
  }
    partial void GetGlobalAndProjectGroups_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Int32 projectId, ref System.Boolean includeGlobal);
    partial void GetGlobalAndProjectGroups_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, System.Int32 projectId, System.Boolean includeGlobal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetGlobalAndProjectGroups_UnitTest()
  {
    System.Int32 projectId = default(System.Int32);
    System.Boolean includeGlobal = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
        },
        (instance) =>
        {
          projectId = default(System.Int32); //No Constructor
          includeGlobal = default(System.Boolean); //No Constructor
          GetGlobalAndProjectGroups_PreCondition(ref instance, ref projectId, ref includeGlobal);
        },
       (instance) =>
       {
             instance.GetGlobalAndProjectGroups(projectId,includeGlobal);
       },
      (instance) =>
      {
              GetGlobalAndProjectGroups_PostValidate(instance, projectId, includeGlobal);
      });
  }
   partial void CultureInfo_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Globalization.CultureInfo setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CultureInfo_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CultureInfo;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ServerStringComparer_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.StringComparer setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ServerStringComparer_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ServerStringComparer;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Projects_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProjectCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Projects_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Projects;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void TeamProjectCollection_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TeamProjectCollection_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.TeamProjectCollection;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ClientService_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ClientService_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ClientService;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void RegisteredLinkTypes_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkTypeCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RegisteredLinkTypes_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.RegisteredLinkTypes;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void WorkItemLinkTypes_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void WorkItemLinkTypes_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.WorkItemLinkTypes;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Diagnostics_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStoreDiagnostics setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Diagnostics_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Diagnostics;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CallingProcessIdentity_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CallingProcessIdentity_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          CallingProcessIdentity_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.CallingProcessIdentity = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.CallingProcessIdentity;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void UserDisplayMode_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IUserDisplayMode setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UserDisplayMode_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.UserDisplayMode;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ServerInfo_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IServerInfo setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ServerInfo_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ServerInfo;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void MaxBulkUpdateBatchSize_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void MaxBulkUpdateBatchSize_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.MaxBulkUpdateBatchSize;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void BypassRules_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BypassRules_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.BypassRules;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void QueryHierarchyProvider_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryHierarchyProvider_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.QueryHierarchyProvider;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void WebServiceUrl_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void WebServiceUrl_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.WebServiceUrl;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void UserDisplayName_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UserDisplayName_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.UserDisplayName;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void UserSid_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UserSid_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.UserSid;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
