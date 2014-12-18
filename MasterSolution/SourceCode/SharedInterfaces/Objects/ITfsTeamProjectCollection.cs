using System;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects
{
    /// <summary>
    /// Interface ITfsTeamProjectCollectionWrapper
    /// </summary>
    public interface ITfsTeamProjectCollection
    {
        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        T GetService<T>();
        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns>System.Object.</returns>
        object GetService(Type serviceType);
    }
}