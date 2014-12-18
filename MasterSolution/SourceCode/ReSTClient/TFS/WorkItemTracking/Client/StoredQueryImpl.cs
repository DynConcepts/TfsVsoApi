using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class StoredQueryImpl : IStoredQuery, IComparable
    {
        Int32 IStoredQuery.CompareTo(IStoredQuery storedQuery) { throw new ToBeImplementedException(); }
        Int32 IComparable.CompareTo(Object obj) { throw new ToBeImplementedException(); }
        DateTime IStoredQuery.CreationTime { get { throw new ToBeImplementedException(); } }
        DateTime IStoredQuery.CreationTimeUtc { get { throw new ToBeImplementedException(); } }
        String IStoredQuery.Description { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean IStoredQuery.IsSaved { get { throw new ToBeImplementedException(); } }
        DateTime IStoredQuery.LastWriteTime { get { throw new ToBeImplementedException(); } }
        DateTime IStoredQuery.LastWriteTimeUtc { get { throw new ToBeImplementedException(); } }
        String IStoredQuery.Name { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IStoredQuery.Owner { get { throw new ToBeImplementedException(); } }
        IProject IStoredQuery.Project { get { throw new ToBeImplementedException(); } }
        Guid IStoredQuery.QueryGuid { get { throw new ToBeImplementedException(); } }
        IQueryScope IStoredQuery.QueryScope { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IStoredQuery.QueryText { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IStoredQuery.Reset() { throw new ToBeImplementedException(); }
        void IStoredQuery.Update() { throw new ToBeImplementedException(); }
    }
}