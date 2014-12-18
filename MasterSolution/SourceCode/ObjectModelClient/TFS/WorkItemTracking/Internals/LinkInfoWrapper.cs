using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals
{
    internal class LinkInfoWrapper : LinkInfoWrapper<ILinkInfo, LinkInfo>, ILinkInfo
    {
        protected LinkInfoWrapper(LinkInfo instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ILinkInfo, LinkInfo>(src => ((LinkInfoWrapper) src).r_Instance, src => new LinkInfoWrapper(src)); }
    }


    internal abstract class LinkInfoWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ILinkInfo where TInterface : class where TWrapper : class
    {
        DateTime ILinkInfo.AuthorizedAddedDate
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AuthorizedAddedDate;
                return nativeCallResult;
            }
            set { r_Instance.AuthorizedAddedDate = value; }
        }

        DateTime ILinkInfo.AuthorizedRemovedDate
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AuthorizedRemovedDate;
                return nativeCallResult;
            }
            set { r_Instance.AuthorizedRemovedDate = value; }
        }

        String ILinkInfo.Comment
        {
            get
            {
                string nativeCallResult = r_Instance.Comment;
                return nativeCallResult;
            }
            set { r_Instance.Comment = value; }
        }

        Int32 ILinkInfo.FieldId
        {
            get
            {
                int nativeCallResult = r_Instance.FieldId;
                return nativeCallResult;
            }
            set { r_Instance.FieldId = value; }
        }

        protected LinkInfoWrapper(LinkInfo instance) { r_Instance = instance; }
        protected readonly LinkInfo r_Instance;
    }
}