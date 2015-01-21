using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class MetadataEventArgsWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void MetadataChangeFlags_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IMetadataEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.MetadataChangeFlags; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<MetadataEventArgsWrapper> GetIEnumerableInstance() { return new List<MetadataEventArgsWrapper> {GetInstance()}; }

        internal static MetadataEventArgsWrapper GetInstance()
        {
            MetadataEventArgs real = default(MetadataEventArgs);
            RealInstanceFactory(ref real);
            var instance = (MetadataEventArgsWrapper) MetadataEventArgsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref MetadataEventArgsWrapper instance, [CallerMemberName] string callerName = "");

        partial void MetadataChangeFlags_SetCondition(ref IMetadataEventArgs instance, ref IMetadataChangeTypes setValue);
        static partial void RealInstanceFactory(ref MetadataEventArgs real, [CallerMemberName] string callerName = "");
    }
}