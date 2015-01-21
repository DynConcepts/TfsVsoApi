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
    public partial class ImportEventArgsWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Message_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IImportEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Message; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Severity_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IImportEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Severity; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<ImportEventArgsWrapper> GetIEnumerableInstance() { return new List<ImportEventArgsWrapper> {GetInstance()}; }

        internal static ImportEventArgsWrapper GetInstance()
        {
            ImportEventArgs real = default(ImportEventArgs);
            RealInstanceFactory(ref real);
            var instance = (ImportEventArgsWrapper) ImportEventArgsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ImportEventArgsWrapper instance, [CallerMemberName] string callerName = "");
        partial void Message_SetCondition(ref IImportEventArgs instance, ref String setValue);

        static partial void RealInstanceFactory(ref ImportEventArgs real, [CallerMemberName] string callerName = "");

        partial void Severity_SetCondition(ref IImportEventArgs instance, ref IImportSeverity setValue);
    }
}