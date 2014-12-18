using System;
using System.Collections;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryFolderImpl : QueryItemImpl, IQueryFolder, IEnumerable
    {
        void IQueryFolder.Add(IQueryItem item) { throw new ToBeImplementedException(); }
        Boolean IQueryFolder.Contains(String name) { throw new ToBeImplementedException(); }
        Boolean IQueryFolder.Contains(IQueryItem item) { throw new ToBeImplementedException(); }
        Boolean IQueryFolder.Contains(Guid id) { throw new ToBeImplementedException(); }
        Int32 IQueryFolder.Count { get { throw new ToBeImplementedException(); } }
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }
        Boolean IQueryFolder.IsRootNode { get { throw new ToBeImplementedException(); } }
        IQueryItem IQueryFolder.this[Guid id] { get { throw new ToBeImplementedException(); } }
        IQueryItem IQueryFolder.this[String name] { get { throw new ToBeImplementedException(); } }
    }
}