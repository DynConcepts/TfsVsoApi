using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class RegisteredLinkTypeImpl.
    /// </summary>
    internal class RegisteredLinkTypeImpl : IRegisteredLinkType
    {
        /// <summary>
        ///     Equalses the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IRegisteredLinkType.Equals(IRegisteredLinkType type) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IRegisteredLinkType.Name { get { throw new ToBeImplementedException(); } }
    }
}