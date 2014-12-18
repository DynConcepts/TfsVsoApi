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
  public partial class IdentityDescriptorImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.IdentityDescriptorImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.IdentityDescriptorImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.IdentityDescriptorImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.IdentityDescriptorImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.IdentityDescriptorImpl>{ GetInstance() }; }

    partial void ToXml_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor instance, ref System.Xml.XmlWriter writer, ref System.String element);
    partial void ToXml_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor instance, System.Xml.XmlWriter writer, System.String element);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ToXml_UnitTest()
  {
    System.Xml.XmlWriter writer = default(System.Xml.XmlWriter);
    System.String element = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor) GetInstance();
        },
        (instance) =>
        {
          writer = default(System.Xml.XmlWriter); //No Type
          element = default(System.String); //No Constructor
          ToXml_PreCondition(ref instance, ref writer, ref element);
        },
       (instance) =>
       {
             instance.ToXml(writer,element);
       },
      (instance) =>
      {
              ToXml_PostValidate(instance, writer, element);
      });
  }
   partial void Data_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor instance, ref System.Object setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Data_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Object);
          Data_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.Data = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.Data;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Identifier_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Identifier_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Identifier;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IdentityType_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IdentityType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IdentityType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
