namespace DynCon.OSI.VSO.SharedInterfaces.Objects
{
    /// <summary>
    ///     Represents a TFS/VSO WorkItem Type
    /// </summary>
    public interface IWorkItemType
    {
        /// <summary>
        ///     Gets the description.
        /// </summary>
        /// <value>The description.</value>
        string Description { get; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
    }
}