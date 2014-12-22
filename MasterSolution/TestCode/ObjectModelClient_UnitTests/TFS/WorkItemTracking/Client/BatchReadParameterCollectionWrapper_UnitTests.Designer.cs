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
    public partial class BatchReadParameterCollectionWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<BatchReadParameterCollectionWrapper> GetIEnumerableInstance() { return new List<BatchReadParameterCollectionWrapper> {GetInstance()}; }

        internal static BatchReadParameterCollectionWrapper GetInstance()
        {
            var real = new BatchReadParameterCollection();
            RealInstanceFactory(ref real);
            var instance = (BatchReadParameterCollectionWrapper) BatchReadParameterCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref BatchReadParameterCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref BatchReadParameterCollection real, [CallerMemberName] string callerName = "");
    }
}