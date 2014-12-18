using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class RevisionCollectionWrapper : RevisionCollectionWrapper<IRevisionCollection, RevisionCollection>, IRevisionCollection
    {
        protected RevisionCollectionWrapper(RevisionCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IRevisionCollection, RevisionCollection>(src => ((RevisionCollectionWrapper) src).r_Instance, src => new RevisionCollectionWrapper(src)); }
    }


    internal class RevisionCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, Revision, IRevision>, IRevisionCollection
        where TInterface : class
        where TWrapper : class
    {

        Boolean IRevisionCollection.Contains(IRevision value)
        {
            bool nativeCallResult = r_Instance.Contains(RevisionWrapper.GetInstance(value));
            return nativeCallResult;
        }

        Int32 IRevisionCollection.IndexOf(IRevision value)
        {
            int nativeCallResult = r_Instance.IndexOf(RevisionWrapper.GetInstance(value));
            return nativeCallResult;
        }

        IRevision IRevisionCollection.this[Int32 index]
        {
            get
            {
                Revision nativeCallResult = r_Instance[index];
                IRevision wrappedCallResult = RevisionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected RevisionCollectionWrapper(RevisionCollection instance)
            : base(instance, o => RevisionWrapper.GetWrapper((Revision) o)) { r_Instance = instance; }

        protected new readonly RevisionCollection r_Instance;
    }
}