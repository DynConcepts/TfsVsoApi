using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CacheWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetSnapshot_UnitTest()
        {
            ExecuteMethod(
                () => { return (ICache) GetInstance(); },
                instance => { GetSnapshot_PreCondition(ref instance); },
                instance => { instance.GetSnapshot(); },
                instance => { GetSnapshot_PostValidate(instance); });
        }

        internal static IEnumerable<CacheWrapper> GetIEnumerableInstance() { return new List<CacheWrapper> {GetInstance()}; }

        internal static CacheWrapper GetInstance()
        {
            Cache real = default(Cache);
            RealInstanceFactory(ref real);
            var instance = (CacheWrapper) CacheWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetSnapshot_PostValidate(ICache instance);
        partial void GetSnapshot_PreCondition(ref ICache instance);
        static partial void InstanceFactory(ref CacheWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref Cache real, [CallerMemberName] string callerName = "");
    }
}