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
    public partial class ArtifactWorkItemIdsWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkItemIds_UnitTest()
        {
            ExecuteMethod(
                () => { return (IArtifactWorkItemIds) GetInstance(); },
                instance => { GetWorkItemIds_PreCondition(instance); },
                instance => { instance.GetWorkItemIds(); },
                instance => { GetWorkItemIds_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UriListOffset_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IArtifactWorkItemIds) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    UriListOffset_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.UriListOffset = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.UriListOffset; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<ArtifactWorkItemIdsWrapper> GetIEnumerableInstance() { return new List<ArtifactWorkItemIdsWrapper> {GetInstance()}; }

        internal static ArtifactWorkItemIdsWrapper GetInstance()
        {
            var real = new ArtifactWorkItemIds();
            RealInstanceFactory(ref real);
            var instance = (ArtifactWorkItemIdsWrapper) ArtifactWorkItemIdsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetWorkItemIds_PostValidate(IArtifactWorkItemIds instance);
        partial void GetWorkItemIds_PreCondition(IArtifactWorkItemIds instance);
        static partial void InstanceFactory(ref ArtifactWorkItemIdsWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref ArtifactWorkItemIds real, [CallerMemberName] string callerName = "");

        partial void UriListOffset_SetCondition(ref IArtifactWorkItemIds instance, ref Int32 setValue);
    }
}