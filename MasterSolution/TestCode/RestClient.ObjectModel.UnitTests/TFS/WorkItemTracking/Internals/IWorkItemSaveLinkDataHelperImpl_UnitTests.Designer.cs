using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IWorkItemSaveLinkDataHelperImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AddWorkItemLinkInfo_UnitTest()
        {
            IWorkItemLinkInfo link = default(IWorkItemLinkInfo);
            ExecuteMethod(
                () => { return (IIWorkItemSaveLinkDataHelper) GetInstance(); },
                instance =>
                {
                    link = WorkItemLinkInfoImpl_UnitTests.GetInstance();
                    AddWorkItemLinkInfo_PreCondition(instance, ref link);
                },
                instance => { instance.AddWorkItemLinkInfo(link); },
                instance => { AddWorkItemLinkInfo_PostValidate(instance, link); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ResetWorkItemLinkInfo_UnitTest()
        {
            ExecuteMethod(
                () => { return (IIWorkItemSaveLinkDataHelper) GetInstance(); },
                instance => { ResetWorkItemLinkInfo_PreCondition(instance); },
                instance => { instance.ResetWorkItemLinkInfo(); },
                instance => { ResetWorkItemLinkInfo_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UpdatedLinks_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIWorkItemSaveLinkDataHelper) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.UpdatedLinks; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AddWorkItemLinkInfo_PostValidate(IIWorkItemSaveLinkDataHelper instance, IWorkItemLinkInfo link);
        partial void AddWorkItemLinkInfo_PreCondition(IIWorkItemSaveLinkDataHelper instance, ref IWorkItemLinkInfo link);
        internal static IEnumerable<IWorkItemSaveLinkDataHelperImpl> GetIEnumerableInstance() { return new List<IWorkItemSaveLinkDataHelperImpl> {GetInstance()}; }

        internal static IWorkItemSaveLinkDataHelperImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IWorkItemSaveLinkDataHelperImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IWorkItemSaveLinkDataHelperImpl instance, [CallerMemberName] string callerName = "");
        partial void ResetWorkItemLinkInfo_PostValidate(IIWorkItemSaveLinkDataHelper instance);
        partial void ResetWorkItemLinkInfo_PreCondition(IIWorkItemSaveLinkDataHelper instance);

        partial void UpdatedLinks_SetCondition(ref IIWorkItemSaveLinkDataHelper instance, ref IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> setValue);
    }
}