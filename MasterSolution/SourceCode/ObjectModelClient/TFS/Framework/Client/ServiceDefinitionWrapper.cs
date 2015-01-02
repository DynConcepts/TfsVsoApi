using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class ServiceDefinitionWrapper.
    /// </summary>
    internal partial class ServiceDefinitionWrapper : ServiceDefinitionWrapper<IServiceDefinition, ServiceDefinition>, IServiceDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDefinitionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ServiceDefinitionWrapper(ServiceDefinition instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IServiceDefinition, ServiceDefinition>(src => src == null ? null : ((ServiceDefinitionWrapper) src).r_Instance, src => new ServiceDefinitionWrapper(src)); }
    }


    /// <summary>
    /// Class ServiceDefinitionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class ServiceDefinitionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IServiceDefinition where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Adds the location mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <param name="location">The location.</param>
        void IServiceDefinition.AddLocationMapping(IAccessMapping accessMapping, String location) { r_Instance.AddLocationMapping(AccessMappingWrapper.GetInstance(accessMapping), location); }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        String IServiceDefinition.Description
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
        String IServiceDefinition.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
            set { r_Instance.DisplayName = value; }
        }


        /// <summary>
        /// Gets the location mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>ILocationMapping.</returns>
        ILocationMapping IServiceDefinition.GetLocationMapping(IAccessMapping accessMapping)
        {
            LocationMapping nativeCallResult = r_Instance.GetLocationMapping(AccessMappingWrapper.GetInstance(accessMapping));
            ILocationMapping wrappedCallResult = LocationMappingWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid IServiceDefinition.Identifier
        {
            get
            {
                Guid nativeCallResult = r_Instance.Identifier;
                return nativeCallResult;
            }
            set { r_Instance.Identifier = value; }
        }

        /// <summary>
        /// Gets the location mappings.
        /// </summary>
        /// <value>The location mappings.</value>
        IEnumerable<ILocationMapping> IServiceDefinition.LocationMappings
        {
            get
            {
                IEnumerable<LocationMapping> nativeCallResult = r_Instance.LocationMappings;
                IEnumerable<ILocationMapping> wrappedCallResult = LocationMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the relative path.
        /// </summary>
        /// <value>The relative path.</value>
        String IServiceDefinition.RelativePath
        {
            get
            {
                string nativeCallResult = r_Instance.RelativePath;
                return nativeCallResult;
            }
            set { r_Instance.RelativePath = value; }
        }

        /// <summary>
        /// Gets or sets the relative to setting.
        /// </summary>
        /// <value>The relative to setting.</value>
        IRelativeToSetting IServiceDefinition.RelativeToSetting
        {
            get
            {
                RelativeToSetting nativeCallResult = r_Instance.RelativeToSetting;
                IRelativeToSetting wrappedCallResult = RelativeToSettingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                RelativeToSetting nativeValue = RelativeToSettingWrapper.GetInstance(value);

                r_Instance.RelativeToSetting = nativeValue;
            }
        }

        /// <summary>
        /// Removes the location mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>Boolean.</returns>
        Boolean IServiceDefinition.RemoveLocationMapping(IAccessMapping accessMapping)
        {
            bool nativeCallResult = r_Instance.RemoveLocationMapping(AccessMappingWrapper.GetInstance(accessMapping));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets or sets the type of the service.
        /// </summary>
        /// <value>The type of the service.</value>
        String IServiceDefinition.ServiceType
        {
            get
            {
                string nativeCallResult = r_Instance.ServiceType;
                return nativeCallResult;
            }
            set { r_Instance.ServiceType = value; }
        }

        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void IServiceDefinition.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }

        /// <summary>
        /// Gets or sets the type of the tool.
        /// </summary>
        /// <value>The type of the tool.</value>
        String IServiceDefinition.ToolType
        {
            get
            {
                string nativeCallResult = r_Instance.ToolType;
                return nativeCallResult;
            }
            set { r_Instance.ToolType = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDefinitionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ServiceDefinitionWrapper(ServiceDefinition instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ServiceDefinition r_Instance;
    }
}