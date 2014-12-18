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
  public partial class IssuedTokenProviderWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenProviderWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenProviderWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.IssuedTokenProvider);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenProviderWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenProviderWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.IssuedTokenProvider real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenProviderWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenProviderWrapper>{ GetInstance() }; }

    partial void GetToken_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider instance, ref System.TimeSpan timeout);
    partial void GetToken_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider instance, System.TimeSpan timeout);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetToken_UnitTest()
  {
    System.TimeSpan timeout = default(System.TimeSpan);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider) GetInstance();
        },
        (instance) =>
        {
          timeout = default(System.TimeSpan); //No Constructor
          GetToken_PreCondition(ref instance, ref timeout);
        },
       (instance) =>
       {
             instance.GetToken(timeout);
       },
      (instance) =>
      {
              GetToken_PostValidate(instance, timeout);
      });
  }
    partial void BeginGetToken_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider instance, ref System.TimeSpan timeout, ref System.AsyncCallback callback, ref System.Object state);
    partial void BeginGetToken_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider instance, System.TimeSpan timeout, System.AsyncCallback callback, System.Object state);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BeginGetToken_UnitTest()
  {
    System.TimeSpan timeout = default(System.TimeSpan);
    System.AsyncCallback callback = default(System.AsyncCallback);
    System.Object state = default(System.Object);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider) GetInstance();
        },
        (instance) =>
        {
          timeout = default(System.TimeSpan); //No Constructor
          callback = default(System.AsyncCallback); //No Constructor
          state = new System.Object();
          BeginGetToken_PreCondition(ref instance, ref timeout, ref callback, ref state);
        },
       (instance) =>
       {
             instance.BeginGetToken(timeout,callback,state);
       },
      (instance) =>
      {
              BeginGetToken_PostValidate(instance, timeout, callback, state);
      });
  }
    partial void EndGetToken_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider instance, ref System.IAsyncResult result);
    partial void EndGetToken_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider instance, System.IAsyncResult result);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void EndGetToken_UnitTest()
  {
    System.IAsyncResult result = default(System.IAsyncResult);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider) GetInstance();
        },
        (instance) =>
        {
          result = default(System.IAsyncResult); //No Constructor
          EndGetToken_PreCondition(ref instance, ref result);
        },
       (instance) =>
       {
             instance.EndGetToken(result);
       },
      (instance) =>
      {
              EndGetToken_PostValidate(instance, result);
      });
  }
   partial void CurrentToken_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CurrentToken_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CurrentToken;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void GetTokenIsInteractive_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetTokenIsInteractive_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.GetTokenIsInteractive;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SignInUrl_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider instance, ref System.Uri setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SignInUrl_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.SignInUrl;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
