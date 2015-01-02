using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemOperationErrorImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemOperationErrorImpl> GetIEnumerableInstance() { return new List<WorkItemOperationErrorImpl> {GetInstance()}; }

        internal static WorkItemOperationErrorImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemOperationErrorImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemOperationErrorImpl instance, [CallerMemberName] string callerName = "");
    }
}