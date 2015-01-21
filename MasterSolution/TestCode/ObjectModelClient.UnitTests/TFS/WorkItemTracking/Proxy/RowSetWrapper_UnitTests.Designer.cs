using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IRowSet = DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RowSetWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Columns_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IRowSet) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Columns; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Columns_SetCondition(ref IRowSet instance, ref IRowSetColumn[] setValue);
        internal static IEnumerable<RowSetWrapper> GetIEnumerableInstance() { return new List<RowSetWrapper> {GetInstance()}; }

        internal static RowSetWrapper GetInstance()
        {
            var real = new RowSet();
            RealInstanceFactory(ref real);
            var instance = (RowSetWrapper) RowSetWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref RowSetWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref RowSet real, [CallerMemberName] string callerName = "");
    }
}