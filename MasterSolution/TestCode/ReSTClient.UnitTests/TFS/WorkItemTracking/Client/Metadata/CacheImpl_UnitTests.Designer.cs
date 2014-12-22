using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CacheImpl_UnitTests : DynTestClassBase
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

        internal static IEnumerable<CacheImpl> GetIEnumerableInstance() { return new List<CacheImpl> {GetInstance()}; }

        internal static CacheImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new CacheImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetSnapshot_PostValidate(ICache instance);
        partial void GetSnapshot_PreCondition(ref ICache instance);
        static partial void InstanceFactory(ref CacheImpl instance, [CallerMemberName] string callerName = "");
    }
}