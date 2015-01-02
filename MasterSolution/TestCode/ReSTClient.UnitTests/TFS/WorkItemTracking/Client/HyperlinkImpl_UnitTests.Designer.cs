using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class HyperlinkImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<HyperlinkImpl> GetIEnumerableInstance() { return new List<HyperlinkImpl> {GetInstance()}; }

        internal static HyperlinkImpl GetInstance([CallerMemberName] string callerName = "")
        {
            HyperlinkImpl instance = default(HyperlinkImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref HyperlinkImpl instance, [CallerMemberName] string callerName = "");
    }
}