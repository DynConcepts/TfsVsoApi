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
    public partial class SortFieldListWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<SortFieldListWrapper> GetIEnumerableInstance() { return new List<SortFieldListWrapper> {GetInstance()}; }

        internal static SortFieldListWrapper GetInstance()
        {
            SortFieldList real = default(SortFieldList);
            RealInstanceFactory(ref real);
            var instance = (SortFieldListWrapper) SortFieldListWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref SortFieldListWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref SortFieldList real, [CallerMemberName] string callerName = "");
    }
}