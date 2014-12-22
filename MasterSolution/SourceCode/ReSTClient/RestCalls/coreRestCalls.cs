class coreRestCalls
{
 internal static CallSpec identityMru { get { return sr_identityMru; } }
 private static readonly CallSpec sr_identityMru= new CallSpec("_apis/core/identityMru/{mruName}");
 internal static CallSpec members { get { return sr_members; } }
 private static readonly CallSpec sr_members= new CallSpec("_apis/projects/{projectId}/teams/{teamId}/members");
 internal static CallSpec teams { get { return sr_teams; } }
 private static readonly CallSpec sr_teams= new CallSpec("_apis/projects/{projectId}/teams/{*teamId}");
 internal static CallSpec connectedServices { get { return sr_connectedServices; } }
 private static readonly CallSpec sr_connectedServices= new CallSpec("_apis/projects/{projectId}/connectedServices/{name}");
 internal static CallSpec proxies { get { return sr_proxies; } }
 private static readonly CallSpec sr_proxies= new CallSpec("_apis/proxies");
 internal static CallSpec projects { get { return sr_projects; } }
 private static readonly CallSpec sr_projects= new CallSpec("_apis/projects/{*projectId}");
}
