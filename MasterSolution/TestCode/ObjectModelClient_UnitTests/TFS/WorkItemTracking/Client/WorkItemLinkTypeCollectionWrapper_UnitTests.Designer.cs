using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemLinkTypeCollectionWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeCollectionWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeCollectionWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLinkTypeCollection);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeCollectionWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeCollectionWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLinkTypeCollection real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeCollectionWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeCollectionWrapper>{ GetInstance() }; }

    partial void Validate_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeCollection instance, ref System.String definitionXml);
    partial void Validate_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeCollection instance, System.String definitionXml);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Validate_UnitTest()
  {
    System.String definitionXml = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeCollection) GetInstance();
        },
        (instance) =>
        {
          definitionXml = default(System.String); //No Constructor
          Validate_PreCondition(ref instance, ref definitionXml);
        },
       (instance) =>
       {
             instance.Validate(definitionXml);
       },
      (instance) =>
      {
              Validate_PostValidate(instance, definitionXml);
      });
  }
   partial void LinkTypeEnds_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeCollection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEndCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void LinkTypeEnds_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeCollection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.LinkTypeEnds;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
