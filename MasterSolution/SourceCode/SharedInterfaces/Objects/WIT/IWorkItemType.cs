using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
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

        /// <summary>
        /// Exports the specified flag.
        /// </summary>
        /// <param name="flag">if set to <c>true</c> [flag].</param>
        /// <returns>XmlDocument.</returns>
        XmlDocument Export(bool flag);

        /// <summary>
        /// Gets the field definitions.
        /// </summary>
        /// <value>The field definitions.</value>
        IFieldDefinitionCollection FieldDefinitions { get; }
    }
}