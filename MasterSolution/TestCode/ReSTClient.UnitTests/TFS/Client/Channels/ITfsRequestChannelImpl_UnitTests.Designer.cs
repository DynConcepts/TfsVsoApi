using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.Channels
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class ITfsRequestChannelImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelImpl>{ GetInstance() }; }

    partial void Abort_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance);
    partial void Abort_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Abort_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel) GetInstance();
        },
        (instance) =>
        {
          Abort_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Abort();
       },
      (instance) =>
      {
              Abort_PostValidate(instance);
      });
  }
    partial void BeginRequest_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message, ref System.AsyncCallback callback, ref System.Object state);
    partial void BeginRequest_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message, System.AsyncCallback callback, System.Object state);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BeginRequest_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage);
    System.AsyncCallback callback = default(System.AsyncCallback);
    System.Object state = default(System.Object);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel) GetInstance();
        },
        (instance) =>
        {
          message = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.Channels.TfsMessageImpl_UnitTests.GetInstance();
          callback = default(System.AsyncCallback); //No Constructor
          state = new System.Object();
          BeginRequest_PreCondition(ref instance, ref message, ref callback, ref state);
        },
       (instance) =>
       {
             instance.BeginRequest(message,callback,state);
       },
      (instance) =>
      {
              BeginRequest_PostValidate(instance, message, callback, state);
      });
  }
    partial void EndRequest_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, ref System.IAsyncResult result);
    partial void EndRequest_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, System.IAsyncResult result);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void EndRequest_UnitTest()
  {
    System.IAsyncResult result = default(System.IAsyncResult);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel) GetInstance();
        },
        (instance) =>
        {
          result = default(System.IAsyncResult); //No Constructor
          EndRequest_PreCondition(ref instance, ref result);
        },
       (instance) =>
       {
             instance.EndRequest(result);
       },
      (instance) =>
      {
              EndRequest_PostValidate(instance, result);
      });
  }
    partial void Request_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message);
    partial void Request_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Request_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel) GetInstance();
        },
        (instance) =>
        {
          message = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.Channels.TfsMessageImpl_UnitTests.GetInstance();
          Request_PreCondition(ref instance, ref message);
        },
       (instance) =>
       {
             instance.Request(message);
       },
      (instance) =>
      {
              Request_PostValidate(instance, message);
      });
  }
   partial void Uri_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, ref System.Uri setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Uri_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Uri;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Culture_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, ref System.Globalization.CultureInfo setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Culture_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Culture;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SessionId_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, ref System.Guid setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SessionId_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.SessionId;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Settings_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Settings_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Settings;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void State_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsHttpClientState setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void State_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.State;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
