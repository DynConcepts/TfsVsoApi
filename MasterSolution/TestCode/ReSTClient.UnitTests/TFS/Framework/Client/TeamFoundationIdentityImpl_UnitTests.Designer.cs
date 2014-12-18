using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class TeamFoundationIdentityImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.TeamFoundationIdentityImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.TeamFoundationIdentityImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.TeamFoundationIdentityImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.TeamFoundationIdentityImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.TeamFoundationIdentityImpl>{ GetInstance() }; }

    partial void TryGetProperty_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.String name, ref System.Object value);
    partial void TryGetProperty_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, System.String name, System.Object value);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TryGetProperty_UnitTest()
  {
    System.String name = default(System.String);
    System.Object value = default(System.Object);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
        },
        (instance) =>
        {
          name = default(System.String); //No Constructor
          value = new System.Object();
          TryGetProperty_PreCondition(ref instance, ref name, ref value);
        },
       (instance) =>
       {
             instance.TryGetProperty(name, out value);
       },
      (instance) =>
      {
              TryGetProperty_PostValidate(instance, name, value);
      });
  }
    partial void GetProperty_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.String name);
    partial void GetProperty_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, System.String name);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetProperty_UnitTest()
  {
    System.String name = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
        },
        (instance) =>
        {
          name = default(System.String); //No Constructor
          GetProperty_PreCondition(ref instance, ref name);
        },
       (instance) =>
       {
             instance.GetProperty(name);
       },
      (instance) =>
      {
              GetProperty_PostValidate(instance, name);
      });
  }
    partial void GetProperties_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance);
    partial void GetProperties_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetProperties_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
        },
        (instance) =>
        {
          GetProperties_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetProperties();
       },
      (instance) =>
      {
              GetProperties_PostValidate(instance);
      });
  }
    partial void SetProperty_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.String name, ref System.Object value);
    partial void SetProperty_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, System.String name, System.Object value);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetProperty_UnitTest()
  {
    System.String name = default(System.String);
    System.Object value = default(System.Object);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
        },
        (instance) =>
        {
          name = default(System.String); //No Constructor
          value = new System.Object();
          SetProperty_PreCondition(ref instance, ref name, ref value);
        },
       (instance) =>
       {
             instance.SetProperty(name,value);
       },
      (instance) =>
      {
              SetProperty_PostValidate(instance, name, value);
      });
  }
    partial void RemoveProperty_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.String name);
    partial void RemoveProperty_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, System.String name);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveProperty_UnitTest()
  {
    System.String name = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
        },
        (instance) =>
        {
          name = default(System.String); //No Constructor
          RemoveProperty_PreCondition(ref instance, ref name);
        },
       (instance) =>
       {
             instance.RemoveProperty(name);
       },
      (instance) =>
      {
              RemoveProperty_PostValidate(instance, name);
      });
  }
    partial void GetAttribute_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.String name, ref System.String defaultValue);
    partial void GetAttribute_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, System.String name, System.String defaultValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetAttribute_UnitTest()
  {
    System.String name = default(System.String);
    System.String defaultValue = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
        },
        (instance) =>
        {
          name = default(System.String); //No Constructor
          defaultValue = default(System.String); //No Constructor
          GetAttribute_PreCondition(ref instance, ref name, ref defaultValue);
        },
       (instance) =>
       {
             instance.GetAttribute(name,defaultValue);
       },
      (instance) =>
      {
              GetAttribute_PostValidate(instance, name, defaultValue);
      });
  }
    partial void SetAttribute_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.String name, ref System.String value);
    partial void SetAttribute_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, System.String name, System.String value);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetAttribute_UnitTest()
  {
    System.String name = default(System.String);
    System.String value = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
        },
        (instance) =>
        {
          name = default(System.String); //No Constructor
          value = default(System.String); //No Constructor
          SetAttribute_PreCondition(ref instance, ref name, ref value);
        },
       (instance) =>
       {
             instance.SetAttribute(name,value);
       },
      (instance) =>
      {
              SetAttribute_PostValidate(instance, name, value);
      });
  }
   partial void IsContainer_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsContainer_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsContainer;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void UniqueName_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UniqueName_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.UniqueName;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Descriptor_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Descriptor_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor);
          Descriptor_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Descriptor = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Descriptor;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void DisplayName_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DisplayName_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          DisplayName_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.DisplayName = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.DisplayName;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsActive_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsActive_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Boolean);
          IsActive_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.IsActive = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.IsActive;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void MemberOf_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor[] setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void MemberOf_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor[]);
          MemberOf_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.MemberOf = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.MemberOf;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Members_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor[] setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Members_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor[]);
          Members_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Members = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Members;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void TeamFoundationId_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.Guid setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TeamFoundationId_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Guid);
          TeamFoundationId_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.TeamFoundationId = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.TeamFoundationId;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void UniqueUserId_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity instance, ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UniqueUserId_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Int32);
          UniqueUserId_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.UniqueUserId = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.UniqueUserId;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
