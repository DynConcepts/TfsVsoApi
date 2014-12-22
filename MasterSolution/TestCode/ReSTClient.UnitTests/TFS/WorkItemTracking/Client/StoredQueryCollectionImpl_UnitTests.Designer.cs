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
    public partial class StoredQueryCollectionImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Refresh_UnitTest()
        {
            ExecuteMethod(
                () => { return (IStoredQueryCollection) GetInstance(); },
                instance => { Refresh_PreCondition(ref instance); },
                instance => { instance.Refresh(); },
                instance => { Refresh_PostValidate(instance); });
        }

        internal static IEnumerable<StoredQueryCollectionImpl> GetIEnumerableInstance() { return new List<StoredQueryCollectionImpl> {GetInstance()}; }

        internal static StoredQueryCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            StoredQueryCollectionImpl instance = default(StoredQueryCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref StoredQueryCollectionImpl instance, [CallerMemberName] string callerName = "");

        partial void Refresh_PostValidate(IStoredQueryCollection instance);
        partial void Refresh_PreCondition(ref IStoredQueryCollection instance);
    }
}