using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class AttachmentCollectionWrapper : AttachmentCollectionWrapper<IAttachmentCollection, AttachmentCollection>, IAttachmentCollection
    {
        protected AttachmentCollectionWrapper(AttachmentCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAttachmentCollection, AttachmentCollection>(src => src==null ? null : ((AttachmentCollectionWrapper) src).r_Instance, src => new AttachmentCollectionWrapper(src)); }
    }


    internal class AttachmentCollectionWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, IAttachmentCollection where TInterface : class where TWrapper : class
    {

        Int32 IAttachmentCollection.Add(IAttachment attachment)
        {
            int nativeCallResult = r_Instance.Add(AttachmentWrapper.GetInstance(attachment));
            return nativeCallResult;
        }



        Boolean IAttachmentCollection.Contains(IAttachment attachment)
        {
            bool nativeCallResult = r_Instance.Contains(AttachmentWrapper.GetInstance(attachment));
            return nativeCallResult;
        }

        Int32 IAttachmentCollection.IndexOf(IAttachment attachment)
        {
            int nativeCallResult = r_Instance.IndexOf(AttachmentWrapper.GetInstance(attachment));
            return nativeCallResult;
        }

        IAttachment IAttachmentCollection.this[Int32 index]
        {
            get
            {
                Attachment nativeCallResult = r_Instance[index];
                IAttachment wrappedCallResult = AttachmentWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IAttachmentCollection.Refresh() { r_Instance.Refresh(); }
        void IAttachmentCollection.Remove(IAttachment attachment) { r_Instance.Remove(AttachmentWrapper.GetInstance(attachment)); }
        protected AttachmentCollectionWrapper(AttachmentCollection instance) : base(instance) { r_Instance = instance; }
        protected new readonly AttachmentCollection r_Instance;
    }
}