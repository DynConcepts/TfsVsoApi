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
    public partial class ReportingAttributesImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Name_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IReportingAttributes) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Name; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ReferenceName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IReportingAttributes) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ReferenceName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Type_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IReportingAttributes) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Type; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<ReportingAttributesImpl> GetIEnumerableInstance() { return new List<ReportingAttributesImpl> {GetInstance()}; }

        internal static ReportingAttributesImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ReportingAttributesImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref ReportingAttributesImpl instance, [CallerMemberName] string callerName = "");

        partial void Name_SetCondition(ref IReportingAttributes instance, ref String setValue);

        partial void ReferenceName_SetCondition(ref IReportingAttributes instance, ref String setValue);

        partial void Type_SetCondition(ref IReportingAttributes instance, ref IReportingType setValue);
    }
}