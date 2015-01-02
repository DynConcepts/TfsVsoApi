using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class SortFieldListImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<SortFieldListImpl> GetIEnumerableInstance() { return new List<SortFieldListImpl> {GetInstance()}; }

        internal static SortFieldListImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new SortFieldListImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref SortFieldListImpl instance, [CallerMemberName] string callerName = "");
    }
}