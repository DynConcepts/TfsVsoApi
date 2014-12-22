using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class ServiceDefinitionImpl : IServiceDefinition
    {
        void IServiceDefinition.AddLocationMapping(IAccessMapping accessMapping, String location) { throw new ToBeImplementedException(); }
        String IServiceDefinition.Description { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IServiceDefinition.DisplayName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        ILocationMapping IServiceDefinition.GetLocationMapping(IAccessMapping accessMapping) { throw new ToBeImplementedException(); }
        Guid IServiceDefinition.Identifier { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IEnumerable<ILocationMapping> IServiceDefinition.LocationMappings { get { throw new ToBeImplementedException(); } }
        String IServiceDefinition.RelativePath { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IRelativeToSetting IServiceDefinition.RelativeToSetting { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean IServiceDefinition.RemoveLocationMapping(IAccessMapping accessMapping) { throw new ToBeImplementedException(); }
        String IServiceDefinition.ServiceType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IServiceDefinition.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
        String IServiceDefinition.ToolType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}