using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Internals
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class LinkUpdateImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.LinkUpdateImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.LinkUpdateImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.LinkUpdateImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.LinkUpdateImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.LinkUpdateImpl>{ GetInstance() }; }

    partial void Submit_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkUpdate instance, ref System.Xml.XmlElement element);
    partial void Submit_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkUpdate instance, System.Xml.XmlElement element);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Submit_UnitTest()
  {
    System.Xml.XmlElement element = default(System.Xml.XmlElement);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkUpdate) GetInstance();
        },
        (instance) =>
        {
          element = default(System.Xml.XmlElement); //No Type
          Submit_PreCondition(ref instance, ref element);
        },
       (instance) =>
       {
             instance.Submit(element);
       },
      (instance) =>
      {
              Submit_PostValidate(instance, element);
      });
  }
   partial void Mask_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkUpdate instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkProperties setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Mask_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkUpdate) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Mask;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
