using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkDataImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AddLinkInfo_UnitTest()
        {
            ILinkInfo linkInfo = default(ILinkInfo);
            Object updatedItem = default(Object);
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance =>
                {
                    linkInfo = LinkInfoImpl_UnitTests.GetInstance();
                    updatedItem = new Object();
                    AddLinkInfo_PreCondition(instance, ref linkInfo, ref updatedItem);
                },
                instance => { instance.AddLinkInfo(linkInfo, updatedItem); },
                instance => { AddLinkInfo_PostValidate(instance, linkInfo, updatedItem); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Check_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance => { Check_PreCondition(instance); },
                instance => { instance.Check(); },
                instance => { Check_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetAddedLinksCount_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance => { GetAddedLinksCount_PreCondition(instance); },
                instance => { instance.GetAddedLinksCount(); },
                instance => { GetAddedLinksCount_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetAddedLinks_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance => { GetAddedLinks_PreCondition(instance); },
                instance => { instance.GetAddedLinks(); },
                instance => { GetAddedLinks_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetDeletedLinksCount_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance => { GetDeletedLinksCount_PreCondition(instance); },
                instance => { instance.GetDeletedLinksCount(); },
                instance => { GetDeletedLinksCount_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetDeletedLinks_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance => { GetDeletedLinks_PreCondition(instance); },
                instance => { instance.GetDeletedLinks(); },
                instance => { GetDeletedLinks_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetLinkInfoCount_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance => { GetLinkInfoCount_PreCondition(instance); },
                instance => { instance.GetLinkInfoCount(); },
                instance => { GetLinkInfoCount_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetLinkInfo_UnitTest()
        {
            Int32 index = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    GetLinkInfo_PreCondition(instance, ref index);
                },
                instance => { instance.GetLinkInfo(index); },
                instance => { GetLinkInfo_PostValidate(instance, index); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetUpdatedLinksCount_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance => { GetUpdatedLinksCount_PreCondition(instance); },
                instance => { instance.GetUpdatedLinksCount(); },
                instance => { GetUpdatedLinksCount_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetUpdatedLinks_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance => { GetUpdatedLinks_PreCondition(instance); },
                instance => { instance.GetUpdatedLinks(); },
                instance => { GetUpdatedLinks_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void MarkLinkToDelete_UnitTest()
        {
            ILinkInfo linkInfo = default(ILinkInfo);
            Object updatedItem = default(Object);
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance =>
                {
                    linkInfo = LinkInfoImpl_UnitTests.GetInstance();
                    updatedItem = new Object();
                    MarkLinkToDelete_PreCondition(instance, ref linkInfo, ref updatedItem);
                },
                instance => { instance.MarkLinkToDelete(linkInfo, updatedItem); },
                instance => { MarkLinkToDelete_PostValidate(instance, linkInfo, updatedItem); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetLinkComment_UnitTest()
        {
            ILinkInfo linkInfo = default(ILinkInfo);
            String value = default(String);
            ExecuteMethod(
                () => { return (IWorkItemLinkData) GetInstance(); },
                instance =>
                {
                    linkInfo = LinkInfoImpl_UnitTests.GetInstance();
                    value = default(String); //No Constructor
                    SetLinkComment_PreCondition(instance, ref linkInfo, ref value);
                },
                instance => { instance.SetLinkComment(linkInfo, value); },
                instance => { SetLinkComment_PostValidate(instance, linkInfo, value); });
        }

        partial void AddLinkInfo_PostValidate(IWorkItemLinkData instance, ILinkInfo linkInfo, Object updatedItem);
        partial void AddLinkInfo_PreCondition(IWorkItemLinkData instance, ref ILinkInfo linkInfo, ref Object updatedItem);
        partial void Check_PostValidate(IWorkItemLinkData instance);
        partial void Check_PreCondition(IWorkItemLinkData instance);

        partial void GetAddedLinksCount_PostValidate(IWorkItemLinkData instance);
        partial void GetAddedLinksCount_PreCondition(IWorkItemLinkData instance);
        partial void GetAddedLinks_PostValidate(IWorkItemLinkData instance);
        partial void GetAddedLinks_PreCondition(IWorkItemLinkData instance);

        partial void GetDeletedLinksCount_PostValidate(IWorkItemLinkData instance);
        partial void GetDeletedLinksCount_PreCondition(IWorkItemLinkData instance);
        partial void GetDeletedLinks_PostValidate(IWorkItemLinkData instance);
        partial void GetDeletedLinks_PreCondition(IWorkItemLinkData instance);
        internal static IEnumerable<WorkItemLinkDataImpl> GetIEnumerableInstance() { return new List<WorkItemLinkDataImpl> {GetInstance()}; }

        internal static WorkItemLinkDataImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemLinkDataImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetLinkInfoCount_PostValidate(IWorkItemLinkData instance);
        partial void GetLinkInfoCount_PreCondition(IWorkItemLinkData instance);
        partial void GetLinkInfo_PostValidate(IWorkItemLinkData instance, Int32 index);
        partial void GetLinkInfo_PreCondition(IWorkItemLinkData instance, ref Int32 index);

        partial void GetUpdatedLinksCount_PostValidate(IWorkItemLinkData instance);
        partial void GetUpdatedLinksCount_PreCondition(IWorkItemLinkData instance);
        partial void GetUpdatedLinks_PostValidate(IWorkItemLinkData instance);
        partial void GetUpdatedLinks_PreCondition(IWorkItemLinkData instance);
        static partial void InstanceFactory(ref WorkItemLinkDataImpl instance, [CallerMemberName] string callerName = "");
        partial void MarkLinkToDelete_PostValidate(IWorkItemLinkData instance, ILinkInfo linkInfo, Object updatedItem);
        partial void MarkLinkToDelete_PreCondition(IWorkItemLinkData instance, ref ILinkInfo linkInfo, ref Object updatedItem);

        partial void SetLinkComment_PostValidate(IWorkItemLinkData instance, ILinkInfo linkInfo, String value);
        partial void SetLinkComment_PreCondition(IWorkItemLinkData instance, ref ILinkInfo linkInfo, ref String value);
    }
}