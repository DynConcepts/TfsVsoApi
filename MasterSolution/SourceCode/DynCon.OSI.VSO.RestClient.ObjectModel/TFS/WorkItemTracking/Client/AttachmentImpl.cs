using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class AttachmentImpl : LinkImpl, IAttachment, ILinkImpl
    {
        public new static AttachmentImpl FromToken(JToken value)
        {
            var instance = new AttachmentImpl(value);
            return instance;
        }

        public AttachmentImpl(JToken json)
            : base(json)
        {
        }

        DateTime IAttachment.AttachedTime { get { throw new ToBeImplementedException(); } }
        DateTime IAttachment.AttachedTimeUtc { get { throw new ToBeImplementedException(); } }
        String IAttachment.Comment { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        DateTime IAttachment.CreationTime { get { throw new ToBeImplementedException(); } }
        DateTime IAttachment.CreationTimeUtc { get { throw new ToBeImplementedException(); } }
        String IAttachment.Extension { get { throw new ToBeImplementedException(); } }
        String IAttachment.FileGuid { get { throw new ToBeImplementedException(); } }
        Int32 IAttachment.Id { get { throw new ToBeImplementedException(); } }
        Boolean IAttachment.IsSaved { get { throw new ToBeImplementedException(); } }
        DateTime IAttachment.LastWriteTime { get { throw new ToBeImplementedException(); } }
        DateTime IAttachment.LastWriteTimeUtc { get { throw new ToBeImplementedException(); } }
        Int64 IAttachment.Length { get { throw new ToBeImplementedException(); } }
        String IAttachment.Name { get { throw new ToBeImplementedException(); } }
        Uri IAttachment.Uri { get { throw new ToBeImplementedException(); } }
    }
}