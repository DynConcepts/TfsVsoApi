using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AllowedValuesCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<AllowedValuesCollectionImpl> GetIEnumerableInstance() { return new List<AllowedValuesCollectionImpl> {GetInstance()}; }

        internal static AllowedValuesCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new AllowedValuesCollectionImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref AllowedValuesCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}