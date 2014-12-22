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
    public partial class HyperlinkWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<HyperlinkWrapper> GetIEnumerableInstance() { return new List<HyperlinkWrapper> {GetInstance()}; }

        internal static HyperlinkWrapper GetInstance()
        {
            Hyperlink real = default(Hyperlink);
            RealInstanceFactory(ref real);
            var instance = (HyperlinkWrapper) HyperlinkWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref HyperlinkWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref Hyperlink real, [CallerMemberName] string callerName = "");
    }
}