using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.DataStore;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Common.DataStore;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class FieldDefinitionWrapper : FieldDefinitionWrapper<IFieldDefinition, FieldDefinition>, IFieldDefinition
    {
        protected FieldDefinitionWrapper(FieldDefinition instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldDefinition, FieldDefinition>(src => src == null ? null : ((FieldDefinitionWrapper) src).r_Instance, src => new FieldDefinitionWrapper(src)); }
    }


    internal class FieldDefinitionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IFieldDefinition where TInterface : class where TWrapper : class
    {
        IAllowedValuesCollection IFieldDefinition.AllowedValues
        {
            get
            {
                AllowedValuesCollection nativeCallResult = r_Instance.AllowedValues;
                IAllowedValuesCollection wrappedCallResult = AllowedValuesCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IFieldDefinition.CanSortBy
        {
            get
            {
                bool nativeCallResult = r_Instance.CanSortBy;
                return nativeCallResult;
            }
        }

        IFieldType IFieldDefinition.FieldType
        {
            get
            {
                FieldType nativeCallResult = r_Instance.FieldType;
                IFieldType wrappedCallResult = FieldTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IAllowedValuesCollection IFieldDefinition.FilteredAllowedValues(IFieldFilterList filters)
        {
            AllowedValuesCollection nativeCallResult = r_Instance.FilteredAllowedValues(FieldFilterListWrapper.GetInstance(filters));
            IAllowedValuesCollection wrappedCallResult = AllowedValuesCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        String IFieldDefinition.HelpText
        {
            get
            {
                string nativeCallResult = r_Instance.HelpText;
                return nativeCallResult;
            }
        }

        Int32 IFieldDefinition.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsCloneable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsCloneable;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsComputed
        {
            get
            {
                bool nativeCallResult = r_Instance.IsComputed;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsCoreField
        {
            get
            {
                bool nativeCallResult = r_Instance.IsCoreField;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsEditable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEditable;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsIndexed
        {
            get
            {
                bool nativeCallResult = r_Instance.IsIndexed;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsInternal
        {
            get
            {
                bool nativeCallResult = r_Instance.IsInternal;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsLongText
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLongText;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsQueryable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsQueryable;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsReportable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsReportable;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsUsedInGlobalWorkflow
        {
            get
            {
                bool nativeCallResult = r_Instance.IsUsedInGlobalWorkflow;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsUsedInWorkItemType
        {
            get
            {
                bool nativeCallResult = r_Instance.IsUsedInWorkItemType;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.IsUserNameField
        {
            get
            {
                bool nativeCallResult = r_Instance.IsUserNameField;
                return nativeCallResult;
            }
        }

        String IFieldDefinition.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        IValuesCollection IFieldDefinition.ProhibitedValues
        {
            get
            {
                ValuesCollection nativeCallResult = r_Instance.ProhibitedValues;
                IValuesCollection wrappedCallResult = ValuesCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IPsFieldDefinitionTypeEnum IFieldDefinition.PsFieldType
        {
            get
            {
                PsFieldDefinitionTypeEnum nativeCallResult = r_Instance.PsFieldType;
                IPsFieldDefinitionTypeEnum wrappedCallResult = PsFieldDefinitionTypeEnumWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Int32 IFieldDefinition.PsReportingFormula
        {
            get
            {
                int nativeCallResult = r_Instance.PsReportingFormula;
                return nativeCallResult;
            }
        }

        Int32 IFieldDefinition.PsReportingType
        {
            get
            {
                int nativeCallResult = r_Instance.PsReportingType;
                return nativeCallResult;
            }
        }

        String IFieldDefinition.ReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReferenceName;
                return nativeCallResult;
            }
        }

        IReportingAttributes IFieldDefinition.ReportingAttributes
        {
            get
            {
                ReportingAttributes nativeCallResult = r_Instance.ReportingAttributes;
                IReportingAttributes wrappedCallResult = ReportingAttributesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IFieldDefinition.ReportingName
        {
            get
            {
                string nativeCallResult = r_Instance.ReportingName;
                return nativeCallResult;
            }
        }

        String IFieldDefinition.ReportingReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReportingReferenceName;
                return nativeCallResult;
            }
        }

        Boolean IFieldDefinition.SupportsTextQuery
        {
            get
            {
                bool nativeCallResult = r_Instance.SupportsTextQuery;
                return nativeCallResult;
            }
        }

        Type IFieldDefinition.SystemType
        {
            get
            {
                Type nativeCallResult = r_Instance.SystemType;
                return nativeCallResult;
            }
        }

        IFieldUsages IFieldDefinition.Usage
        {
            get
            {
                FieldUsages nativeCallResult = r_Instance.Usage;
                IFieldUsages wrappedCallResult = FieldUsagesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IWorkItemStore IFieldDefinition.WorkItemStore
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.WorkItemStore;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected FieldDefinitionWrapper(FieldDefinition instance) { r_Instance = instance; }
        protected readonly FieldDefinition r_Instance;
    }
}