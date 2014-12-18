using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class TeamFoundationIdentityWrapper : TeamFoundationIdentityWrapper<ITeamFoundationIdentity, TeamFoundationIdentity>, ITeamFoundationIdentity
    {
        protected TeamFoundationIdentityWrapper(TeamFoundationIdentity instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITeamFoundationIdentity, TeamFoundationIdentity>(src => src==null ? null : ((TeamFoundationIdentityWrapper) src).r_Instance, src => new TeamFoundationIdentityWrapper(src)); }
    }


    internal class TeamFoundationIdentityWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITeamFoundationIdentity where TInterface : class where TWrapper : class
    {

        IIdentityDescriptor ITeamFoundationIdentity.Descriptor
        {
            get
            {
                IdentityDescriptor nativeCallResult = r_Instance.Descriptor;
                IIdentityDescriptor wrappedCallResult = IdentityDescriptorWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                IdentityDescriptor nativeValue = IdentityDescriptorWrapper.GetInstance(value);

                r_Instance.Descriptor = nativeValue;
            }
        }

        String ITeamFoundationIdentity.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
            set { r_Instance.DisplayName = value; }
        }

        String ITeamFoundationIdentity.GetAttribute(String name, String defaultValue)
        {
            string nativeCallResult = r_Instance.GetAttribute(name, defaultValue);
            return nativeCallResult;
        }

        IEnumerable<KeyValuePair<String, Object>> ITeamFoundationIdentity.GetProperties()
        {
            IEnumerable<KeyValuePair<string, object>> nativeCallResult = r_Instance.GetProperties();
            return nativeCallResult;
        }


        IEnumerable<KeyValuePair<String, Object>> ITeamFoundationIdentity.GetProperties(IIdentityPropertyScope propertyScope)
        {
            IEnumerable<KeyValuePair<string, object>> nativeCallResult = r_Instance.GetProperties(IdentityPropertyScopeWrapper.GetInstance(propertyScope));
            return nativeCallResult;
        }

        Object ITeamFoundationIdentity.GetProperty(String name)
        {
            object nativeCallResult = r_Instance.GetProperty(name);
            return nativeCallResult;
        }


        Object ITeamFoundationIdentity.GetProperty(IIdentityPropertyScope propertyScope, String name)
        {
            object nativeCallResult = r_Instance.GetProperty(IdentityPropertyScopeWrapper.GetInstance(propertyScope), name);
            return nativeCallResult;
        }

        Boolean ITeamFoundationIdentity.IsActive
        {
            get
            {
                bool nativeCallResult = r_Instance.IsActive;
                return nativeCallResult;
            }
            set { r_Instance.IsActive = value; }
        }

        Boolean ITeamFoundationIdentity.IsContainer
        {
            get
            {
                bool nativeCallResult = r_Instance.IsContainer;
                return nativeCallResult;
            }
        }

        IIdentityDescriptor[] ITeamFoundationIdentity.MemberOf
        {
            get
            {
                IdentityDescriptor[] nativeCallResult = r_Instance.MemberOf;
                IIdentityDescriptor[] wrappedCallResult = IdentityDescriptorWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                IdentityDescriptor[] nativeValue = IdentityDescriptorWrapper.GetInstance(value);

                r_Instance.MemberOf = nativeValue;
            }
        }

        IIdentityDescriptor[] ITeamFoundationIdentity.Members
        {
            get
            {
                IdentityDescriptor[] nativeCallResult = r_Instance.Members;
                IIdentityDescriptor[] wrappedCallResult = IdentityDescriptorWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                IdentityDescriptor[] nativeValue = IdentityDescriptorWrapper.GetInstance(value);

                r_Instance.Members = nativeValue;
            }
        }



        void ITeamFoundationIdentity.RemoveProperty(String name) { r_Instance.RemoveProperty(name); }

        void ITeamFoundationIdentity.RemoveProperty(IIdentityPropertyScope propertyScope, String name) { r_Instance.RemoveProperty(IdentityPropertyScopeWrapper.GetInstance(propertyScope), name); }



        void ITeamFoundationIdentity.SetAttribute(String name, String value) { r_Instance.SetAttribute(name, value); }
        void ITeamFoundationIdentity.SetProperty(String name, Object value) { r_Instance.SetProperty(name, value); }

        void ITeamFoundationIdentity.SetProperty(IIdentityPropertyScope propertyScope, String name, Object value) { r_Instance.SetProperty(IdentityPropertyScopeWrapper.GetInstance(propertyScope), name, value); }

        Guid ITeamFoundationIdentity.TeamFoundationId
        {
            get
            {
                Guid nativeCallResult = r_Instance.TeamFoundationId;
                return nativeCallResult;
            }
            set { r_Instance.TeamFoundationId = value; }
        }


        void ITeamFoundationIdentity.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }

        Boolean ITeamFoundationIdentity.TryGetProperty(String name, out Object value)
        {
            Object tmp_value;
            bool nativeCallResult = r_Instance.TryGetProperty(name, out tmp_value);
            value = tmp_value;
            return nativeCallResult;
        }


        Boolean ITeamFoundationIdentity.TryGetProperty(IIdentityPropertyScope propertyScope, String name, out Object value)
        {
            Object tmp_value;
            bool nativeCallResult = r_Instance.TryGetProperty(IdentityPropertyScopeWrapper.GetInstance(propertyScope), name, out tmp_value);
            value = tmp_value;
            return nativeCallResult;
        }

        String ITeamFoundationIdentity.UniqueName
        {
            get
            {
                string nativeCallResult = r_Instance.UniqueName;
                return nativeCallResult;
            }
        }

        Int32 ITeamFoundationIdentity.UniqueUserId
        {
            get
            {
                int nativeCallResult = r_Instance.UniqueUserId;
                return nativeCallResult;
            }
            set { r_Instance.UniqueUserId = value; }
        }

        protected TeamFoundationIdentityWrapper(TeamFoundationIdentity instance) { r_Instance = instance; }
        protected readonly TeamFoundationIdentity r_Instance;
    }
}