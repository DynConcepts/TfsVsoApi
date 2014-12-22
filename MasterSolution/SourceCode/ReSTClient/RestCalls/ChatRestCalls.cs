class ChatRestCalls
{
 internal static CallSpec Users { get { return sr_Users; } }
 private static readonly CallSpec sr_Users= new CallSpec("_apis/Chat/{parentresource}/{roomId}/Users/{userId}");
 internal static CallSpec Messages { get { return sr_Messages; } }
 private static readonly CallSpec sr_Messages= new CallSpec("_apis/Chat/{parentresource}/{roomId}/Messages/{messageId}");
 internal static CallSpec Rooms { get { return sr_Rooms; } }
 private static readonly CallSpec sr_Rooms= new CallSpec("_apis/Chat/Rooms/{roomId}");
}
