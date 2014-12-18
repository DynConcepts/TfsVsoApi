using System;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ValuesCollectionImpl : ReadOnlyListImpl, IValuesCollection
    {
        Boolean IValuesCollection.Contains(String value) { throw new ToBeImplementedException(); }
        Int32 IValuesCollection.IndexOf(String value) { throw new ToBeImplementedException(); }
        String IValuesCollection.this[Int32 index] { get { throw new ToBeImplementedException(); } }
    }
}