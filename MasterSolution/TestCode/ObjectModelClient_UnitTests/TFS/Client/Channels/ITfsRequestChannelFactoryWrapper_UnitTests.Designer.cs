using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class ITfsRequestChannelFactoryWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.ITfsRequestChannelFactoryWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.ITfsRequestChannelFactoryWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.Channels.ITfsRequestChannelFactory);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.ITfsRequestChannelFactoryWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.ITfsRequestChannelFactoryWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.Channels.ITfsRequestChannelFactory real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.ITfsRequestChannelFactoryWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.ITfsRequestChannelFactoryWrapper>{ GetInstance() }; }

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
          innerChannel = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels.ITfsRequestChannelWrapper_UnitTests.GetInstance();
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
