using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
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

        DateTime IAttachment.AttachedTime { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime IAttachment.AttachedTimeUtc { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IAttachment.Comment { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime IAttachment.CreationTime { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime IAttachment.CreationTimeUtc { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IAttachment.Extension { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IAttachment.FileGuid { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IAttachment.Id { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IAttachment.IsSaved { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime IAttachment.LastWriteTime { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime IAttachment.LastWriteTimeUtc { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int64 IAttachment.Length { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IAttachment.Name { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Uri IAttachment.Uri { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}