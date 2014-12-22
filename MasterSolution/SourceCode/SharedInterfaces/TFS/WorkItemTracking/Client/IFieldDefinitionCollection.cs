using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IFieldDefinitionCollection : IReadOnlyList
    {
        Boolean Contains(String name);
        Boolean Contains(Int32 id);
        Boolean Contains(IFieldDefinition fieldDefinition);
        IFieldDefinition GetById(Int32 id);
        Int32 IndexOf(IFieldDefinition fieldDefinition);
        IFieldDefinition TryGetById(Int32 id);
        IFieldDefinition TryGetByName(String name);
        IFieldDefinition this[Int32 index] { get; }
        IFieldDefinition this[ICoreField coreField] { get; }
        IFieldDefinition this[String name] { get; }
    }
}