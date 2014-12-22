using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Common
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class OrderedVariableSizeListWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<OrderedVariableSizeListWrapper> GetIEnumerableInstance() { return new List<OrderedVariableSizeListWrapper> {GetInstance()}; }

        internal static OrderedVariableSizeListWrapper GetInstance()
        {
            OrderedVariableSizeList real = default(OrderedVariableSizeList);
            RealInstanceFactory(ref real);
            var instance = (OrderedVariableSizeListWrapper) OrderedVariableSizeListWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref OrderedVariableSizeListWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref OrderedVariableSizeList real, [CallerMemberName] string callerName = "");
    }
}