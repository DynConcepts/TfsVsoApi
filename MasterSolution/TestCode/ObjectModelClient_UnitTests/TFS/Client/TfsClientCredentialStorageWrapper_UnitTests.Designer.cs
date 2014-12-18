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
  public partial class TfsClientCredentialStorageWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsClientCredentialStorageWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsClientCredentialStorageWrapper GetInstance() 
  { 
    var real = new Microsoft.TeamFoundation.Client.TfsClientCredentialStorage();
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsClientCredentialStorageWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsClientCredentialStorageWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.TfsClientCredentialStorage real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsClientCredentialStorageWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsClientCredentialStorageWrapper>{ GetInstance() }; }

    partial void RetrieveToken_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, ref System.Uri serverUrl, ref Microsoft.VisualStudio.Services.Common.VssCredentialsType credentialType);
    partial void RetrieveToken_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, System.Uri serverUrl, Microsoft.VisualStudio.Services.Common.VssCredentialsType credentialType);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RetrieveToken_UnitTest()
  {
    System.Uri serverUrl = default(System.Uri);
    Microsoft.VisualStudio.Services.Common.VssCredentialsType credentialType = default(Microsoft.VisualStudio.Services.Common.VssCredentialsType);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage) GetInstance();
        },
        (instance) =>
        {
          serverUrl = default(System.Uri); //No Type
          credentialType = default(Microsoft.VisualStudio.Services.Common.VssCredentialsType); //No Type
          RetrieveToken_PreCondition(ref instance, ref serverUrl, ref credentialType);
        },
       (instance) =>
       {
             instance.RetrieveToken(serverUrl,credentialType);
       },
      (instance) =>
      {
              RetrieveToken_PostValidate(instance, serverUrl, credentialType);
      });
  }
    partial void GetTokenProperty_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, ref System.Uri[] serverUrls, ref System.String propertyName);
    partial void GetTokenProperty_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, System.Uri[] serverUrls, System.String propertyName);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetTokenProperty_UnitTest()
  {
    System.Uri[] serverUrls = default(System.Uri[]);
    System.String propertyName = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage) GetInstance();
        },
        (instance) =>
        {
          serverUrls = default(System.Uri[]); //No Type
          propertyName = default(System.String); //No Constructor
          GetTokenProperty_PreCondition(ref instance, ref serverUrls, ref propertyName);
        },
       (instance) =>
       {
             instance.GetTokenProperty(serverUrls,propertyName);
       },
      (instance) =>
      {
              GetTokenProperty_PostValidate(instance, serverUrls, propertyName);
      });
  }
    partial void StoreToken_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, ref System.Uri serverUrl, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken token, ref System.Boolean matchUserInformation);
    partial void StoreToken_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, System.Uri serverUrl, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken token, System.Boolean matchUserInformation);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void StoreToken_UnitTest()
  {
    System.Uri serverUrl = default(System.Uri);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken token = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken);
    System.Boolean matchUserInformation = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage) GetInstance();
        },
        (instance) =>
        {
          serverUrl = default(System.Uri); //No Type
          token = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.IssuedTokenWrapper_UnitTests.GetInstance();
          matchUserInformation = default(System.Boolean); //No Constructor
          StoreToken_PreCondition(ref instance, ref serverUrl, ref token, ref matchUserInformation);
        },
       (instance) =>
       {
             instance.StoreToken(serverUrl,token,matchUserInformation);
       },
      (instance) =>
      {
              StoreToken_PostValidate(instance, serverUrl, token, matchUserInformation);
      });
  }
    partial void RemoveToken_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, ref System.Uri serverUrl);
    partial void RemoveToken_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, System.Uri serverUrl);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveToken_UnitTest()
  {
    System.Uri serverUrl = default(System.Uri);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage) GetInstance();
        },
        (instance) =>
        {
          serverUrl = default(System.Uri); //No Type
          RemoveToken_PreCondition(ref instance, ref serverUrl);
        },
       (instance) =>
       {
             instance.RemoveToken(serverUrl);
       },
      (instance) =>
      {
              RemoveToken_PostValidate(instance, serverUrl);
      });
  }
    partial void RemoveTokenValue_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, ref System.Uri serverUrl, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken token);
    partial void RemoveTokenValue_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, System.Uri serverUrl, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken token);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveTokenValue_UnitTest()
  {
    System.Uri serverUrl = default(System.Uri);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken token = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage) GetInstance();
        },
        (instance) =>
        {
          serverUrl = default(System.Uri); //No Type
          token = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.IssuedTokenWrapper_UnitTests.GetInstance();
          RemoveTokenValue_PreCondition(ref instance, ref serverUrl, ref token);
        },
       (instance) =>
       {
             instance.RemoveTokenValue(serverUrl,token);
       },
      (instance) =>
      {
              RemoveTokenValue_PostValidate(instance, serverUrl, token);
      });
  }
    partial void RemoveTokenValuesByUser_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, ref System.Guid userId);
    partial void RemoveTokenValuesByUser_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage instance, System.Guid userId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveTokenValuesByUser_UnitTest()
  {
    System.Guid userId = default(System.Guid);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage) GetInstance();
        },
        (instance) =>
        {
          userId = default(System.Guid); //No Constructor
          RemoveTokenValuesByUser_PreCondition(ref instance, ref userId);
        },
       (instance) =>
       {
             instance.RemoveTokenValuesByUser(userId);
       },
      (instance) =>
      {
              RemoveTokenValuesByUser_PostValidate(instance, userId);
      });
  }
  }
}
