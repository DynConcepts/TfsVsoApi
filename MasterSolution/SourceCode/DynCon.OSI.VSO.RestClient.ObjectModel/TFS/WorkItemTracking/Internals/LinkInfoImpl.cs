using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals
{
    internal class LinkInfoImpl : ILinkInfo
    {
        DateTime ILinkInfo.AuthorizedAddedDate { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        DateTime ILinkInfo.AuthorizedRemovedDate { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String ILinkInfo.Comment { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 ILinkInfo.FieldId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}