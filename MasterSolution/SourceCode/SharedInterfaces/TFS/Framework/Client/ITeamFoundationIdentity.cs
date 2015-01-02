using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface ITeamFoundationIdentity
    /// </summary>
    public interface ITeamFoundationIdentity
    {
        /// <summary>
        /// Gets the attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>String.</returns>
        String GetAttribute(String name, String defaultValue);
        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <returns>IEnumerable&lt;KeyValuePair&lt;String, Object&gt;&gt;.</returns>
        IEnumerable<KeyValuePair<String, Object>> GetProperties();
        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <returns>IEnumerable&lt;KeyValuePair&lt;String, Object&gt;&gt;.</returns>
        IEnumerable<KeyValuePair<String, Object>> GetProperties(IIdentityPropertyScope propertyScope);
        /// <summary>
        /// Gets the property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        Object GetProperty(String name);
        /// <summary>
        /// Gets the property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        Object GetProperty(IIdentityPropertyScope propertyScope, String name);
        /// <summary>
        /// Removes the property.
        /// </summary>
        /// <param name="name">The name.</param>
        void RemoveProperty(String name);
        /// <summary>
        /// Removes the property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        void RemoveProperty(IIdentityPropertyScope propertyScope, String name);
        /// <summary>
        /// Sets the attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        void SetAttribute(String name, String value);
        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        void SetProperty(String name, Object value);
        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        void SetProperty(IIdentityPropertyScope propertyScope, String name, Object value);
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Tries the get property.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean TryGetProperty(String name, out Object value);
        /// <summary>
        /// Tries the get property.
        /// </summary>
        /// <param name="propertyScope">The property scope.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean TryGetProperty(IIdentityPropertyScope propertyScope, String name, out Object value);
        /// <summary>
        /// Gets or sets the descriptor.
        /// </summary>
        /// <value>The descriptor.</value>
        IIdentityDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the is active.
        /// </summary>
        /// <value>The is active.</value>
        Boolean IsActive { get; set; }
        /// <summary>
        /// Gets the is container.
        /// </summary>
        /// <value>The is container.</value>
        Boolean IsContainer { get; }
        /// <summary>
        /// Gets or sets the member of.
        /// </summary>
        /// <value>The member of.</value>
        IIdentityDescriptor[] MemberOf { get; set; }
        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
        IIdentityDescriptor[] Members { get; set; }
        /// <summary>
        /// Gets or sets the team foundation identifier.
        /// </summary>
        /// <value>The team foundation identifier.</value>
        Guid TeamFoundationId { get; set; }
        /// <summary>
        /// Gets the name of the unique.
        /// </summary>
        /// <value>The name of the unique.</value>
        String UniqueName { get; }
        /// <summary>
        /// Gets or sets the unique user identifier.
        /// </summary>
        /// <value>The unique user identifier.</value>
        Int32 UniqueUserId { get; set; }
    }
}