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
  public partial class ConnectivityFailureStatusChangedEventArgsWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ConnectivityFailureStatusChangedEventArgsWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ConnectivityFailureStatusChangedEventArgsWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.ConnectivityFailureStatusChangedEventArgs);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ConnectivityFailureStatusChangedEventArgsWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ConnectivityFailureStatusChangedEventArgsWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.ConnectivityFailureStatusChangedEventArgs real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ConnectivityFailureStatusChangedEventArgsWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ConnectivityFailureStatusChangedEventArgsWrapper>{ GetInstance() }; }

   partial void NewConnectivityFailureStatus_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IConnectivityFailureStatusChangedEventArgs instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void NewConnectivityFailureStatus_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IConnectivityFailureStatusChangedEventArgs) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.NewConnectivityFailureStatus;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
