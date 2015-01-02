using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldCollectionWrapper.
    /// </summary>
    internal class FieldCollectionWrapper : FieldCollectionWrapper<IFieldCollection, FieldCollection>, IFieldCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldCollectionWrapper(FieldCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldCollection, FieldCollection>(src => src == null ? null : ((FieldCollectionWrapper) src).r_Instance, src => new FieldCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class FieldCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class FieldCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, Field, IField>, IFieldCollection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Determines whether [contains] [the specified field name].
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldCollection.Contains(String fieldName)
        {
            bool nativeCallResult = r_Instance.Contains(fieldName);
            return nativeCallResult;
        }


        /// <summary>
        /// Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldCollection.Contains(Int32 id)
        {
            bool nativeCallResult = r_Instance.Contains(id);
            return nativeCallResult;
        }

        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldCollection.Contains(IField value)
        {
            bool nativeCallResult = r_Instance.Contains(FieldWrapper.GetInstance(value));
            return nativeCallResult;
        }


        /// <summary>
        /// Drops the cached data.
        /// </summary>
        void IFieldCollection.DropCachedData() { r_Instance.DropCachedData(); }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IField.</returns>
        IField IFieldCollection.GetById(Int32 id)
        {
            Field nativeCallResult = r_Instance.GetById(id);
            IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IFieldCollection.IndexOf(IField value)
        {
            int nativeCallResult = r_Instance.IndexOf(FieldWrapper.GetInstance(value));
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the <see cref="IField" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IField.</returns>
        IField IFieldCollection.this[Int32 index]
        {
            get
            {
                Field nativeCallResult = r_Instance[index];
                IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the <see cref="IField" /> with the specified core field.
        /// </summary>
        /// <param name="coreField">The core field.</param>
        /// <returns>IField.</returns>
        IField IFieldCollection.this[ICoreField coreField]
        {
            get
            {
                Field nativeCallResult = r_Instance[CoreFieldWrapper.GetInstance(coreField)];
                IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the <see cref="IField" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IField.</returns>
        IField IFieldCollection.this[String name]
        {
            get
            {
                Field nativeCallResult = r_Instance[name];
                IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IField.</returns>
        IField IFieldCollection.TryGetById(Int32 id)
        {
            Field nativeCallResult = r_Instance.TryGetById(id);
            IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldCollectionWrapper(FieldCollection instance) : base(instance, o => FieldWrapper.GetWrapper((Field) o)) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly FieldCollection r_Instance;
    }
}