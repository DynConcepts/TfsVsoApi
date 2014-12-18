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
  public partial class TfsRequestSettingsImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsRequestSettingsImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsRequestSettingsImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsRequestSettingsImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsRequestSettingsImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsRequestSettingsImpl>{ GetInstance() }; }

    partial void Clone_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance);
    partial void Clone_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Clone_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
        },
        (instance) =>
        {
          Clone_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Clone();
       },
      (instance) =>
      {
              Clone_PostValidate(instance);
      });
  }
   partial void BypassProxyOnLocal_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BypassProxyOnLocal_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Boolean);
          BypassProxyOnLocal_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.BypassProxyOnLocal = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.BypassProxyOnLocal;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CompressionEnabled_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CompressionEnabled_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Boolean);
          CompressionEnabled_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.CompressionEnabled = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.CompressionEnabled;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CompressRequestBody_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CompressRequestBody_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Boolean);
          CompressRequestBody_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.CompressRequestBody = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.CompressRequestBody;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ConnectionLimit_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance, ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ConnectionLimit_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ConnectionLimit;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SendTimeout_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance, ref System.TimeSpan setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SendTimeout_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.TimeSpan);
          SendTimeout_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.SendTimeout = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.SendTimeout;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SoapTraceEnabled_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SoapTraceEnabled_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.SoapTraceEnabled;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Tracing_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance, ref System.Diagnostics.TraceSwitch setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Tracing_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Tracing;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void UserAgent_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UserAgent_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.UserAgent;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AgentId_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AgentId_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          AgentId_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.AgentId = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.AgentId;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
