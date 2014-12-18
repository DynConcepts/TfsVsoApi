using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class DisplayFieldListWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.DisplayFieldListWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.DisplayFieldListWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.DisplayFieldList);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.DisplayFieldListWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.DisplayFieldListWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.DisplayFieldList real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.DisplayFieldListWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.DisplayFieldListWrapper>{ GetInstance() }; }

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
          value = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.FieldDefinitionWrapper_UnitTests.GetInstance();
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
