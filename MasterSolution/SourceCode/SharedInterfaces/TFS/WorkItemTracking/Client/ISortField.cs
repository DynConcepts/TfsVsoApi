namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface ISortField
    /// </summary>
    public interface ISortField
    {
        /// <summary>
        /// Gets the field definition.
        /// </summary>
        /// <value>The field definition.</value>
        IFieldDefinition FieldDefinition { get; }
        /// <summary>
        /// Gets the type of the sort.
        /// </summary>
        /// <value>The type of the sort.</value>
        ISortType SortType { get; }
    }
}