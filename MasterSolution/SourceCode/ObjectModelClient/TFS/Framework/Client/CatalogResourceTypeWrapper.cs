using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class CatalogResourceTypeWrapper.
    /// </summary>
    internal class CatalogResourceTypeWrapper : CatalogResourceTypeWrapper<ICatalogResourceType, CatalogResourceType>, ICatalogResourceType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogResourceTypeWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CatalogResourceTypeWrapper(CatalogResourceType instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ICatalogResourceType, CatalogResourceType>(src => src == null ? null : ((CatalogResourceTypeWrapper) src).r_Instance, src => new CatalogResourceTypeWrapper(src)); }
    }


    /// <summary>
    /// Class CatalogResourceTypeWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class CatalogResourceTypeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICatalogResourceType where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        String ICatalogResourceType.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String ICatalogResourceType.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid ICatalogResourceType.Identifier
        {
            get
            {
                Guid nativeCallResult = r_Instance.Identifier;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ICatalogResourceType.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogResourceTypeWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CatalogResourceTypeWrapper(CatalogResourceType instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly CatalogResourceType r_Instance;
    }
}