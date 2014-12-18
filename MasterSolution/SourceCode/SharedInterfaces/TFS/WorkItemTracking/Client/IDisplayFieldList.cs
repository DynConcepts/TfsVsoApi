using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IDisplayFieldList : IOrderedVariableSizeList
  {
    void Remove( String fieldName);
    Int32 IndexOfFieldId( Int32 id);
    Int32 IndexOf( IFieldDefinition value);
    Boolean Contains( IFieldDefinition value);
    void Remove( IFieldDefinition value);
    Int32 Add( IFieldDefinition value);
    void Insert( Int32 index, IFieldDefinition value);
    Int32 Add( String fieldName);
    void Insert( Int32 index, String fieldName);
    IFieldDefinition this[Int32 index] { get; set;   }
  }
}
