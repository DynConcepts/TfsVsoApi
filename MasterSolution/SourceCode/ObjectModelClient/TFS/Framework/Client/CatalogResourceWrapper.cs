using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class CatalogResourceWrapper : CatalogResourceWrapper<ICatalogResource, CatalogResource>, ICatalogResource
    {
        protected CatalogResourceWrapper(CatalogResource instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ICatalogResource, CatalogResource>(src => src==null ? null : ((CatalogResourceWrapper) src).r_Instance, src => new CatalogResourceWrapper(src)); }
    }


    internal class CatalogResourceWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICatalogResource where TInterface : class where TWrapper : class
    {
        String ICatalogResource.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
            set { r_Instance.Description = value; }
        }

        String ICatalogResource.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
            set { r_Instance.DisplayName = value; }
        }

        Guid ICatalogResource.Identifier
        {
            get
            {
                Guid nativeCallResult = r_Instance.Identifier;
                return nativeCallResult;
            }
        }

        ReadOnlyCollection<ICatalogNode> ICatalogResource.NodeReferences
        {
            get
            {
                ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.NodeReferences;
                ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IDictionary<String, String> ICatalogResource.Properties
        {
            get
            {
                IDictionary<string, string> nativeCallResult = r_Instance.Properties;
                return nativeCallResult;
            }
        }

        ICatalogResourceType ICatalogResource.ResourceType
        {
            get
            {
                CatalogResourceType nativeCallResult = r_Instance.ResourceType;
                ICatalogResourceType wrappedCallResult = CatalogResourceTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IDictionary<String, IServiceDefinition> ICatalogResource.ServiceReferences
        {
            get
            {
                IDictionary<string, ServiceDefinition> nativeCallResult = r_Instance.ServiceReferences;
                IDictionary<string, IServiceDefinition> wrappedCallResult = ServiceDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void ICatalogResource.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected CatalogResourceWrapper(CatalogResource instance) { r_Instance = instance; }
        protected readonly CatalogResource r_Instance;
    }
}