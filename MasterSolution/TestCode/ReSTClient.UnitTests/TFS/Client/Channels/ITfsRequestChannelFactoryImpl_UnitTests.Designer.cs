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
  public partial class ITfsRequestChannelFactoryImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelFactoryImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelFactoryImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelFactoryImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelFactoryImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.ITfsRequestChannelFactoryImpl>{ GetInstance() }; }

    partial void CreateChannel_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannelFactory instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel innerChannel);
    partial void CreateChannel_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannelFactory instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel innerChannel);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CreateChannel_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel innerChannel = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannelFactory) GetInstance();
        },
        (instance) =>
        {
          innerChannel = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.Channels.ITfsRequestChannelImpl_UnitTests.GetInstance();
          CreateChannel_PreCondition(ref instance, ref innerChannel);
        },
       (instance) =>
       {
             instance.CreateChannel(innerChannel);
       },
      (instance) =>
      {
              CreateChannel_PostValidate(instance, innerChannel);
      });
  }
  }
}
