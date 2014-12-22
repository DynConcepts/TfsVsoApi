class PackagingRestCalls
{
 internal static CallSpec Modules { get { return sr_Modules; } }
 private static readonly CallSpec sr_Modules= new CallSpec("_apis/Packaging/stores/{storeId}/Modules/{moduleId}/{moduleVersion}");
 internal static CallSpec ArtifactBatch { get { return sr_ArtifactBatch; } }
 private static readonly CallSpec sr_ArtifactBatch= new CallSpec("_apis/Packaging/stores/{storeId}/ArtifactBatch");
 internal static CallSpec Artifacts { get { return sr_Artifacts; } }
 private static readonly CallSpec sr_Artifacts= new CallSpec("_apis/Packaging/stores/{storeId}/Artifacts/{moduleId}/{moduleVersion}/{*artifactId}");
 internal static CallSpec ModuleBatch { get { return sr_ModuleBatch; } }
 private static readonly CallSpec sr_ModuleBatch= new CallSpec("_apis/Packaging/stores/{storeId}/ModuleBatch");
 internal static CallSpec Lineups { get { return sr_Lineups; } }
 private static readonly CallSpec sr_Lineups= new CallSpec("_apis/Packaging/stores/{storeId}/Lineups/{lineupId}/{lineupVersion}");
 internal static CallSpec LineupBatch { get { return sr_LineupBatch; } }
 private static readonly CallSpec sr_LineupBatch= new CallSpec("_apis/Packaging/stores/{storeId}/LineupBatch");
 internal static CallSpec Stores { get { return sr_Stores; } }
 private static readonly CallSpec sr_Stores= new CallSpec("_apis/Packaging/Stores");
}
