using System;
using System.IO;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IFileAttachment
    {
        String AreaNodeUri { get; set; }
        Guid FileNameGUID { get; set; }
        Stream LocalFile { get; set; }
        String ProjectUri { get; set; }
    }
}