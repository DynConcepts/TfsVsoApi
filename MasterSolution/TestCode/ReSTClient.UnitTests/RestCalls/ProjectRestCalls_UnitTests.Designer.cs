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
  public partial class ProjectRestCalls_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls>{ GetInstance() }; }

    partial void ToString_PreCondition(DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls instance);
    partial void ToString_PostValidate(DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls instance, System.String _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToString_UnitTest()
  {
    System.String _retVal = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls) GetInstance();
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
    partial void Equals_PreCondition(DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls instance, ref System.Object obj);
    partial void Equals_PostValidate(DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls instance, System.Object obj, System.Boolean _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Equals_UnitTest()
  {
    System.Object obj = default(System.Object);
    System.Boolean _retVal = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls) GetInstance();
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
    partial void GetHashCode_PreCondition(DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls instance);
    partial void GetHashCode_PostValidate(DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls instance, System.Int32 _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetHashCode_UnitTest()
  {
    System.Int32 _retVal = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls) GetInstance();
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
    partial void GetType_PreCondition(DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls instance);
    partial void GetType_PostValidate(DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls instance, System.Type _retVal);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetType_UnitTest()
  {
    System.Type _retVal = default(System.Type);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls) GetInstance();
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
   partial void ProjectById_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ProjectById_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls.ProjectById;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void ProjectByName_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ProjectByName_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls.ProjectByName;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void ProjectTeam_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ProjectTeam_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls.ProjectTeam;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void ProjectTeamMembers_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ProjectTeamMembers_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls.ProjectTeamMembers;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void ProjectTeams_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ProjectTeams_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls.ProjectTeams;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
   partial void Projects_SetCondition(ref DynCon.OSI.JasonBackedObjects.Communications.CallSpec setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Projects_UnitTest()
  {
      ExecuteProperty(
        null, null,null,  // No Set Accessor
        // Invoke Getter
        () =>
        {
            return DynCon.OSI.VSO.ReSTClient.RestCalls.ProjectRestCalls.Projects;
        },
        // Validate Get Operation
       (setValue, getValue) =>
       {
       });
  }
  }
}
