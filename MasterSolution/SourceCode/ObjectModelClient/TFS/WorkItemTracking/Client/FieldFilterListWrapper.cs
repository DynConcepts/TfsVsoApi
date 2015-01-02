using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldFilterListWrapper.
    /// </summary>
    internal class FieldFilterListWrapper : FieldFilterListWrapper<IFieldFilterList, FieldFilterList>, IFieldFilterList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilterListWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldFilterListWrapper(FieldFilterList instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldFilterList, FieldFilterList>(src => src == null ? null : ((FieldFilterListWrapper) src).r_Instance, src => new FieldFilterListWrapper(src)); }
    }


    /// <summary>
    /// Class FieldFilterListWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class FieldFilterListWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, IFieldFilterList where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Adds the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>Int32.</returns>
        Int32 IFieldFilterList.Add(IFieldFilter filter)
        {
            int nativeCallResult = r_Instance.Add(FieldFilterWrapper.GetInstance(filter));
            return nativeCallResult;
        }


        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldFilterList.Contains(IFieldFilter value)
        {
            bool nativeCallResult = r_Instance.Contains(FieldFilterWrapper.GetInstance(value));
            return nativeCallResult;
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>Int32.</returns>
        Int32 IFieldFilterList.IndexOf(IFieldFilter filter)
        {
            int nativeCallResult = r_Instance.IndexOf(FieldFilterWrapper.GetInstance(filter));
            return nativeCallResult;
        }

        /// <summary>
        /// Indexes the of field identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Int32.</returns>
        Int32 IFieldFilterList.IndexOfFieldId(Int32 id)
        {
            int nativeCallResult = r_Instance.IndexOfFieldId(id);
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the <see cref="IFieldFilter" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IFieldFilter.</returns>
        IFieldFilter IFieldFilterList.this[Int32 index]
        {
            get
            {
                FieldFilter nativeCallResult = r_Instance[index];
                IFieldFilter wrappedCallResult = FieldFilterWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Removes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        void IFieldFilterList.Remove(IFieldFilter value) { r_Instance.Remove(FieldFilterWrapper.GetInstance(value)); }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilterListWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldFilterListWrapper(FieldFilterList instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly FieldFilterList r_Instance;
    }
}