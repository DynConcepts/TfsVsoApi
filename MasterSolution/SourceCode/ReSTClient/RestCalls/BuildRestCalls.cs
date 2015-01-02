using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class BuildRestCalls.
    /// </summary>
    internal class BuildRestCalls
    {
        /// <summary>
        ///     Gets the artifacts.
        /// </summary>
        /// <value>The artifacts.</value>
        internal static CallSpec Artifacts { get { return sr_Artifacts; } }

        /// <summary>
        ///     Gets the commits.
        /// </summary>
        /// <value>The commits.</value>
        internal static CallSpec Commits { get { return sr_Commits; } }

        /// <summary>
        ///     Gets the definitions.
        /// </summary>
        /// <value>The definitions.</value>
        internal static CallSpec Definitions { get { return sr_Definitions; } }

        /// <summary>
        ///     Gets the logs.
        /// </summary>
        /// <value>The logs.</value>
        internal static CallSpec Logs { get { return sr_Logs; } }

        /// <summary>
        ///     Gets the options.
        /// </summary>
        /// <value>The options.</value>
        internal static CallSpec Options { get { return sr_Options; } }

        /// <summary>
        ///     Gets the revisions.
        /// </summary>
        /// <value>The revisions.</value>
        internal static CallSpec Revisions { get { return sr_Revisions; } }

        /// <summary>
        ///     Gets the tags0.
        /// </summary>
        /// <value>The tags0.</value>
        internal static CallSpec Tags0 { get { return sr_Tags0; } }

        /// <summary>
        ///     Gets the tags1.
        /// </summary>
        /// <value>The tags1.</value>
        internal static CallSpec Tags1 { get { return sr_Tags1; } }

        /// <summary>
        ///     Gets the templates.
        /// </summary>
        /// <value>The templates.</value>
        internal static CallSpec Templates { get { return sr_Templates; } }

        /// <summary>
        ///     The SR_ artifacts
        /// </summary>
        private static readonly CallSpec sr_Artifacts = new CallSpec("_apis/build/builds/{buildId}/artifacts/{artifactName}");

        /// <summary>
        ///     The SR_ commits
        /// </summary>
        private static readonly CallSpec sr_Commits = new CallSpec("{project}/_apis/build/builds/{buildId}/commits");

        /// <summary>
        ///     The SR_ definitions
        /// </summary>
        private static readonly CallSpec sr_Definitions = new CallSpec("{project}/_apis/build/definitions");

        /// <summary>
        ///     The SR_ logs
        /// </summary>
        private static readonly CallSpec sr_Logs = new CallSpec("{project}/_apis/build/builds/{buildId}/logs");

        /// <summary>
        ///     The SR_ options
        /// </summary>
        private static readonly CallSpec sr_Options = new CallSpec("_apis/build/options");

        /// <summary>
        ///     The SR_ revisions
        /// </summary>
        private static readonly CallSpec sr_Revisions = new CallSpec("_apis/build/definitions/{definitionId}/revisions");

        /// <summary>
        ///     The SR_ tags0
        /// </summary>
        private static readonly CallSpec sr_Tags0 = new CallSpec("{project}/_apis/build/tags");

        /// <summary>
        ///     The SR_ tags1
        /// </summary>
        private static readonly CallSpec sr_Tags1 = new CallSpec("{project}/_apis/build/builds/{buildId}/tags/{tag}");

        /// <summary>
        ///     The SR_ templates
        /// </summary>
        private static readonly CallSpec sr_Templates = new CallSpec("{project}/_apis/build/definitions/templates/{templateId}");
    }
}