using System;
using System.IO;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal struct FileAttachmentWrapper : IFileAttachment
    {
        public static FileAttachment GetInstance(IFileAttachment src) { return default(FileAttachment); }
        public static FileAttachment[] GetInstance(IFileAttachment[] src) { return null; }
        public static FileAttachmentWrapper GetWrapper(FileAttachment src) { return default(FileAttachmentWrapper); }
        public static IFileAttachment[] GetWrapper(FileAttachment[] src) { return null; }

        String IFileAttachment.AreaNodeUri
        {
            get
            {
                string nativeCallResult = r_Instance.AreaNodeUri;
                return nativeCallResult;
            }
            set { r_Instance.AreaNodeUri = value; }
        }

        Guid IFileAttachment.FileNameGUID
        {
            get
            {
                Guid nativeCallResult = r_Instance.FileNameGUID;
                return nativeCallResult;
            }
            set { r_Instance.FileNameGUID = value; }
        }

        Stream IFileAttachment.LocalFile
        {
            get
            {
                Stream nativeCallResult = r_Instance.LocalFile;
                return nativeCallResult;
            }
            set { r_Instance.LocalFile = value; }
        }

        String IFileAttachment.ProjectUri
        {
            get
            {
                string nativeCallResult = r_Instance.ProjectUri;
                return nativeCallResult;
            }
            set { r_Instance.ProjectUri = value; }
        }

        private FileAttachmentWrapper(FileAttachment instance) { r_Instance = instance; }
        private FileAttachment r_Instance;
    }
}