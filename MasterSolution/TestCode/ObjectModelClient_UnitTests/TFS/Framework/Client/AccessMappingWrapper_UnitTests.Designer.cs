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
  public partial class AccessMappingWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.AccessMappingWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.AccessMappingWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Framework.Client.AccessMapping);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.AccessMappingWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.AccessMappingWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Framework.Client.AccessMapping real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.AccessMappingWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client.AccessMappingWrapper>{ GetInstance() }; }

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
