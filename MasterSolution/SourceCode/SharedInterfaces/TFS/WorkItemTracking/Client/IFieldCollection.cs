using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IFieldCollection : IReadOnlyList
  {
    IField GetById( Int32 id);
    IField TryGetById( Int32 id);
    Boolean Contains( String fieldName);
    Boolean Contains( Int32 id);
    void DropCachedData();
    Int32 IndexOf( IField value);
    Boolean Contains( IField value);
    IField this[Int32 index] { get;   }
    IField this[ICoreField coreField] { get;   }
    IField this[String name] { get;   }
  }
}
