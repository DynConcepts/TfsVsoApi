using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class IWorkItemSaveLinkDataHelperWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelper);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelper real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveLinkDataHelperWrapper>{ GetInstance() }; }

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
          link = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals.WorkItemLinkInfoWrapper_UnitTests.GetInstance();
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
