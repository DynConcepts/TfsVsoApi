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
    internal partial class ServiceDefinitionWrapper : ServiceDefinitionWrapper<IServiceDefinition, ServiceDefinition>, IServiceDefinition
    {
        protected ServiceDefinitionWrapper(ServiceDefinition instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IServiceDefinition, ServiceDefinition>(src => src == null ? null : ((ServiceDefinitionWrapper) src).r_Instance, src => new ServiceDefinitionWrapper(src)); }
    }


    internal class ServiceDefinitionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IServiceDefinition where TInterface : class where TWrapper : class
    {
        void IServiceDefinition.AddLocationMapping(IAccessMapping accessMapping, String location) { r_Instance.AddLocationMapping(AccessMappingWrapper.GetInstance(accessMapping), location); }

        String IServiceDefinition.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
            set { r_Instance.Description = value; }
        }

        String IServiceDefinition.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
            set { r_Instance.DisplayName = value; }
        }


        ILocationMapping IServiceDefinition.GetLocationMapping(IAccessMapping accessMapping)
        {
            LocationMapping nativeCallResult = r_Instance.GetLocationMapping(AccessMappingWrapper.GetInstance(accessMapping));
            ILocationMapping wrappedCallResult = LocationMappingWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        Guid IServiceDefinition.Identifier
        {
            get
            {
                Guid nativeCallResult = r_Instance.Identifier;
                return nativeCallResult;
            }
            set { r_Instance.Identifier = value; }
        }

        IEnumerable<ILocationMapping> IServiceDefinition.LocationMappings
        {
            get
            {
                IEnumerable<LocationMapping> nativeCallResult = r_Instance.LocationMappings;
                IEnumerable<ILocationMapping> wrappedCallResult = LocationMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IServiceDefinition.RelativePath
        {
            get
            {
                string nativeCallResult = r_Instance.RelativePath;
                return nativeCallResult;
            }
            set { r_Instance.RelativePath = value; }
        }

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

        Boolean IServiceDefinition.RemoveLocationMapping(IAccessMapping accessMapping)
        {
            bool nativeCallResult = r_Instance.RemoveLocationMapping(AccessMappingWrapper.GetInstance(accessMapping));
            return nativeCallResult;
        }

        String IServiceDefinition.ServiceType
        {
            get
            {
                string nativeCallResult = r_Instance.ServiceType;
                return nativeCallResult;
            }
            set { r_Instance.ServiceType = value; }
        }

        void IServiceDefinition.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }

        String IServiceDefinition.ToolType
        {
            get
            {
                string nativeCallResult = r_Instance.ToolType;
                return nativeCallResult;
            }
            set { r_Instance.ToolType = value; }
        }

        protected ServiceDefinitionWrapper(ServiceDefinition instance) { r_Instance = instance; }
        protected readonly ServiceDefinition r_Instance;
    }
}