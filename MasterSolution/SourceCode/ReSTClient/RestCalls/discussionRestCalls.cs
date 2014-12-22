class discussionRestCalls
{
 internal static CallSpec threads_0 { get { return sr_threads_0; } }
 private static readonly CallSpec sr_threads_0= new CallSpec("_apis/discussion/threads");
 internal static CallSpec threads_1 { get { return sr_threads_1; } }
 private static readonly CallSpec sr_threads_1= new CallSpec("_apis/discussion/threads/{discussionId}");
 internal static CallSpec threadsBatch { get { return sr_threadsBatch; } }
 private static readonly CallSpec sr_threadsBatch= new CallSpec("_apis/discussion/threadsBatch");
 internal static CallSpec comments_0 { get { return sr_comments_0; } }
 private static readonly CallSpec sr_comments_0= new CallSpec("_apis/discussion/comments");
 internal static CallSpec comments_1 { get { return sr_comments_1; } }
 private static readonly CallSpec sr_comments_1= new CallSpec("_apis/discussion/threads/{discussionId}/comments/{commentId}");
}
