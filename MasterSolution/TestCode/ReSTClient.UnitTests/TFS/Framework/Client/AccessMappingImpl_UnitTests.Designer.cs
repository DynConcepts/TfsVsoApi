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
  public partial class AccessMappingImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessMappingImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessMappingImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessMappingImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessMappingImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessMappingImpl>{ GetInstance() }; }

   partial void Moniker_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Moniker_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Moniker;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AccessPoint_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AccessPoint_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AccessPoint;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
