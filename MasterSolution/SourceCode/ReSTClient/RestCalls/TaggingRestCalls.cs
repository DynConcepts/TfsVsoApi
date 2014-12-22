class TaggingRestCalls
{
 internal static CallSpec tags { get { return sr_tags; } }
 private static readonly CallSpec sr_tags= new CallSpec("_apis/Tagging/scopes/{scopeId}/tags/{tagId}");
}
