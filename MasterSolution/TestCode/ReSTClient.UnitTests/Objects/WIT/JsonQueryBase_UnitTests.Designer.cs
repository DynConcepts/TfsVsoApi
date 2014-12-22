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
  public partial class JsonQueryBase_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase GetInstance([CallerMemberName]string callerName = "") 
  { 
    Newtonsoft.Json.Linq.JToken json = new JObject();
    JsonSource(ref json);
    var instance = (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase.FromToken(json);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  static partial void JsonSource(ref Newtonsoft.Json.Linq.JToken json);
  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase>{ GetInstance() }; }

    partial void CaptureJson_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, ref Newtonsoft.Json.Linq.JToken token);
    partial void CaptureJson_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, Newtonsoft.Json.Linq.JToken token);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CaptureJson_UnitTest()
  {
    Newtonsoft.Json.Linq.JToken token = default(Newtonsoft.Json.Linq.JToken);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
        },
        (instance) =>
        {
          token = default(Newtonsoft.Json.Linq.JToken); //No Type
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
    partial void ToJSonString_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance);
    partial void ToJSonString_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToJSonString_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
        },
        (instance) =>
        {
          ToJSonString_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.ToJSonString();
       },
      (instance) =>
      {
              ToJSonString_PostValidate(instance);
      });
  }
    partial void ToString_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance);
    partial void ToString_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToString_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
        },
        (instance) =>
        {
          ToString_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.ToString();
       },
      (instance) =>
      {
              ToString_PostValidate(instance);
      });
  }
    partial void Equals_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, ref System.Object obj);
    partial void Equals_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, System.Object obj);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Equals_UnitTest()
  {
    System.Object obj = default(System.Object);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
        },
        (instance) =>
        {
          obj = new System.Object();
          Equals_PreCondition(ref instance, ref obj);
        },
       (instance) =>
       {
             instance.Equals(obj);
       },
      (instance) =>
      {
              Equals_PostValidate(instance, obj);
      });
  }
    partial void GetHashCode_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance);
    partial void GetHashCode_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetHashCode_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
        },
        (instance) =>
        {
          GetHashCode_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetHashCode();
       },
      (instance) =>
      {
              GetHashCode_PostValidate(instance);
      });
  }
    partial void GetType_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance);
    partial void GetType_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetType_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
        },
        (instance) =>
        {
          GetType_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetType();
       },
      (instance) =>
      {
              GetType_PostValidate(instance);
      });
  }
   partial void Id_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, ref System.Guid setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Id_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Id;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Name_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Name_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
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
   partial void Path_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Path_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Path;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsFolder_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsFolder_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsFolder;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void JsonValue_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase instance, ref Newtonsoft.Json.Linq.JToken setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void JsonValue_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonQueryBase) GetInstance();
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
