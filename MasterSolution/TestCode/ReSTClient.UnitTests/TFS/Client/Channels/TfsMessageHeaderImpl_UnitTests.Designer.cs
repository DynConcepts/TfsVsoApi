using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.Channels
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class TfsMessageHeaderImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageHeaderImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageHeaderImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageHeaderImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageHeaderImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels.TfsMessageHeaderImpl>{ GetInstance() }; }

    partial void Write_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader instance, ref System.Xml.XmlDictionaryWriter writer);
    partial void Write_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader instance, System.Xml.XmlDictionaryWriter writer);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Write_UnitTest()
  {
    System.Xml.XmlDictionaryWriter writer = default(System.Xml.XmlDictionaryWriter);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader) GetInstance();
        },
        (instance) =>
        {
          writer = default(System.Xml.XmlDictionaryWriter); //No Type
          Write_PreCondition(ref instance, ref writer);
        },
       (instance) =>
       {
             instance.Write(writer);
       },
      (instance) =>
      {
              Write_PostValidate(instance, writer);
      });
  }
    partial void GetReader_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader instance);
    partial void GetReader_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetReader_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader) GetInstance();
        },
        (instance) =>
        {
          GetReader_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetReader();
       },
      (instance) =>
      {
              GetReader_PostValidate(instance);
      });
  }
   partial void Namespace_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Namespace_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Namespace;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
