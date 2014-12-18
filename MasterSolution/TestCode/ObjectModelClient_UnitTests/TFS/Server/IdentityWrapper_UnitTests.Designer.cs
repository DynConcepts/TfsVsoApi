using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Server
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class IdentityWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Server.IdentityWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Server.IdentityWrapper GetInstance() 
  { 
    var real = new Microsoft.TeamFoundation.Server.Identity();
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Server.IdentityWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Server.IdentityWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Server.Identity real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Server.IdentityWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Server.IdentityWrapper>{ GetInstance() }; }

    partial void CompareTo_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, ref System.Object obj);
    partial void CompareTo_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, System.Object obj);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CompareTo_UnitTest()
  {
    System.Object obj = default(System.Object);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity) GetInstance();
        },
        (instance) =>
        {
          obj = new System.Object();
          CompareTo_PreCondition(ref instance, ref obj);
        },
       (instance) =>
       {
             instance.CompareTo(obj);
       },
      (instance) =>
      {
              CompareTo_PostValidate(instance, obj);
      });
  }
   partial void Sid_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Sid_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.String);
          Sid_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Sid = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Sid;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Domain_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Domain_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.String);
          Domain_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Domain = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Domain;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AccountName_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AccountName_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.String);
          AccountName_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.AccountName = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.AccountName;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void DistinguishedName_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DistinguishedName_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.String);
          DistinguishedName_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.DistinguishedName = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.DistinguishedName;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void MailAddress_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void MailAddress_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.String);
          MailAddress_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.MailAddress = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.MailAddress;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SpecialType_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IApplicationGroupSpecialType setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SpecialType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IApplicationGroupSpecialType);
          SpecialType_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.SpecialType = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.SpecialType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Deleted_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Deleted_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.Boolean);
          Deleted_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Deleted = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Deleted;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SecurityGroup_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SecurityGroup_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
          var setValue = default(System.Boolean);
          SecurityGroup_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.SecurityGroup = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.SecurityGroup;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
