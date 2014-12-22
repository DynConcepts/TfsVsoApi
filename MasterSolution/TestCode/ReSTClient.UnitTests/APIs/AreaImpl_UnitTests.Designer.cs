using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class AreaImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    Newtonsoft.Json.Linq.JObject json = new Newtonsoft.Json.Linq.JObject();
    JsonSource(ref json);
    var instance = (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl.FromToken(json);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  static partial void JsonSource(ref Newtonsoft.Json.Linq.JObject json);
  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl>{ GetInstance() }; }

    partial void CaptureJson_PreCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, ref Newtonsoft.Json.Linq.JToken token);
    partial void CaptureJson_PostValidate(DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, Newtonsoft.Json.Linq.JToken token);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CaptureJson_UnitTest()
  {
    Newtonsoft.Json.Linq.JToken token = default(Newtonsoft.Json.Linq.JToken);
    System.Void _retVal = default(System.Void);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
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
    partial void ToJSonString_PreCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance);
    partial void ToJSonString_PostValidate(DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToJSonString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
        },
        (instance) =>
        {
          ToJSonString_PreCondition(ref instance);
        },
       (instance) =>
       {
             _retVal = instance.ToJSonString();
       },
      (instance) =>
      {
              ToJSonString_PostValidate(instance, _retVal);
      });
  }
    partial void ToString_PreCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance);
    partial void ToString_PostValidate(DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
        },
        (instance) =>
        {
          ToString_PreCondition(ref instance);
        },
       (instance) =>
       {
             _retVal = instance.ToString();
       },
      (instance) =>
      {
              ToString_PostValidate(instance, _retVal);
      });
  }
    partial void Equals_PreCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, ref System.Object obj);
    partial void Equals_PostValidate(DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, System.Object obj, System.Boolean _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Equals_UnitTest()
  {
    System.Object obj = default(System.Object);
    System.Boolean _retVal = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
        },
        (instance) =>
        {
          obj = new System.Object();
          Equals_PreCondition(ref instance, ref obj);
        },
       (instance) =>
       {
             _retVal = instance.Equals(obj);
       },
      (instance) =>
      {
              Equals_PostValidate(instance, obj, _retVal);
      });
  }
    partial void GetHashCode_PreCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance);
    partial void GetHashCode_PostValidate(DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, System.Int32 _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetHashCode_UnitTest()
  {
    System.Int32 _retVal = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
        },
        (instance) =>
        {
          GetHashCode_PreCondition(ref instance);
        },
       (instance) =>
       {
             _retVal = instance.GetHashCode();
       },
      (instance) =>
      {
              GetHashCode_PostValidate(instance, _retVal);
      });
  }
    partial void GetType_PreCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance);
    partial void GetType_PostValidate(DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, System.Type _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetType_UnitTest()
  {
    System.Type _retVal = default(System.Type);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
        },
        (instance) =>
        {
          GetType_PreCondition(ref instance);
        },
       (instance) =>
       {
             _retVal = instance.GetType();
       },
      (instance) =>
      {
              GetType_PostValidate(instance, _retVal);
      });
  }
   partial void Children_SetCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, ref System.Collections.Generic.IList<DynCon.OSI.VSO.SharedInterfaces.Objects.WIT.IArea> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Children_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Children;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Parent_SetCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, ref DynCon.OSI.VSO.SharedInterfaces.Objects.WIT.IArea setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Parent_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Parent;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Links_SetCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Links_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Links;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void HasChildren_SetCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void HasChildren_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.HasChildren;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Name_SetCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Name_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Name;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Url_SetCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Url_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Url;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void JsonValue_SetCondition(ref DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl instance, ref Newtonsoft.Json.Linq.JToken setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void JsonValue_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.APIs.AreaImpl) GetInstance();
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
