using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class RevisionWrapper : RevisionWrapper<IRevision, Revision>, IRevision
    {
        protected RevisionWrapper(Revision instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IRevision, Revision>(src => ((RevisionWrapper) src).r_Instance, src => new RevisionWrapper(src)); }
    }


    internal class RevisionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IRevision where TInterface : class where TWrapper : class
    {

        IAttachmentCollection IRevision.Attachments
        {
            get
            {
                AttachmentCollection nativeCallResult = r_Instance.Attachments;
                IAttachmentCollection wrappedCallResult = AttachmentCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IFieldCollection IRevision.Fields
        {
            get
            {
                FieldCollection nativeCallResult = r_Instance.Fields;
                IFieldCollection wrappedCallResult = FieldCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IRevision.GetTagLine()
        {
            string nativeCallResult = r_Instance.GetTagLine();
            return nativeCallResult;
        }

        Int32 IRevision.Index
        {
            get
            {
                int nativeCallResult = r_Instance.Index;
                return nativeCallResult;
            }
        }

        Object IRevision.this[String name]
        {
            get
            {
                object nativeCallResult = r_Instance[name];
                return nativeCallResult;
            }
        }

        ILinkCollection IRevision.Links
        {
            get
            {
                LinkCollection nativeCallResult = r_Instance.Links;
                ILinkCollection wrappedCallResult = LinkCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IWorkItem IRevision.WorkItem
        {
            get
            {
                WorkItem nativeCallResult = r_Instance.WorkItem;
                IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected RevisionWrapper(Revision instance) { r_Instance = instance; }
        protected readonly Revision r_Instance;
    }
}