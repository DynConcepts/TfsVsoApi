using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client.Metadata;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class SnapshotImpl_UnitTests : DynTestClassBase
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
                    LoadFieldIdsByWorkItemType_PreCondition(instance, ref typeId);
                },
                instance => { instance.LoadFieldIdsByWorkItemType(typeId); },
                instance => { LoadFieldIdsByWorkItemType_PostValidate(instance, typeId); });
        }

        internal static IEnumerable<SnapshotImpl> GetIEnumerableInstance() { return new List<SnapshotImpl> {GetInstance()}; }

        internal static SnapshotImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new SnapshotImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref SnapshotImpl instance, [CallerMemberName] string callerName = "");

        partial void LoadFieldIdsByWorkItemType_PostValidate(ISnapshot instance, Int32 typeId);
        partial void LoadFieldIdsByWorkItemType_PreCondition(ISnapshot instance, ref Int32 typeId);
    }
}