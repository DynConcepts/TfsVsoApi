using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class BatchReadParameterCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<BatchReadParameterCollectionImpl> GetIEnumerableInstance() { return new List<BatchReadParameterCollectionImpl> {GetInstance()}; }

        internal static BatchReadParameterCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            BatchReadParameterCollectionImpl instance = default(BatchReadParameterCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref BatchReadParameterCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}