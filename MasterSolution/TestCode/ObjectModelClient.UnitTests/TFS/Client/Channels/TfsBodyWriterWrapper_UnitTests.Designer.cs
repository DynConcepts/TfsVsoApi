using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class TfsBodyWriterWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.TfsBodyWriterWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.TfsBodyWriterWrapper GetInstance() 
  { 
    var instance = default(DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.TfsBodyWriterWrapper);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.TfsBodyWriterWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels.TfsBodyWriterWrapper>{ GetInstance() }; }

    partial void WriteBodyContents_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsBodyWriter instance, ref System.Xml.XmlDictionaryWriter writer);
    partial void WriteBodyContents_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsBodyWriter instance, System.Xml.XmlDictionaryWriter writer);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void WriteBodyContents_UnitTest()
  {
    System.Xml.XmlDictionaryWriter writer = default(System.Xml.XmlDictionaryWriter);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsBodyWriter) GetInstance();
        },
        (instance) =>
        {
          writer = default(System.Xml.XmlDictionaryWriter); //No Type
          WriteBodyContents_PreCondition(ref instance, ref writer);
        },
       (instance) =>
       {
             instance.WriteBodyContents(writer);
       },
      (instance) =>
      {
              WriteBodyContents_PostValidate(instance, writer);
      });
  }
    partial void Close_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsBodyWriter instance);
    partial void Close_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsBodyWriter instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Close_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsBodyWriter) GetInstance();
        },
        (instance) =>
        {
          Close_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Close();
       },
      (instance) =>
      {
              Close_PostValidate(instance);
      });
  }
  }
}
