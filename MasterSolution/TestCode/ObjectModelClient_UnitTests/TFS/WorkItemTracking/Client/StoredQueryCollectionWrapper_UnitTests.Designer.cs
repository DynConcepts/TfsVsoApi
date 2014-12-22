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
    public partial class StoredQueryCollectionWrapper_UnitTests : DynTestClassBase
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

        internal static IEnumerable<StoredQueryCollectionWrapper> GetIEnumerableInstance() { return new List<StoredQueryCollectionWrapper> {GetInstance()}; }

        internal static StoredQueryCollectionWrapper GetInstance()
        {
            StoredQueryCollection real = default(StoredQueryCollection);
            RealInstanceFactory(ref real);
            var instance = (StoredQueryCollectionWrapper) StoredQueryCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref StoredQueryCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref StoredQueryCollection real, [CallerMemberName] string callerName = "");
        partial void Refresh_PostValidate(IStoredQueryCollection instance);
        partial void Refresh_PreCondition(ref IStoredQueryCollection instance);
    }
}