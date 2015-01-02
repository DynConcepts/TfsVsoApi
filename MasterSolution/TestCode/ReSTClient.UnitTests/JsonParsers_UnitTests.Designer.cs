using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class JsonParsers_UnitTests : DynTestClassBase 
  {

    partial void JArrayToObjects_PreCondition(ref Newtonsoft.Json.Linq.JArray array, ref System.Func<Newtonsoft.Json.Linq.JToken,T> creator);
    partial void JArrayToObjects_PostValidate(Newtonsoft.Json.Linq.JArray array, System.Func<Newtonsoft.Json.Linq.JToken,T> creator, System.Collections.Generic.List<T> _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void JArrayToObjects_UnitTest()
  {
    Newtonsoft.Json.Linq.JArray array = default(Newtonsoft.Json.Linq.JArray);
    System.Func<Newtonsoft.Json.Linq.JToken,T> creator = default(System.Func<Newtonsoft.Json.Linq.JToken,T>);
    System.Collections.Generic.List<T> _retVal = default(System.Collections.Generic.List<T>);
      ExecuteMethod(
        () =>
        {
          array = new Newtonsoft.Json.Linq.JArray();
          creator = default(System.Func<Newtonsoft.Json.Linq.JToken,T>); //No Constructor
          JArrayToObjects_PreCondition(ref array, ref creator);
        },
       () =>
       {
             _retVal =DynCon.OSI.VSO.ReSTClient.JsonParsers.JArrayToObjects<object>(array,creator);
       },
      () =>
      {
              JArrayToObjects_PostValidate(array, creator, _retVal);
      });
  }
    partial void JObjectToInstance_PreCondition(ref Newtonsoft.Json.Linq.JObject jObject, ref System.Func<Newtonsoft.Json.Linq.JObject,T> creator);
    partial void JObjectToInstance_PostValidate(Newtonsoft.Json.Linq.JObject jObject, System.Func<Newtonsoft.Json.Linq.JObject,T> creator, T _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void JObjectToInstance_UnitTest()
  {
    Newtonsoft.Json.Linq.JObject jObject = default(Newtonsoft.Json.Linq.JObject);
    System.Func<Newtonsoft.Json.Linq.JObject,T> creator = default(System.Func<Newtonsoft.Json.Linq.JObject,T>);
    T _retVal = default(T);
      ExecuteMethod(
        () =>
        {
          jObject = new Newtonsoft.Json.Linq.JObject();
          creator = default(System.Func<Newtonsoft.Json.Linq.JObject,T>); //No Constructor
          JObjectToInstance_PreCondition(ref jObject, ref creator);
        },
       () =>
       {
             _retVal =DynCon.OSI.VSO.ReSTClient.JsonParsers.JObjectToInstance<object>(jObject,creator);
       },
      () =>
      {
              JObjectToInstance_PostValidate(jObject, creator, _retVal);
      });
  }
    partial void JArrayToInstance_PreCondition(ref Newtonsoft.Json.Linq.JArray jArray, ref System.Func<Newtonsoft.Json.Linq.JArray,T> creator);
    partial void JArrayToInstance_PostValidate(Newtonsoft.Json.Linq.JArray jArray, System.Func<Newtonsoft.Json.Linq.JArray,T> creator, T _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void JArrayToInstance_UnitTest()
  {
    Newtonsoft.Json.Linq.JArray jArray = default(Newtonsoft.Json.Linq.JArray);
    System.Func<Newtonsoft.Json.Linq.JArray,T> creator = default(System.Func<Newtonsoft.Json.Linq.JArray,T>);
    T _retVal = default(T);
      ExecuteMethod(
        () =>
        {
          jArray = new Newtonsoft.Json.Linq.JArray();
          creator = default(System.Func<Newtonsoft.Json.Linq.JArray,T>); //No Constructor
          JArrayToInstance_PreCondition(ref jArray, ref creator);
        },
       () =>
       {
             _retVal =DynCon.OSI.VSO.ReSTClient.JsonParsers.JArrayToInstance<object>(jArray,creator);
       },
      () =>
      {
              JArrayToInstance_PostValidate(jArray, creator, _retVal);
      });
  }
    partial void ValuesToObjects_PreCondition(ref Newtonsoft.Json.Linq.JObject jObject, ref System.Func<Newtonsoft.Json.Linq.JToken,T> creator);
    partial void ValuesToObjects_PostValidate(Newtonsoft.Json.Linq.JObject jObject, System.Func<Newtonsoft.Json.Linq.JToken,T> creator, System.Collections.Generic.IReadOnlyList<T> _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ValuesToObjects_UnitTest()
  {
    Newtonsoft.Json.Linq.JObject jObject = default(Newtonsoft.Json.Linq.JObject);
    System.Func<Newtonsoft.Json.Linq.JToken,T> creator = default(System.Func<Newtonsoft.Json.Linq.JToken,T>);
    System.Collections.Generic.IReadOnlyList<T> _retVal = default(System.Collections.Generic.IReadOnlyList<T>);
      ExecuteMethod(
        () =>
        {
          jObject = new Newtonsoft.Json.Linq.JObject();
          creator = default(System.Func<Newtonsoft.Json.Linq.JToken,T>); //No Constructor
          ValuesToObjects_PreCondition(ref jObject, ref creator);
        },
       () =>
       {
             _retVal =DynCon.OSI.VSO.ReSTClient.JsonParsers.ValuesToObjects<object>(jObject,creator);
       },
      () =>
      {
              ValuesToObjects_PostValidate(jObject, creator, _retVal);
      });
  }
  }
}
