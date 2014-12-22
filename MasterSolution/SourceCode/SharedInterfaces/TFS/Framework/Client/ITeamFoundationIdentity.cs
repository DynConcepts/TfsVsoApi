using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface ITeamFoundationIdentity
    {
        String GetAttribute(String name, String defaultValue);
        IEnumerable<KeyValuePair<String, Object>> GetProperties();
        IEnumerable<KeyValuePair<String, Object>> GetProperties(IIdentityPropertyScope propertyScope);
        Object GetProperty(String name);
        Object GetProperty(IIdentityPropertyScope propertyScope, String name);
        void RemoveProperty(String name);
        void RemoveProperty(IIdentityPropertyScope propertyScope, String name);
        void SetAttribute(String name, String value);
        void SetProperty(String name, Object value);
        void SetProperty(IIdentityPropertyScope propertyScope, String name, Object value);
        void ToXml(XmlWriter writer, String element);
        Boolean TryGetProperty(String name, out Object value);
        Boolean TryGetProperty(IIdentityPropertyScope propertyScope, String name, out Object value);
        IIdentityDescriptor Descriptor { get; set; }
        String DisplayName { get; set; }
        Boolean IsActive { get; set; }
        Boolean IsContainer { get; }
        IIdentityDescriptor[] MemberOf { get; set; }
        IIdentityDescriptor[] Members { get; set; }
        Guid TeamFoundationId { get; set; }
        String UniqueName { get; }
        Int32 UniqueUserId { get; set; }
    }
}