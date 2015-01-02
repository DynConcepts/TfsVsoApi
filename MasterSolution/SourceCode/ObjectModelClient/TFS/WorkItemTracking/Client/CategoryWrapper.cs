using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class CategoryWrapper.
    /// </summary>
    internal class CategoryWrapper : CategoryWrapper<ICategory, Category>, ICategory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CategoryWrapper(Category instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ICategory, Category>(src => src == null ? null : ((CategoryWrapper) src).r_Instance, src => new CategoryWrapper(src)); }
    }


    /// <summary>
    /// Class CategoryWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class CategoryWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICategory where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean ICategory.Contains(IWorkItemType value)
        {
            bool nativeCallResult = r_Instance.Contains(WorkItemTypeWrapper.GetInstance(value));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the default type of the work item.
        /// </summary>
        /// <value>The default type of the work item.</value>
        IWorkItemType ICategory.DefaultWorkItemType
        {
            get
            {
                WorkItemType nativeCallResult = r_Instance.DefaultWorkItemType;
                IWorkItemType wrappedCallResult = WorkItemTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String ICategory.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        String ICategory.ReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReferenceName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        IEnumerable<IWorkItemType> ICategory.WorkItemTypes
        {
            get
            {
                IEnumerable<WorkItemType> nativeCallResult = r_Instance.WorkItemTypes;
                IEnumerable<IWorkItemType> wrappedCallResult = WorkItemTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CategoryWrapper(Category instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly Category r_Instance;
    }
}