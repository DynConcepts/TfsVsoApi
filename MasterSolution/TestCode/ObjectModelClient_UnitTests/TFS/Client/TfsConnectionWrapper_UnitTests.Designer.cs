using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class TfsConnectionWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConnectionWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConnectionWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.TfsConnection);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConnectionWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConnectionWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.TfsConnection real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConnectionWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConnectionWrapper>{ GetInstance() }; }

    partial void GetAuthenticatedIdentity_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity identity);
    partial void GetAuthenticatedIdentity_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity identity);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetAuthenticatedIdentity_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity identity = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
        },
        (instance) =>
        {
          identity = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client.TeamFoundationIdentityWrapper_UnitTests.GetInstance();
          GetAuthenticatedIdentity_PreCondition(ref instance, ref identity);
        },
       (instance) =>
       {
             instance.GetAuthenticatedIdentity( out identity);
       },
      (instance) =>
      {
              GetAuthenticatedIdentity_PostValidate(instance, identity);
      });
  }
    partial void GetService_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance);
    partial void GetService_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetService_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
        },
        (instance) =>
        {
          GetService_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetService<object>();
       },
      (instance) =>
      {
              GetService_PostValidate(instance);
      });
  }
    partial void FlushServices_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance);
    partial void FlushServices_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FlushServices_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
        },
        (instance) =>
        {
          FlushServices_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.FlushServices();
       },
      (instance) =>
      {
              FlushServices_PostValidate(instance);
      });
  }
    partial void GetClient_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance);
    partial void GetClient_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetClient_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
        },
        (instance) =>
        {
          GetClient_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetClient<object>();
       },
      (instance) =>
      {
              GetClient_PostValidate(instance);
      });
  }
    partial void Dispose_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance);
    partial void Dispose_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Dispose_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
        },
        (instance) =>
        {
          Dispose_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Dispose();
       },
      (instance) =>
      {
              Dispose_PostValidate(instance);
      });
  }
   partial void ChannelFactory_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannelFactory setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ChannelFactory_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ChannelFactory;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ClientCredentials_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ClientCredentials_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials);
          ClientCredentials_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.ClientCredentials = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.ClientCredentials;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void TimeZone_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref System.TimeZone setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TimeZone_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.TimeZone);
          TimeZone_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.TimeZone = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.TimeZone;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsHostedServer_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsHostedServer_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsHostedServer;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CatalogNode_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CatalogNode_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CatalogNode;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IdentityToImpersonate_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IdentityToImpersonate_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IdentityToImpersonate;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void UICulture_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref System.Globalization.CultureInfo setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UICulture_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.Globalization.CultureInfo);
          UICulture_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.UICulture = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.UICulture;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ProxyServer_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITFProxyServer setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ProxyServer_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ProxyServer;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ConnectivityFailureOnLastWebServiceCall_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ConnectivityFailureOnLastWebServiceCall_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ConnectivityFailureOnLastWebServiceCall;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Disposed_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Disposed_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Disposed;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ServerDataProvider_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ServerDataProvider_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ServerDataProvider;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
