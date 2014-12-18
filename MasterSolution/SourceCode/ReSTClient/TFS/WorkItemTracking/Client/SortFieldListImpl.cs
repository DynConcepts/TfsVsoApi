using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class SortFieldListImpl : OrderedVariableSizeListImpl, ISortFieldList
    {
        Int32 ISortFieldList.Add(ISortField sortField) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 ISortFieldList.Add(String name, ISortType sortType) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean ISortFieldList.Contains(ISortField value) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 ISortFieldList.IndexOf(ISortField sortField) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 ISortFieldList.IndexOfFieldId(Int32 id) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ISortFieldList.Insert(Int32 index, ISortField sortField) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ISortFieldList.Insert(Int32 index, String name, ISortType sortType) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        ISortField ISortFieldList.this[Int32 index] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ISortFieldList.Remove(String fieldName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ISortFieldList.Remove(IFieldDefinition fd) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ISortFieldList.Remove(ISortField value) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}