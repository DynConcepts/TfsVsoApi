using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class WindowsCredentialWrapper.
    /// </summary>
    internal class WindowsCredentialWrapper : WindowsCredentialWrapper<IWindowsCredential, WindowsCredential>, IWindowsCredential
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsCredentialWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected WindowsCredentialWrapper(WindowsCredential instance) : base(instance) {  r_Instance = instance; }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IWindowsCredential, WindowsCredential>(src => src == null ? null : ((WindowsCredentialWrapper)src).r_Instance, src => new WindowsCredentialWrapper(src)); }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly WindowsCredential r_Instance;

        protected override IssuedTokenCredential IssuedTokenCredentialInstance { get { return r_Instance; } }

        protected override WindowsCredential WindowsCredentialInstance { get { return r_Instance; } }
    }



    /// <summary>
    /// Class WindowsCredentialWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class WindowsCredentialWrapper<TWrapper, TInterface> : IssuedTokenCredentialWrapper<TWrapper, TInterface>, IWindowsCredential
        where TInterface : class
        where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ICredentials IWindowsCredential.Credentials
        {
            get
            {
                ICredentials nativeCallResult = WindowsCredentialInstance.Credentials;
                return nativeCallResult;
            }
            set { WindowsCredentialInstance.Credentials = value; }
        }

        /// <summary>
        /// The r_ instance
        /// </summary>
        protected abstract WindowsCredential WindowsCredentialInstance { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsCredentialWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected WindowsCredentialWrapper(WindowsCredential instance) : base(instance) {  }
     }
}