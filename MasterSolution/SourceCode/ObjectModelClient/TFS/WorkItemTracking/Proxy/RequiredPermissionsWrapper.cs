using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class RequiredPermissionsWrapper : RequiredPermissionsWrapper<IRequiredPermissions, RequiredPermissions>, IRequiredPermissions
    {
        protected RequiredPermissionsWrapper(RequiredPermissions instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IRequiredPermissions, RequiredPermissions>(src => src == null ? null : ((RequiredPermissionsWrapper) src).r_Instance, src => new RequiredPermissionsWrapper(src)); }
    }


    internal class RequiredPermissionsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IRequiredPermissions where TInterface : class where TWrapper : class
    {
        String IRequiredPermissions.PermissionName
        {
            get
            {
                string nativeCallResult = r_Instance.PermissionName;
                return nativeCallResult;
            }
            set { r_Instance.PermissionName = value; }
        }

        Int32 IRequiredPermissions.RequiredPermissionBits
        {
            get
            {
                int nativeCallResult = r_Instance.RequiredPermissionBits;
                return nativeCallResult;
            }
            set { r_Instance.RequiredPermissionBits = value; }
        }

        void IRequiredPermissions.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected RequiredPermissionsWrapper(RequiredPermissions instance) { r_Instance = instance; }
        protected readonly RequiredPermissions r_Instance;
    }
}