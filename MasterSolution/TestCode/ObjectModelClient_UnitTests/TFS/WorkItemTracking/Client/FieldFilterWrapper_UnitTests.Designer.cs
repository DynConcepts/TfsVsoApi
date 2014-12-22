using System;
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
    public partial class FieldFilterWrapper_UnitTests : DynTestClassBase
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
        internal static IEnumerable<FieldFilterWrapper> GetIEnumerableInstance() { return new List<FieldFilterWrapper> {GetInstance()}; }

        internal static FieldFilterWrapper GetInstance()
        {
            FieldFilter real = default(FieldFilter);
            RealInstanceFactory(ref real);
            var instance = (FieldFilterWrapper) FieldFilterWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref FieldFilterWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref FieldFilter real, [CallerMemberName] string callerName = "");

        partial void Value_SetCondition(ref IFieldFilter instance, ref Object setValue);
    }
}