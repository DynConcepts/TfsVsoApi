using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class AttachmentWrapper : AttachmentWrapper<IAttachment, Attachment>, IAttachment
    {
        protected AttachmentWrapper(Attachment instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAttachment, Attachment>(src => src == null ? null : ((AttachmentWrapper) src).r_Instance, src => new AttachmentWrapper(src)); }
    }


    internal class AttachmentWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAttachment where TInterface : class where TWrapper : class
    {
        DateTime IAttachment.AttachedTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AttachedTime;
                return nativeCallResult;
            }
        }

        DateTime IAttachment.AttachedTimeUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AttachedTimeUtc;
                return nativeCallResult;
            }
        }

        String IAttachment.Comment
        {
            get
            {
                string nativeCallResult = r_Instance.Comment;
                return nativeCallResult;
            }
            set { r_Instance.Comment = value; }
        }

        DateTime IAttachment.CreationTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.CreationTime;
                return nativeCallResult;
            }
        }

        DateTime IAttachment.CreationTimeUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.CreationTimeUtc;
                return nativeCallResult;
            }
        }

        String IAttachment.Extension
        {
            get
            {
                string nativeCallResult = r_Instance.Extension;
                return nativeCallResult;
            }
        }

        String IAttachment.FileGuid
        {
            get
            {
                string nativeCallResult = r_Instance.FileGuid;
                return nativeCallResult;
            }
        }

        Int32 IAttachment.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        Boolean IAttachment.IsSaved
        {
            get
            {
                bool nativeCallResult = r_Instance.IsSaved;
                return nativeCallResult;
            }
        }

        DateTime IAttachment.LastWriteTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.LastWriteTime;
                return nativeCallResult;
            }
        }

        DateTime IAttachment.LastWriteTimeUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.LastWriteTimeUtc;
                return nativeCallResult;
            }
        }

        Int64 IAttachment.Length
        {
            get
            {
                long nativeCallResult = r_Instance.Length;
                return nativeCallResult;
            }
        }

        String IAttachment.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        Uri IAttachment.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        protected AttachmentWrapper(Attachment instance) { r_Instance = instance; }
        protected readonly Attachment r_Instance;
    }
}