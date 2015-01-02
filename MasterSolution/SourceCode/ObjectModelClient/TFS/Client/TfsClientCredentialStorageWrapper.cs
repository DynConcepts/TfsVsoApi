using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.Services.Common;
using IssuedToken = Microsoft.TeamFoundation.Client.IssuedToken;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class TfsClientCredentialStorageWrapper.
    /// </summary>
    internal class TfsClientCredentialStorageWrapper : TfsClientCredentialStorageWrapper<ITfsClientCredentialStorage, TfsClientCredentialStorage>, ITfsClientCredentialStorage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsClientCredentialStorageWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsClientCredentialStorageWrapper(TfsClientCredentialStorage instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsClientCredentialStorage, TfsClientCredentialStorage>(src => src == null ? null : ((TfsClientCredentialStorageWrapper) src).r_Instance, src => new TfsClientCredentialStorageWrapper(src)); }
    }


    /// <summary>
    /// Class TfsClientCredentialStorageWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class TfsClientCredentialStorageWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsClientCredentialStorage where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the token property.
        /// </summary>
        /// <param name="serverUrls">The server urls.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>String[].</returns>
        String[] ITfsClientCredentialStorage.GetTokenProperty(Uri[] serverUrls, String propertyName)
        {
            string[] nativeCallResult = r_Instance.GetTokenProperty(serverUrls, propertyName);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the token property.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>String.</returns>
        String ITfsClientCredentialStorage.GetTokenProperty(Uri serverUrl, String propertyName)
        {
            string nativeCallResult = r_Instance.GetTokenProperty(serverUrl, propertyName);
            return nativeCallResult;
        }


        /// <summary>
        /// Removes the token.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        void ITfsClientCredentialStorage.RemoveToken(Uri serverUrl) { r_Instance.RemoveToken(serverUrl); }

        /// <summary>
        /// Removes the token value.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="token">The token.</param>
        /// <returns>Boolean.</returns>
        Boolean ITfsClientCredentialStorage.RemoveTokenValue(Uri serverUrl, IIssuedToken token)
        {
            bool nativeCallResult = r_Instance.RemoveTokenValue(serverUrl, IssuedTokenWrapper.GetInstance(token));
            return nativeCallResult;
        }


        /// <summary>
        /// Removes the token values by user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        void ITfsClientCredentialStorage.RemoveTokenValuesByUser(Guid userId) { r_Instance.RemoveTokenValuesByUser(userId); }

        /// <summary>
        /// Retrieves the token.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="credentialType">Type of the credential.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken ITfsClientCredentialStorage.RetrieveToken(Uri serverUrl, VssCredentialsType credentialType)
        {
            IssuedToken nativeCallResult = r_Instance.RetrieveToken(serverUrl, credentialType);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Stores the token.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="token">The token.</param>
        /// <param name="matchUserInformation">The match user information.</param>
        void ITfsClientCredentialStorage.StoreToken(Uri serverUrl, IIssuedToken token, Boolean matchUserInformation) { r_Instance.StoreToken(serverUrl, IssuedTokenWrapper.GetInstance(token), matchUserInformation); }
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsClientCredentialStorageWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsClientCredentialStorageWrapper(TfsClientCredentialStorage instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly TfsClientCredentialStorage r_Instance;
    }
}