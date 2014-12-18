using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.TeamFoundation.Client;
using System;

namespace DynCon.OSI.VSO.ObjectModelClient.Helpers
{
    /// <summary>
    /// Class TfsTeamProjectCollectionWrapper.
    /// </summary>
    internal class TfsTeamProjectCollectionWrapper : SharedInterfaces.Objects.ITfsTeamProjectCollection
    {
        /// <summary>
        /// The r_ instance
        /// </summary>
        private ITfsTeamProjectCollection m_Instance;

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        public T GetService<T>() { return default(T); }

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns>System.Object.</returns>
        public object GetService(Type serviceType) { return null; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsTeamProjectCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public TfsTeamProjectCollectionWrapper(ITfsTeamProjectCollection instance) { m_Instance = instance; }

        public static ITfsTeamProjectCollection GetWrapper(TfsTeamProjectCollection teamProjectCollection) { throw new NotImplementedException(); }
    }
}
