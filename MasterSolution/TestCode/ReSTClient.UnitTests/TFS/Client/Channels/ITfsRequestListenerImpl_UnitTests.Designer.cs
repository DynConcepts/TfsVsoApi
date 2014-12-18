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
  public partial class ITfsRequestListenerImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestListenerImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestListenerImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestListenerImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestListenerImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestListenerImpl>{ GetInstance() }; }

    partial void AfterReceiveReply_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestListener instance, ref System.Int64 requestId, ref System.String methodName, ref System.Net.HttpWebResponse response);
    partial void AfterReceiveReply_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestListener instance, System.Int64 requestId, System.String methodName, System.Net.HttpWebResponse response);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AfterReceiveReply_UnitTest()
  {
    System.Int64 requestId = default(System.Int64);
    System.String methodName = default(System.String);
    System.Net.HttpWebResponse response = default(System.Net.HttpWebResponse);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestListener) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.Int64); //No Constructor
          methodName = default(System.String); //No Constructor
          response = default(System.Net.HttpWebResponse); //No Type
          AfterReceiveReply_PreCondition(ref instance, ref requestId, ref methodName, ref response);
        },
       (instance) =>
       {
             instance.AfterReceiveReply(requestId,methodName,response);
       },
      (instance) =>
      {
              AfterReceiveReply_PostValidate(instance, requestId, methodName, response);
      });
  }
    partial void BeforeSendRequest_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestListener instance, ref System.Int64 requestId, ref System.String methodName, ref System.Net.HttpWebRequest request);
    partial void BeforeSendRequest_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestListener instance, System.Int64 requestId, System.String methodName, System.Net.HttpWebRequest request);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BeforeSendRequest_UnitTest()
  {
    System.Int64 requestId = default(System.Int64);
    System.String methodName = default(System.String);
    System.Net.HttpWebRequest request = default(System.Net.HttpWebRequest);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestListener) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.Int64); //No Constructor
          methodName = default(System.String); //No Constructor
          request = default(System.Net.HttpWebRequest); //No Type
          BeforeSendRequest_PreCondition(ref instance, ref requestId, ref methodName, ref request);
        },
       (instance) =>
       {
             instance.BeforeSendRequest(requestId,methodName,request);
       },
      (instance) =>
      {
              BeforeSendRequest_PostValidate(instance, requestId, methodName, request);
      });
  }
  }
}
