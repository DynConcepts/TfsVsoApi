using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ArtifactWorkItemIdsImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkItemIds_UnitTest()
        {
            ExecuteMethod(
                () => { return (IArtifactWorkItemIds) GetInstance(); },
                instance => { GetWorkItemIds_PreCondition(ref instance); },
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

        internal static IEnumerable<ArtifactWorkItemIdsImpl> GetIEnumerableInstance() { return new List<ArtifactWorkItemIdsImpl> {GetInstance()}; }

        internal static ArtifactWorkItemIdsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ArtifactWorkItemIdsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetWorkItemIds_PostValidate(IArtifactWorkItemIds instance);
        partial void GetWorkItemIds_PreCondition(ref IArtifactWorkItemIds instance);
        static partial void InstanceFactory(ref ArtifactWorkItemIdsImpl instance, [CallerMemberName] string callerName = "");

        partial void UriListOffset_SetCondition(ref IArtifactWorkItemIds instance, ref Int32 setValue);
    }
}