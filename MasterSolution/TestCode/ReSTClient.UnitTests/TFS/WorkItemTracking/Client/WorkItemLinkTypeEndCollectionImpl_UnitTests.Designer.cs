using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkTypeEndCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemLinkTypeEndCollectionImpl> GetIEnumerableInstance() { return new List<WorkItemLinkTypeEndCollectionImpl> {GetInstance()}; }

        internal static WorkItemLinkTypeEndCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemLinkTypeEndCollectionImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkTypeEndCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}