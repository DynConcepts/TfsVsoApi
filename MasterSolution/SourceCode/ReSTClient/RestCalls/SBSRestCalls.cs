using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class SBSRestCalls.
    /// </summary>
    internal class SBSRestCalls
    {
        /// <summary>
        ///     Gets the SBS aces.
        /// </summary>
        /// <value>The SBS aces.</value>
        internal static CallSpec SBSAces { get { return sr_SBSAces; } }

        /// <summary>
        ///     Gets the SBS acls.
        /// </summary>
        /// <value>The SBS acls.</value>
        internal static CallSpec SBSAcls { get { return sr_SBSAcls; } }

        /// <summary>
        ///     Gets the SBS inherit.
        /// </summary>
        /// <value>The SBS inherit.</value>
        internal static CallSpec SBSInherit { get { return sr_SBSInherit; } }

        /// <summary>
        ///     Gets the SBS namespace.
        /// </summary>
        /// <value>The SBS namespace.</value>
        internal static CallSpec SBSNamespace { get { return sr_SBSNamespace; } }

        /// <summary>
        ///     Gets the SBS tokens.
        /// </summary>
        /// <value>The SBS tokens.</value>
        internal static CallSpec SBSTokens { get { return sr_SBSTokens; } }

        /// <summary>
        ///     The SR_ SBS aces
        /// </summary>
        private static readonly CallSpec sr_SBSAces = new CallSpec("_apis/SBS/{securityNamespaceId}/aces");

        /// <summary>
        ///     The SR_ SBS acls
        /// </summary>
        private static readonly CallSpec sr_SBSAcls = new CallSpec("_apis/SBS/{securityNamespaceId}/acls");

        /// <summary>
        ///     The SR_ SBS inherit
        /// </summary>
        private static readonly CallSpec sr_SBSInherit = new CallSpec("_apis/SBS/{securityNamespaceId}/inherit");

        /// <summary>
        ///     The SR_ SBS namespace
        /// </summary>
        private static readonly CallSpec sr_SBSNamespace = new CallSpec("_apis/SBS/{securityNamespaceId}");

        /// <summary>
        ///     The SR_ SBS tokens
        /// </summary>
        private static readonly CallSpec sr_SBSTokens = new CallSpec("_apis/SBS/{securityNamespaceId}/tokens");
    }
}