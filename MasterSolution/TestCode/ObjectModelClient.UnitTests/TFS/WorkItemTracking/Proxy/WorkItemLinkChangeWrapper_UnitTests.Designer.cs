using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkChangeWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ChangedDate_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkChange) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    DateTime setValue = default(DateTime);
                    ChangedDate_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.ChangedDate = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.ChangedDate; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LinkType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkChange) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    LinkType_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.LinkType = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.LinkType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void ChangedDate_SetCondition(ref IWorkItemLinkChange instance, ref DateTime setValue);
        internal static IEnumerable<WorkItemLinkChangeWrapper> GetIEnumerableInstance() { return new List<WorkItemLinkChangeWrapper> {GetInstance()}; }

        internal static WorkItemLinkChangeWrapper GetInstance()
        {
            WorkItemLinkChange real = default(WorkItemLinkChange);
            RealInstanceFactory(ref real);
            var instance = (WorkItemLinkChangeWrapper) WorkItemLinkChangeWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkChangeWrapper instance, [CallerMemberName] string callerName = "");
        partial void LinkType_SetCondition(ref IWorkItemLinkChange instance, ref String setValue);
        static partial void RealInstanceFactory(ref WorkItemLinkChange real, [CallerMemberName] string callerName = "");
    }
}