using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Common
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class ReadOnlyListWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.ReadOnlyListWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.ReadOnlyListWrapper GetInstance() 
  { 
    var instance = default(DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.ReadOnlyListWrapper);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.ReadOnlyListWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.ReadOnlyListWrapper>{ GetInstance() }; }

    partial void GetEnumerator_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList instance);
    partial void GetEnumerator_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetEnumerator_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList) GetInstance();
        },
        (instance) =>
        {
          GetEnumerator_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetEnumerator();
       },
      (instance) =>
      {
              GetEnumerator_PostValidate(instance);
      });
  }
    partial void CopyTo_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList instance, ref System.Array array, ref System.Int32 index);
    partial void CopyTo_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList instance, System.Array array, System.Int32 index);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CopyTo_UnitTest()
  {
    System.Array array = default(System.Array);
    System.Int32 index = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList) GetInstance();
        },
        (instance) =>
        {
          array = default(System.Array); //No Constructor
          index = default(System.Int32); //No Constructor
          CopyTo_PreCondition(ref instance, ref array, ref index);
        },
       (instance) =>
       {
             instance.CopyTo(array,index);
       },
      (instance) =>
      {
              CopyTo_PostValidate(instance, array, index);
      });
  }
   partial void Count_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList instance, ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Count_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Count;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsSynchronized_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsSynchronized_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsSynchronized;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SyncRoot_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList instance, ref System.Object setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SyncRoot_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.SyncRoot;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsFixedSize_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsFixedSize_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsFixedSize;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsReadOnly_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsReadOnly_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsReadOnly;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
