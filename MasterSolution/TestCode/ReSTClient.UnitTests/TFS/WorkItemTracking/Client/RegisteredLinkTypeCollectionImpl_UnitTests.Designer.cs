using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RegisteredLinkTypeCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<RegisteredLinkTypeCollectionImpl> GetIEnumerableInstance() { return new List<RegisteredLinkTypeCollectionImpl> {GetInstance()}; }

        internal static RegisteredLinkTypeCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            RegisteredLinkTypeCollectionImpl instance = default(RegisteredLinkTypeCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref RegisteredLinkTypeCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}