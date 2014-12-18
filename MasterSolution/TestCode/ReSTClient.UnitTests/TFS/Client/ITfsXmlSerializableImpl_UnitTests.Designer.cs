using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class ITfsXmlSerializableImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsXmlSerializableImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsXmlSerializableImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsXmlSerializableImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsXmlSerializableImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsXmlSerializableImpl>{ GetInstance() }; }

    partial void WriteXml_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsXmlSerializable instance, ref System.Xml.XmlWriter writer, ref System.String xmlElement);
    partial void WriteXml_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsXmlSerializable instance, System.Xml.XmlWriter writer, System.String xmlElement);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void WriteXml_UnitTest()
  {
    System.Xml.XmlWriter writer = default(System.Xml.XmlWriter);
    System.String xmlElement = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsXmlSerializable) GetInstance();
        },
        (instance) =>
        {
          writer = default(System.Xml.XmlWriter); //No Type
          xmlElement = default(System.String); //No Constructor
          WriteXml_PreCondition(ref instance, ref writer, ref xmlElement);
        },
       (instance) =>
       {
             instance.WriteXml(writer,xmlElement);
       },
      (instance) =>
      {
              WriteXml_PostValidate(instance, writer, xmlElement);
      });
  }
    partial void ReadXml_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsXmlSerializable instance, ref System.Xml.XmlReader reader, ref System.String xmlElement);
    partial void ReadXml_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsXmlSerializable instance, System.Xml.XmlReader reader, System.String xmlElement);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ReadXml_UnitTest()
  {
    System.Xml.XmlReader reader = default(System.Xml.XmlReader);
    System.String xmlElement = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsXmlSerializable) GetInstance();
        },
        (instance) =>
        {
          reader = default(System.Xml.XmlReader); //No Type
          xmlElement = default(System.String); //No Constructor
          ReadXml_PreCondition(ref instance, ref reader, ref xmlElement);
        },
       (instance) =>
       {
             instance.ReadXml(reader,xmlElement);
       },
      (instance) =>
      {
              ReadXml_PostValidate(instance, reader, xmlElement);
      });
  }
  }
}
