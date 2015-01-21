using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.RestCalls
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class BuildRestCalls_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls>{ GetInstance() }; }

    partial void ToString_PreCondition(DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls instance);
    partial void ToString_PostValidate(DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls) GetInstance();
        },
        (instance) =>
        {
          ToString_PreCondition(instance);
        },
       (instance) =>
       {
             _retVal =instance.ToString();
       },
      (instance) =>
      {
              ToString_PostValidate(instance, _retVal);
      });
  }
    partial void Equals_PreCondition(DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls instance, ref System.Object obj);
    partial void Equals_PostValidate(DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls instance, System.Object obj, System.Boolean _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Equals_UnitTest()
  {
    System.Object obj = default(System.Object);
    System.Boolean _retVal = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls) GetInstance();
        },
        (instance) =>
        {
          obj = new System.Object();
          Equals_PreCondition(instance, ref obj);
        },
       (instance) =>
       {
             _retVal =instance.Equals(obj);
       },
      (instance) =>
      {
              Equals_PostValidate(instance, obj, _retVal);
      });
  }
    partial void GetHashCode_PreCondition(DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls instance);
    partial void GetHashCode_PostValidate(DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls instance, System.Int32 _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetHashCode_UnitTest()
  {
    System.Int32 _retVal = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls) GetInstance();
        },
        (instance) =>
        {
          GetHashCode_PreCondition(instance);
        },
       (instance) =>
       {
             _retVal =instance.GetHashCode();
       },
      (instance) =>
      {
              GetHashCode_PostValidate(instance, _retVal);
      });
  }
    partial void GetType_PreCondition(DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls instance);
    partial void GetType_PostValidate(DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls instance, System.Type _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetType_UnitTest()
  {
    System.Type _retVal = default(System.Type);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls) GetInstance();
        },
        (instance) =>
        {
          GetType_PreCondition(instance);
        },
       (instance) =>
       {
             _retVal =instance.GetType();
       },
      (instance) =>
      {
              GetType_PostValidate(instance, _retVal);
      });
  }
   partial void Build_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Build_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Build;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void BuildDetails_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BuildDetails_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.BuildDetails;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Builds_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Builds_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Builds;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Definition_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Definition_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Definition;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Definitions_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Definitions_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Definitions;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Qualities_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Qualities_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Qualities;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Quality_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Quality_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Quality;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Queue_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Queue_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Queue;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Queues_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Queues_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Queues;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Request_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Request_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Request;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Requests_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Requests_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.BuildRestCalls.Requests;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
  }
}
