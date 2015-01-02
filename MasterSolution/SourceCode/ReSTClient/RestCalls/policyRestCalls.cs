using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class PolicyRestCalls.
    /// </summary>
    internal class PolicyRestCalls
    {
        /// <summary>
        ///     Gets the configurations.
        /// </summary>
        /// <value>The configurations.</value>
        internal static CallSpec Configurations { get { return sr_Configurations; } }

        /// <summary>
        ///     Gets the evaluations0.
        /// </summary>
        /// <value>The evaluations0.</value>
        internal static CallSpec Evaluations0 { get { return sr_Evaluations0; } }

        /// <summary>
        ///     Gets the evaluations1.
        /// </summary>
        /// <value>The evaluations1.</value>
        internal static CallSpec Evaluations1 { get { return sr_Evaluations1; } }

        /// <summary>
        ///     Gets the types.
        /// </summary>
        /// <value>The types.</value>
        internal static CallSpec Types { get { return sr_Types; } }

        /// <summary>
        ///     Gets the versions.
        /// </summary>
        /// <value>The versions.</value>
        internal static CallSpec Versions { get { return sr_Versions; } }

        /// <summary>
        ///     The SR_ configurations
        /// </summary>
        private static readonly CallSpec sr_Configurations = new CallSpec("_apis/policy/{projectId}/configurations/{configurationId}");

        /// <summary>
        ///     The SR_ evaluations0
        /// </summary>
        private static readonly CallSpec sr_Evaluations0 = new CallSpec("_apis/policy/{projectId}/configurations/{configurationId}/evaluations");

        /// <summary>
        ///     The SR_ evaluations1
        /// </summary>
        private static readonly CallSpec sr_Evaluations1 = new CallSpec("_apis/policy/{projectId}/evaluations");

        /// <summary>
        ///     The SR_ types
        /// </summary>
        private static readonly CallSpec sr_Types = new CallSpec("_apis/policy/types/{typeId}");

        /// <summary>
        ///     The SR_ versions
        /// </summary>
        private static readonly CallSpec sr_Versions = new CallSpec("_apis/policy/{projectId}/configurations/{configurationId}/versions/{versionId}");
    }
}