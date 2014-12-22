using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class FieldDefinitionImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AllowedValues_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AllowedValues; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CanSortBy_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CanSortBy; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FieldType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FieldType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FilteredAllowedValues_UnitTest()
        {
            IFieldFilterList filters = default(IFieldFilterList);
            ExecuteMethod(
                () => { return (IFieldDefinition) GetInstance(); },
                instance =>
                {
                    filters = FieldFilterListImpl_UnitTests.GetInstance();
                    FilteredAllowedValues_PreCondition(ref instance, ref filters);
                },
                instance => { instance.FilteredAllowedValues(filters); },
                instance => { FilteredAllowedValues_PostValidate(instance, filters); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HelpText_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.HelpText; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsCloneable_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsCloneable; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsComputed_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsComputed; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsCoreField_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsCoreField; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsIndexed_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsIndexed; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsInternal_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsInternal; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsLongText_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsLongText; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsQueryable_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsQueryable; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsReportable_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsReportable; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsUsedInGlobalWorkflow_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsUsedInGlobalWorkflow; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsUsedInWorkItemType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsUsedInWorkItemType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsUserNameField_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsUserNameField; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ProhibitedValues_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ProhibitedValues; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PsFieldType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.PsFieldType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PsReportingFormula_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.PsReportingFormula; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PsReportingType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.PsReportingType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ReportingAttributes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ReportingAttributes; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ReportingName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ReportingName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ReportingReferenceName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ReportingReferenceName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SupportsTextQuery_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SupportsTextQuery; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SystemType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SystemType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Usage_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Usage; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WorkItemStore_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFieldDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WorkItemStore; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AllowedValues_SetCondition(ref IFieldDefinition instance, ref IAllowedValuesCollection setValue);

        partial void CanSortBy_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void FieldType_SetCondition(ref IFieldDefinition instance, ref IFieldType setValue);
        partial void FilteredAllowedValues_PostValidate(IFieldDefinition instance, IFieldFilterList filters);
        partial void FilteredAllowedValues_PreCondition(ref IFieldDefinition instance, ref IFieldFilterList filters);
        internal static IEnumerable<FieldDefinitionImpl> GetIEnumerableInstance() { return new List<FieldDefinitionImpl> {GetInstance()}; }

        internal static FieldDefinitionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            FieldDefinitionImpl instance = FieldDefinitionImpl.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void HelpText_SetCondition(ref IFieldDefinition instance, ref String setValue);
        static partial void InstanceFactory(ref FieldDefinitionImpl instance, [CallerMemberName] string callerName = "");

        partial void IsCloneable_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void IsComputed_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void IsCoreField_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void IsIndexed_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);

        partial void IsInternal_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void IsLongText_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void IsQueryable_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);

        partial void IsReportable_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void IsUsedInGlobalWorkflow_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void IsUsedInWorkItemType_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void IsUserNameField_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        static partial void JsonSource(ref JToken json);
        partial void ProhibitedValues_SetCondition(ref IFieldDefinition instance, ref IValuesCollection setValue);
        partial void PsFieldType_SetCondition(ref IFieldDefinition instance, ref IPsFieldDefinitionTypeEnum setValue);
        partial void PsReportingFormula_SetCondition(ref IFieldDefinition instance, ref Int32 setValue);
        partial void PsReportingType_SetCondition(ref IFieldDefinition instance, ref Int32 setValue);
        partial void ReportingAttributes_SetCondition(ref IFieldDefinition instance, ref IReportingAttributes setValue);

        partial void ReportingName_SetCondition(ref IFieldDefinition instance, ref String setValue);

        partial void ReportingReferenceName_SetCondition(ref IFieldDefinition instance, ref String setValue);
        partial void SupportsTextQuery_SetCondition(ref IFieldDefinition instance, ref Boolean setValue);
        partial void SystemType_SetCondition(ref IFieldDefinition instance, ref Type setValue);
        partial void Usage_SetCondition(ref IFieldDefinition instance, ref IFieldUsages setValue);

        partial void WorkItemStore_SetCondition(ref IFieldDefinition instance, ref IWorkItemStore setValue);
    }
}