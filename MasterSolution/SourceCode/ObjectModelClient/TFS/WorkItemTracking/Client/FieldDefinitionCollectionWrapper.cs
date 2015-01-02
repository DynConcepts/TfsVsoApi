using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldDefinitionCollectionWrapper.
    /// </summary>
    internal class FieldDefinitionCollectionWrapper : FieldDefinitionCollectionWrapper<IFieldDefinitionCollection, FieldDefinitionCollection>, IFieldDefinitionCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDefinitionCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldDefinitionCollectionWrapper(FieldDefinitionCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldDefinitionCollection, FieldDefinitionCollection>(src => src == null ? null : ((FieldDefinitionCollectionWrapper) src).r_Instance, src => new FieldDefinitionCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class FieldDefinitionCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class FieldDefinitionCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, FieldDefinition, IFieldDefinition>, IFieldDefinitionCollection
        where TInterface : class
        where TWrapper : class
    {
        /// <summary>
        /// Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldDefinitionCollection.Contains(String name)
        {
            bool nativeCallResult = r_Instance.Contains(name);
            return nativeCallResult;
        }


        /// <summary>
        /// Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldDefinitionCollection.Contains(Int32 id)
        {
            bool nativeCallResult = r_Instance.Contains(id);
            return nativeCallResult;
        }


        /// <summary>
        /// Determines whether [contains] [the specified field definition].
        /// </summary>
        /// <param name="fieldDefinition">The field definition.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldDefinitionCollection.Contains(IFieldDefinition fieldDefinition)
        {
            bool nativeCallResult = r_Instance.Contains(FieldDefinitionWrapper.GetInstance(fieldDefinition));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition IFieldDefinitionCollection.GetById(Int32 id)
        {
            FieldDefinition nativeCallResult = r_Instance.GetById(id);
            IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="fieldDefinition">The field definition.</param>
        /// <returns>Int32.</returns>
        Int32 IFieldDefinitionCollection.IndexOf(IFieldDefinition fieldDefinition)
        {
            int nativeCallResult = r_Instance.IndexOf(FieldDefinitionWrapper.GetInstance(fieldDefinition));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the <see cref="IFieldDefinition" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition IFieldDefinitionCollection.this[Int32 index]
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance[index];
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the <see cref="IFieldDefinition" /> with the specified core field.
        /// </summary>
        /// <param name="coreField">The core field.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition IFieldDefinitionCollection.this[ICoreField coreField]
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance[CoreFieldWrapper.GetInstance(coreField)];
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the <see cref="IFieldDefinition" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition IFieldDefinitionCollection.this[String name]
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance[name];
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition IFieldDefinitionCollection.TryGetById(Int32 id)
        {
            FieldDefinition nativeCallResult = r_Instance.TryGetById(id);
            IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Tries the name of the get by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition IFieldDefinitionCollection.TryGetByName(String name)
        {
            FieldDefinition nativeCallResult = r_Instance.TryGetByName(name);
            IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDefinitionCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldDefinitionCollectionWrapper(FieldDefinitionCollection instance)
            : base(instance, o => FieldDefinitionWrapper.GetWrapper((FieldDefinition) o)) { r_Instance = instance; }

        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly FieldDefinitionCollection r_Instance;
    }
}