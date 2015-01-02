using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class AttachmentCollectionWrapper.
    /// </summary>
    internal class AttachmentCollectionWrapper : AttachmentCollectionWrapper<IAttachmentCollection, AttachmentCollection>, IAttachmentCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AttachmentCollectionWrapper(AttachmentCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IAttachmentCollection, AttachmentCollection>(src => src == null ? null : ((AttachmentCollectionWrapper) src).r_Instance, src => new AttachmentCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class AttachmentCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class AttachmentCollectionWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, IAttachmentCollection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Adds the specified attachment.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>Int32.</returns>
        Int32 IAttachmentCollection.Add(IAttachment attachment)
        {
            int nativeCallResult = r_Instance.Add(AttachmentWrapper.GetInstance(attachment));
            return nativeCallResult;
        }


        /// <summary>
        /// Determines whether [contains] [the specified attachment].
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>Boolean.</returns>
        Boolean IAttachmentCollection.Contains(IAttachment attachment)
        {
            bool nativeCallResult = r_Instance.Contains(AttachmentWrapper.GetInstance(attachment));
            return nativeCallResult;
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>Int32.</returns>
        Int32 IAttachmentCollection.IndexOf(IAttachment attachment)
        {
            int nativeCallResult = r_Instance.IndexOf(AttachmentWrapper.GetInstance(attachment));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the <see cref="IAttachment" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IAttachment.</returns>
        IAttachment IAttachmentCollection.this[Int32 index]
        {
            get
            {
                Attachment nativeCallResult = r_Instance[index];
                IAttachment wrappedCallResult = AttachmentWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        void IAttachmentCollection.Refresh() { r_Instance.Refresh(); }
        /// <summary>
        /// Removes the specified attachment.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        void IAttachmentCollection.Remove(IAttachment attachment) { r_Instance.Remove(AttachmentWrapper.GetInstance(attachment)); }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AttachmentCollectionWrapper(AttachmentCollection instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly AttachmentCollection r_Instance;
    }
}