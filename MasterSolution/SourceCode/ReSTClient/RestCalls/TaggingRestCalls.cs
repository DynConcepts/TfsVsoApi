using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class TaggingRestCalls.
    /// </summary>
    internal class TaggingRestCalls
    {
        /// <summary>
        ///     Gets the tags.
        /// </summary>
        /// <value>The tags.</value>
        internal static CallSpec Tags { get { return sr_Tags; } }

        /// <summary>
        ///     The SR_ tags
        /// </summary>
        private static readonly CallSpec sr_Tags = new CallSpec("_apis/Tagging/scopes/{scopeId}/tags/{tagId}");
    }
}