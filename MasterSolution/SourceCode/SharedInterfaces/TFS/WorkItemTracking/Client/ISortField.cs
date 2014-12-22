namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface ISortField
    {
        IFieldDefinition FieldDefinition { get; }
        ISortType SortType { get; }
    }
}