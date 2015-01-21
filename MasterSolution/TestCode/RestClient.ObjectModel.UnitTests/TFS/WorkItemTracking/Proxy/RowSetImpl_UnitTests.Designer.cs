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
    public partial class RowSetImpl_UnitTests : DynTestClassBase
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
        internal static IEnumerable<RowSetImpl> GetIEnumerableInstance() { return new List<RowSetImpl> {GetInstance()}; }

        internal static RowSetImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new RowSetImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref RowSetImpl instance, [CallerMemberName] string callerName = "");
    }
}