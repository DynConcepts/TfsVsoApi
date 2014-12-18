using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.TeamFoundation.Server;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Server
{
    internal class IdentityWrapper : IdentityWrapper<IIdentity, Identity>, IIdentity, IComparable, IITfsXmlSerializable
    {
        protected IdentityWrapper(Identity instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIdentity, Identity>(src => src==null ? null : ((IdentityWrapper) src).r_Instance, src => new IdentityWrapper(src)); }
    }


    internal class IdentityWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIdentity where TInterface : class where TWrapper : class
    {

        String IIdentity.AccountName
        {
            get
            {
                string nativeCallResult = r_Instance.AccountName;
                return nativeCallResult;
            }
            set { r_Instance.AccountName = value; }
        }

        Int32 IComparable.CompareTo(Object obj)
        {
            int nativeCallResult = r_Instance.CompareTo(obj);
            return nativeCallResult;
        }

        Boolean IIdentity.Deleted
        {
            get
            {
                bool nativeCallResult = r_Instance.Deleted;
                return nativeCallResult;
            }
            set { r_Instance.Deleted = value; }
        }



        String IIdentity.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
            set { r_Instance.Description = value; }
        }

        String IIdentity.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
            set { r_Instance.DisplayName = value; }
        }

        String IIdentity.DistinguishedName
        {
            get
            {
                string nativeCallResult = r_Instance.DistinguishedName;
                return nativeCallResult;
            }
            set { r_Instance.DistinguishedName = value; }
        }

        String IIdentity.Domain
        {
            get
            {
                string nativeCallResult = r_Instance.Domain;
                return nativeCallResult;
            }
            set { r_Instance.Domain = value; }
        }

        String IIdentity.MailAddress
        {
            get
            {
                string nativeCallResult = r_Instance.MailAddress;
                return nativeCallResult;
            }
            set { r_Instance.MailAddress = value; }
        }

        String[] IIdentity.MemberOf
        {
            get
            {
                string[] nativeCallResult = r_Instance.MemberOf;
                return nativeCallResult;
            }
            set { r_Instance.MemberOf = value; }
        }

        String[] IIdentity.Members
        {
            get
            {
                string[] nativeCallResult = r_Instance.Members;
                return nativeCallResult;
            }
            set { r_Instance.Members = value; }
        }

        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { r_Instance.ReadXml(reader, xmlElement); }

        Boolean IIdentity.SecurityGroup
        {
            get
            {
                bool nativeCallResult = r_Instance.SecurityGroup;
                return nativeCallResult;
            }
            set { r_Instance.SecurityGroup = value; }
        }

        String IIdentity.Sid
        {
            get
            {
                string nativeCallResult = r_Instance.Sid;
                return nativeCallResult;
            }
            set { r_Instance.Sid = value; }
        }

        IApplicationGroupSpecialType IIdentity.SpecialType
        {
            get
            {
                ApplicationGroupSpecialType nativeCallResult = r_Instance.SpecialType;
                IApplicationGroupSpecialType wrappedCallResult = ApplicationGroupSpecialTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                ApplicationGroupSpecialType nativeValue = ApplicationGroupSpecialTypeWrapper.GetInstance(value);

                r_Instance.SpecialType = nativeValue;
            }
        }

        Guid IIdentity.TeamFoundationId
        {
            get
            {
                Guid nativeCallResult = r_Instance.TeamFoundationId;
                return nativeCallResult;
            }
            set { r_Instance.TeamFoundationId = value; }
        }

        void IIdentity.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }

        IIdentityType IIdentity.Type
        {
            get
            {
                IdentityType nativeCallResult = r_Instance.Type;
                IIdentityType wrappedCallResult = IdentityTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                IdentityType nativeValue = IdentityTypeWrapper.GetInstance(value);

                r_Instance.Type = nativeValue;
            }
        }

        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { r_Instance.WriteXml(writer, xmlElement); }
        protected IdentityWrapper(Identity instance) { r_Instance = instance; }
        protected readonly Identity r_Instance;
    }
}