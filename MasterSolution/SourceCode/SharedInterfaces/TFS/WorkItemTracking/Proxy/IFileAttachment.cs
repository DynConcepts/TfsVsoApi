using System;
using System.IO;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IFileAttachment
  {
    Guid FileNameGUID  { get; set;   }
    String AreaNodeUri  { get; set;   }
    String ProjectUri  { get; set;   }
    Stream LocalFile  { get; set;   }
  }
}
