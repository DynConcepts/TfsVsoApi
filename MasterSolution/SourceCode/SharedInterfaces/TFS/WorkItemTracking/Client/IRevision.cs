using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IRevision
  {
    String GetTagLine();
    IWorkItem WorkItem  { get;   }
    Int32 Index  { get;   }
    IFieldCollection Fields  { get;   }
    IAttachmentCollection Attachments  { get;   }
    ILinkCollection Links  { get;   }
    Object this[String name] { get;   }
  }
}
