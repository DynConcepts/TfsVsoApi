using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IDisplayFieldList : IOrderedVariableSizeList
    {
        Int32 Add(IFieldDefinition value);
        Int32 Add(String fieldName);
        Boolean Contains(IFieldDefinition value);
        Int32 IndexOf(IFieldDefinition value);
        Int32 IndexOfFieldId(Int32 id);
        void Insert(Int32 index, IFieldDefinition value);
        void Insert(Int32 index, String fieldName);
        void Remove(String fieldName);
        void Remove(IFieldDefinition value);
        IFieldDefinition this[Int32 index] { get; set; }
    }
}