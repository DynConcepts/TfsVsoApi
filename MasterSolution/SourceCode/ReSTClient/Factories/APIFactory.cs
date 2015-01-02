using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;

namespace DynCon.OSI.VSO.ReSTClient.Factories
{
    /// <summary>
    ///     Class APIFactory.
    /// </summary>
    public static class APIFactory
    {
   
        /// <summary>
        ///     Gets the work item API.
        /// </summary>
        /// <value>The work item API.</value>
        public static JsonWitAPI JsonWorkItemAPI { get { return new JsonWitAPI(); } }

        ///// <summary>
        ///// Gets the TFS version control API.
        ///// </summary>
        ///// <value>The TFS version control API.</value>
        //public static ITFSVersionControlAPI TFSVersionControlAPI { get { return new TFSVersionControlAPI(); } }

    //    /// <summary>
    //    /// Connects the specified URL.
    //    /// </summary>
    //    /// <param name="url">The URL.</param>
    //    /// <returns>ITfsTeamProjectCollection.</returns>
    //    public static ITfsTeamProjectCollection Connect(Uri url)
    //    {
    //        JsonWorkItem.APIFactory = () => new JsonWitAPI();
    //        return new TfsTeamProjectCollectionImpl(url);
    //    }

    }
}