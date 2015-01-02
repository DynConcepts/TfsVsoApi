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
    /// <summary>
    /// Class TeamFoundationIdentityWrapper.
    /// </summary>
    internal class TeamFoundationIdentityWrapper : TeamFoundationIdentityWrapper<ITeamFoundationIdentity, TeamFoundationIdentity>, ITeamFoundationIdentity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFoundationIdentityWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TeamFoundationIdentityWrapper(TeamFoundationIdentity instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITeamFoundationIdentity, TeamFoundationIdentity>(src => src == null ? null : ((TeamFoundationIdentityWrapper) src).r_Instance, src => new TeamFoundationIdentityWrapper(src)); }
    }


    /// <summary>
    /// Class TeamFoundationIdentityWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class TeamFoundationIdentityWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITeamFoundationIdentity where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the descriptor.
        /// </summary>
        /// <value>The descriptor.</value>
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

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String ITeamFoundationIdentity.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
            set { r_Instance.DisplayName = value; }
        }

        /// <summary>
        /// Gets the attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>String.</returns>
        String ITeamFoundationIdentity.GetAttribute(String name, String defaultValue)
        {
            string nativeCallResult = r_Instance.GetAttribute(name, defaultValue);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <returns>IEnumerable&lt;KeyValuePair&lt;String, Object&gt;&gt;.</returns>
        IEnumerable<KeyValuePair<String, Object>> ITeamFoundationIdentity.GetProperties()
        {
            IEnumerable<KeyValuePair<string, object>> nativeCallResult = r_Instance.GetProperties();
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <returns>IEnumerable&lt;KeyValuePair&lt;String, Object&gt;&gt;.</returns>
        IEnumerable<KeyValuePair<String, Object>> ITeamFoundationIdentity.GetProperties(IIdentityPropertyScope propertyScope)
        {
            IEnumerable<KeyValuePair<string, object>> nativeCallResult = r_Instance.GetProperties(IdentityPropertyScopeWrapper.GetInstance(propertyScope));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        Object ITeamFoundationIdentity.GetProperty(String name)
        {
            object nativeCallResult = r_Instance.GetProperty(name);
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        Object ITeamFoundationIdentity.GetProperty(IIdentityPropertyScope propertyScope, String name)
        {
            object nativeCallResult = r_Instance.GetProperty(IdentityPropertyScopeWrapper.GetInstance(propertyScope), name);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets or sets the is active.
        /// </summary>
        /// <value>The is active.</value>
        Boolean ITeamFoundationIdentity.IsActive
        {
            get
            {
                bool nativeCallResult = r_Instance.IsActive;
                return nativeCallResult;
            }
            set { r_Instance.IsActive = value; }
        }

        /// <summary>
        /// Gets the is container.
        /// </summary>
        /// <value>The is container.</value>
        Boolean ITeamFoundationIdentity.IsContainer
        {
            get
            {
                bool nativeCallResult = r_Instance.IsContainer;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the member of.
        /// </summary>
        /// <value>The member of.</value>
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

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
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


        /// <summary>
        /// Removes the property.
        /// </summary>
        /// <param name="name">The name.</param>
        void ITeamFoundationIdentity.RemoveProperty(String name) { r_Instance.RemoveProperty(name); }

        /// <summary>
        /// Removes the property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        void ITeamFoundationIdentity.RemoveProperty(IIdentityPropertyScope propertyScope, String name) { r_Instance.RemoveProperty(IdentityPropertyScopeWrapper.GetInstance(propertyScope), name); }


        /// <summary>
        /// Sets the attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        void ITeamFoundationIdentity.SetAttribute(String name, String value) { r_Instance.SetAttribute(name, value); }
        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        void ITeamFoundationIdentity.SetProperty(String name, Object value) { r_Instance.SetProperty(name, value); }

        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        void ITeamFoundationIdentity.SetProperty(IIdentityPropertyScope propertyScope, String name, Object value) { r_Instance.SetProperty(IdentityPropertyScopeWrapper.GetInstance(propertyScope), name, value); }

        /// <summary>
        /// Gets or sets the team foundation identifier.
        /// </summary>
        /// <value>The team foundation identifier.</value>
        Guid ITeamFoundationIdentity.TeamFoundationId
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
        void ITeamFoundationIdentity.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }

        /// <summary>
        /// Tries the get property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean ITeamFoundationIdentity.TryGetProperty(String name, out Object value)
        {
            Object tmp_value;
            bool nativeCallResult = r_Instance.TryGetProperty(name, out tmp_value);
            value = tmp_value;
            return nativeCallResult;
        }


        /// <summary>
        /// Tries the get property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean ITeamFoundationIdentity.TryGetProperty(IIdentityPropertyScope propertyScope, String name, out Object value)
        {
            Object tmp_value;
            bool nativeCallResult = r_Instance.TryGetProperty(IdentityPropertyScopeWrapper.GetInstance(propertyScope), name, out tmp_value);
            value = tmp_value;
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the name of the unique.
        /// </summary>
        /// <value>The name of the unique.</value>
        String ITeamFoundationIdentity.UniqueName
        {
            get
            {
                string nativeCallResult = r_Instance.UniqueName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the unique user identifier.
        /// </summary>
        /// <value>The unique user identifier.</value>
        Int32 ITeamFoundationIdentity.UniqueUserId
        {
            get
            {
                int nativeCallResult = r_Instance.UniqueUserId;
                return nativeCallResult;
            }
            set { r_Instance.UniqueUserId = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFoundationIdentityWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TeamFoundationIdentityWrapper(TeamFoundationIdentity instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly TeamFoundationIdentity r_Instance;
    }
}