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
        void IServiceDefinition.AddLocationMapping(IAccessMapping accessMapping, String location) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IServiceDefinition.Description { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IServiceDefinition.DisplayName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ILocationMapping IServiceDefinition.GetLocationMapping(IAccessMapping accessMapping) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Guid IServiceDefinition.Identifier { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IEnumerable<ILocationMapping> IServiceDefinition.LocationMappings { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IServiceDefinition.RelativePath { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IRelativeToSetting IServiceDefinition.RelativeToSetting { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IServiceDefinition.RemoveLocationMapping(IAccessMapping accessMapping) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IServiceDefinition.ServiceType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IServiceDefinition.ToXml(XmlWriter writer, String element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IServiceDefinition.ToolType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}