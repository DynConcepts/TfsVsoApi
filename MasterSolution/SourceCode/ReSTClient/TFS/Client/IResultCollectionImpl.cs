using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class IResultCollectionImpl<T> : IIResultCollection<T>, IEnumerable, IDisposable
    {
        void IDisposable.Dispose() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerator IEnumerable.GetEnumerator() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}