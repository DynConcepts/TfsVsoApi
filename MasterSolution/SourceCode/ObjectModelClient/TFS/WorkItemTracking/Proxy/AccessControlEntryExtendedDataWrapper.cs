using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class AccessControlEntryExtendedDataWrapper : AccessControlEntryExtendedDataWrapper<IAccessControlEntryExtendedData, AccessControlEntryExtendedData>, IAccessControlEntryExtendedData
    {
        protected AccessControlEntryExtendedDataWrapper(AccessControlEntryExtendedData instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAccessControlEntryExtendedData, AccessControlEntryExtendedData>(src => src==null ? null : ((AccessControlEntryExtendedDataWrapper) src).r_Instance, src => new AccessControlEntryExtendedDataWrapper(src)); }
    }


    internal class AccessControlEntryExtendedDataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAccessControlEntryExtendedData where TInterface : class where TWrapper : class
    {
        Int32 IAccessControlEntryExtendedData.EffectiveAllow
        {
            get
            {
                int nativeCallResult = r_Instance.EffectiveAllow;
                return nativeCallResult;
            }
            set { r_Instance.EffectiveAllow = value; }
        }

        Int32 IAccessControlEntryExtendedData.EffectiveDeny
        {
            get
            {
                int nativeCallResult = r_Instance.EffectiveDeny;
                return nativeCallResult;
            }
            set { r_Instance.EffectiveDeny = value; }
        }

        Int32 IAccessControlEntryExtendedData.InheritedAllow
        {
            get
            {
                int nativeCallResult = r_Instance.InheritedAllow;
                return nativeCallResult;
            }
            set { r_Instance.InheritedAllow = value; }
        }

        Int32 IAccessControlEntryExtendedData.InheritedDeny
        {
            get
            {
                int nativeCallResult = r_Instance.InheritedDeny;
                return nativeCallResult;
            }
            set { r_Instance.InheritedDeny = value; }
        }

        void IAccessControlEntryExtendedData.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected AccessControlEntryExtendedDataWrapper(AccessControlEntryExtendedData instance) { r_Instance = instance; }
        protected readonly AccessControlEntryExtendedData r_Instance;
    }
}