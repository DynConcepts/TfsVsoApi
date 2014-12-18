using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class FileAttachmentWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.FileAttachmentWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.FileAttachmentWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Proxy.FileAttachment);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.FileAttachmentWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.FileAttachmentWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Proxy.FileAttachment real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.FileAttachmentWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.FileAttachmentWrapper>{ GetInstance() }; }

   partial void FileNameGUID_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment instance, ref System.Guid setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FileNameGUID_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.Guid);
          FileNameGUID_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.FileNameGUID = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.FileNameGUID;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AreaNodeUri_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AreaNodeUri_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.String);
          AreaNodeUri_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.AreaNodeUri = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.AreaNodeUri;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ProjectUri_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ProjectUri_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.String);
          ProjectUri_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.ProjectUri = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.ProjectUri;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void LocalFile_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment instance, ref System.IO.Stream setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void LocalFile_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.IO.Stream);
          LocalFile_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.LocalFile = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.LocalFile;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
