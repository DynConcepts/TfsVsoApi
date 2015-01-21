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
    public partial class LinkCollectionWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<LinkCollectionWrapper> GetIEnumerableInstance() { return new List<LinkCollectionWrapper> {GetInstance()}; }

        internal static LinkCollectionWrapper GetInstance()
        {
            LinkCollection real = default(LinkCollection);
            RealInstanceFactory(ref real);
            var instance = (LinkCollectionWrapper) LinkCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref LinkCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref LinkCollection real, [CallerMemberName] string callerName = "");
    }
}