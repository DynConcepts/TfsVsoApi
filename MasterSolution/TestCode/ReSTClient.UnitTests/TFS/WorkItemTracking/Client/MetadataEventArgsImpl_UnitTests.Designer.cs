using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class MetadataEventArgsImpl_UnitTests : DynTestClassBase
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

        internal static IEnumerable<MetadataEventArgsImpl> GetIEnumerableInstance() { return new List<MetadataEventArgsImpl> {GetInstance()}; }

        internal static MetadataEventArgsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new MetadataEventArgsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref MetadataEventArgsImpl instance, [CallerMemberName] string callerName = "");

        partial void MetadataChangeFlags_SetCondition(ref IMetadataEventArgs instance, ref IMetadataChangeTypes setValue);
    }
}