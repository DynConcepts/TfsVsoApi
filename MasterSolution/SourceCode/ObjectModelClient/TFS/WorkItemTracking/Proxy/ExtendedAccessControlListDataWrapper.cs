using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class ExtendedAccessControlListDataWrapper : ExtendedAccessControlListDataWrapper<IExtendedAccessControlListData, ExtendedAccessControlListData>, IExtendedAccessControlListData
    {
        protected ExtendedAccessControlListDataWrapper(ExtendedAccessControlListData instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IExtendedAccessControlListData, ExtendedAccessControlListData>(src => src == null ? null : ((ExtendedAccessControlListDataWrapper) src).r_Instance, src => new ExtendedAccessControlListDataWrapper(src)); }
    }


    internal class ExtendedAccessControlListDataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IExtendedAccessControlListData where TInterface : class where TWrapper : class
    {
        Boolean IExtendedAccessControlListData.InheritPermissions
        {
            get
            {
                bool nativeCallResult = r_Instance.InheritPermissions;
                return nativeCallResult;
            }
            set { r_Instance.InheritPermissions = value; }
        }

        Boolean IExtendedAccessControlListData.IsEditable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEditable;
                return nativeCallResult;
            }
            set { r_Instance.IsEditable = value; }
        }

        IAccessControlListMetadata[] IExtendedAccessControlListData.Metadata
        {
            get
            {
                AccessControlListMetadata[] nativeCallResult = r_Instance.Metadata;
                IAccessControlListMetadata[] wrappedCallResult = AccessControlListMetadataWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                AccessControlListMetadata[] nativeValue = AccessControlListMetadataWrapper.GetInstance(value);

                r_Instance.Metadata = nativeValue;
            }
        }

        IAccessControlEntryData[] IExtendedAccessControlListData.Permissions
        {
            get
            {
                AccessControlEntryData[] nativeCallResult = r_Instance.Permissions;
                IAccessControlEntryData[] wrappedCallResult = AccessControlEntryDataWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                AccessControlEntryData[] nativeValue = AccessControlEntryDataWrapper.GetInstance(value);

                r_Instance.Permissions = nativeValue;
            }
        }

        void IExtendedAccessControlListData.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }

        String IExtendedAccessControlListData.Token
        {
            get
            {
                string nativeCallResult = r_Instance.Token;
                return nativeCallResult;
            }
            set { r_Instance.Token = value; }
        }

        protected ExtendedAccessControlListDataWrapper(ExtendedAccessControlListData instance) { r_Instance = instance; }
        protected readonly ExtendedAccessControlListData r_Instance;
    }
}