using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class QueryImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AsOfUTC_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AsOfUTC; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AsOf_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AsOf; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BeginCountOnlyQuery_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { BeginCountOnlyQuery_PreCondition(ref instance); },
                instance => { instance.BeginCountOnlyQuery(); },
                instance => { BeginCountOnlyQuery_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BeginLinkQuery_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { BeginLinkQuery_PreCondition(ref instance); },
                instance => { instance.BeginLinkQuery(); },
                instance => { BeginLinkQuery_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BeginQuery_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { BeginQuery_PreCondition(ref instance); },
                instance => { instance.BeginQuery(); },
                instance => { BeginQuery_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BeginRegularQuery_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { BeginRegularQuery_PreCondition(ref instance); },
                instance => { instance.BeginRegularQuery(); },
                instance => { BeginRegularQuery_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DisplayFieldList_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.DisplayFieldList; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void EndCountOnlyQuery_UnitTest()
        {
            IICancelableAsyncResult car = default(IICancelableAsyncResult);
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance =>
                {
                    car = ICancelableAsyncResultImpl_UnitTests.GetInstance();
                    EndCountOnlyQuery_PreCondition(ref instance, ref car);
                },
                instance => { instance.EndCountOnlyQuery(car); },
                instance => { EndCountOnlyQuery_PostValidate(instance, car); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void EndLinkQuery_UnitTest()
        {
            IICancelableAsyncResult car = default(IICancelableAsyncResult);
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance =>
                {
                    car = ICancelableAsyncResultImpl_UnitTests.GetInstance();
                    EndLinkQuery_PreCondition(ref instance, ref car);
                },
                instance => { instance.EndLinkQuery(car); },
                instance => { EndLinkQuery_PostValidate(instance, car); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void EndQuery_UnitTest()
        {
            IICancelableAsyncResult car = default(IICancelableAsyncResult);
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance =>
                {
                    car = ICancelableAsyncResultImpl_UnitTests.GetInstance();
                    EndQuery_PreCondition(ref instance, ref car);
                },
                instance => { instance.EndQuery(car); },
                instance => { EndQuery_PostValidate(instance, car); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void EndRegularQuery_UnitTest()
        {
            IICancelableAsyncResult car = default(IICancelableAsyncResult);
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance =>
                {
                    car = ICancelableAsyncResultImpl_UnitTests.GetInstance();
                    EndRegularQuery_PreCondition(ref instance, ref car);
                },
                instance => { instance.EndRegularQuery(car); },
                instance => { EndRegularQuery_PostValidate(instance, car); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetLinkTypes_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { GetLinkTypes_PreCondition(ref instance); },
                instance => { instance.GetLinkTypes(); },
                instance => { GetLinkTypes_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsBatchReadMode_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsBatchReadMode; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsLinkQuery_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsLinkQuery; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsTreeQuery_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsTreeQuery; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryString_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.QueryString; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RunCountQuery_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { RunCountQuery_PreCondition(ref instance); },
                instance => { instance.RunCountQuery(); },
                instance => { RunCountQuery_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RunLinkQuery_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { RunLinkQuery_PreCondition(ref instance); },
                instance => { instance.RunLinkQuery(); },
                instance => { RunLinkQuery_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RunQuery_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { RunQuery_PreCondition(ref instance); },
                instance => { instance.RunQuery(); },
                instance => { RunQuery_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RunRegularQuery_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { RunRegularQuery_PreCondition(ref instance); },
                instance => { instance.RunRegularQuery(); },
                instance => { RunRegularQuery_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RunRevisionQuery_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQuery) GetInstance(); },
                instance => { RunRevisionQuery_PreCondition(ref instance); },
                instance => { instance.RunRevisionQuery(); },
                instance => { RunRevisionQuery_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SortFieldList_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SortFieldList; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AsOfUTC_SetCondition(ref IQuery instance, ref DateTime setValue);

        partial void AsOf_SetCondition(ref IQuery instance, ref DateTime setValue);
        partial void BeginCountOnlyQuery_PostValidate(IQuery instance);
        partial void BeginCountOnlyQuery_PreCondition(ref IQuery instance);
        partial void BeginLinkQuery_PostValidate(IQuery instance);
        partial void BeginLinkQuery_PreCondition(ref IQuery instance);
        partial void BeginQuery_PostValidate(IQuery instance);
        partial void BeginQuery_PreCondition(ref IQuery instance);
        partial void BeginRegularQuery_PostValidate(IQuery instance);
        partial void BeginRegularQuery_PreCondition(ref IQuery instance);

        partial void DisplayFieldList_SetCondition(ref IQuery instance, ref IDisplayFieldList setValue);
        partial void EndCountOnlyQuery_PostValidate(IQuery instance, IICancelableAsyncResult car);
        partial void EndCountOnlyQuery_PreCondition(ref IQuery instance, ref IICancelableAsyncResult car);
        partial void EndLinkQuery_PostValidate(IQuery instance, IICancelableAsyncResult car);
        partial void EndLinkQuery_PreCondition(ref IQuery instance, ref IICancelableAsyncResult car);
        partial void EndQuery_PostValidate(IQuery instance, IICancelableAsyncResult car);
        partial void EndQuery_PreCondition(ref IQuery instance, ref IICancelableAsyncResult car);
        partial void EndRegularQuery_PostValidate(IQuery instance, IICancelableAsyncResult car);
        partial void EndRegularQuery_PreCondition(ref IQuery instance, ref IICancelableAsyncResult car);
        internal static IEnumerable<QueryImpl> GetIEnumerableInstance() { return new List<QueryImpl> {GetInstance()}; }

        internal static QueryImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new QueryImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetLinkTypes_PostValidate(IQuery instance);
        partial void GetLinkTypes_PreCondition(ref IQuery instance);
        static partial void InstanceFactory(ref QueryImpl instance, [CallerMemberName] string callerName = "");
        partial void IsBatchReadMode_SetCondition(ref IQuery instance, ref Boolean setValue);
        partial void IsLinkQuery_SetCondition(ref IQuery instance, ref Boolean setValue);
        partial void IsTreeQuery_SetCondition(ref IQuery instance, ref Boolean setValue);

        partial void QueryString_SetCondition(ref IQuery instance, ref String setValue);
        partial void RunCountQuery_PostValidate(IQuery instance);
        partial void RunCountQuery_PreCondition(ref IQuery instance);
        partial void RunLinkQuery_PostValidate(IQuery instance);
        partial void RunLinkQuery_PreCondition(ref IQuery instance);
        partial void RunQuery_PostValidate(IQuery instance);
        partial void RunQuery_PreCondition(ref IQuery instance);
        partial void RunRegularQuery_PostValidate(IQuery instance);
        partial void RunRegularQuery_PreCondition(ref IQuery instance);
        partial void RunRevisionQuery_PostValidate(IQuery instance);
        partial void RunRevisionQuery_PreCondition(ref IQuery instance);
        partial void SortFieldList_SetCondition(ref IQuery instance, ref ISortFieldList setValue);
    }
}