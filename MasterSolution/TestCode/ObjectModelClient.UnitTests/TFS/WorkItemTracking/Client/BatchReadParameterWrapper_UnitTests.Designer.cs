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
    public partial class BatchReadParameterWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Id_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IBatchReadParameter) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Id; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ProjectHint_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IBatchReadParameter) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    ProjectHint_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.ProjectHint = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.ProjectHint; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Revision_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IBatchReadParameter) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Revision; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<BatchReadParameterWrapper> GetIEnumerableInstance() { return new List<BatchReadParameterWrapper> {GetInstance()}; }

        internal static BatchReadParameterWrapper GetInstance()
        {
            BatchReadParameter real = default(BatchReadParameter);
            RealInstanceFactory(ref real);
            var instance = (BatchReadParameterWrapper) BatchReadParameterWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void Id_SetCondition(ref IBatchReadParameter instance, ref Int32 setValue);
        static partial void InstanceFactory(ref BatchReadParameterWrapper instance, [CallerMemberName] string callerName = "");

        partial void ProjectHint_SetCondition(ref IBatchReadParameter instance, ref Int32 setValue);
        static partial void RealInstanceFactory(ref BatchReadParameter real, [CallerMemberName] string callerName = "");
        partial void Revision_SetCondition(ref IBatchReadParameter instance, ref Int32 setValue);
    }
}