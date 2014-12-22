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
    public partial class QueryFolderContentsChangedEventArgsWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryItem_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryFolderContentsChangedEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.QueryItem; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<QueryFolderContentsChangedEventArgsWrapper> GetIEnumerableInstance() { return new List<QueryFolderContentsChangedEventArgsWrapper> {GetInstance()}; }

        internal static QueryFolderContentsChangedEventArgsWrapper GetInstance()
        {
            QueryFolderContentsChangedEventArgs real = default(QueryFolderContentsChangedEventArgs);
            RealInstanceFactory(ref real);
            var instance = (QueryFolderContentsChangedEventArgsWrapper) QueryFolderContentsChangedEventArgsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref QueryFolderContentsChangedEventArgsWrapper instance, [CallerMemberName] string callerName = "");

        partial void QueryItem_SetCondition(ref IQueryFolderContentsChangedEventArgs instance, ref IQueryItem setValue);
        static partial void RealInstanceFactory(ref QueryFolderContentsChangedEventArgs real, [CallerMemberName] string callerName = "");
    }
}