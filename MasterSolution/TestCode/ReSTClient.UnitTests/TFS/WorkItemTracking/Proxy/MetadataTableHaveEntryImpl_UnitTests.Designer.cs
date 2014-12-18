using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class MetadataTableHaveEntryImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = default(DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryImpl);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryImpl>{ GetInstance() }; }

   partial void RowVersion_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry instance, ref System.Int64 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RowVersion_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Int64);
          RowVersion_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.RowVersion = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.RowVersion;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void TableName_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TableName_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          TableName_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.TableName = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.TableName;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
