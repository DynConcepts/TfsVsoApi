using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class IMSRestCalls.
    /// </summary>
    internal class IMSRestCalls
    {
        /// <summary>
        ///     Gets the identities.
        /// </summary>
        /// <value>The identities.</value>
        internal static CallSpec Identities { get { return sr_Identities; } }

        /// <summary>
        ///     Gets the identity batch.
        /// </summary>
        /// <value>The identity batch.</value>
        internal static CallSpec IdentityBatch { get { return sr_IdentityBatch; } }

        /// <summary>
        ///     Gets the identity snapshot.
        /// </summary>
        /// <value>The identity snapshot.</value>
        internal static CallSpec IdentitySnapshot { get { return sr_IdentitySnapshot; } }

        /// <summary>
        ///     Gets the members.
        /// </summary>
        /// <value>The members.</value>
        internal static CallSpec Members { get { return sr_Members; } }

        /// <summary>
        ///     Gets the members of.
        /// </summary>
        /// <value>The members of.</value>
        internal static CallSpec MembersOf { get { return sr_MembersOf; } }

        /// <summary>
        ///     The SR_ identities
        /// </summary>
        private static readonly CallSpec sr_Identities = new CallSpec("_apis/Identities/{identityId}");

        /// <summary>
        ///     The SR_ identity batch
        /// </summary>
        private static readonly CallSpec sr_IdentityBatch = new CallSpec("_apis/IdentityBatch");

        /// <summary>
        ///     The SR_ identity snapshot
        /// </summary>
        private static readonly CallSpec sr_IdentitySnapshot = new CallSpec("_apis/IdentitySnapshot/{scopeId}");

        /// <summary>
        ///     The SR_ members
        /// </summary>
        private static readonly CallSpec sr_Members = new CallSpec("_apis/identities/{containerId}/Members/{memberId}");

        /// <summary>
        ///     The SR_ members of
        /// </summary>
        private static readonly CallSpec sr_MembersOf = new CallSpec("_apis/identities/{memberId}/MembersOf/{containerId}");
    }
}