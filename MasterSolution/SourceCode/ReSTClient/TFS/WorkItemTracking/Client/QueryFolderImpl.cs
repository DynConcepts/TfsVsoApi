using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryFolderImpl : QueryItemImpl, IQueryFolder, IEnumerable
    {
        void IQueryFolder.Add(IQueryItem item) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IQueryFolder.Contains(String name) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IQueryFolder.Contains(IQueryItem item) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IQueryFolder.Contains(Guid id) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IQueryFolder.Count { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IEnumerator IEnumerable.GetEnumerator() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IQueryFolder.IsRootNode { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IQueryItem IQueryFolder.this[Guid id] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IQueryItem IQueryFolder.this[String name] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}