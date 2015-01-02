using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.DataStore;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Common.DataStore;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldDefinitionWrapper.
    /// </summary>
    internal class FieldDefinitionWrapper : FieldDefinitionWrapper<IFieldDefinition, FieldDefinition>, IFieldDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDefinitionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldDefinitionWrapper(FieldDefinition instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldDefinition, FieldDefinition>(src => src == null ? null : ((FieldDefinitionWrapper) src).r_Instance, src => new FieldDefinitionWrapper(src)); }
    }


    /// <summary>
    /// Class FieldDefinitionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class FieldDefinitionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IFieldDefinition where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the allowed values.
        /// </summary>
        /// <value>The allowed values.</value>
        IAllowedValuesCollection IFieldDefinition.AllowedValues
        {
            get
            {
                AllowedValuesCollection nativeCallResult = r_Instance.AllowedValues;
                IAllowedValuesCollection wrappedCallResult = AllowedValuesCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the can sort by.
        /// </summary>
        /// <value>The can sort by.</value>
        Boolean IFieldDefinition.CanSortBy
        {
            get
            {
                bool nativeCallResult = r_Instance.CanSortBy;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        IFieldType IFieldDefinition.FieldType
        {
            get
            {
                FieldType nativeCallResult = r_Instance.FieldType;
                IFieldType wrappedCallResult = FieldTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Filtereds the allowed values.
        /// </summary>
        /// <param name="filters">The filters.</param>
        /// <returns>IAllowedValuesCollection.</returns>
        IAllowedValuesCollection IFieldDefinition.FilteredAllowedValues(IFieldFilterList filters)
        {
            AllowedValuesCollection nativeCallResult = r_Instance.FilteredAllowedValues(FieldFilterListWrapper.GetInstance(filters));
            IAllowedValuesCollection wrappedCallResult = AllowedValuesCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the help text.
        /// </summary>
        /// <value>The help text.</value>
        String IFieldDefinition.HelpText
        {
            get
            {
                string nativeCallResult = r_Instance.HelpText;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 IFieldDefinition.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is cloneable.
        /// </summary>
        /// <value>The is cloneable.</value>
        Boolean IFieldDefinition.IsCloneable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsCloneable;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is computed.
        /// </summary>
        /// <value>The is computed.</value>
        Boolean IFieldDefinition.IsComputed
        {
            get
            {
                bool nativeCallResult = r_Instance.IsComputed;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is core field.
        /// </summary>
        /// <value>The is core field.</value>
        Boolean IFieldDefinition.IsCoreField
        {
            get
            {
                bool nativeCallResult = r_Instance.IsCoreField;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is editable.
        /// </summary>
        /// <value>The is editable.</value>
        Boolean IFieldDefinition.IsEditable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEditable;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is indexed.
        /// </summary>
        /// <value>The is indexed.</value>
        Boolean IFieldDefinition.IsIndexed
        {
            get
            {
                bool nativeCallResult = r_Instance.IsIndexed;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is internal.
        /// </summary>
        /// <value>The is internal.</value>
        Boolean IFieldDefinition.IsInternal
        {
            get
            {
                bool nativeCallResult = r_Instance.IsInternal;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is long text.
        /// </summary>
        /// <value>The is long text.</value>
        Boolean IFieldDefinition.IsLongText
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLongText;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is queryable.
        /// </summary>
        /// <value>The is queryable.</value>
        Boolean IFieldDefinition.IsQueryable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsQueryable;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is reportable.
        /// </summary>
        /// <value>The is reportable.</value>
        Boolean IFieldDefinition.IsReportable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsReportable;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is used in global workflow.
        /// </summary>
        /// <value>The is used in global workflow.</value>
        Boolean IFieldDefinition.IsUsedInGlobalWorkflow
        {
            get
            {
                bool nativeCallResult = r_Instance.IsUsedInGlobalWorkflow;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the type of the is used in work item.
        /// </summary>
        /// <value>The type of the is used in work item.</value>
        Boolean IFieldDefinition.IsUsedInWorkItemType
        {
            get
            {
                bool nativeCallResult = r_Instance.IsUsedInWorkItemType;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is user name field.
        /// </summary>
        /// <value>The is user name field.</value>
        Boolean IFieldDefinition.IsUserNameField
        {
            get
            {
                bool nativeCallResult = r_Instance.IsUserNameField;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String IFieldDefinition.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the prohibited values.
        /// </summary>
        /// <value>The prohibited values.</value>
        IValuesCollection IFieldDefinition.ProhibitedValues
        {
            get
            {
                ValuesCollection nativeCallResult = r_Instance.ProhibitedValues;
                IValuesCollection wrappedCallResult = ValuesCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the type of the ps field.
        /// </summary>
        /// <value>The type of the ps field.</value>
        IPsFieldDefinitionTypeEnum IFieldDefinition.PsFieldType
        {
            get
            {
                PsFieldDefinitionTypeEnum nativeCallResult = r_Instance.PsFieldType;
                IPsFieldDefinitionTypeEnum wrappedCallResult = PsFieldDefinitionTypeEnumWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the ps reporting formula.
        /// </summary>
        /// <value>The ps reporting formula.</value>
        Int32 IFieldDefinition.PsReportingFormula
        {
            get
            {
                int nativeCallResult = r_Instance.PsReportingFormula;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the type of the ps reporting.
        /// </summary>
        /// <value>The type of the ps reporting.</value>
        Int32 IFieldDefinition.PsReportingType
        {
            get
            {
                int nativeCallResult = r_Instance.PsReportingType;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        String IFieldDefinition.ReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReferenceName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the reporting attributes.
        /// </summary>
        /// <value>The reporting attributes.</value>
        IReportingAttributes IFieldDefinition.ReportingAttributes
        {
            get
            {
                ReportingAttributes nativeCallResult = r_Instance.ReportingAttributes;
                IReportingAttributes wrappedCallResult = ReportingAttributesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the name of the reporting.
        /// </summary>
        /// <value>The name of the reporting.</value>
        String IFieldDefinition.ReportingName
        {
            get
            {
                string nativeCallResult = r_Instance.ReportingName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the name of the reporting reference.
        /// </summary>
        /// <value>The name of the reporting reference.</value>
        String IFieldDefinition.ReportingReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReportingReferenceName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the supports text query.
        /// </summary>
        /// <value>The supports text query.</value>
        Boolean IFieldDefinition.SupportsTextQuery
        {
            get
            {
                bool nativeCallResult = r_Instance.SupportsTextQuery;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the type of the system.
        /// </summary>
        /// <value>The type of the system.</value>
        Type IFieldDefinition.SystemType
        {
            get
            {
                Type nativeCallResult = r_Instance.SystemType;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the usage.
        /// </summary>
        /// <value>The usage.</value>
        IFieldUsages IFieldDefinition.Usage
        {
            get
            {
                FieldUsages nativeCallResult = r_Instance.Usage;
                IFieldUsages wrappedCallResult = FieldUsagesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the work item store.
        /// </summary>
        /// <value>The work item store.</value>
        IWorkItemStore IFieldDefinition.WorkItemStore
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.WorkItemStore;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDefinitionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldDefinitionWrapper(FieldDefinition instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly FieldDefinition r_Instance;
    }
}