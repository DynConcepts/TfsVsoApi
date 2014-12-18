using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IExtendedAccessControlListData
  {
    void ToXml( XmlWriter writer, String element);
    Boolean InheritPermissions  { get; set;   }
    Boolean IsEditable  { get; set;   }
    IAccessControlListMetadata[] Metadata  { get; set;   }
    IAccessControlEntryData[] Permissions  { get; set;   }
    String Token  { get; set;   }
  }
}
