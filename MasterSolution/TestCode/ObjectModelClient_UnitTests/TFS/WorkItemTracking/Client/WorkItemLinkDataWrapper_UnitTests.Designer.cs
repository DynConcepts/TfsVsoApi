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
  public partial class WorkItemLinkDataWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkDataWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkDataWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLinkData);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkDataWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkDataWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLinkData real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkDataWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkDataWrapper>{ GetInstance() }; }

    partial void GetLinkInfo_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance, ref System.Int32 index);
    partial void GetLinkInfo_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance, System.Int32 index);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetLinkInfo_UnitTest()
  {
    System.Int32 index = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          index = default(System.Int32); //No Constructor
          GetLinkInfo_PreCondition(ref instance, ref index);
        },
       (instance) =>
       {
             instance.GetLinkInfo(index);
       },
      (instance) =>
      {
              GetLinkInfo_PostValidate(instance, index);
      });
  }
    partial void GetLinkInfoCount_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
    partial void GetLinkInfoCount_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetLinkInfoCount_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          GetLinkInfoCount_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetLinkInfoCount();
       },
      (instance) =>
      {
              GetLinkInfoCount_PostValidate(instance);
      });
  }
    partial void AddLinkInfo_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo, ref System.Object updatedItem);
    partial void AddLinkInfo_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo, System.Object updatedItem);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AddLinkInfo_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo);
    System.Object updatedItem = default(System.Object);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          linkInfo = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals.LinkInfoWrapper_UnitTests.GetInstance();
          updatedItem = new System.Object();
          AddLinkInfo_PreCondition(ref instance, ref linkInfo, ref updatedItem);
        },
       (instance) =>
       {
             instance.AddLinkInfo(linkInfo,updatedItem);
       },
      (instance) =>
      {
              AddLinkInfo_PostValidate(instance, linkInfo, updatedItem);
      });
  }
    partial void MarkLinkToDelete_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo, ref System.Object updatedItem);
    partial void MarkLinkToDelete_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo, System.Object updatedItem);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void MarkLinkToDelete_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo);
    System.Object updatedItem = default(System.Object);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          linkInfo = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals.LinkInfoWrapper_UnitTests.GetInstance();
          updatedItem = new System.Object();
          MarkLinkToDelete_PreCondition(ref instance, ref linkInfo, ref updatedItem);
        },
       (instance) =>
       {
             instance.MarkLinkToDelete(linkInfo,updatedItem);
       },
      (instance) =>
      {
              MarkLinkToDelete_PostValidate(instance, linkInfo, updatedItem);
      });
  }
    partial void GetAddedLinks_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
    partial void GetAddedLinks_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetAddedLinks_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          GetAddedLinks_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetAddedLinks();
       },
      (instance) =>
      {
              GetAddedLinks_PostValidate(instance);
      });
  }
    partial void GetDeletedLinks_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
    partial void GetDeletedLinks_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetDeletedLinks_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          GetDeletedLinks_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetDeletedLinks();
       },
      (instance) =>
      {
              GetDeletedLinks_PostValidate(instance);
      });
  }
    partial void GetUpdatedLinks_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
    partial void GetUpdatedLinks_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetUpdatedLinks_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          GetUpdatedLinks_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetUpdatedLinks();
       },
      (instance) =>
      {
              GetUpdatedLinks_PostValidate(instance);
      });
  }
    partial void GetAddedLinksCount_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
    partial void GetAddedLinksCount_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetAddedLinksCount_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          GetAddedLinksCount_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetAddedLinksCount();
       },
      (instance) =>
      {
              GetAddedLinksCount_PostValidate(instance);
      });
  }
    partial void GetDeletedLinksCount_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
    partial void GetDeletedLinksCount_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetDeletedLinksCount_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          GetDeletedLinksCount_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetDeletedLinksCount();
       },
      (instance) =>
      {
              GetDeletedLinksCount_PostValidate(instance);
      });
  }
    partial void GetUpdatedLinksCount_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
    partial void GetUpdatedLinksCount_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetUpdatedLinksCount_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          GetUpdatedLinksCount_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetUpdatedLinksCount();
       },
      (instance) =>
      {
              GetUpdatedLinksCount_PostValidate(instance);
      });
  }
    partial void SetLinkComment_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo, ref System.String value);
    partial void SetLinkComment_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo, System.String value);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetLinkComment_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo);
    System.String value = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          linkInfo = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals.LinkInfoWrapper_UnitTests.GetInstance();
          value = default(System.String); //No Constructor
          SetLinkComment_PreCondition(ref instance, ref linkInfo, ref value);
        },
       (instance) =>
       {
             instance.SetLinkComment(linkInfo,value);
       },
      (instance) =>
      {
              SetLinkComment_PostValidate(instance, linkInfo, value);
      });
  }
    partial void Check_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
    partial void Check_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Check_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData) GetInstance();
        },
        (instance) =>
        {
          Check_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Check();
       },
      (instance) =>
      {
              Check_PostValidate(instance);
      });
  }
  }
}
