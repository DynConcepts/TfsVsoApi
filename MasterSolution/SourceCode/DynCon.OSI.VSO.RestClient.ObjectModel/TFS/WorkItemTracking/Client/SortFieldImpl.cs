using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class SortFieldImpl.
    /// </summary>
    internal class SortFieldImpl : ISortField
    {
        /// <summary>
        ///     Gets the field definition.
        /// </summary>
        /// <value>The field definition.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IFieldDefinition ISortField.FieldDefinition { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type of the sort.
        /// </summary>
        /// <value>The type of the sort.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ISortType ISortField.SortType { get { throw new ToBeImplementedException(); } }
    }
}