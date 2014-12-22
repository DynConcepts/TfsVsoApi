using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkTypeEndImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ImmutableName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkTypeEnd) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ImmutableName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsForwardLink_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkTypeEnd) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsForwardLink; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void OppositeEnd_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkTypeEnd) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.OppositeEnd; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<WorkItemLinkTypeEndImpl> GetIEnumerableInstance() { return new List<WorkItemLinkTypeEndImpl> {GetInstance()}; }

        internal static WorkItemLinkTypeEndImpl GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            WorkItemLinkTypeEndImpl instance = WorkItemLinkTypeEndImpl.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void ImmutableName_SetCondition(ref IWorkItemLinkTypeEnd instance, ref String setValue);
        static partial void InstanceFactory(ref WorkItemLinkTypeEndImpl instance, [CallerMemberName] string callerName = "");

        partial void IsForwardLink_SetCondition(ref IWorkItemLinkTypeEnd instance, ref Boolean setValue);
        static partial void JsonSource(ref JToken json);
        partial void OppositeEnd_SetCondition(ref IWorkItemLinkTypeEnd instance, ref IWorkItemLinkTypeEnd setValue);
    }
}