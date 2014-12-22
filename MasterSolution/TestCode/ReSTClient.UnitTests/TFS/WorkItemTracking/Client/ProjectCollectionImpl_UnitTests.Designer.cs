using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ProjectCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<ProjectCollectionImpl> GetIEnumerableInstance() { return new List<ProjectCollectionImpl> {GetInstance()}; }

        internal static ProjectCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            ProjectCollectionImpl instance = default(ProjectCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref ProjectCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}