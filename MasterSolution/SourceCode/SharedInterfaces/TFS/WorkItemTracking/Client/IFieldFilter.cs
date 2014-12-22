using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IFieldFilter
    {
        IFieldDefinition FieldDefinition { get; }
        Object Value { get; set; }
    }
}