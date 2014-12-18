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
  public partial class CatalogNodeImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogNodeImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogNodeImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogNodeImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogNodeImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client.CatalogNodeImpl>{ GetInstance() }; }

    partial void QueryChildren_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref System.Collections.Generic.IEnumerable<System.Guid> resourceTypeFilters, ref System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> propertyFilters, ref System.Boolean recurse, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
    partial void QueryChildren_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, System.Collections.Generic.IEnumerable<System.Guid> resourceTypeFilters, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> propertyFilters, System.Boolean recurse, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryChildren_UnitTest()
  {
    System.Collections.Generic.IEnumerable<System.Guid> resourceTypeFilters = default(System.Collections.Generic.IEnumerable<System.Guid>);
    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> propertyFilters = default(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>);
    System.Boolean recurse = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
        },
        (instance) =>
        {
          resourceTypeFilters = default(System.Collections.Generic.IEnumerable<System.Guid>); //No Type
          propertyFilters = default(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>); //No Type
          recurse = default(System.Boolean); //No Constructor
          queryOptions = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Common.CatalogQueryOptionsImpl_UnitTests.GetInstance();
          QueryChildren_PreCondition(ref instance, ref resourceTypeFilters, ref propertyFilters, ref recurse, ref queryOptions);
        },
       (instance) =>
       {
             instance.QueryChildren(resourceTypeFilters,propertyFilters,recurse,queryOptions);
       },
      (instance) =>
      {
              QueryChildren_PostValidate(instance, resourceTypeFilters, propertyFilters, recurse, queryOptions);
      });
  }
    partial void CreateChild_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref System.Guid resourceTypeIdentifier, ref System.String resourceDisplayName);
    partial void CreateChild_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, System.Guid resourceTypeIdentifier, System.String resourceDisplayName);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CreateChild_UnitTest()
  {
    System.Guid resourceTypeIdentifier = default(System.Guid);
    System.String resourceDisplayName = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
        },
        (instance) =>
        {
          resourceTypeIdentifier = default(System.Guid); //No Constructor
          resourceDisplayName = default(System.String); //No Constructor
          CreateChild_PreCondition(ref instance, ref resourceTypeIdentifier, ref resourceDisplayName);
        },
       (instance) =>
       {
             instance.CreateChild(resourceTypeIdentifier,resourceDisplayName);
       },
      (instance) =>
      {
              CreateChild_PostValidate(instance, resourceTypeIdentifier, resourceDisplayName);
      });
  }
    partial void QueryParents_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref System.Collections.Generic.IEnumerable<System.Guid> resourceTypeFilters, ref System.Boolean recurseToRoot, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
    partial void QueryParents_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, System.Collections.Generic.IEnumerable<System.Guid> resourceTypeFilters, System.Boolean recurseToRoot, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryParents_UnitTest()
  {
    System.Collections.Generic.IEnumerable<System.Guid> resourceTypeFilters = default(System.Collections.Generic.IEnumerable<System.Guid>);
    System.Boolean recurseToRoot = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
        },
        (instance) =>
        {
          resourceTypeFilters = default(System.Collections.Generic.IEnumerable<System.Guid>); //No Type
          recurseToRoot = default(System.Boolean); //No Constructor
          queryOptions = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Common.CatalogQueryOptionsImpl_UnitTests.GetInstance();
          QueryParents_PreCondition(ref instance, ref resourceTypeFilters, ref recurseToRoot, ref queryOptions);
        },
       (instance) =>
       {
             instance.QueryParents(resourceTypeFilters,recurseToRoot,queryOptions);
       },
      (instance) =>
      {
              QueryParents_PostValidate(instance, resourceTypeFilters, recurseToRoot, queryOptions);
      });
  }
    partial void QueryDependents_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
    partial void QueryDependents_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryDependents_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
        },
        (instance) =>
        {
          queryOptions = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Common.CatalogQueryOptionsImpl_UnitTests.GetInstance();
          QueryDependents_PreCondition(ref instance, ref queryOptions);
        },
       (instance) =>
       {
             instance.QueryDependents(queryOptions);
       },
      (instance) =>
      {
              QueryDependents_PostValidate(instance, queryOptions);
      });
  }
    partial void ExpandDependencies_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance);
    partial void ExpandDependencies_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ExpandDependencies_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
        },
        (instance) =>
        {
          ExpandDependencies_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.ExpandDependencies();
       },
      (instance) =>
      {
              ExpandDependencies_PostValidate(instance);
      });
  }
   partial void ParentNode_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ParentNode_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ParentNode;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ParentPath_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ParentPath_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ParentPath;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void FullPath_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FullPath_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.FullPath;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Resource_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Resource_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Resource;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsDefault_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsDefault_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
           return instance;
        },
        // Create Set Value
        (instance) =>
        {
 var setValue = default(System.Boolean);
          IsDefault_SetCondition(ref instance, ref setValue);
          return setValue;
        },
        // Invoke Setter
       (instance, setValue) =>
       {
           instance.IsDefault = setValue;
       },
       // Validate Set Operation
       (instance, setValue) =>
       {
       },
        // Invoke Getter
        (instance) =>
        {
            return instance.IsDefault;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Dependencies_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Dependencies_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Dependencies;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void CatalogTree_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogTree setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void CatalogTree_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.CatalogTree;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
