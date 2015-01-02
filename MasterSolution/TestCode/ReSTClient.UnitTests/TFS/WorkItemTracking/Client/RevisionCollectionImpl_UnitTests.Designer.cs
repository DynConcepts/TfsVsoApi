using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RevisionCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<RevisionCollectionImpl> GetIEnumerableInstance() { return new List<RevisionCollectionImpl> {GetInstance()}; }

        internal static RevisionCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            RevisionCollectionImpl instance = default(RevisionCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref RevisionCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}