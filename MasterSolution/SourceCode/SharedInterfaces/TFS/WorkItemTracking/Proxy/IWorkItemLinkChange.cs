using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IWorkItemLinkChange
  {
    void ToXml( XmlWriter writer, String element);
    DateTime ChangedDate  { get; set;   }
    Boolean IsActive  { get; set;   }
    String LinkType  { get; set;   }
    Int64 RowVersion  { get; set;   }
    Int32 SourceID  { get; set;   }
    Int32 TargetID  { get; set;   }
  }
}
