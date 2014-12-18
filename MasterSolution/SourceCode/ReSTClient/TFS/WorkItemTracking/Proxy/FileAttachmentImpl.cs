using System;
using System.IO;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal struct FileAttachmentImpl : IFileAttachment
    {
        String IFileAttachment.AreaNodeUri { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Guid IFileAttachment.FileNameGUID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Stream IFileAttachment.LocalFile { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IFileAttachment.ProjectUri { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}