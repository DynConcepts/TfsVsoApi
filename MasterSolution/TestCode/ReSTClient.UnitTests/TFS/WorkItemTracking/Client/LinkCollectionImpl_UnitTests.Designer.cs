using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class LinkCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<LinkCollectionImpl> GetIEnumerableInstance() { return new List<LinkCollectionImpl> {GetInstance()}; }

        internal static LinkCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            LinkCollectionImpl instance = default(LinkCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref LinkCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}