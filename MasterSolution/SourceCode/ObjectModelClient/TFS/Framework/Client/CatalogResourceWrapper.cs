using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class CatalogResourceWrapper.
    /// </summary>
    internal class CatalogResourceWrapper : CatalogResourceWrapper<ICatalogResource, CatalogResource>, ICatalogResource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogResourceWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CatalogResourceWrapper(CatalogResource instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ICatalogResource, CatalogResource>(src => src == null ? null : ((CatalogResourceWrapper) src).r_Instance, src => new CatalogResourceWrapper(src)); }
    }


    /// <summary>
    /// Class CatalogResourceWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class CatalogResourceWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICatalogResource where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        String ICatalogResource.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
            set { r_Instance.Description = value; }
        }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String ICatalogResource.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
            set { r_Instance.DisplayName = value; }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid ICatalogResource.Identifier
        {
            get
            {
                Guid nativeCallResult = r_Instance.Identifier;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the node references.
        /// </summary>
        /// <value>The node references.</value>
        ReadOnlyCollection<ICatalogNode> ICatalogResource.NodeReferences
        {
            get
            {
                ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.NodeReferences;
                ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        IDictionary<String, String> ICatalogResource.Properties
        {
            get
            {
                IDictionary<string, string> nativeCallResult = r_Instance.Properties;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        /// <value>The type of the resource.</value>
        ICatalogResourceType ICatalogResource.ResourceType
        {
            get
            {
                CatalogResourceType nativeCallResult = r_Instance.ResourceType;
                ICatalogResourceType wrappedCallResult = CatalogResourceTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the service references.
        /// </summary>
        /// <value>The service references.</value>
        IDictionary<String, IServiceDefinition> ICatalogResource.ServiceReferences
        {
            get
            {
                IDictionary<string, ServiceDefinition> nativeCallResult = r_Instance.ServiceReferences;
                IDictionary<string, IServiceDefinition> wrappedCallResult = ServiceDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ICatalogResource.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogResourceWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CatalogResourceWrapper(CatalogResource instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly CatalogResource r_Instance;
    }
}