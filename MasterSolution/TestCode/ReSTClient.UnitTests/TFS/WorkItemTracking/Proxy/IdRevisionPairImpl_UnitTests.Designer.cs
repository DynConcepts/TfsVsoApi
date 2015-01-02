using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IdRevisionPairImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IdRevisionPairImpl> GetIEnumerableInstance() { return new List<IdRevisionPairImpl> {GetInstance()}; }

        internal static IdRevisionPairImpl GetInstance([CallerMemberName] string callerName = "")
        {
            IdRevisionPairImpl instance = default(IdRevisionPairImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IdRevisionPairImpl instance, [CallerMemberName] string callerName = "");
    }
}