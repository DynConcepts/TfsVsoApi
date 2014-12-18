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
  public partial class WindowsCredentialImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.WindowsCredentialImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.WindowsCredentialImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.WindowsCredentialImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.WindowsCredentialImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.WindowsCredentialImpl>{ GetInstance() }; }

   partial void Credentials_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IWindowsCredential instance, ref System.Net.ICredentials setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Credentials_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IWindowsCredential) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Net.ICredentials);
          Credentials_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Credentials = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Credentials;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
