using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface ILinkUpdate
  {
    void Submit( XmlElement element);
    void Submit( ILinkInfo li);
    ILinkProperties Mask  { get;   }
    String Comment  { get; set;   }
    Boolean IsLocked  { get; set;   }
  }
}
