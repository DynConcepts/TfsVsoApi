using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class TfsClientCredentialsImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsClientCredentialsImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsClientCredentialsImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsClientCredentialsImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsClientCredentialsImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsClientCredentialsImpl>{ GetInstance() }; }

    partial void TryGetTokenProvider_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials instance, ref System.Uri serverUrl, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider provider);
    partial void TryGetTokenProvider_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials instance, System.Uri serverUrl, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider provider);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TryGetTokenProvider_UnitTest()
  {
    System.Uri serverUrl = default(System.Uri);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider provider = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials) GetInstance();
        },
        (instance) =>
        {
          serverUrl = default(System.Uri); //No Type
          provider = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.IssuedTokenProviderImpl_UnitTests.GetInstance();
          TryGetTokenProvider_PreCondition(ref instance, ref serverUrl, ref provider);
        },
       (instance) =>
       {
             instance.TryGetTokenProvider(serverUrl, out provider);
       },
      (instance) =>
      {
              TryGetTokenProvider_PostValidate(instance, serverUrl, provider);
      });
  }
    partial void SignOut_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials instance, ref System.Uri serverUrl, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider serverDataProvider);
    partial void SignOut_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials instance, System.Uri serverUrl, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider serverDataProvider);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SignOut_UnitTest()
  {
    System.Uri serverUrl = default(System.Uri);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider serverDataProvider = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials) GetInstance();
        },
        (instance) =>
        {
          serverUrl = default(System.Uri); //No Type
          serverDataProvider = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.IServerDataProviderImpl_UnitTests.GetInstance();
          SignOut_PreCondition(ref instance, ref serverUrl, ref serverDataProvider);
        },
       (instance) =>
       {
             instance.SignOut(serverUrl,serverDataProvider);
       },
      (instance) =>
      {
              SignOut_PostValidate(instance, serverUrl, serverDataProvider);
      });
  }
   partial void AllowInteractive_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AllowInteractive_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Boolean);
          AllowInteractive_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.AllowInteractive = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.AllowInteractive;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Federated_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IFederatedCredential setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Federated_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IFederatedCredential);
          Federated_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Federated = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Federated;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Windows_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IWindowsCredential setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Windows_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IWindowsCredential);
          Windows_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Windows = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Windows;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
