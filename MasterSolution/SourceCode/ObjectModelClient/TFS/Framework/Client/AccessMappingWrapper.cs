using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class AccessMappingWrapper : AccessMappingWrapper<IAccessMapping, AccessMapping>, IAccessMapping
    {
        protected AccessMappingWrapper(AccessMapping instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAccessMapping, AccessMapping>(src => src == null ? null : ((AccessMappingWrapper) src).r_Instance, src => new AccessMappingWrapper(src)); }
    }


    internal class AccessMappingWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAccessMapping where TInterface : class where TWrapper : class
    {
        String IAccessMapping.AccessPoint
        {
            get
            {
                string nativeCallResult = r_Instance.AccessPoint;
                return nativeCallResult;
            }
        }

        String IAccessMapping.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
        }

        String IAccessMapping.Moniker
        {
            get
            {
                string nativeCallResult = r_Instance.Moniker;
                return nativeCallResult;
            }
        }

        void IAccessMapping.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected AccessMappingWrapper(AccessMapping instance) { r_Instance = instance; }
        protected readonly AccessMapping r_Instance;
    }
}