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
  public partial class FieldWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.Field);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.Field real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldWrapper>{ GetInstance() }; }

   partial void ValueWithServerDefault_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref System.Object setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ValueWithServerDefault_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ValueWithServerDefault;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void OriginalValue_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref System.Object setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void OriginalValue_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.OriginalValue;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsChangedInRevision_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsChangedInRevision_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsChangedInRevision;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsRequired_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsRequired_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsRequired;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsChangedByUser_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsChangedByUser_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsChangedByUser;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void HasAllowedValuesList_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void HasAllowedValuesList_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.HasAllowedValuesList;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsLimitedToAllowedValues_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsLimitedToAllowedValues_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsLimitedToAllowedValues;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void HasPatternMatch_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void HasPatternMatch_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.HasPatternMatch;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Status_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldStatus setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Status_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Status;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsValid_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsValid_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsValid;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
