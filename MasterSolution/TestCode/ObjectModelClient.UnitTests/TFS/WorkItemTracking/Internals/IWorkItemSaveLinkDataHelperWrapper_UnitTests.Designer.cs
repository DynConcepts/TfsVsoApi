using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IWorkItemSaveLinkDataHelperWrapper_UnitTests : DynTestClassBase
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
                    link = WorkItemLinkInfoWrapper_UnitTests.GetInstance();
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
        internal static IEnumerable<IWorkItemSaveLinkDataHelperWrapper> GetIEnumerableInstance() { return new List<IWorkItemSaveLinkDataHelperWrapper> {GetInstance()}; }

        internal static IWorkItemSaveLinkDataHelperWrapper GetInstance()
        {
            IWorkItemSaveLinkDataHelper real = default(IWorkItemSaveLinkDataHelper);
            RealInstanceFactory(ref real);
            var instance = (IWorkItemSaveLinkDataHelperWrapper) IWorkItemSaveLinkDataHelperWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref IWorkItemSaveLinkDataHelperWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref IWorkItemSaveLinkDataHelper real, [CallerMemberName] string callerName = "");
        partial void ResetWorkItemLinkInfo_PostValidate(IIWorkItemSaveLinkDataHelper instance);
        partial void ResetWorkItemLinkInfo_PreCondition(IIWorkItemSaveLinkDataHelper instance);

        partial void UpdatedLinks_SetCondition(ref IIWorkItemSaveLinkDataHelper instance, ref IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> setValue);
    }
}