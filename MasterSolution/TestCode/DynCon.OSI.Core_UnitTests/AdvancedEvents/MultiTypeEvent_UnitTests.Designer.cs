using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.Core.AdvancedEvents
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class MultiTypeEvent_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent> GetIEnumerableInstance() { 
return new List<DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent>{ GetInstance() }; }

    partial void Fire_PreCondition(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance, ref System.Object sender, ref System.Object data);
    partial void Fire_PostValidate(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance, System.Object sender, System.Object data);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Fire_UnitTest()
  {
    System.Object sender = default(System.Object);
    System.Object data = default(System.Object);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent) GetInstance();
        },
        (instance) =>
        {
          sender = new System.Object();
          data = new System.Object();
          Fire_PreCondition(ref instance, ref sender, ref data);
        },
       (instance) =>
       {
             instance.Fire(sender,data);
       },
      (instance) =>
      {
              Fire_PostValidate(ref instance, sender, data);
      });
  }
    partial void ToString_PreCondition(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance);
    partial void ToString_PostValidate(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent) GetInstance();
        },
        (instance) =>
        {
          ToString_PreCondition(ref instance);
        },
       (instance) =>
       {
             _retVal =instance.ToString();
       },
      (instance) =>
      {
              ToString_PostValidate(ref instance, _retVal);
      });
  }
    partial void Equals_PreCondition(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance, ref System.Object obj);
    partial void Equals_PostValidate(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance, System.Object obj, System.Boolean _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Equals_UnitTest()
  {
    System.Object obj = default(System.Object);
    System.Boolean _retVal = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent) GetInstance();
        },
        (instance) =>
        {
          obj = new System.Object();
          Equals_PreCondition(ref instance, ref obj);
        },
       (instance) =>
       {
             _retVal =instance.Equals(obj);
       },
      (instance) =>
      {
              Equals_PostValidate(ref instance, obj, _retVal);
      });
  }
    partial void GetHashCode_PreCondition(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance);
    partial void GetHashCode_PostValidate(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance, System.Int32 _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetHashCode_UnitTest()
  {
    System.Int32 _retVal = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent) GetInstance();
        },
        (instance) =>
        {
          GetHashCode_PreCondition(ref instance);
        },
       (instance) =>
       {
             _retVal =instance.GetHashCode();
       },
      (instance) =>
      {
              GetHashCode_PostValidate(ref instance, _retVal);
      });
  }
    partial void GetType_PreCondition(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance);
    partial void GetType_PostValidate(ref DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent instance, System.Type _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetType_UnitTest()
  {
    System.Type _retVal = default(System.Type);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.Core.AdvancedEvents.MultiTypeEvent) GetInstance();
        },
        (instance) =>
        {
          GetType_PreCondition(ref instance);
        },
       (instance) =>
       {
             _retVal =instance.GetType();
       },
      (instance) =>
      {
              GetType_PostValidate(ref instance, _retVal);
      });
  }
  }
}
