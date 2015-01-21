using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.Build
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class JsonBuildDefinition_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition GetInstance([CallerMemberName]string callerName = "") 
  { 
    Newtonsoft.Json.Linq.JToken json = new JObject();
    JsonSource(ref json);
    var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition.FromToken(json);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  static partial void JsonSource(ref Newtonsoft.Json.Linq.JToken json);
  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition>{ GetInstance() }; }

    partial void FromToken_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, ref Newtonsoft.Json.Linq.JToken token);
    partial void FromToken_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, Newtonsoft.Json.Linq.JToken token, DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FromToken_UnitTest()
  {
    Newtonsoft.Json.Linq.JToken token = default(Newtonsoft.Json.Linq.JToken);
    DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition _retVal = default(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
        },
        (instance) =>
        {
          token = default(Newtonsoft.Json.Linq.JToken); //No Constructor
          FromToken_PreCondition(instance, ref token);
        },
       (instance) =>
       {
             _retVal =DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition.FromToken(token);
       },
      (instance) =>
      {
              FromToken_PostValidate(instance, token, _retVal);
      });
  }
    partial void CaptureJson_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, ref Newtonsoft.Json.Linq.JToken token);
    partial void CaptureJson_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, Newtonsoft.Json.Linq.JToken token);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CaptureJson_UnitTest()
  {
    Newtonsoft.Json.Linq.JToken token = default(Newtonsoft.Json.Linq.JToken);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
        },
        (instance) =>
        {
          token = default(Newtonsoft.Json.Linq.JToken); //No Constructor
          CaptureJson_PreCondition(instance, ref token);
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
    partial void ToJSonString_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance);
    partial void ToJSonString_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToJSonString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
        },
        (instance) =>
        {
          ToJSonString_PreCondition(instance);
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
    partial void ToString_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance);
    partial void ToString_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
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
    partial void Equals_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, ref System.Object obj);
    partial void Equals_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, System.Object obj, System.Boolean _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Equals_UnitTest()
  {
    System.Object obj = default(System.Object);
    System.Boolean _retVal = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
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
    partial void GetHashCode_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance);
    partial void GetHashCode_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, System.Int32 _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetHashCode_UnitTest()
  {
    System.Int32 _retVal = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
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
    partial void GetType_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance);
    partial void GetType_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance, System.Type _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetType_UnitTest()
  {
    System.Type _retVal = default(System.Type);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
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
   partial void BatchSize_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BatchSize_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.BatchSize;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void BuildArgs_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BuildArgs_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.BuildArgs;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void DateCreated_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.DateTime setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DateCreated_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.DateCreated;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void DefaultDropLocation_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DefaultDropLocation_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.DefaultDropLocation;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void DefinitionType_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DefinitionType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.DefinitionType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Description_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Description_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Description;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Id_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Id_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
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
   partial void LastBuild_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void LastBuild_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.LastBuild;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Name_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Name_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
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
   partial void Queue_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Queue_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Queue;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SupportedReasons_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SupportedReasons_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.SupportedReasons;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void TriggerType_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TriggerType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.TriggerType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Uri_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Uri_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Uri;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Url_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Url_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
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
   partial void JsonValue_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition instance,ref Newtonsoft.Json.Linq.JToken setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void JsonValue_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildDefinition) GetInstance();
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
