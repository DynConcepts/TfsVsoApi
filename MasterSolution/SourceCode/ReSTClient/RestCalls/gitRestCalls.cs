using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class GitRestCalls.
    /// </summary>
    internal class GitRestCalls
    {
/*
/git/repositories/{repositoryId}/blobs/{objectId}		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/blobs/61a86fdaa79e5c6f5fb6e4026508489feb6ed92c?api-version=1.0
/git/repositories/{repositoryId}/commits		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/commits?api-version=1.0
/git/repositories/{repositoryId}/commits/{commitId}		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/commits/be67f8871a4d2c75f13a51c1d3c30ac0d74d4ef4?api-version=1.0
/git/repositories/{repositoryId}/commits/{commitId}/changes		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/commits/be67f8871a4d2c75f13a51c1d3c30ac0d74d4ef4/changes?top=2&skip=10&api-version=1.0
/git/repositories/{repositoryId}/pushes/{pushId}/commits		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pushes/1/commits?api-version=1.0
/git/repositories/{repositoryId}/commitsBatch		POST		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/commitsBatch?api-version=1.0
/git/repositories/{repositoryId}/diffs/commits		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/diffs/commits?targetVersion=master&baseVersion=develop&api-version=1.0
/git/repositories/{repoId}/items		GET		http://localhost:8080/tfs/DefaultCollection/_apis/git/repositories/18b70da6-63c5-4767-a77d-7847538e05f1/items
/git/repositories/{repositoryId}/items		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/items?scopePath=/MyWebSite/MyWebSite/Views/Home/_Home.cshtml&api-version=1.0
/git/repositories/{repositoryId}/itemsBatch		POST		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/itemsBatch?api-version=1.0
/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{additionalReviewerId}		DELETE		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pullRequests/50/reviewers/19d9411e-9a34-45bb-b985-d24d9d87c0c9?api-version=1.0-preview.1
/git/repositories/{repositoryId}/pullRequests		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pullRequests?api-version=1.0-preview.1
/git/repositories/{repositoryId}/pullRequests/{pullRequestId}		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pullRequests/50?api-version=1.0-preview.1
/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pullRequests/50/reviewers?api-version=1.0-preview.1
/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{additionalReviewerId}		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pullRequests/50/reviewers/19d9411e-9a34-45bb-b985-d24d9d87c0c9?api-version=1.0-preview.1
/git/repositories/{repositoryId}/pullRequests/{pullRequestId}		PATCH		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pullRequests/50?api-version=1.0-preview.1
/git/repositories/{repositoryId}/pullRequests		POST		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pullRequests?api-version=1.0-preview.1
/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{additionalReviewerId}		PUT		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pullRequests/50/reviewers/19d9411e-9a34-45bb-b985-d24d9d87c0c9?api-version=1.0-preview.1
/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{initialReviewerId}		PUT		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pullRequests/50/reviewers/3b5f0c34-4aec-4bf4-8708-1d36f0dbc468?api-version=1.0-preview.1
/git/repositories/{repositoryId}/pushes		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pushes?api-version=1.0
/git/repositories/{repositoryId}/pushes/{pushId}		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/pushes/23?api-version=1.0
/git/repositories/{tempRepoId}/pushes		POST		_apis/git/repositories/8ee9091d-0f54-4633-9bb2-b5ac74855a46/pushes?api-version=2.0-preview
/git/repositories/{repositoryId}/refs		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/refs?api-version=1.0
/git/repositories/{repositoryId}/refs/heads		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/refs/heads?api-version=1.0
/git/repositories/{repositoryId}/refs/tags		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/refs/tags?api-version=1.0
/git/repositories/{repositoryId}		DELETE		_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6?api-version=1.0
/git/repositories		GET		_apis/git/repositories?api-version=1.0
/git/repositories/{repositoryId}		GET		_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6?api-version=1.0
/git/repositories/{repositoryId}		PATCH		_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6?api-version=1.0
/git/repositories		POST		_apis/git/repositories?api-version=1.0
/git/repositories/{repositoryId}/stats/branches		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/stats/branches?api-version=1.0
/git/repositories/{repositoryId}/stats/branches/{name}		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/stats/branches/develop?api-version=1.0
/git/repositories/{repositoryId}/trees/{objectId}		GET		_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/trees/d1d5c2d49045d52bba6419652d6ecb2cd560dc29?api-version=1.0
*/
        /// <summary>
        ///     Gets the blobs0.
        /// </summary>
        /// <value>The blobs0.</value>
        internal static CallSpec Blobs0 { get { return sr_Blobs0; } }

        /// <summary>
        ///     Gets the blobs1.
        /// </summary>
        /// <value>The blobs1.</value>
        internal static CallSpec Blobs1 { get { return sr_Blobs1; } }

        /// <summary>
        ///     Gets the branch stats0.
        /// </summary>
        /// <value>The branch stats0.</value>
        internal static CallSpec BranchStats0 { get { return sr_BranchStats0; } }

        /// <summary>
        ///     Gets the branch stats1.
        /// </summary>
        /// <value>The branch stats1.</value>
        internal static CallSpec BranchStats1 { get { return sr_BranchStats1; } }

        /// <summary>
        ///     Gets the branch stats2.
        /// </summary>
        /// <value>The branch stats2.</value>
        internal static CallSpec BranchStats2 { get { return sr_BranchStats2; } }

        /// <summary>
        ///     Gets the branch stats3.
        /// </summary>
        /// <value>The branch stats3.</value>
        internal static CallSpec BranchStats3 { get { return sr_BranchStats3; } }

        /// <summary>
        ///     Gets the changes0.
        /// </summary>
        /// <value>The changes0.</value>
        internal static CallSpec Changes0 { get { return sr_Changes0; } }

        /// <summary>
        ///     Gets the changes1.
        /// </summary>
        /// <value>The changes1.</value>
        internal static CallSpec Changes1 { get { return sr_Changes1; } }

        /// <summary>
        ///     Gets the commit diffs0.
        /// </summary>
        /// <value>The commit diffs0.</value>
        internal static CallSpec CommitDiffs0 { get { return sr_CommitDiffs0; } }

        /// <summary>
        ///     Gets the commit diffs1.
        /// </summary>
        /// <value>The commit diffs1.</value>
        internal static CallSpec CommitDiffs1 { get { return sr_CommitDiffs1; } }

        /// <summary>
        ///     Gets the commits0.
        /// </summary>
        /// <value>The commits0.</value>
        internal static CallSpec Commits0 { get { return sr_Commits0; } }

        /// <summary>
        ///     Gets the commits1.
        /// </summary>
        /// <value>The commits1.</value>
        internal static CallSpec Commits1 { get { return sr_Commits1; } }

        /// <summary>
        ///     Gets the commits2.
        /// </summary>
        /// <value>The commits2.</value>
        internal static CallSpec Commits2 { get { return sr_Commits2; } }

        /// <summary>
        ///     Gets the commits3.
        /// </summary>
        /// <value>The commits3.</value>
        internal static CallSpec Commits3 { get { return sr_Commits3; } }

        /// <summary>
        ///     Gets the commits batch0.
        /// </summary>
        /// <value>The commits batch0.</value>
        internal static CallSpec CommitsBatch0 { get { return sr_CommitsBatch0; } }

        /// <summary>
        ///     Gets the commits batch1.
        /// </summary>
        /// <value>The commits batch1.</value>
        internal static CallSpec CommitsBatch1 { get { return sr_CommitsBatch1; } }

        /// <summary>
        ///     Gets the items0.
        /// </summary>
        /// <value>The items0.</value>
        internal static CallSpec Items0 { get { return sr_Items0; } }

        /// <summary>
        ///     Gets the items1.
        /// </summary>
        /// <value>The items1.</value>
        internal static CallSpec Items1 { get { return sr_Items1; } }

        /// <summary>
        ///     Gets the items batch0.
        /// </summary>
        /// <value>The items batch0.</value>
        internal static CallSpec ItemsBatch0 { get { return sr_ItemsBatch0; } }

        /// <summary>
        ///     Gets the items batch1.
        /// </summary>
        /// <value>The items batch1.</value>
        internal static CallSpec ItemsBatch1 { get { return sr_ItemsBatch1; } }

        /// <summary>
        ///     Gets the objects0.
        /// </summary>
        /// <value>The objects0.</value>
        internal static CallSpec Objects0 { get { return sr_Objects0; } }

        /// <summary>
        ///     Gets the objects1.
        /// </summary>
        /// <value>The objects1.</value>
        internal static CallSpec Objects1 { get { return sr_Objects1; } }

        /// <summary>
        ///     Gets the pull request reviewers0.
        /// </summary>
        /// <value>The pull request reviewers0.</value>
        internal static CallSpec PullRequestReviewers0 { get { return sr_PullRequestReviewers0; } }

        /// <summary>
        ///     Gets the pull request reviewers1.
        /// </summary>
        /// <value>The pull request reviewers1.</value>
        internal static CallSpec PullRequestReviewers1 { get { return sr_PullRequestReviewers1; } }

        /// <summary>
        ///     Gets the pull request work items0.
        /// </summary>
        /// <value>The pull request work items0.</value>
        internal static CallSpec PullRequestWorkItems0 { get { return sr_PullRequestWorkItems0; } }

        /// <summary>
        ///     Gets the pull request work items1.
        /// </summary>
        /// <value>The pull request work items1.</value>
        internal static CallSpec PullRequestWorkItems1 { get { return sr_PullRequestWorkItems1; } }

        /// <summary>
        ///     Gets the pull requests0.
        /// </summary>
        /// <value>The pull requests0.</value>
        internal static CallSpec PullRequests0 { get { return sr_PullRequests0; } }

        /// <summary>
        ///     Gets the pull requests1.
        /// </summary>
        /// <value>The pull requests1.</value>
        internal static CallSpec PullRequests1 { get { return sr_PullRequests1; } }

        /// <summary>
        ///     Gets the pushes0.
        /// </summary>
        /// <value>The pushes0.</value>
        internal static CallSpec Pushes0 { get { return sr_Pushes0; } }

        /// <summary>
        ///     Gets the pushes1.
        /// </summary>
        /// <value>The pushes1.</value>
        internal static CallSpec Pushes1 { get { return sr_Pushes1; } }

        /// <summary>
        ///     Gets the refs0.
        /// </summary>
        /// <value>The refs0.</value>
        internal static CallSpec Refs0 { get { return sr_Refs0; } }

        /// <summary>
        ///     Gets the refs1.
        /// </summary>
        /// <value>The refs1.</value>
        internal static CallSpec Refs1 { get { return sr_Refs1; } }

        /// <summary>
        ///     Gets the repositories0.
        /// </summary>
        /// <value>The repositories0.</value>
        internal static CallSpec Repositories0 { get { return sr_Repositories0; } }

        /// <summary>
        ///     Gets the repositories1.
        /// </summary>
        /// <value>The repositories1.</value>
        internal static CallSpec Repositories1 { get { return sr_Repositories1; } }

        /// <summary>
        ///     Gets the trees0.
        /// </summary>
        /// <value>The trees0.</value>
        internal static CallSpec Trees0 { get { return sr_Trees0; } }

        /// <summary>
        ///     Gets the trees1.
        /// </summary>
        /// <value>The trees1.</value>
        internal static CallSpec Trees1 { get { return sr_Trees1; } }

        /// <summary>
        ///     The SR_ blobs0
        /// </summary>
        private static readonly CallSpec sr_Blobs0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/blobs/{sha1}");

        /// <summary>
        ///     The SR_ blobs1
        /// </summary>
        private static readonly CallSpec sr_Blobs1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/blobs/{sha1}");

        /// <summary>
        ///     The SR_ branch stats0
        /// </summary>
        private static readonly CallSpec sr_BranchStats0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/stats/branches");

        /// <summary>
        ///     The SR_ branch stats1
        /// </summary>
        private static readonly CallSpec sr_BranchStats1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/stats/branches");

        /// <summary>
        ///     The SR_ branch stats2
        /// </summary>
        private static readonly CallSpec sr_BranchStats2 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/stats/branches/{name}");

        /// <summary>
        ///     The SR_ branch stats3
        /// </summary>
        private static readonly CallSpec sr_BranchStats3 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/stats/branches/{name}");

        /// <summary>
        ///     The SR_ changes0
        /// </summary>
        private static readonly CallSpec sr_Changes0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/commits/{commitId}/changes");

        /// <summary>
        ///     The SR_ changes1
        /// </summary>
        private static readonly CallSpec sr_Changes1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/commits/{commitId}/changes");

        /// <summary>
        ///     The SR_ commit diffs0
        /// </summary>
        private static readonly CallSpec sr_CommitDiffs0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/diffs/commits");

        /// <summary>
        ///     The SR_ commit diffs1
        /// </summary>
        private static readonly CallSpec sr_CommitDiffs1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/diffs/commits");

        /// <summary>
        ///     The SR_ commits0
        /// </summary>
        private static readonly CallSpec sr_Commits0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/commits/{commitId}");

        /// <summary>
        ///     The SR_ commits1
        /// </summary>
        private static readonly CallSpec sr_Commits1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/commits/{commitId}");

        /// <summary>
        ///     The SR_ commits2
        /// </summary>
        private static readonly CallSpec sr_Commits2 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pushes/{pushId}/commits");

        /// <summary>
        ///     The SR_ commits3
        /// </summary>
        private static readonly CallSpec sr_Commits3 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pushes/{pushId}/commits");

        /// <summary>
        ///     The SR_ commits batch0
        /// </summary>
        private static readonly CallSpec sr_CommitsBatch0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/commitsBatch");

        /// <summary>
        ///     The SR_ commits batch1
        /// </summary>
        private static readonly CallSpec sr_CommitsBatch1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/commitsBatch");

        /// <summary>
        ///     The SR_ items0
        /// </summary>
        private static readonly CallSpec sr_Items0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/items/{*path}");

        /// <summary>
        ///     The SR_ items1
        /// </summary>
        private static readonly CallSpec sr_Items1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/items/{*path}");

        /// <summary>
        ///     The SR_ items batch0
        /// </summary>
        private static readonly CallSpec sr_ItemsBatch0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/itemsBatch");

        /// <summary>
        ///     The SR_ items batch1
        /// </summary>
        private static readonly CallSpec sr_ItemsBatch1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/itemsBatch");

        /// <summary>
        ///     The SR_ objects0
        /// </summary>
        private static readonly CallSpec sr_Objects0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/objects/{mediaObjectId}/{*includeLinks}");

        /// <summary>
        ///     The SR_ objects1
        /// </summary>
        private static readonly CallSpec sr_Objects1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/objects/{mediaObjectId}/{*includeLinks}");

        /// <summary>
        ///     The SR_ pull request reviewers0
        /// </summary>
        private static readonly CallSpec sr_PullRequestReviewers0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{reviewerId}");

        /// <summary>
        ///     The SR_ pull request reviewers1
        /// </summary>
        private static readonly CallSpec sr_PullRequestReviewers1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{reviewerId}");

        /// <summary>
        ///     The SR_ pull request work items0
        /// </summary>
        private static readonly CallSpec sr_PullRequestWorkItems0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}/workitems");

        /// <summary>
        ///     The SR_ pull request work items1
        /// </summary>
        private static readonly CallSpec sr_PullRequestWorkItems1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pullRequests/{pullRequestId}/workitems");

        /// <summary>
        ///     The SR_ pull requests0
        /// </summary>
        private static readonly CallSpec sr_PullRequests0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pullRequests/{pullRequestId}");

        /// <summary>
        ///     The SR_ pull requests1
        /// </summary>
        private static readonly CallSpec sr_PullRequests1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pullRequests/{pullRequestId}");

        /// <summary>
        ///     The SR_ pushes0
        /// </summary>
        private static readonly CallSpec sr_Pushes0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/pushes/{pushId}");

        /// <summary>
        ///     The SR_ pushes1
        /// </summary>
        private static readonly CallSpec sr_Pushes1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/pushes/{pushId}");

        /// <summary>
        ///     The SR_ refs0
        /// </summary>
        private static readonly CallSpec sr_Refs0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/refs/{*refType}");

        /// <summary>
        ///     The SR_ refs1
        /// </summary>
        private static readonly CallSpec sr_Refs1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/refs/{*refType}");

        /// <summary>
        ///     The SR_ repositories0
        /// </summary>
        private static readonly CallSpec sr_Repositories0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}");

        /// <summary>
        ///     The SR_ repositories1
        /// </summary>
        private static readonly CallSpec sr_Repositories1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}");

        /// <summary>
        ///     The SR_ trees0
        /// </summary>
        private static readonly CallSpec sr_Trees0 = new CallSpec("{project}/_apis/git/repositories/{repositoryId}/trees/{sha1}");

        /// <summary>
        ///     The SR_ trees1
        /// </summary>
        private static readonly CallSpec sr_Trees1 = new CallSpec("_apis/git/{projectId}/repositories/{repositoryId}/trees/{sha1}");
    }
}