using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class StoredQueriesChangedEventArgsWrapper_UnitTests : DynTestClassBase
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

        internal static IEnumerable<StoredQueriesChangedEventArgsWrapper> GetIEnumerableInstance() { return new List<StoredQueriesChangedEventArgsWrapper> {GetInstance()}; }

        internal static StoredQueriesChangedEventArgsWrapper GetInstance()
        {
            StoredQueriesChangedEventArgs real = default(StoredQueriesChangedEventArgs);
            RealInstanceFactory(ref real);
            var instance = (StoredQueriesChangedEventArgsWrapper) StoredQueriesChangedEventArgsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref StoredQueriesChangedEventArgsWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref StoredQueriesChangedEventArgs real, [CallerMemberName] string callerName = "");

        partial void SourceStoredQuery_SetCondition(ref IStoredQueriesChangedEventArgs instance, ref IStoredQuery setValue);

        partial void StoredQueriesAction_SetCondition(ref IStoredQueriesChangedEventArgs instance, ref IStoredQueriesAction setValue);
    }
}