using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class CatalogResourceTypeWrapper : CatalogResourceTypeWrapper<ICatalogResourceType, CatalogResourceType>, ICatalogResourceType
    {
        protected CatalogResourceTypeWrapper(CatalogResourceType instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ICatalogResourceType, CatalogResourceType>(src => ((CatalogResourceTypeWrapper) src).r_Instance, src => new CatalogResourceTypeWrapper(src)); }
    }


    internal class CatalogResourceTypeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICatalogResourceType where TInterface : class where TWrapper : class
    {
        String ICatalogResourceType.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
        }

        String ICatalogResourceType.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
        }

        Guid ICatalogResourceType.Identifier
        {
            get
            {
                Guid nativeCallResult = r_Instance.Identifier;
                return nativeCallResult;
            }
        }

        void ICatalogResourceType.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected CatalogResourceTypeWrapper(CatalogResourceType instance) { r_Instance = instance; }
        protected readonly CatalogResourceType r_Instance;
    }
}