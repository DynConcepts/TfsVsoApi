using System;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class DisplayFieldListImpl : OrderedVariableSizeListImpl, IDisplayFieldList
    {
        Int32 IDisplayFieldList.Add(IFieldDefinition value) { throw new ToBeImplementedException(); }
        Int32 IDisplayFieldList.Add(String fieldName) { throw new ToBeImplementedException(); }
        Boolean IDisplayFieldList.Contains(IFieldDefinition value) { throw new ToBeImplementedException(); }
        Int32 IDisplayFieldList.IndexOf(IFieldDefinition value) { throw new ToBeImplementedException(); }
        Int32 IDisplayFieldList.IndexOfFieldId(Int32 id) { throw new ToBeImplementedException(); }
        void IDisplayFieldList.Insert(Int32 index, IFieldDefinition value) { throw new ToBeImplementedException(); }
        void IDisplayFieldList.Insert(Int32 index, String fieldName) { throw new ToBeImplementedException(); }
        IFieldDefinition IDisplayFieldList.this[Int32 index] { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IDisplayFieldList.Remove(String fieldName) { throw new ToBeImplementedException(); }
        void IDisplayFieldList.Remove(IFieldDefinition value) { throw new ToBeImplementedException(); }
    }
}