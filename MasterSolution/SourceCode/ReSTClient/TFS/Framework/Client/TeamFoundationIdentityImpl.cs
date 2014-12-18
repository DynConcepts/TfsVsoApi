using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class TeamFoundationIdentityImpl : ITeamFoundationIdentity
    {
        IIdentityDescriptor ITeamFoundationIdentity.Descriptor { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String ITeamFoundationIdentity.DisplayName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String ITeamFoundationIdentity.GetAttribute(String name, String defaultValue) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<KeyValuePair<String, Object>> ITeamFoundationIdentity.GetProperties() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<KeyValuePair<String, Object>> ITeamFoundationIdentity.GetProperties(IIdentityPropertyScope propertyScope) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Object ITeamFoundationIdentity.GetProperty(String name) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Object ITeamFoundationIdentity.GetProperty(IIdentityPropertyScope propertyScope, String name) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean ITeamFoundationIdentity.IsActive { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ITeamFoundationIdentity.IsContainer { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IIdentityDescriptor[] ITeamFoundationIdentity.MemberOf { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IIdentityDescriptor[] ITeamFoundationIdentity.Members { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ITeamFoundationIdentity.RemoveProperty(String name) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ITeamFoundationIdentity.RemoveProperty(IIdentityPropertyScope propertyScope, String name) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ITeamFoundationIdentity.SetAttribute(String name, String value) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ITeamFoundationIdentity.SetProperty(String name, Object value) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ITeamFoundationIdentity.SetProperty(IIdentityPropertyScope propertyScope, String name, Object value) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Guid ITeamFoundationIdentity.TeamFoundationId { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ITeamFoundationIdentity.ToXml(XmlWriter writer, String element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean ITeamFoundationIdentity.TryGetProperty(String name, out Object value) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean ITeamFoundationIdentity.TryGetProperty(IIdentityPropertyScope propertyScope, String name, out Object value) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String ITeamFoundationIdentity.UniqueName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 ITeamFoundationIdentity.UniqueUserId { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}