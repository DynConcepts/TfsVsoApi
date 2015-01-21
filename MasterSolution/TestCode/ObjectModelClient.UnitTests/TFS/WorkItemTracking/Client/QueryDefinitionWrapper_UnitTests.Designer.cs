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
    public partial class QueryDefinitionWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.QueryType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<QueryDefinitionWrapper> GetIEnumerableInstance() { return new List<QueryDefinitionWrapper> {GetInstance()}; }

        internal static QueryDefinitionWrapper GetInstance()
        {
            QueryDefinition real = default(QueryDefinition);
            RealInstanceFactory(ref real);
            var instance = (QueryDefinitionWrapper) QueryDefinitionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref QueryDefinitionWrapper instance, [CallerMemberName] string callerName = "");

        partial void QueryType_SetCondition(ref IQueryDefinition instance, ref IQueryType setValue);
        static partial void RealInstanceFactory(ref QueryDefinition real, [CallerMemberName] string callerName = "");
    }
}