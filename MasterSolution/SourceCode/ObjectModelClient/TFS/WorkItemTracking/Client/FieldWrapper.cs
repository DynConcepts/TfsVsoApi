using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldWrapper.
    /// </summary>
    internal class FieldWrapper : FieldWrapper<IField, Field>, IField
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldWrapper(Field instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IField, Field>(src => src == null ? null : ((FieldWrapper) src).r_Instance, src => new FieldWrapper(src)); }
    }


    /// <summary>
    /// Class FieldWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class FieldWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IField where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the allowed values.
        /// </summary>
        /// <value>The allowed values.</value>
        IAllowedValuesCollection IField.AllowedValues
        {
            get
            {
                AllowedValuesCollection nativeCallResult = r_Instance.AllowedValues;
                IAllowedValuesCollection wrappedCallResult = AllowedValuesCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the field definition.
        /// </summary>
        /// <value>The field definition.</value>
        IFieldDefinition IField.FieldDefinition
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance.FieldDefinition;
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the has allowed values list.
        /// </summary>
        /// <value>The has allowed values list.</value>
        Boolean IField.HasAllowedValuesList
        {
            get
            {
                bool nativeCallResult = r_Instance.HasAllowedValuesList;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the has pattern match.
        /// </summary>
        /// <value>The has pattern match.</value>
        Boolean IField.HasPatternMatch
        {
            get
            {
                bool nativeCallResult = r_Instance.HasPatternMatch;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 IField.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is changed by user.
        /// </summary>
        /// <value>The is changed by user.</value>
        Boolean IField.IsChangedByUser
        {
            get
            {
                bool nativeCallResult = r_Instance.IsChangedByUser;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is changed in revision.
        /// </summary>
        /// <value>The is changed in revision.</value>
        Boolean IField.IsChangedInRevision
        {
            get
            {
                bool nativeCallResult = r_Instance.IsChangedInRevision;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is computed.
        /// </summary>
        /// <value>The is computed.</value>
        Boolean IField.IsComputed
        {
            get
            {
                bool nativeCallResult = r_Instance.IsComputed;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        Boolean IField.IsDirty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDirty;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is editable.
        /// </summary>
        /// <value>The is editable.</value>
        Boolean IField.IsEditable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEditable;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is limited to allowed values.
        /// </summary>
        /// <value>The is limited to allowed values.</value>
        Boolean IField.IsLimitedToAllowedValues
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLimitedToAllowedValues;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is required.
        /// </summary>
        /// <value>The is required.</value>
        Boolean IField.IsRequired
        {
            get
            {
                bool nativeCallResult = r_Instance.IsRequired;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is valid.
        /// </summary>
        /// <value>The is valid.</value>
        Boolean IField.IsValid
        {
            get
            {
                bool nativeCallResult = r_Instance.IsValid;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String IField.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the original value.
        /// </summary>
        /// <value>The original value.</value>
        Object IField.OriginalValue
        {
            get
            {
                object nativeCallResult = r_Instance.OriginalValue;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the prohibited values.
        /// </summary>
        /// <value>The prohibited values.</value>
        IValuesCollection IField.ProhibitedValues
        {
            get
            {
                ValuesCollection nativeCallResult = r_Instance.ProhibitedValues;
                IValuesCollection wrappedCallResult = ValuesCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        String IField.ReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReferenceName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        IFieldStatus IField.Status
        {
            get
            {
                FieldStatus nativeCallResult = r_Instance.Status;
                IFieldStatus wrappedCallResult = FieldStatusWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        Object IField.Value
        {
            get
            {
                object nativeCallResult = r_Instance.Value;
                return nativeCallResult;
            }
            set { r_Instance.Value = value; }
        }

        /// <summary>
        /// Gets the value with server default.
        /// </summary>
        /// <value>The value with server default.</value>
        Object IField.ValueWithServerDefault
        {
            get
            {
                object nativeCallResult = r_Instance.ValueWithServerDefault;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        IWorkItem IField.WorkItem
        {
            get
            {
                WorkItem nativeCallResult = r_Instance.WorkItem;
                IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldWrapper(Field instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly Field r_Instance;
    }
}