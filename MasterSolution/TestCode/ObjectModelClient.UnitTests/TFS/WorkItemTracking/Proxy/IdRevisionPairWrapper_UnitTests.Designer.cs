using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IdRevisionPairWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IdRevisionPairWrapper> GetIEnumerableInstance() { return new List<IdRevisionPairWrapper> {GetInstance()}; }

        internal static IdRevisionPairWrapper GetInstance()
        {
            IdRevisionPair real = default(IdRevisionPair);
            RealInstanceFactory(ref real);
            IdRevisionPairWrapper instance = IdRevisionPairWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            return instance;
        }

        static partial void InstanceFactory(ref IdRevisionPairWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref IdRevisionPair real, [CallerMemberName] string callerName = "");
    }
}