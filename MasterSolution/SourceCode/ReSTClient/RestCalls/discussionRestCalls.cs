using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class DiscussionRestCalls.
    /// </summary>
    internal class DiscussionRestCalls
    {
        /// <summary>
        ///     Initializes static members of the <see cref="DiscussionRestCalls" /> class.
        /// </summary>
        static DiscussionRestCalls() { ThreadsBatch = new CallSpec("_apis/discussion/threadsBatch"); }

        /// <summary>
        ///     Gets the comments0.
        /// </summary>
        /// <value>The comments0.</value>
        internal static CallSpec Comments0 { get { return sr_Comments0; } }

        /// <summary>
        ///     Gets the comments1.
        /// </summary>
        /// <value>The comments1.</value>
        internal static CallSpec Comments1 { get { return sr_Comments1; } }

        /// <summary>
        ///     Gets the threads0.
        /// </summary>
        /// <value>The threads0.</value>
        internal static CallSpec Threads0 { get { return sr_Threads0; } }

        /// <summary>
        ///     Gets the threads1.
        /// </summary>
        /// <value>The threads1.</value>
        internal static CallSpec Threads1 { get { return sr_Threads1; } }

        /// <summary>
        ///     Gets the threads batch.
        /// </summary>
        /// <value>The threads batch.</value>
        internal static CallSpec ThreadsBatch { get; private set; }

        /// <summary>
        ///     The SR_ comments0
        /// </summary>
        private static readonly CallSpec sr_Comments0 = new CallSpec("_apis/discussion/comments");

        /// <summary>
        ///     The SR_ comments1
        /// </summary>
        private static readonly CallSpec sr_Comments1 = new CallSpec("_apis/discussion/threads/{discussionId}/comments/{commentId}");

        /// <summary>
        ///     The SR_ threads0
        /// </summary>
        private static readonly CallSpec sr_Threads0 = new CallSpec("_apis/discussion/threads");

        /// <summary>
        ///     The SR_ threads1
        /// </summary>
        private static readonly CallSpec sr_Threads1 = new CallSpec("_apis/discussion/threads/{discussionId}");
    }
}