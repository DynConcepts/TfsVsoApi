class SBSRestCalls
{
 internal static CallSpec SBSNamespace { get { return sr_SBSNamespace; } }
 private static readonly CallSpec sr_SBSNamespace= new CallSpec("_apis/SBS/{securityNamespaceId}");
 internal static CallSpec SBSAcls { get { return sr_SBSAcls; } }
 private static readonly CallSpec sr_SBSAcls= new CallSpec("_apis/SBS/{securityNamespaceId}/acls");
 internal static CallSpec SBSAces { get { return sr_SBSAces; } }
 private static readonly CallSpec sr_SBSAces= new CallSpec("_apis/SBS/{securityNamespaceId}/aces");
 internal static CallSpec SBSInherit { get { return sr_SBSInherit; } }
 private static readonly CallSpec sr_SBSInherit= new CallSpec("_apis/SBS/{securityNamespaceId}/inherit");
 internal static CallSpec SBSTokens { get { return sr_SBSTokens; } }
 private static readonly CallSpec sr_SBSTokens= new CallSpec("_apis/SBS/{securityNamespaceId}/tokens");
}
