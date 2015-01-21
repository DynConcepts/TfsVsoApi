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
  public partial class JsonBuildQueue_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue GetInstance([CallerMemberName]string callerName = "") 
  { 
    Newtonsoft.Json.Linq.JToken json = new JObject();
    JsonSource(ref json);
    var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue.FromToken(json);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  static partial void JsonSource(ref Newtonsoft.Json.Linq.JToken json);
  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue>{ GetInstance() }; }

    partial void FromToken_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, ref Newtonsoft.Json.Linq.JToken token);
    partial void FromToken_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, Newtonsoft.Json.Linq.JToken token, DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FromToken_UnitTest()
  {
    Newtonsoft.Json.Linq.JToken token = default(Newtonsoft.Json.Linq.JToken);
    DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue _retVal = default(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
        },
        (instance) =>
        {
          token = default(Newtonsoft.Json.Linq.JToken); //No Constructor
          FromToken_PreCondition(instance, ref token);
        },
       (instance) =>
       {
             _retVal =DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue.FromToken(token);
       },
      (instance) =>
      {
              FromToken_PostValidate(instance, token, _retVal);
      });
  }
    partial void CaptureJson_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, ref Newtonsoft.Json.Linq.JToken token);
    partial void CaptureJson_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, Newtonsoft.Json.Linq.JToken token);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CaptureJson_UnitTest()
  {
    Newtonsoft.Json.Linq.JToken token = default(Newtonsoft.Json.Linq.JToken);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
    partial void ToJSonString_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance);
    partial void ToJSonString_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToJSonString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
    partial void ToString_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance);
    partial void ToString_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
    partial void Equals_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, ref System.Object obj);
    partial void Equals_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, System.Object obj, System.Boolean _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Equals_UnitTest()
  {
    System.Object obj = default(System.Object);
    System.Boolean _retVal = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
    partial void GetHashCode_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance);
    partial void GetHashCode_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, System.Int32 _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetHashCode_UnitTest()
  {
    System.Int32 _retVal = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
    partial void GetType_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance);
    partial void GetType_PostValidate(DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance, System.Type _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetType_UnitTest()
  {
    System.Type _retVal = default(System.Type);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
   partial void CreatedDate_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref System.DateTime setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CreatedDate_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CreatedDate;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Enabled_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Enabled_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Enabled;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Id_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Id_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
   partial void Name_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Name_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
   partial void QueueType_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueueType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.QueueType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Status_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Status_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Status;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void UpdatedDate_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref System.DateTime setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UpdatedDate_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.UpdatedDate;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Uri_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Uri_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
   partial void Url_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Url_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
   partial void JsonValue_SetCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue instance,ref Newtonsoft.Json.Linq.JToken setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void JsonValue_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.ReSTClient.Objects.Build.JsonBuildQueue) GetInstance();
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
