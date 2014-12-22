using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class MetadataTableHaveEntryImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RowVersion_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IMetadataTableHaveEntry) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    long setValue = default(Int64);
                    RowVersion_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.RowVersion = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.RowVersion; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TableName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IMetadataTableHaveEntry) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    TableName_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.TableName = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.TableName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<MetadataTableHaveEntryImpl> GetIEnumerableInstance() { return new List<MetadataTableHaveEntryImpl> {GetInstance()}; }

        internal static MetadataTableHaveEntryImpl GetInstance([CallerMemberName] string callerName = "")
        {
            MetadataTableHaveEntryImpl instance = default(MetadataTableHaveEntryImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref MetadataTableHaveEntryImpl instance, [CallerMemberName] string callerName = "");

        partial void RowVersion_SetCondition(ref IMetadataTableHaveEntry instance, ref Int64 setValue);

        partial void TableName_SetCondition(ref IMetadataTableHaveEntry instance, ref String setValue);
    }
}