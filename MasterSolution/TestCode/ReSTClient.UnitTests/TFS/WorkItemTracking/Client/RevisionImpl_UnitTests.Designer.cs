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
  public partial class RevisionImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RevisionImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RevisionImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    JToken json = new JObject();
    JsonSource(ref json);
    var instance = (DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RevisionImpl) DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RevisionImpl.FromToken(json);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  static partial void JsonSource(ref JToken json);
  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RevisionImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RevisionImpl>{ GetInstance() }; }

    partial void GetTagLine_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision instance);
    partial void GetTagLine_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetTagLine_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision) GetInstance();
        },
        (instance) =>
        {
          GetTagLine_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetTagLine();
       },
      (instance) =>
      {
              GetTagLine_PostValidate(instance);
      });
  }
   partial void Index_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision instance, ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Index_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Index;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Fields_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Fields_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Fields;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Attachments_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAttachmentCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Attachments_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Attachments;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Links_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ILinkCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Links_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Links;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
