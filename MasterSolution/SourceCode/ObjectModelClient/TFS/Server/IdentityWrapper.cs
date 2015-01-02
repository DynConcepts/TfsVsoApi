using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.TeamFoundation.Server;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Server
{
    /// <summary>
    /// Class IdentityWrapper.
    /// </summary>
    internal class IdentityWrapper : IdentityWrapper<IIdentity, Identity>, IIdentity, IComparable, IITfsXmlSerializable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IdentityWrapper(Identity instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IIdentity, Identity>(src => src == null ? null : ((IdentityWrapper) src).r_Instance, src => new IdentityWrapper(src)); }
    }


    /// <summary>
    /// Class IdentityWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class IdentityWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIdentity where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the name of the account.
        /// </summary>
        /// <value>The name of the account.</value>
        String IIdentity.AccountName
        {
            get
            {
                string nativeCallResult = r_Instance.AccountName;
                return nativeCallResult;
            }
            set { r_Instance.AccountName = value; }
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name="obj" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name="obj" />. Greater than zero This instance follows <paramref name="obj" /> in the sort order.</returns>
        Int32 IComparable.CompareTo(Object obj)
        {
            int nativeCallResult = r_Instance.CompareTo(obj);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets or sets the deleted.
        /// </summary>
        /// <value>The deleted.</value>
        Boolean IIdentity.Deleted
        {
            get
            {
                bool nativeCallResult = r_Instance.Deleted;
                return nativeCallResult;
            }
            set { r_Instance.Deleted = value; }
        }


        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        String IIdentity.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
            set { r_Instance.Description = value; }
        }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String IIdentity.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
            set { r_Instance.DisplayName = value; }
        }

        /// <summary>
        /// Gets or sets the name of the distinguished.
        /// </summary>
        /// <value>The name of the distinguished.</value>
        String IIdentity.DistinguishedName
        {
            get
            {
                string nativeCallResult = r_Instance.DistinguishedName;
                return nativeCallResult;
            }
            set { r_Instance.DistinguishedName = value; }
        }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        String IIdentity.Domain
        {
            get
            {
                string nativeCallResult = r_Instance.Domain;
                return nativeCallResult;
            }
            set { r_Instance.Domain = value; }
        }

        /// <summary>
        /// Gets or sets the mail address.
        /// </summary>
        /// <value>The mail address.</value>
        String IIdentity.MailAddress
        {
            get
            {
                string nativeCallResult = r_Instance.MailAddress;
                return nativeCallResult;
            }
            set { r_Instance.MailAddress = value; }
        }

        /// <summary>
        /// Gets or sets the member of.
        /// </summary>
        /// <value>The member of.</value>
        String[] IIdentity.MemberOf
        {
            get
            {
                string[] nativeCallResult = r_Instance.MemberOf;
                return nativeCallResult;
            }
            set { r_Instance.MemberOf = value; }
        }

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
        String[] IIdentity.Members
        {
            get
            {
                string[] nativeCallResult = r_Instance.Members;
                return nativeCallResult;
            }
            set { r_Instance.Members = value; }
        }

        /// <summary>
        /// Reads the XML.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="xmlElement">The XML element.</param>
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { r_Instance.ReadXml(reader, xmlElement); }

        /// <summary>
        /// Gets or sets the security group.
        /// </summary>
        /// <value>The security group.</value>
        Boolean IIdentity.SecurityGroup
        {
            get
            {
                bool nativeCallResult = r_Instance.SecurityGroup;
                return nativeCallResult;
            }
            set { r_Instance.SecurityGroup = value; }
        }

        /// <summary>
        /// Gets or sets the sid.
        /// </summary>
        /// <value>The sid.</value>
        String IIdentity.Sid
        {
            get
            {
                string nativeCallResult = r_Instance.Sid;
                return nativeCallResult;
            }
            set { r_Instance.Sid = value; }
        }

        /// <summary>
        /// Gets or sets the type of the special.
        /// </summary>
        /// <value>The type of the special.</value>
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

        /// <summary>
        /// Gets or sets the team foundation identifier.
        /// </summary>
        /// <value>The team foundation identifier.</value>
        Guid IIdentity.TeamFoundationId
        {
            get
            {
                Guid nativeCallResult = r_Instance.TeamFoundationId;
                return nativeCallResult;
            }
            set { r_Instance.TeamFoundationId = value; }
        }

        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void IIdentity.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
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

        /// <summary>
        /// Writes the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="xmlElement">The XML element.</param>
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { r_Instance.WriteXml(writer, xmlElement); }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IdentityWrapper(Identity instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly Identity r_Instance;
    }
}