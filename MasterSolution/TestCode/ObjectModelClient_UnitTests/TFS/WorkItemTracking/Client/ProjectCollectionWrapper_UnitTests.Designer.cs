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
    public partial class ProjectCollectionWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<ProjectCollectionWrapper> GetIEnumerableInstance() { return new List<ProjectCollectionWrapper> {GetInstance()}; }

        internal static ProjectCollectionWrapper GetInstance()
        {
            ProjectCollection real = default(ProjectCollection);
            RealInstanceFactory(ref real);
            var instance = (ProjectCollectionWrapper) ProjectCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ProjectCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref ProjectCollection real, [CallerMemberName] string callerName = "");
    }
}