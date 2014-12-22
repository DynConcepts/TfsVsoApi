using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class SnapshotWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LoadFieldIdsByWorkItemType_UnitTest()
        {
            Int32 typeId = default(Int32);
            ExecuteMethod(
                () => { return (ISnapshot) GetInstance(); },
                instance =>
                {
                    typeId = default(Int32); //No Constructor
                    LoadFieldIdsByWorkItemType_PreCondition(ref instance, ref typeId);
                },
                instance => { instance.LoadFieldIdsByWorkItemType(typeId); },
                instance => { LoadFieldIdsByWorkItemType_PostValidate(instance, typeId); });
        }

        internal static IEnumerable<SnapshotWrapper> GetIEnumerableInstance() { return new List<SnapshotWrapper> {GetInstance()}; }

        internal static SnapshotWrapper GetInstance()
        {
            Snapshot real = default(Snapshot);
            RealInstanceFactory(ref real);
            var instance = (SnapshotWrapper) SnapshotWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref SnapshotWrapper instance, [CallerMemberName] string callerName = "");

        partial void LoadFieldIdsByWorkItemType_PostValidate(ISnapshot instance, Int32 typeId);
        partial void LoadFieldIdsByWorkItemType_PreCondition(ref ISnapshot instance, ref Int32 typeId);
        static partial void RealInstanceFactory(ref Snapshot real, [CallerMemberName] string callerName = "");
    }
}