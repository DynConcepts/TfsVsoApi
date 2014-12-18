using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class IServerDataProviderWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.IServerDataProviderWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.IServerDataProviderWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Framework.Client.IServerDataProvider);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.IServerDataProviderWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.IServerDataProviderWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Framework.Client.IServerDataProvider real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.IServerDataProviderWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.IServerDataProviderWrapper>{ GetInstance() }; }

    partial void EnsureAuthenticated_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance);
    partial void EnsureAuthenticated_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void EnsureAuthenticated_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
        },
        (instance) =>
        {
          EnsureAuthenticated_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.EnsureAuthenticated();
       },
      (instance) =>
      {
              EnsureAuthenticated_PostValidate(instance);
      });
  }
    partial void Authenticate_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance);
    partial void Authenticate_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Authenticate_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
        },
        (instance) =>
        {
          Authenticate_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Authenticate();
       },
      (instance) =>
      {
              Authenticate_PostValidate(instance);
      });
  }
    partial void FindServerLocation_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref System.Guid serverGuid);
    partial void FindServerLocation_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, System.Guid serverGuid);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FindServerLocation_UnitTest()
  {
    System.Guid serverGuid = default(System.Guid);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
        },
        (instance) =>
        {
          serverGuid = default(System.Guid); //No Constructor
          FindServerLocation_PreCondition(ref instance, ref serverGuid);
        },
       (instance) =>
       {
             instance.FindServerLocation(serverGuid);
       },
      (instance) =>
      {
              FindServerLocation_PostValidate(instance, serverGuid);
      });
  }
    partial void Connect_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IConnectOptions connectOptions);
    partial void Connect_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IConnectOptions connectOptions);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Connect_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IConnectOptions connectOptions = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IConnectOptions);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
        },
        (instance) =>
        {
          connectOptions = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Common.ConnectOptionsWrapper_UnitTests.GetInstance();
          Connect_PreCondition(ref instance, ref connectOptions);
        },
       (instance) =>
       {
             instance.Connect(connectOptions);
       },
      (instance) =>
      {
              Connect_PostValidate(instance, connectOptions);
      });
  }
    partial void Disconnect_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance);
    partial void Disconnect_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Disconnect_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
        },
        (instance) =>
        {
          Disconnect_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Disconnect();
       },
      (instance) =>
      {
              Disconnect_PostValidate(instance);
      });
  }
    partial void ReactToPossibleServerUpdate_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref System.Int32 serverLastChangeId);
    partial void ReactToPossibleServerUpdate_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, System.Int32 serverLastChangeId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ReactToPossibleServerUpdate_UnitTest()
  {
    System.Int32 serverLastChangeId = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
        },
        (instance) =>
        {
          serverLastChangeId = default(System.Int32); //No Constructor
          ReactToPossibleServerUpdate_PreCondition(ref instance, ref serverLastChangeId);
        },
       (instance) =>
       {
             instance.ReactToPossibleServerUpdate(serverLastChangeId);
       },
      (instance) =>
      {
              ReactToPossibleServerUpdate_PostValidate(instance, serverLastChangeId);
      });
  }
   partial void InstanceId_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref System.Guid setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void InstanceId_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.InstanceId;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CachedInstanceId_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref System.Guid setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CachedInstanceId_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CachedInstanceId;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CatalogResourceId_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref System.Guid setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CatalogResourceId_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CatalogResourceId;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ServerCapabilities_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IServerCapabilities setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ServerCapabilities_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ServerCapabilities;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ClientCacheDirectoryForInstance_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ClientCacheDirectoryForInstance_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ClientCacheDirectoryForInstance;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ClientVolatileCacheDirectoryForInstance_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ClientVolatileCacheDirectoryForInstance_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ClientVolatileCacheDirectoryForInstance;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ClientCacheDirectoryForUser_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ClientCacheDirectoryForUser_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ClientCacheDirectoryForUser;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AuthorizedIdentity_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AuthorizedIdentity_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AuthorizedIdentity;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AuthenticatedIdentity_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AuthenticatedIdentity_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AuthenticatedIdentity;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void HasAuthenticated_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void HasAuthenticated_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.HasAuthenticated;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
