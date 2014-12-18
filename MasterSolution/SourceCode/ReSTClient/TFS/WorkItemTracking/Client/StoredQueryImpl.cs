using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class StoredQueryImpl : IStoredQuery, IComparable
    {
        Int32 IStoredQuery.CompareTo(IStoredQuery storedQuery) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IComparable.CompareTo(Object obj) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        DateTime IStoredQuery.CreationTime { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime IStoredQuery.CreationTimeUtc { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IStoredQuery.Description { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IStoredQuery.IsSaved { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime IStoredQuery.LastWriteTime { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime IStoredQuery.LastWriteTimeUtc { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IStoredQuery.Name { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IStoredQuery.Owner { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IProject IStoredQuery.Project { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Guid IStoredQuery.QueryGuid { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IQueryScope IStoredQuery.QueryScope { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IStoredQuery.QueryText { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IStoredQuery.Reset() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IStoredQuery.Update() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}