using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class ReportingAttributesImpl.
    /// </summary>
    internal class ReportingAttributesImpl : IReportingAttributes
    {
        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IReportingAttributes.Name { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IReportingAttributes.ReferenceName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IReportingType IReportingAttributes.Type { get { throw new ToBeImplementedException(); } }
    }
}