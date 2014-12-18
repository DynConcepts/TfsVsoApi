using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class LocationMappingWrapper : LocationMappingWrapper<ILocationMapping, LocationMapping>, ILocationMapping
    {
        protected LocationMappingWrapper(LocationMapping instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ILocationMapping, LocationMapping>(src => src==null ? null : ((LocationMappingWrapper) src).r_Instance, src => new LocationMappingWrapper(src)); }
    }


    internal class LocationMappingWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ILocationMapping where TInterface : class where TWrapper : class
    {
        IAccessMapping ILocationMapping.AccessMapping
        {
            get
            {
                AccessMapping nativeCallResult = r_Instance.AccessMapping;
                IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String ILocationMapping.Location
        {
            get
            {
                string nativeCallResult = r_Instance.Location;
                return nativeCallResult;
            }
        }

        void ILocationMapping.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected LocationMappingWrapper(LocationMapping instance) { r_Instance = instance; }
        protected readonly LocationMapping r_Instance;
    }
}