using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemOperationErrorWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemOperationErrorWrapper> GetIEnumerableInstance() { return new List<WorkItemOperationErrorWrapper> {GetInstance()}; }

        internal static WorkItemOperationErrorWrapper GetInstance()
        {
            WorkItemOperationError real = default(WorkItemOperationError);
            RealInstanceFactory(ref real);
            var instance = (WorkItemOperationErrorWrapper) WorkItemOperationErrorWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemOperationErrorWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemOperationError real, [CallerMemberName] string callerName = "");
    }
}