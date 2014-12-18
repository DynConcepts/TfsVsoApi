using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class ITfsXmlSerializableWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsXmlSerializableWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsXmlSerializableWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.ITfsXmlSerializable);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsXmlSerializableWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsXmlSerializableWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.ITfsXmlSerializable real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsXmlSerializableWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsXmlSerializableWrapper>{ GetInstance() }; }

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
