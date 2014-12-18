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
  public partial class AccessControlEntryImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlEntryImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlEntryImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlEntryImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlEntryImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlEntryImpl>{ GetInstance() }; }

   partial void Allow_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry instance, ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Allow_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Int32);
          Allow_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Allow = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Allow;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Deny_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry instance, ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Deny_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Int32);
          Deny_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Deny = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Deny;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ExtendedInfo_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAceExtendedInformation setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ExtendedInfo_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAceExtendedInformation);
          ExtendedInfo_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.ExtendedInfo = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.ExtendedInfo;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
