using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class PackagingRestCalls.
    /// </summary>
    internal class PackagingRestCalls
    {
        /// <summary>
        ///     Gets the artifact batch.
        /// </summary>
        /// <value>The artifact batch.</value>
        internal static CallSpec ArtifactBatch { get { return sr_ArtifactBatch; } }

        /// <summary>
        ///     Gets the artifacts.
        /// </summary>
        /// <value>The artifacts.</value>
        internal static CallSpec Artifacts { get { return sr_Artifacts; } }

        /// <summary>
        ///     Gets the lineup batch.
        /// </summary>
        /// <value>The lineup batch.</value>
        internal static CallSpec LineupBatch { get { return sr_LineupBatch; } }

        /// <summary>
        ///     Gets the lineups.
        /// </summary>
        /// <value>The lineups.</value>
        internal static CallSpec Lineups { get { return sr_Lineups; } }

        /// <summary>
        ///     Gets the module batch.
        /// </summary>
        /// <value>The module batch.</value>
        internal static CallSpec ModuleBatch { get { return sr_ModuleBatch; } }

        /// <summary>
        ///     Gets the modules.
        /// </summary>
        /// <value>The modules.</value>
        internal static CallSpec Modules { get { return sr_Modules; } }

        /// <summary>
        ///     Gets the stores.
        /// </summary>
        /// <value>The stores.</value>
        internal static CallSpec Stores { get { return sr_Stores; } }

        /// <summary>
        ///     The SR_ artifact batch
        /// </summary>
        private static readonly CallSpec sr_ArtifactBatch = new CallSpec("_apis/Packaging/stores/{storeId}/ArtifactBatch");

        /// <summary>
        ///     The SR_ artifacts
        /// </summary>
        private static readonly CallSpec sr_Artifacts = new CallSpec("_apis/Packaging/stores/{storeId}/Artifacts/{moduleId}/{moduleVersion}/{*artifactId}");

        /// <summary>
        ///     The SR_ lineup batch
        /// </summary>
        private static readonly CallSpec sr_LineupBatch = new CallSpec("_apis/Packaging/stores/{storeId}/LineupBatch");

        /// <summary>
        ///     The SR_ lineups
        /// </summary>
        private static readonly CallSpec sr_Lineups = new CallSpec("_apis/Packaging/stores/{storeId}/Lineups/{lineupId}/{lineupVersion}");

        /// <summary>
        ///     The SR_ module batch
        /// </summary>
        private static readonly CallSpec sr_ModuleBatch = new CallSpec("_apis/Packaging/stores/{storeId}/ModuleBatch");

        /// <summary>
        ///     The SR_ modules
        /// </summary>
        private static readonly CallSpec sr_Modules = new CallSpec("_apis/Packaging/stores/{storeId}/Modules/{moduleId}/{moduleVersion}");

        /// <summary>
        ///     The SR_ stores
        /// </summary>
        private static readonly CallSpec sr_Stores = new CallSpec("_apis/Packaging/Stores");
    }
}