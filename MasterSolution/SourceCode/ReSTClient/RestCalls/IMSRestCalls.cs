class IMSRestCalls
{
 internal static CallSpec Identities { get { return sr_Identities; } }
 private static readonly CallSpec sr_Identities= new CallSpec("_apis/Identities/{identityId}");
 internal static CallSpec IdentityBatch { get { return sr_IdentityBatch; } }
 private static readonly CallSpec sr_IdentityBatch= new CallSpec("_apis/IdentityBatch");
 internal static CallSpec Members { get { return sr_Members; } }
 private static readonly CallSpec sr_Members= new CallSpec("_apis/identities/{containerId}/Members/{memberId}");
 internal static CallSpec MembersOf { get { return sr_MembersOf; } }
 private static readonly CallSpec sr_MembersOf= new CallSpec("_apis/identities/{memberId}/MembersOf/{containerId}");
 internal static CallSpec IdentitySnapshot { get { return sr_IdentitySnapshot; } }
 private static readonly CallSpec sr_IdentitySnapshot= new CallSpec("_apis/IdentitySnapshot/{scopeId}");
}
