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
    public partial class RegisteredLinkTypeCollectionWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<RegisteredLinkTypeCollectionWrapper> GetIEnumerableInstance() { return new List<RegisteredLinkTypeCollectionWrapper> {GetInstance()}; }

        internal static RegisteredLinkTypeCollectionWrapper GetInstance()
        {
            RegisteredLinkTypeCollection real = default(RegisteredLinkTypeCollection);
            RealInstanceFactory(ref real);
            var instance = (RegisteredLinkTypeCollectionWrapper) RegisteredLinkTypeCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref RegisteredLinkTypeCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref RegisteredLinkTypeCollection real, [CallerMemberName] string callerName = "");
    }
}