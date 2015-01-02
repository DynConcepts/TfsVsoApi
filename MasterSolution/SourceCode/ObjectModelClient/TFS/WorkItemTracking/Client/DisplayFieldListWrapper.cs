using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class DisplayFieldListWrapper.
    /// </summary>
    internal class DisplayFieldListWrapper : DisplayFieldListWrapper<IDisplayFieldList, DisplayFieldList>, IDisplayFieldList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayFieldListWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected DisplayFieldListWrapper(DisplayFieldList instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IDisplayFieldList, DisplayFieldList>(src => src == null ? null : ((DisplayFieldListWrapper) src).r_Instance, src => new DisplayFieldListWrapper(src)); }
    }


    /// <summary>
    /// Class DisplayFieldListWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class DisplayFieldListWrapper<TWrapper, TInterface> : OrderedVariableSizeListWrapper<TWrapper, TInterface>, IDisplayFieldList where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Adds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IDisplayFieldList.Add(IFieldDefinition value)
        {
            int nativeCallResult = r_Instance.Add(FieldDefinitionWrapper.GetInstance(value));
            return nativeCallResult;
        }


        /// <summary>
        /// Adds the specified field name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Int32.</returns>
        Int32 IDisplayFieldList.Add(String fieldName)
        {
            int nativeCallResult = r_Instance.Add(fieldName);
            return nativeCallResult;
        }

        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IDisplayFieldList.Contains(IFieldDefinition value)
        {
            bool nativeCallResult = r_Instance.Contains(FieldDefinitionWrapper.GetInstance(value));
            return nativeCallResult;
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IDisplayFieldList.IndexOf(IFieldDefinition value)
        {
            int nativeCallResult = r_Instance.IndexOf(FieldDefinitionWrapper.GetInstance(value));
            return nativeCallResult;
        }

        /// <summary>
        /// Indexes the of field identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Int32.</returns>
        Int32 IDisplayFieldList.IndexOfFieldId(Int32 id)
        {
            int nativeCallResult = r_Instance.IndexOfFieldId(id);
            return nativeCallResult;
        }

        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="value">The value.</param>
        void IDisplayFieldList.Insert(Int32 index, IFieldDefinition value) { r_Instance.Insert(index, FieldDefinitionWrapper.GetInstance(value)); }


        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="fieldName">Name of the field.</param>
        void IDisplayFieldList.Insert(Int32 index, String fieldName) { r_Instance.Insert(index, fieldName); }

        /// <summary>
        /// Gets or sets the <see cref="IFieldDefinition" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition IDisplayFieldList.this[Int32 index]
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance[index];
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                FieldDefinition nativeValue = FieldDefinitionWrapper.GetInstance(value);
                r_Instance[index] = nativeValue;
            }
        }

        /// <summary>
        /// Removes the specified field name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        void IDisplayFieldList.Remove(String fieldName) { r_Instance.Remove(fieldName); }
        /// <summary>
        /// Removes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        void IDisplayFieldList.Remove(IFieldDefinition value) { r_Instance.Remove(FieldDefinitionWrapper.GetInstance(value)); }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayFieldListWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected DisplayFieldListWrapper(DisplayFieldList instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly DisplayFieldList r_Instance;
    }
}