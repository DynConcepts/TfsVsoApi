namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface IITfsTeamProjectCollectionObject
    /// </summary>
    public interface IITfsTeamProjectCollectionObject
    {
        /// <summary>
        /// Initializes the specified project collection.
        /// </summary>
        /// <param name="projectCollection">The project collection.</param>
        void Initialize(ITfsTeamProjectCollection projectCollection);
    }
}