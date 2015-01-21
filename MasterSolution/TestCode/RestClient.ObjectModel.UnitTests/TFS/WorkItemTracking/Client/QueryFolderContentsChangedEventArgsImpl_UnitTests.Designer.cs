using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class QueryFolderContentsChangedEventArgsImpl_UnitTests : DynTestClassBase
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

        internal static IEnumerable<QueryFolderContentsChangedEventArgsImpl> GetIEnumerableInstance() { return new List<QueryFolderContentsChangedEventArgsImpl> {GetInstance()}; }

        internal static QueryFolderContentsChangedEventArgsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new QueryFolderContentsChangedEventArgsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref QueryFolderContentsChangedEventArgsImpl instance, [CallerMemberName] string callerName = "");

        partial void QueryItem_SetCondition(ref IQueryFolderContentsChangedEventArgs instance, ref IQueryItem setValue);
    }
}