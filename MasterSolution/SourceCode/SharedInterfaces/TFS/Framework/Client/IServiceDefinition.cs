using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface IServiceDefinition
    {
        void AddLocationMapping(IAccessMapping accessMapping, String location);
        ILocationMapping GetLocationMapping(IAccessMapping accessMapping);
        Boolean RemoveLocationMapping(IAccessMapping accessMapping);
        void ToXml(XmlWriter writer, String element);
        String Description { get; set; }
        String DisplayName { get; set; }
        Guid Identifier { get; set; }
        IEnumerable<ILocationMapping> LocationMappings { get; }
        String RelativePath { get; set; }
        IRelativeToSetting RelativeToSetting { get; set; }
        String ServiceType { get; set; }
        String ToolType { get; set; }
    }
}