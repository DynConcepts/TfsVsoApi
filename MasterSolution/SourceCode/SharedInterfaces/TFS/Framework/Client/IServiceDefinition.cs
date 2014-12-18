using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IServiceDefinition
  {
    void AddLocationMapping( IAccessMapping accessMapping, String location);
    Boolean RemoveLocationMapping( IAccessMapping accessMapping);
    ILocationMapping GetLocationMapping( IAccessMapping accessMapping);
    void ToXml( XmlWriter writer, String element);
    String ServiceType  { get; set;   }
    Guid Identifier  { get; set;   }
    String DisplayName  { get; set;   }
    IRelativeToSetting RelativeToSetting  { get; set;   }
    String RelativePath  { get; set;   }
    String Description  { get; set;   }
    String ToolType  { get; set;   }
    IEnumerable<ILocationMapping> LocationMappings  { get;   }
  }
}
