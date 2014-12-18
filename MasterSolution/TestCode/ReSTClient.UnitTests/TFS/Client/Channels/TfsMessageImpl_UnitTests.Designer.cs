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
  public partial class TfsMessageImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageImpl>{ GetInstance() }; }

    partial void CreateException_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage instance);
    partial void CreateException_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CreateException_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage) GetInstance();
        },
        (instance) =>
        {
          CreateException_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.CreateException();
       },
      (instance) =>
      {
              CreateException_PostValidate(instance);
      });
  }
    partial void GetBodyReader_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage instance);
    partial void GetBodyReader_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetBodyReader_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage) GetInstance();
        },
        (instance) =>
        {
          GetBodyReader_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetBodyReader();
       },
      (instance) =>
      {
              GetBodyReader_PostValidate(instance);
      });
  }
   partial void Action_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Action_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Action;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Headers_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage instance, ref System.Collections.ObjectModel.Collection<DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Headers_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Headers;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsEmpty_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsEmpty_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsEmpty;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsFault_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsFault_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsFault;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void To_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage instance, ref System.Uri setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void To_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.To;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
