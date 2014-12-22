class gitRestCalls
{
 internal static CallSpec repositories_0 { get { return sr_repositories_0; } }
 private static readonly CallSpec sr_repositories_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}");
 internal static CallSpec repositories_1 { get { return sr_repositories_1; } }
 private static readonly CallSpec sr_repositories_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}");
 internal static CallSpec refs_0 { get { return sr_refs_0; } }
 private static readonly CallSpec sr_refs_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/refs/{*refType}");
 internal static CallSpec refs_1 { get { return sr_refs_1; } }
 private static readonly CallSpec sr_refs_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/refs/{*refType}");
 internal static CallSpec branchStats_0 { get { return sr_branchStats_0; } }
 private static readonly CallSpec sr_branchStats_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/stats/branches");
 internal static CallSpec branchStats_1 { get { return sr_branchStats_1; } }
 private static readonly CallSpec sr_branchStats_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/stats/branches");
 internal static CallSpec branchStats_2 { get { return sr_branchStats_2; } }
 private static readonly CallSpec sr_branchStats_2= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/stats/branches/{name}");
 internal static CallSpec branchStats_3 { get { return sr_branchStats_3; } }
 private static readonly CallSpec sr_branchStats_3= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/stats/branches/{name}");
 internal static CallSpec changes_0 { get { return sr_changes_0; } }
 private static readonly CallSpec sr_changes_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/commits/{commitId}/changes");
 internal static CallSpec changes_1 { get { return sr_changes_1; } }
 private static readonly CallSpec sr_changes_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/commits/{commitId}/changes");
 internal static CallSpec commits_0 { get { return sr_commits_0; } }
 private static readonly CallSpec sr_commits_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/commits/{commitId}");
 internal static CallSpec commits_1 { get { return sr_commits_1; } }
 private static readonly CallSpec sr_commits_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/commits/{commitId}");
 internal static CallSpec commits_2 { get { return sr_commits_2; } }
 private static readonly CallSpec sr_commits_2= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pushes/{pushId}/commits");
 internal static CallSpec commits_3 { get { return sr_commits_3; } }
 private static readonly CallSpec sr_commits_3= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pushes/{pushId}/commits");
 internal static CallSpec commitsBatch_0 { get { return sr_commitsBatch_0; } }
 private static readonly CallSpec sr_commitsBatch_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/commitsBatch");
 internal static CallSpec commitsBatch_1 { get { return sr_commitsBatch_1; } }
 private static readonly CallSpec sr_commitsBatch_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/commitsBatch");
 internal static CallSpec pushes_0 { get { return sr_pushes_0; } }
 private static readonly CallSpec sr_pushes_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pushes/{pushId}");
 internal static CallSpec pushes_1 { get { return sr_pushes_1; } }
 private static readonly CallSpec sr_pushes_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pushes/{pushId}");
 internal static CallSpec items_0 { get { return sr_items_0; } }
 private static readonly CallSpec sr_items_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/items/{*path}");
 internal static CallSpec items_1 { get { return sr_items_1; } }
 private static readonly CallSpec sr_items_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/items/{*path}");
 internal static CallSpec itemsBatch_0 { get { return sr_itemsBatch_0; } }
 private static readonly CallSpec sr_itemsBatch_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/itemsBatch");
 internal static CallSpec itemsBatch_1 { get { return sr_itemsBatch_1; } }
 private static readonly CallSpec sr_itemsBatch_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/itemsBatch");
 internal static CallSpec trees_0 { get { return sr_trees_0; } }
 private static readonly CallSpec sr_trees_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/trees/{sha1}");
 internal static CallSpec trees_1 { get { return sr_trees_1; } }
 private static readonly CallSpec sr_trees_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/trees/{sha1}");
 internal static CallSpec blobs_0 { get { return sr_blobs_0; } }
 private static readonly CallSpec sr_blobs_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/blobs/{sha1}");
 internal static CallSpec blobs_1 { get { return sr_blobs_1; } }
 private static readonly CallSpec sr_blobs_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/blobs/{sha1}");
 internal static CallSpec commitDiffs_0 { get { return sr_commitDiffs_0; } }
 private static readonly CallSpec sr_commitDiffs_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/diffs/commits");
 internal static CallSpec commitDiffs_1 { get { return sr_commitDiffs_1; } }
 private static readonly CallSpec sr_commitDiffs_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/diffs/commits");
 internal static CallSpec pullRequestWorkItems_0 { get { return sr_pullRequestWorkItems_0; } }
 private static readonly CallSpec sr_pullRequestWorkItems_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/workitems");
 internal static CallSpec pullRequestWorkItems_1 { get { return sr_pullRequestWorkItems_1; } }
 private static readonly CallSpec sr_pullRequestWorkItems_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pullRequests/{pullRequestId}/workitems");
 internal static CallSpec pullRequestReviewers_0 { get { return sr_pullRequestReviewers_0; } }
 private static readonly CallSpec sr_pullRequestReviewers_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{reviewerId}");
 internal static CallSpec pullRequestReviewers_1 { get { return sr_pullRequestReviewers_1; } }
 private static readonly CallSpec sr_pullRequestReviewers_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{reviewerId}");
 internal static CallSpec pullRequests_0 { get { return sr_pullRequests_0; } }
 private static readonly CallSpec sr_pullRequests_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}");
 internal static CallSpec pullRequests_1 { get { return sr_pullRequests_1; } }
 private static readonly CallSpec sr_pullRequests_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pullRequests/{pullRequestId}");
 internal static CallSpec objects_0 { get { return sr_objects_0; } }
 private static readonly CallSpec sr_objects_0= new CallSpec("{project}/_apis/git/repositories/{repositoryId}/objects/{mediaObjectId}/{*includeLinks}");
 internal static CallSpec objects_1 { get { return sr_objects_1; } }
 private static readonly CallSpec sr_objects_1= new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/objects/{mediaObjectId}/{*includeLinks}");
}
