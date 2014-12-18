using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class DisplayFieldListImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.DisplayFieldListImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.DisplayFieldListImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.DisplayFieldListImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.DisplayFieldListImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.DisplayFieldListImpl>{ GetInstance() }; }

    partial void Insert_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IDisplayFieldList instance, ref System.Int32 index, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition value);
    partial void Insert_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IDisplayFieldList instance, System.Int32 index, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition value);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Insert_UnitTest()
  {
    System.Int32 index = default(System.Int32);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition value = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IDisplayFieldList) GetInstance();
        },
        (instance) =>
        {
          index = default(System.Int32); //No Constructor
          value = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client.FieldDefinitionImpl_UnitTests.GetInstance();
          Insert_PreCondition(ref instance, ref index, ref value);
        },
       (instance) =>
       {
             instance.Insert(index,value);
       },
      (instance) =>
      {
              Insert_PostValidate(instance, index, value);
      });
  }
  }
}
