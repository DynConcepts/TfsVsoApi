namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface IIssuedTokenCredential
    /// </summary>
    public interface IIssuedTokenCredential
    {
        /// <summary>
        /// Gets or sets the token storage.
        /// </summary>
        /// <value>The token storage.</value>
        ITfsClientCredentialStorage TokenStorage { get; set; }
    }
}