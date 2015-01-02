using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class TeamFoundationIdentityImpl.
    /// </summary>
    internal class TeamFoundationIdentityImpl : ITeamFoundationIdentity
    {
        /// <summary>
        ///     Gets or sets the descriptor.
        /// </summary>
        /// <value>The descriptor.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IIdentityDescriptor ITeamFoundationIdentity.Descriptor { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String ITeamFoundationIdentity.DisplayName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ITeamFoundationIdentity.GetAttribute(String name, String defaultValue) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the properties.
        /// </summary>
        /// <returns>IEnumerable&lt;KeyValuePair&lt;String, Object&gt;&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<KeyValuePair<String, Object>> ITeamFoundationIdentity.GetProperties() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the properties.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <returns>IEnumerable&lt;KeyValuePair&lt;String, Object&gt;&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<KeyValuePair<String, Object>> ITeamFoundationIdentity.GetProperties(IIdentityPropertyScope propertyScope) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object ITeamFoundationIdentity.GetProperty(String name) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object ITeamFoundationIdentity.GetProperty(IIdentityPropertyScope propertyScope, String name) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the is active.
        /// </summary>
        /// <value>The is active.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean ITeamFoundationIdentity.IsActive { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is container.
        /// </summary>
        /// <value>The is container.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ITeamFoundationIdentity.IsContainer { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the member of.
        /// </summary>
        /// <value>The member of.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IIdentityDescriptor[] ITeamFoundationIdentity.MemberOf { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IIdentityDescriptor[] ITeamFoundationIdentity.Members { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Removes the property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITeamFoundationIdentity.RemoveProperty(String name) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITeamFoundationIdentity.RemoveProperty(IIdentityPropertyScope propertyScope, String name) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITeamFoundationIdentity.SetAttribute(String name, String value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITeamFoundationIdentity.SetProperty(String name, Object value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITeamFoundationIdentity.SetProperty(IIdentityPropertyScope propertyScope, String name, Object value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the team foundation identifier.
        /// </summary>
        /// <value>The team foundation identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Guid ITeamFoundationIdentity.TeamFoundationId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITeamFoundationIdentity.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Tries the get property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ITeamFoundationIdentity.TryGetProperty(String name, out Object value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Tries the get property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ITeamFoundationIdentity.TryGetProperty(IIdentityPropertyScope propertyScope, String name, out Object value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the name of the unique.
        /// </summary>
        /// <value>The name of the unique.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ITeamFoundationIdentity.UniqueName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the unique user identifier.
        /// </summary>
        /// <value>The unique user identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 ITeamFoundationIdentity.UniqueUserId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}