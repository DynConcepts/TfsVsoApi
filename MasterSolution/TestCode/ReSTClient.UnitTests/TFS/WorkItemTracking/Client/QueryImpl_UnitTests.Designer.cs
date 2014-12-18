using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class QueryImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryImpl>{ GetInstance() }; }

    partial void GetLinkTypes_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void GetLinkTypes_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetLinkTypes_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          GetLinkTypes_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetLinkTypes();
       },
      (instance) =>
      {
              GetLinkTypes_PostValidate(instance);
      });
  }
    partial void RunQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void RunQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RunQuery_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          RunQuery_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.RunQuery();
       },
      (instance) =>
      {
              RunQuery_PostValidate(instance);
      });
  }
    partial void RunRevisionQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void RunRevisionQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RunRevisionQuery_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          RunRevisionQuery_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.RunRevisionQuery();
       },
      (instance) =>
      {
              RunRevisionQuery_PostValidate(instance);
      });
  }
    partial void RunRegularQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void RunRegularQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RunRegularQuery_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          RunRegularQuery_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.RunRegularQuery();
       },
      (instance) =>
      {
              RunRegularQuery_PostValidate(instance);
      });
  }
    partial void RunLinkQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void RunLinkQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RunLinkQuery_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          RunLinkQuery_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.RunLinkQuery();
       },
      (instance) =>
      {
              RunLinkQuery_PostValidate(instance);
      });
  }
    partial void RunCountQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void RunCountQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RunCountQuery_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          RunCountQuery_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.RunCountQuery();
       },
      (instance) =>
      {
              RunCountQuery_PostValidate(instance);
      });
  }
    partial void BeginQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void BeginQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BeginQuery_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          BeginQuery_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.BeginQuery();
       },
      (instance) =>
      {
              BeginQuery_PostValidate(instance);
      });
  }
    partial void BeginRegularQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void BeginRegularQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BeginRegularQuery_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          BeginRegularQuery_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.BeginRegularQuery();
       },
      (instance) =>
      {
              BeginRegularQuery_PostValidate(instance);
      });
  }
    partial void BeginLinkQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void BeginLinkQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BeginLinkQuery_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          BeginLinkQuery_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.BeginLinkQuery();
       },
      (instance) =>
      {
              BeginLinkQuery_PostValidate(instance);
      });
  }
    partial void BeginCountOnlyQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
    partial void BeginCountOnlyQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BeginCountOnlyQuery_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          BeginCountOnlyQuery_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.BeginCountOnlyQuery();
       },
      (instance) =>
      {
              BeginCountOnlyQuery_PostValidate(instance);
      });
  }
    partial void EndQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
    partial void EndQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void EndQuery_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          car = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.ICancelableAsyncResultImpl_UnitTests.GetInstance();
          EndQuery_PreCondition(ref instance, ref car);
        },
       (instance) =>
       {
             instance.EndQuery(car);
       },
      (instance) =>
      {
              EndQuery_PostValidate(instance, car);
      });
  }
    partial void EndRegularQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
    partial void EndRegularQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void EndRegularQuery_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          car = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.ICancelableAsyncResultImpl_UnitTests.GetInstance();
          EndRegularQuery_PreCondition(ref instance, ref car);
        },
       (instance) =>
       {
             instance.EndRegularQuery(car);
       },
      (instance) =>
      {
              EndRegularQuery_PostValidate(instance, car);
      });
  }
    partial void EndLinkQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
    partial void EndLinkQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void EndLinkQuery_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          car = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.ICancelableAsyncResultImpl_UnitTests.GetInstance();
          EndLinkQuery_PreCondition(ref instance, ref car);
        },
       (instance) =>
       {
             instance.EndLinkQuery(car);
       },
      (instance) =>
      {
              EndLinkQuery_PostValidate(instance, car);
      });
  }
    partial void EndCountOnlyQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
    partial void EndCountOnlyQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void EndCountOnlyQuery_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
        },
        (instance) =>
        {
          car = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.ICancelableAsyncResultImpl_UnitTests.GetInstance();
          EndCountOnlyQuery_PreCondition(ref instance, ref car);
        },
       (instance) =>
       {
             instance.EndCountOnlyQuery(car);
       },
      (instance) =>
      {
              EndCountOnlyQuery_PostValidate(instance, car);
      });
  }
   partial void IsBatchReadMode_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsBatchReadMode_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsBatchReadMode;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsLinkQuery_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsLinkQuery_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsLinkQuery;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void IsTreeQuery_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsTreeQuery_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsTreeQuery;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AsOfUTC_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref System.DateTime setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AsOfUTC_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AsOfUTC;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AsOf_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref System.DateTime setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AsOf_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AsOf;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void DisplayFieldList_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IDisplayFieldList setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DisplayFieldList_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.DisplayFieldList;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SortFieldList_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortFieldList setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SortFieldList_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.SortFieldList;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void QueryString_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryString_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQuery) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.QueryString;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
