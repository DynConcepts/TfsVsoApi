using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class AccessMappingWrapper.
    /// </summary>
    internal class AccessMappingWrapper : AccessMappingWrapper<IAccessMapping, AccessMapping>, IAccessMapping
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessMappingWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AccessMappingWrapper(AccessMapping instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IAccessMapping, AccessMapping>(src => src == null ? null : ((AccessMappingWrapper) src).r_Instance, src => new AccessMappingWrapper(src)); }
    }


    /// <summary>
    /// Class AccessMappingWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class AccessMappingWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAccessMapping where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the access point.
        /// </summary>
        /// <value>The access point.</value>
        String IAccessMapping.AccessPoint
        {
            get
            {
                string nativeCallResult = r_Instance.AccessPoint;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String IAccessMapping.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the moniker.
        /// </summary>
        /// <value>The moniker.</value>
        String IAccessMapping.Moniker
        {
            get
            {
                string nativeCallResult = r_Instance.Moniker;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void IAccessMapping.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessMappingWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AccessMappingWrapper(AccessMapping instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly AccessMapping r_Instance;
    }
}