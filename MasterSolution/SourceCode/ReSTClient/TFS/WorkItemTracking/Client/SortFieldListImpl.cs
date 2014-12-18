using System;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class SortFieldListImpl : OrderedVariableSizeListImpl, ISortFieldList
    {
        Int32 ISortFieldList.Add(ISortField sortField) { throw new ToBeImplementedException(); }
        Int32 ISortFieldList.Add(String name, ISortType sortType) { throw new ToBeImplementedException(); }
        Boolean ISortFieldList.Contains(ISortField value) { throw new ToBeImplementedException(); }
        Int32 ISortFieldList.IndexOf(ISortField sortField) { throw new ToBeImplementedException(); }
        Int32 ISortFieldList.IndexOfFieldId(Int32 id) { throw new ToBeImplementedException(); }
        void ISortFieldList.Insert(Int32 index, ISortField sortField) { throw new ToBeImplementedException(); }
        void ISortFieldList.Insert(Int32 index, String name, ISortType sortType) { throw new ToBeImplementedException(); }
        ISortField ISortFieldList.this[Int32 index] { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void ISortFieldList.Remove(String fieldName) { throw new ToBeImplementedException(); }
        void ISortFieldList.Remove(IFieldDefinition fd) { throw new ToBeImplementedException(); }
        void ISortFieldList.Remove(ISortField value) { throw new ToBeImplementedException(); }
    }
}