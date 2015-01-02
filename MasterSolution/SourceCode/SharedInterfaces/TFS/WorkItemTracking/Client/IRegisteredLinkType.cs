using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IRegisteredLinkType
    /// </summary>
    public interface IRegisteredLinkType
    {
        /// <summary>
        /// Equalses the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>Boolean.</returns>
        Boolean Equals(IRegisteredLinkType type);
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
    }
}