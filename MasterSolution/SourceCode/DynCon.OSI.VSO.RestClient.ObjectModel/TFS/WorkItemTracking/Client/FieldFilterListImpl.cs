using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class FieldFilterListImpl : VariableSizeListImpl, IFieldFilterList
    {
        Int32 IFieldFilterList.Add(IFieldFilter filter) { throw new ToBeImplementedException(); }
        Boolean IFieldFilterList.Contains(IFieldFilter value) { throw new ToBeImplementedException(); }
        Int32 IFieldFilterList.IndexOf(IFieldFilter filter) { throw new ToBeImplementedException(); }
        Int32 IFieldFilterList.IndexOfFieldId(Int32 id) { throw new ToBeImplementedException(); }
        IFieldFilter IFieldFilterList.this[Int32 index] { get { throw new ToBeImplementedException(); } }
        void IFieldFilterList.Remove(IFieldFilter value) { throw new ToBeImplementedException(); }
    }
}