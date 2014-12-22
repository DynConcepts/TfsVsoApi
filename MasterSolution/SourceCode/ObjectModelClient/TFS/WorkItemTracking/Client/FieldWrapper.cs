using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class FieldWrapper : FieldWrapper<IField, Field>, IField
    {
        protected FieldWrapper(Field instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IField, Field>(src => src == null ? null : ((FieldWrapper) src).r_Instance, src => new FieldWrapper(src)); }
    }


    internal class FieldWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IField where TInterface : class where TWrapper : class
    {
        IAllowedValuesCollection IField.AllowedValues
        {
            get
            {
                AllowedValuesCollection nativeCallResult = r_Instance.AllowedValues;
                IAllowedValuesCollection wrappedCallResult = AllowedValuesCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IFieldDefinition IField.FieldDefinition
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance.FieldDefinition;
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IField.HasAllowedValuesList
        {
            get
            {
                bool nativeCallResult = r_Instance.HasAllowedValuesList;
                return nativeCallResult;
            }
        }

        Boolean IField.HasPatternMatch
        {
            get
            {
                bool nativeCallResult = r_Instance.HasPatternMatch;
                return nativeCallResult;
            }
        }

        Int32 IField.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        Boolean IField.IsChangedByUser
        {
            get
            {
                bool nativeCallResult = r_Instance.IsChangedByUser;
                return nativeCallResult;
            }
        }

        Boolean IField.IsChangedInRevision
        {
            get
            {
                bool nativeCallResult = r_Instance.IsChangedInRevision;
                return nativeCallResult;
            }
        }

        Boolean IField.IsComputed
        {
            get
            {
                bool nativeCallResult = r_Instance.IsComputed;
                return nativeCallResult;
            }
        }

        Boolean IField.IsDirty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDirty;
                return nativeCallResult;
            }
        }

        Boolean IField.IsEditable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEditable;
                return nativeCallResult;
            }
        }

        Boolean IField.IsLimitedToAllowedValues
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLimitedToAllowedValues;
                return nativeCallResult;
            }
        }

        Boolean IField.IsRequired
        {
            get
            {
                bool nativeCallResult = r_Instance.IsRequired;
                return nativeCallResult;
            }
        }

        Boolean IField.IsValid
        {
            get
            {
                bool nativeCallResult = r_Instance.IsValid;
                return nativeCallResult;
            }
        }

        String IField.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        Object IField.OriginalValue
        {
            get
            {
                object nativeCallResult = r_Instance.OriginalValue;
                return nativeCallResult;
            }
        }

        IValuesCollection IField.ProhibitedValues
        {
            get
            {
                ValuesCollection nativeCallResult = r_Instance.ProhibitedValues;
                IValuesCollection wrappedCallResult = ValuesCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IField.ReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReferenceName;
                return nativeCallResult;
            }
        }

        IFieldStatus IField.Status
        {
            get
            {
                FieldStatus nativeCallResult = r_Instance.Status;
                IFieldStatus wrappedCallResult = FieldStatusWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Object IField.Value
        {
            get
            {
                object nativeCallResult = r_Instance.Value;
                return nativeCallResult;
            }
            set { r_Instance.Value = value; }
        }

        Object IField.ValueWithServerDefault
        {
            get
            {
                object nativeCallResult = r_Instance.ValueWithServerDefault;
                return nativeCallResult;
            }
        }

        IWorkItem IField.WorkItem
        {
            get
            {
                WorkItem nativeCallResult = r_Instance.WorkItem;
                IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected FieldWrapper(Field instance) { r_Instance = instance; }
        protected readonly Field r_Instance;
    }
}