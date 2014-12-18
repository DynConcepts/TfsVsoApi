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
  public partial class WorkItemLinkTypeWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLinkType);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLinkType real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeWrapper>{ GetInstance() }; }

    partial void Activate_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance);
    partial void Activate_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Activate_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
        },
        (instance) =>
        {
          Activate_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Activate();
       },
      (instance) =>
      {
              Activate_PostValidate(instance);
      });
  }
    partial void Deactivate_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance);
    partial void Deactivate_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Deactivate_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
        },
        (instance) =>
        {
          Deactivate_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Deactivate();
       },
      (instance) =>
      {
              Deactivate_PostValidate(instance);
      });
  }
   partial void ForwardEnd_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ForwardEnd_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ForwardEnd;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ReverseEnd_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ReverseEnd_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ReverseEnd;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsDirectional_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsDirectional_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsDirectional;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsNonCircular_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsNonCircular_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsNonCircular;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsOneToMany_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsOneToMany_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsOneToMany;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CanDelete_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CanDelete_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CanDelete;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CanEdit_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CanEdit_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CanEdit;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void LinkTopology_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType_Topology setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void LinkTopology_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.LinkTopology;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}


namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemLinkType_TopologyWrapper_UnitTests : DynTestClassBase 
  {
  internal static DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType_Topology GetInstance() { return default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType_Topology); }

  }
}
