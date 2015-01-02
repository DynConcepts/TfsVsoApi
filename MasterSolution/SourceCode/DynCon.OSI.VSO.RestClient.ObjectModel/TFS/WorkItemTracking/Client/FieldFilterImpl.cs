using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class FieldFilterImpl.
    /// </summary>
    internal class FieldFilterImpl : IFieldFilter
    {
        /// <summary>
        ///     Gets the field definition.
        /// </summary>
        /// <value>The field definition.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IFieldDefinition IFieldFilter.FieldDefinition { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Object IFieldFilter.Value { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}