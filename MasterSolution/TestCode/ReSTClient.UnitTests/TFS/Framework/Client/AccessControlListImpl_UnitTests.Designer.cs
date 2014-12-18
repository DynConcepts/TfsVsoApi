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
  public partial class AccessControlListImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlListImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlListImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlListImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlListImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.AccessControlListImpl>{ GetInstance() }; }

    partial void RemovePermissions_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor, ref System.Int32 permissionsToRemove);
    partial void RemovePermissions_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor, System.Int32 permissionsToRemove);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemovePermissions_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor);
    System.Int32 permissionsToRemove = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
        },
        (instance) =>
        {
          descriptor = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.IdentityDescriptorImpl_UnitTests.GetInstance();
          permissionsToRemove = default(System.Int32); //No Constructor
          RemovePermissions_PreCondition(ref instance, ref descriptor, ref permissionsToRemove);
        },
       (instance) =>
       {
             instance.RemovePermissions(descriptor,permissionsToRemove);
       },
      (instance) =>
      {
              RemovePermissions_PostValidate(instance, descriptor, permissionsToRemove);
      });
  }
    partial void RemoveAccessControlEntry_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor);
    partial void RemoveAccessControlEntry_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveAccessControlEntry_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
        },
        (instance) =>
        {
          descriptor = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.IdentityDescriptorImpl_UnitTests.GetInstance();
          RemoveAccessControlEntry_PreCondition(ref instance, ref descriptor);
        },
       (instance) =>
       {
             instance.RemoveAccessControlEntry(descriptor);
       },
      (instance) =>
      {
              RemoveAccessControlEntry_PostValidate(instance, descriptor);
      });
  }
    partial void SetPermissions_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor, ref System.Int32 allow, ref System.Int32 deny, ref System.Boolean merge);
    partial void SetPermissions_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor, System.Int32 allow, System.Int32 deny, System.Boolean merge);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetPermissions_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor);
    System.Int32 allow = default(System.Int32);
    System.Int32 deny = default(System.Int32);
    System.Boolean merge = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
        },
        (instance) =>
        {
          descriptor = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.IdentityDescriptorImpl_UnitTests.GetInstance();
          allow = default(System.Int32); //No Constructor
          deny = default(System.Int32); //No Constructor
          merge = default(System.Boolean); //No Constructor
          SetPermissions_PreCondition(ref instance, ref descriptor, ref allow, ref deny, ref merge);
        },
       (instance) =>
       {
             instance.SetPermissions(descriptor,allow,deny,merge);
       },
      (instance) =>
      {
              SetPermissions_PostValidate(instance, descriptor, allow, deny, merge);
      });
  }
    partial void SetAccessControlEntry_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry accessControlEntry, ref System.Boolean merge);
    partial void SetAccessControlEntry_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry accessControlEntry, System.Boolean merge);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetAccessControlEntry_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry accessControlEntry = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry);
    System.Boolean merge = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
        },
        (instance) =>
        {
          accessControlEntry = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.AccessControlEntryImpl_UnitTests.GetInstance();
          merge = default(System.Boolean); //No Constructor
          SetAccessControlEntry_PreCondition(ref instance, ref accessControlEntry, ref merge);
        },
       (instance) =>
       {
             instance.SetAccessControlEntry(accessControlEntry,merge);
       },
      (instance) =>
      {
              SetAccessControlEntry_PostValidate(instance, accessControlEntry, merge);
      });
  }
    partial void SetAccessControlEntries_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry> accessControlEntries, ref System.Boolean merge);
    partial void SetAccessControlEntries_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry> accessControlEntries, System.Boolean merge);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetAccessControlEntries_UnitTest()
  {
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry> accessControlEntries = default(System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry>);
    System.Boolean merge = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
        },
        (instance) =>
        {
          accessControlEntries = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.AccessControlEntryImpl_UnitTests.GetIEnumerableInstance();
          merge = default(System.Boolean); //No Constructor
          SetAccessControlEntries_PreCondition(ref instance, ref accessControlEntries, ref merge);
        },
       (instance) =>
       {
             instance.SetAccessControlEntries(accessControlEntries,merge);
       },
      (instance) =>
      {
              SetAccessControlEntries_PostValidate(instance, accessControlEntries, merge);
      });
  }
    partial void QueryAccessControlEntry_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor);
    partial void QueryAccessControlEntry_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryAccessControlEntry_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
        },
        (instance) =>
        {
          descriptor = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.IdentityDescriptorImpl_UnitTests.GetInstance();
          QueryAccessControlEntry_PreCondition(ref instance, ref descriptor);
        },
       (instance) =>
       {
             instance.QueryAccessControlEntry(descriptor);
       },
      (instance) =>
      {
              QueryAccessControlEntry_PostValidate(instance, descriptor);
      });
  }
    partial void QueryAccessControlEntries_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor> descriptors);
    partial void QueryAccessControlEntries_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor> descriptors);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryAccessControlEntries_UnitTest()
  {
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor> descriptors = default(System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor>);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
        },
        (instance) =>
        {
          descriptors = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client.IdentityDescriptorImpl_UnitTests.GetIEnumerableInstance();
          QueryAccessControlEntries_PreCondition(ref instance, ref descriptors);
        },
       (instance) =>
       {
             instance.QueryAccessControlEntries(descriptors);
       },
      (instance) =>
      {
              QueryAccessControlEntries_PostValidate(instance, descriptors);
      });
  }
   partial void InheritPermissions_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void InheritPermissions_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Boolean);
          InheritPermissions_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.InheritPermissions = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.InheritPermissions;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Token_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Token_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.String);
          Token_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Token = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Token;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AccessControlEntries_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList instance, ref System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AccessControlEntries_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AccessControlEntries;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
