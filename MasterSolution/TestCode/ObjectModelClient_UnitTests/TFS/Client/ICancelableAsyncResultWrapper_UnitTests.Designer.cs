using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class ICancelableAsyncResultWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ICancelableAsyncResultWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ICancelableAsyncResultWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.ICancelableAsyncResult);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ICancelableAsyncResultWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ICancelableAsyncResultWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.ICancelableAsyncResult real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ICancelableAsyncResultWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ICancelableAsyncResultWrapper>{ GetInstance() }; }

    partial void Cancel_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult instance);
    partial void Cancel_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Cancel_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult) GetInstance();
        },
        (instance) =>
        {
          Cancel_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Cancel();
       },
      (instance) =>
      {
              Cancel_PostValidate(instance);
      });
  }
   partial void IsCanceled_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsCanceled_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsCanceled;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsCompleted_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsCompleted_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsCompleted;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AsyncWaitHandle_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult instance, ref System.Threading.WaitHandle setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AsyncWaitHandle_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AsyncWaitHandle;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AsyncState_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult instance, ref System.Object setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AsyncState_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AsyncState;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CompletedSynchronously_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CompletedSynchronously_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CompletedSynchronously;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
