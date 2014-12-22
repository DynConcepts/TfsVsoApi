using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AllowedValuesCollectionWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<AllowedValuesCollectionWrapper> GetIEnumerableInstance() { return new List<AllowedValuesCollectionWrapper> {GetInstance()}; }

        internal static AllowedValuesCollectionWrapper GetInstance()
        {
            AllowedValuesCollection real = default(AllowedValuesCollection);
            RealInstanceFactory(ref real);
            var instance = (AllowedValuesCollectionWrapper) AllowedValuesCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref AllowedValuesCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref AllowedValuesCollection real, [CallerMemberName] string callerName = "");
    }
}