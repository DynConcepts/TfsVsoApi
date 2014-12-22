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
    public partial class CategoryCollectionWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<CategoryCollectionWrapper> GetIEnumerableInstance() { return new List<CategoryCollectionWrapper> {GetInstance()}; }

        internal static CategoryCollectionWrapper GetInstance()
        {
            CategoryCollection real = default(CategoryCollection);
            RealInstanceFactory(ref real);
            var instance = (CategoryCollectionWrapper) CategoryCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref CategoryCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref CategoryCollection real, [CallerMemberName] string callerName = "");
    }
}