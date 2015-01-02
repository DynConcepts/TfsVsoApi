using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class LocationMappingWrapper.
    /// </summary>
    internal class LocationMappingWrapper : LocationMappingWrapper<ILocationMapping, LocationMapping>, ILocationMapping
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationMappingWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected LocationMappingWrapper(LocationMapping instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ILocationMapping, LocationMapping>(src => src == null ? null : ((LocationMappingWrapper) src).r_Instance, src => new LocationMappingWrapper(src)); }
    }


    /// <summary>
    /// Class LocationMappingWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class LocationMappingWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ILocationMapping where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the access mapping.
        /// </summary>
        /// <value>The access mapping.</value>
        IAccessMapping ILocationMapping.AccessMapping
        {
            get
            {
                AccessMapping nativeCallResult = r_Instance.AccessMapping;
                IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>The location.</value>
        String ILocationMapping.Location
        {
            get
            {
                string nativeCallResult = r_Instance.Location;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ILocationMapping.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationMappingWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected LocationMappingWrapper(LocationMapping instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly LocationMapping r_Instance;
    }
}