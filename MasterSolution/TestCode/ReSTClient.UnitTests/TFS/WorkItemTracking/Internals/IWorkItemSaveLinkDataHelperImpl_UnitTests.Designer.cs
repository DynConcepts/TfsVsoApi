using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Internals
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class IWorkItemSaveLinkDataHelperImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperImpl>{ GetInstance() }; }

    partial void ResetWorkItemLinkInfo_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveLinkDataHelper instance);
    partial void ResetWorkItemLinkInfo_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveLinkDataHelper instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ResetWorkItemLinkInfo_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveLinkDataHelper) GetInstance();
        },
        (instance) =>
        {
          ResetWorkItemLinkInfo_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.ResetWorkItemLinkInfo();
       },
      (instance) =>
      {
              ResetWorkItemLinkInfo_PostValidate(instance);
      });
  }
    partial void AddWorkItemLinkInfo_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveLinkDataHelper instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IWorkItemLinkInfo link);
    partial void AddWorkItemLinkInfo_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveLinkDataHelper instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IWorkItemLinkInfo link);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AddWorkItemLinkInfo_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IWorkItemLinkInfo link = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IWorkItemLinkInfo);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveLinkDataHelper) GetInstance();
        },
        (instance) =>
        {
          link = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Internals.WorkItemLinkInfoImpl_UnitTests.GetInstance();
          AddWorkItemLinkInfo_PreCondition(ref instance, ref link);
        },
       (instance) =>
       {
             instance.AddWorkItemLinkInfo(link);
       },
      (instance) =>
      {
              AddWorkItemLinkInfo_PostValidate(instance, link);
      });
  }
   partial void UpdatedLinks_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveLinkDataHelper instance, ref System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo,DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkUpdate>> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UpdatedLinks_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveLinkDataHelper) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.UpdatedLinks;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
