using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class FieldFilterImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FieldDefinition_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldFilter) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FieldDefinition; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Value_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldFilter) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    object setValue = default(Object);
                    Value_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Value = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Value; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void FieldDefinition_SetCondition(ref IFieldFilter instance, ref IFieldDefinition setValue);
        internal static IEnumerable<FieldFilterImpl> GetIEnumerableInstance() { return new List<FieldFilterImpl> {GetInstance()}; }

        internal static FieldFilterImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new FieldFilterImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref FieldFilterImpl instance, [CallerMemberName] string callerName = "");
        partial void Value_SetCondition(ref IFieldFilter instance, ref Object setValue);
    }
}