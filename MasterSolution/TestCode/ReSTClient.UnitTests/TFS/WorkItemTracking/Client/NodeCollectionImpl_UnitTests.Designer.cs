using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class NodeCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<NodeCollectionImpl> GetIEnumerableInstance() { return new List<NodeCollectionImpl> {GetInstance()}; }

        internal static NodeCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            NodeCollectionImpl instance = default(NodeCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref NodeCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}