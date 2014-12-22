using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Common
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class OrderedVariableSizeListImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<OrderedVariableSizeListImpl> GetIEnumerableInstance() { return new List<OrderedVariableSizeListImpl> {GetInstance()}; }

        internal static OrderedVariableSizeListImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new OrderedVariableSizeListImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref OrderedVariableSizeListImpl instance, [CallerMemberName] string callerName = "");
    }
}