using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class JsonLinkAttributes_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes GetInstance([CallerMemberName]string callerName = "") 
  { 
    Newtonsoft.Json.Linq.JToken json = new JObject();
    JsonSource(ref json);
    var instance = (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes) DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes.FromToken(json);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  static partial void JsonSource(ref Newtonsoft.Json.Linq.JToken json);
  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes>{ GetInstance() }; }

    partial void FromToken_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, ref Newtonsoft.Json.Linq.JToken content);
    partial void FromToken_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, Newtonsoft.Json.Linq.JToken content, DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FromToken_UnitTest()
  {
    Newtonsoft.Json.Linq.JToken content = default(Newtonsoft.Json.Linq.JToken);
    DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes _retVal = default(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes) GetInstance();
        },
        (instance) =>
        {
          content = default(Newtonsoft.Json.Linq.JToken); //No Constructor
          FromToken_PreCondition(ref instance, ref content);
        },
       (instance) =>
       {
             _retVal =DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes.FromToken(content);
       },
      (instance) =>
      {
              FromToken_PostValidate(instance, content, _retVal);
      });
  }
    partial void CaptureJson_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, ref Newtonsoft.Json.Linq.JToken token);
    partial void CaptureJson_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, Newtonsoft.Json.Linq.JToken token);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CaptureJson_UnitTest()
  {
    Newtonsoft.Json.Linq.JToken token = default(Newtonsoft.Json.Linq.JToken);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes) GetInstance();
        },
        (instance) =>
        {
          token = default(Newtonsoft.Json.Linq.JToken); //No Constructor
          CaptureJson_PreCondition(ref instance, ref token);
        },
       (instance) =>
       {
             instance.CaptureJson(token);
       },
      (instance) =>
      {
              CaptureJson_PostValidate(instance, token);
      });
  }
    partial void ToJSonString_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance);
    partial void ToJSonString_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToJSonString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes) GetInstance();
        },
        (instance) =>
        {
          ToJSonString_PreCondition(ref instance);
        },
       (instance) =>
       {
             _retVal =instance.ToJSonString();
       },
      (instance) =>
      {
              ToJSonString_PostValidate(instance, _retVal);
      });
  }
    partial void ToString_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance);
    partial void ToString_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes) GetInstance();
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
              ToString_PostValidate(instance, _retVal);
      });
  }
    partial void Equals_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, ref System.Object obj);
    partial void Equals_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, System.Object obj, System.Boolean _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Equals_UnitTest()
  {
    System.Object obj = default(System.Object);
    System.Boolean _retVal = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes) GetInstance();
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
              Equals_PostValidate(instance, obj, _retVal);
      });
  }
    partial void GetHashCode_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance);
    partial void GetHashCode_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, System.Int32 _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetHashCode_UnitTest()
  {
    System.Int32 _retVal = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes) GetInstance();
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
              GetHashCode_PostValidate(instance, _retVal);
      });
  }
    partial void GetType_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance);
    partial void GetType_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance, System.Type _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetType_UnitTest()
  {
    System.Type _retVal = default(System.Type);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes) GetInstance();
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
              GetType_PostValidate(instance, _retVal);
      });
  }
   partial void JsonValue_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes instance,ref Newtonsoft.Json.Linq.JToken setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void JsonValue_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLinkAttributes) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.JsonValue;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
