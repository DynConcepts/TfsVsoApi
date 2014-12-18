using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ISortFieldList : IOrderedVariableSizeList
  {
    Int32 IndexOfFieldId( Int32 id);
    Int32 IndexOf( ISortField sortField);
    Int32 Add( ISortField sortField);
    Int32 Add( String name, ISortType sortType);
    void Insert( Int32 index, ISortField sortField);
    void Insert( Int32 index, String name, ISortType sortType);
    void Remove( String fieldName);
    void Remove( IFieldDefinition fd);
    Boolean Contains( ISortField value);
    void Remove( ISortField value);
    ISortField this[Int32 index] { get; set;   }
  }
}
