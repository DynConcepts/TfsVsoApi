using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class StoredQueriesChangedEventArgsImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SourceStoredQuery_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQueriesChangedEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SourceStoredQuery; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void StoredQueriesAction_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQueriesChangedEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.StoredQueriesAction; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<StoredQueriesChangedEventArgsImpl> GetIEnumerableInstance() { return new List<StoredQueriesChangedEventArgsImpl> {GetInstance()}; }

        internal static StoredQueriesChangedEventArgsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new StoredQueriesChangedEventArgsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref StoredQueriesChangedEventArgsImpl instance, [CallerMemberName] string callerName = "");

        partial void SourceStoredQuery_SetCondition(ref IStoredQueriesChangedEventArgs instance, ref IStoredQuery setValue);

        partial void StoredQueriesAction_SetCondition(ref IStoredQueriesChangedEventArgs instance, ref IStoredQueriesAction setValue);
    }
}