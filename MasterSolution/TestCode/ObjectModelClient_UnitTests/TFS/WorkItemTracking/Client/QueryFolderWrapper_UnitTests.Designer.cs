using System;
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
    public partial class QueryFolderWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsRootNode_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryFolder) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsRootNode; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<QueryFolderWrapper> GetIEnumerableInstance() { return new List<QueryFolderWrapper> {GetInstance()}; }

        internal static QueryFolderWrapper GetInstance()
        {
            QueryFolder real = default(QueryFolder);
            RealInstanceFactory(ref real);
            var instance = (QueryFolderWrapper) QueryFolderWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref QueryFolderWrapper instance, [CallerMemberName] string callerName = "");

        partial void IsRootNode_SetCondition(ref IQueryFolder instance, ref Boolean setValue);
        static partial void RealInstanceFactory(ref QueryFolder real, [CallerMemberName] string callerName = "");
    }
}