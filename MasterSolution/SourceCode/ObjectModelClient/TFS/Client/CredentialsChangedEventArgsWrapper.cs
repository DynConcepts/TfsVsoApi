using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class CredentialsChangedEventArgsWrapper.
    /// </summary>
    internal class CredentialsChangedEventArgsWrapper : CredentialsChangedEventArgsWrapper<ICredentialsChangedEventArgs, CredentialsChangedEventArgs>, ICredentialsChangedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsChangedEventArgsWrapper"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="CredentialsChangedEventArgs"/> instance containing the event data.</param>
        protected CredentialsChangedEventArgsWrapper(CredentialsChangedEventArgs instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ICredentialsChangedEventArgs, CredentialsChangedEventArgs>(src => src == null ? null : ((CredentialsChangedEventArgsWrapper) src).r_Instance, src => new CredentialsChangedEventArgsWrapper(src)); }
    }


    /// <summary>
    /// Class CredentialsChangedEventArgsWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class CredentialsChangedEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICredentialsChangedEventArgs where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ICredentials ICredentialsChangedEventArgs.Credentials
        {
            get
            {
                ICredentials nativeCallResult = r_Instance.Credentials;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsChangedEventArgsWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="CredentialsChangedEventArgs"/> instance containing the event data.</param>
        protected CredentialsChangedEventArgsWrapper(CredentialsChangedEventArgs instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly CredentialsChangedEventArgs r_Instance;
    }
}