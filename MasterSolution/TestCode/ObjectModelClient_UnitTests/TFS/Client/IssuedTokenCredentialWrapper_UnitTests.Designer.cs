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
  public partial class IssuedTokenCredentialWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenCredentialWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenCredentialWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.IssuedTokenCredential);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenCredentialWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenCredentialWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.IssuedTokenCredential real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenCredentialWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.IssuedTokenCredentialWrapper>{ GetInstance() }; }

   partial void TokenStorage_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenCredential instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TokenStorage_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenCredential) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage);
          TokenStorage_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.TokenStorage = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.TokenStorage;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
