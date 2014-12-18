using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace DynCon.OSI.VSO.ObjectModelClient.Helpers
{
    /// <summary>
    /// Interface IVersionControlServerHelper
    /// </summary>
    internal interface IVersionControlServerHelper
    {
        /// <summary>
        /// Gets the artifact provider.
        /// </summary>
        /// <value>The artifact provider.</value>
        IVersionControlArtifactProvider ArtifactProvider { get; }

        /// <summary>
        /// Gets the authenticated user.
        /// </summary>
        /// <value>The authenticated user.</value>
        [Obsolete(@"This property has been deprecated. If you are looking for the 'active' user who the requests are being made on behalf of, 
                   the AuthorizedUser property should be used. If you actually need the authenticated user then use the TeamProjectCollection.GetAuthenticatedUser() method", false)]
        string AuthenticatedUser { get; }

        /// <summary>
        /// Gets the authorized identity.
        /// </summary>
        /// <value>The authorized identity.</value>
        ITeamFoundationIdentity AuthorizedIdentity { get; }

        /// <summary>
        /// Gets the authorized user.
        /// </summary>
        /// <value>The authorized user.</value>
        string AuthorizedUser { get; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IVersionControlServerHelper"/> is canceled.
        /// </summary>
        /// <value><c>true</c> if canceled; otherwise, <c>false</c>.</value>
        bool Canceled { get; set; }

        /// <summary>
        /// Gets or sets the current command.
        /// </summary>
        /// <value>The current command.</value>
        string CurrentCommand { get; set; }

        /// <summary>
        /// Gets the server unique identifier.
        /// </summary>
        /// <value>The server unique identifier.</value>
        Guid ServerGuid { get; }

        /// <summary>
        /// Gets the supported features.
        /// </summary>
        /// <value>The supported features.</value>
        int SupportedFeatures { get; }


        /// <summary>
        /// Gets the team project collection.
        /// </summary>
        /// <value>The team project collection.</value>
        ITfsTeamProjectCollection TeamProjectCollection { get; }

        /// <summary>
        /// Gets the web service level.
        /// </summary>
        /// <value>The web service level.</value>
        IWebServiceLevel WebServiceLevel { get; }

        /// <summary>
        /// Occurs when [after work items updated].
        /// </summary>
        event AfterWorkItemsUpdatedEventHandler AfterWorkItemsUpdated;

        /// <summary>
        /// Occurs when [before checkin pending change].
        /// </summary>
        event ProcessingChangeEventHandler BeforeCheckinPendingChange;

        /// <summary>
        /// Occurs when [before delete workspace].
        /// </summary>
        event WorkspaceCancelEventHandler BeforeDeleteWorkspace;

        /// <summary>
        /// Occurs when [before shelve pending change].
        /// </summary>
        event ProcessingChangeEventHandler BeforeShelvePendingChange;

        /// <summary>
        /// Occurs when [before work items update].
        /// </summary>
        event BeforeWorkItemsUpdateEventHandler BeforeWorkItemsUpdate;

        /// <summary>
        /// Occurs when [branch object created].
        /// </summary>
        event BranchObjectCreatedEventHandler BranchObjectCreated;

        /// <summary>
        /// Occurs when [branch object deleted].
        /// </summary>
        event BranchObjectDeletedEventHandler BranchObjectDeleted;

        /// <summary>
        /// Occurs when [branch object updated].
        /// </summary>
        event BranchObjectUpdatedEventHandler BranchObjectUpdated;

        /// <summary>
        /// Occurs when [changeset reconciled].
        /// </summary>
        event ChangesetReconciledEventHandler ChangesetReconciled;
        
        /// <summary>
        /// Occurs when [commit checkin].Z
        /// </summary>
        event CommitCheckinEventHandler CommitCheckin;

        /// <summary>
        /// Occurs when [commit shelveset].
        /// </summary>
        event CommitShelvesetEventHandler CommitShelveset;

        /// <summary>
        /// Occurs when [committed branch created].
        /// </summary>
        event CommittedBranchCreatedEventHandler CommittedBranchCreated;

        /// <summary>
        /// Occurs when [conflict].
        /// </summary>
        event ConflictEventHandler Conflict;

        /// <summary>
        /// Occurs when [created workspace].
        /// </summary>
        event WorkspaceEventHandler CreatedWorkspace;

        /// <summary>
        /// Occurs when [deleted shelveset].
        /// </summary>
        event DeletedShelvesetEventHandler DeletedShelveset;

        /// <summary>
        /// Occurs when [deleted workspace].
        /// </summary>
        event WorkspaceEventHandler DeletedWorkspace;

        /// <summary>
        /// Occurs when [destroyed].
        /// </summary>
        event DestroyedEventHandler Destroyed;

        /// <summary>
        /// Occurs when [folder content changed].
        /// </summary>
        event FolderContentChangedEventHandler FolderContentChanged;

        /// <summary>
        /// Occurs when [get completed].
        /// </summary>
        event WorkspaceEventHandler GetCompleted;

        /// <summary>
        /// Occurs when [getting].
        /// </summary>
        event GettingEventHandler Getting;

        /// <summary>
        /// Occurs when [merging].
        /// </summary>
        event MergeEventHandler Merging;

        /// <summary>
        /// Occurs when [new pending change].
        /// </summary>
        event PendingChangeEventHandler NewPendingChange;

        /// <summary>
        /// Occurs when [non fatal error].
        /// </summary>
        event ExceptionEventHandler NonFatalError;

        /// <summary>
        /// Occurs when [operation finished].
        /// </summary>
        event OperationEventHandler OperationFinished;

        /// <summary>
        /// Occurs when [operation starting].
        /// </summary>
        event OperationEventHandler OperationStarting;

        /// <summary>
        /// Occurs when [pending change candidates changed].
        /// </summary>
        event WorkspaceEventHandler PendingChangeCandidatesChanged;

        /// <summary>
        /// Occurs when [pending changes changed].
        /// </summary>
        event WorkspaceEventHandler PendingChangesChanged;

        /// <summary>
        /// Occurs when [resolved conflic].
        /// </summary>
        event ResolvedConflictEventHandler ResolvedConflic;

        /// <summary>
        /// Occurs when [set workspace location progress].
        /// </summary>
        event SetWorkspaceLocationProgressEventHandler SetWorkspaceLocationProgress;

        /// <summary>
        /// Occurs when [shelveset updated].
        /// </summary>
        event ShelvesetUpdatedEventHandler ShelvesetUpdated;

        /// <summary>
        /// Occurs when [team project folder created].
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        event TeamProjectFolderCreatedEventHandler TeamProjectFolderCreated;

        /// <summary>
        /// Occurs when [undone pending change].
        /// </summary>
        event PendingChangeEventHandler UndonePendingChange;

        /// <summary>
        /// Occurs when [unshelve conflict].
        /// </summary>
        event ConflictEventHandler UnshelveConflict;

        /// <summary>
        /// Occurs when [unshelve shelveset].
        /// </summary>
        event UnshelveShelvesetEventHandler UnshelveShelveset;

        /// <summary>
        /// Occurs when [updated workspace].
        /// </summary>
        event WorkspaceEventHandler UpdatedWorkspace;

        /// <summary>
        /// Occurs when [work item updated].
        /// </summary>
        event WorkItemUpdatedEventHandler WorkItemUpdated;

        /// <summary>
        /// Adds the proxy.
        /// </summary>
        /// <param name="proxy">The proxy.</param>
        void AddProxy(IProxyInfo proxy);

        /// <summary>
        /// Adds the proxy.
        /// </summary>
        /// <param name="url">The URL.</param>
        void AddProxy(string url);

        /// <summary>
        /// Adds the proxy.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="friendlyName">Name of the friendly.</param>
        void AddProxy(string url, string friendlyName);

        /// <summary>
        /// Checks the in shelveset.
        /// </summary>
        /// <param name="checkinParameters">The checkin parameters.</param>
        /// <returns>System.Int32.</returns>
        int CheckInShelveset(IShelvesetCheckInParameters checkinParameters);

        /// <summary>
        /// Checks the in shelveset.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="ownerName">Name of the owner.</param>
        /// <returns>System.Int32.</returns>
        int CheckInShelveset(string shelvesetName, string ownerName);

        /// <summary>
        /// Compares the labels.
        /// </summary>
        /// <param name="startLabelName">Start name of the label.</param>
        /// <param name="startLabelScope">The start label scope.</param>
        /// <param name="endLabelName">End name of the label.</param>
        /// <param name="endLabelScope">The end label scope.</param>
        /// <param name="minChangeSet">The minimum change set.</param>
        /// <param name="maxCount">The maximum count.</param>
        /// <returns>IChangeset[].</returns>
        IChangeset[] CompareLabels(string startLabelName, string startLabelScope, string endLabelName, string endLabelScope, int minChangeSet, int maxCount);

        /// <summary>
        /// Configures the proxy.
        /// </summary>
        /// <param name="proxy">The proxy.</param>
        void ConfigureProxy(IProxyInfo proxy);

        /// <summary>
        /// Configures the proxy.
        /// </summary>
        /// <param name="proxyUrl">The proxy URL.</param>
        void ConfigureProxy(string proxyUrl);

        /// <summary>
        /// Creates the branch.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="version">The version.</param>
        /// <returns>System.Int32.</returns>
        int CreateBranch(string sourcePath, string targetPath, IVersionSpec version);

        /// <summary>
        /// Creates the branch.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="version">The version.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="checkinNote">The checkin note.</param>
        /// <param name="policyOverride">The policy override.</param>
        /// <param name="mappings">The mappings.</param>
        /// <returns>System.Int32.</returns>
        int CreateBranch(string sourcePath, string targetPath, IVersionSpec version, string owner, string comment, ICheckinNote checkinNote, IPolicyOverrideInfo policyOverride,IMapping[] mappings);

        /// <summary>
        /// Creates the branch object.
        /// </summary>
        /// <param name="properties">The properties.</param>
        void CreateBranchObject(IBranchProperties properties);

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="options">The options.</param>
        /// <returns>LabelResult[].</returns>
        ILabelResult[] CreateLabel(IVersionControlLabel label, ILabelItemSpec[] itemSpecs, LabelChildOption options);

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="options">The options.</param>
        /// <param name="failures">The failures.</param>
        /// <returns>LabelResult[].</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        ILabelResult[] CreateLabel(IVersionControlLabel label, ILabelItemSpec[] itemSpecs, LabelChildOption options, out IFailure[] failures);

        /// <summary>
        /// Creates the team project folder.
        /// </summary>
        /// <param name="options">The options.</param>
        void CreateTeamProjectFolder(TeamProjectFolderOptions options);

        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="createWorkspaceParameters">The create workspace parameters.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace CreateWorkspace(ICreateWorkspaceParameters createWorkspaceParameters);

        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace CreateWorkspace(string name);

        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace CreateWorkspace(string name, string owner);

        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace CreateWorkspace(string name, string owner, string comment);

        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="mappings">The mappings.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace CreateWorkspace(string name, string owner, string comment, IWorkingFolder[] mappings);

        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="mappings">The mappings.</param>
        /// <param name="computer">The computer.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace CreateWorkspace(string name, string owner, string comment, IWorkingFolder[] mappings, string computer);

        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="mappings">The mappings.</param>
        /// <param name="computer">The computer.</param>
        /// <param name="removeUnparentedCloaks">if set to <c>true</c> [remove unparented cloaks].</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace CreateWorkspace(string name, string owner, string comment, IWorkingFolder[] mappings, string computer, bool removeUnparentedCloaks);

        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="mappings">The mappings.</param>
        /// <param name="computer">The computer.</param>
        /// <param name="permissionProfile">The permission profile.</param>
        /// <param name="removeUnparentedCloaks">if set to <c>true</c> [remove unparented cloaks].</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace CreateWorkspace(string name, string owner, string comment, IWorkingFolder[] mappings, string computer, IWorkspacePermissionProfile permissionProfile, bool removeUnparentedCloaks);

        /// <summary>
        /// Deletes the branch object.
        /// </summary>
        /// <param name="branch">The branch.</param>
        void DeleteBranchObject(ITemIdentifier branch);

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <returns>LabelResult[].</returns>
        ILabelResult[] DeleteLabel(string labelName, string labelScope);

        /// <summary>
        /// Deletes the proxy.
        /// </summary>
        /// <param name="proxyUrl">The proxy URL.</param>
        void DeleteProxy(string proxyUrl);

        /// <summary>
        /// Deletes the shelveset.
        /// </summary>
        /// <param name="shelveset">The shelveset.</param>
        void DeleteShelveset(IShelveset shelveset);

        /// <summary>
        /// Deletes the shelveset.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        void DeleteShelveset(string shelvesetName, string shelvesetOwner);

        /// <summary>
        /// Deletes the workspace.
        /// </summary>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="workspaceOwner">The workspace owner.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool DeleteWorkspace(string workspaceName, string workspaceOwner);

        /// <summary>
        /// Destroys the specified item spec.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="stopAt">The stop at.</param>
        /// <param name="flags">The flags.</param>
        /// <returns>IItem[].</returns>
        IItem[] Destroy(IItemSpec itemSpec, IVersionSpec versionSpec, IVersionSpec stopAt, IDestroyFlags flags);

        /// <summary>
        /// Destroys the specified item spec.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="stopAt">The stop at.</param>
        /// <param name="flags">The flags.</param>
        /// <param name="affectedPendingChanges">The affected pending changes.</param>
        /// <param name="affectedShelvedChanges">The affected shelved changes.</param>
        /// <returns>IItem[].</returns>
        IItem[] Destroy(IItemSpec itemSpec, IVersionSpec versionSpec, IVersionSpec stopAt, IDestroyFlags flags, out IPendingSet[] affectedPendingChanges, out IPendingSet[] affectedShelvedChanges);

        /// <summary>
        /// Downloads the file.
        /// </summary>
        /// <param name="serverPath">The server path.</param>
        /// <param name="localFileName">Name of the local file.</param>
        void DownloadFile(string serverPath, string localFileName);

        /// <summary>
        /// Downloads the file.
        /// </summary>
        /// <param name="serverPath">The server path.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <param name="version">The version.</param>
        /// <param name="localFileName">Name of the local file.</param>
        void DownloadFile(string serverPath, int deletionId, IVersionSpec version, string localFileName);

        /// <summary>
        /// Downloads the file by URL.
        /// </summary>
        /// <param name="downloadUrl">The download URL.</param>
        /// <returns>Stream.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        Stream DownloadFileByUrl(string downloadUrl);

        /// <summary>
        /// Downloads the file by URL.
        /// </summary>
        /// <param name="downloadUrl">The download URL.</param>
        /// <param name="localFileName">Name of the local file.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void DownloadFileByUrl(string downloadUrl, string localFileName);

        /// <summary>
        /// Gets all checkin note field names.
        /// </summary>
        /// <returns>System.String[].</returns>
        string[] GetAllCheckinNoteFieldNames();

        /// <summary>
        /// Gets all team projects.
        /// </summary>
        /// <param name="refresh">if set to <c>true</c> [refresh].</param>
        /// <returns>TeamProject[].</returns>
        ITeamProject[] GetAllTeamProjects(bool refresh);

        /// <summary>
        /// Gets the best proxies.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns>List&lt;IProxyInfo&gt;.</returns>
        List<IProxyInfo> GetBestProxies(string site);

        /// <summary>
        /// Gets the branch history.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <returns>IBranchHistoryTreeItem[][].</returns>
        IBranchHistoryTreeItem[][] GetBranchHistory(IItemSpec[] itemSpecs, IVersionSpec version);

        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <returns>IChangeset.</returns>
        IChangeset GetChangeset(int changesetId);

        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeChanges">if set to <c>true</c> [include changes].</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IChangeset.</returns>
        IChangeset GetChangeset(int changesetId, bool includeChanges, bool includeDownloadInfo);

        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeChanges">if set to <c>true</c> [include changes].</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="includeSourceRenames">if set to <c>true</c> [include source renames].</param>
        /// <returns>IChangeset.</returns>
        IChangeset GetChangeset(int changesetId, bool includeChanges, bool includeDownloadInfo, bool includeSourceRenames);

        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeChanges">if set to <c>true</c> [include changes].</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="changesetPropertyFilters">The changeset property filters.</param>
        /// <returns>IChangeset.</returns>
        IChangeset GetChangeset(int changesetId, bool includeChanges, bool includeDownloadInfo, string[] changesetPropertyFilters);

        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeChanges">if set to <c>true</c> [include changes].</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="changesetPropertyFilters">The changeset property filters.</param>
        /// <param name="itemAttributeFilters">The item attribute filters.</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <returns>IChangeset.</returns>
        IChangeset GetChangeset(int changesetId, bool includeChanges, bool includeDownloadInfo, string[] changesetPropertyFilters, string[] itemAttributeFilters, string[] itemPropertyFilters);

        /// <summary>
        /// Gets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyNameFilter">The property name filter.</param>
        /// <returns>IArtifactPropertyValue.</returns>
        IArtifactPropertyValue GetChangesetProperty(int changesetId, string propertyNameFilter);

        /// <summary>
        /// Gets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyNameFilters">The property name filters.</param>
        /// <returns>IArtifactPropertyValue.</returns>
        IArtifactPropertyValue GetChangesetProperty(int changesetId, string[] propertyNameFilters);

        /// <summary>
        /// Gets the changes for changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="lastItem">The last item.</param>
        /// <returns>IChange[].</returns>
        IChange[] GetChangesForChangeset(int changesetId, bool includeDownloadInfo, int pageSize, IItemSpec lastItem);

        /// <summary>
        /// Gets the changes for changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="lastItem">The last item.</param>
        /// <param name="propertyNameFilters">The property name filters.</param>
        /// <returns>IChange[].</returns>
        IChange[] GetChangesForChangeset(int changesetId, bool includeDownloadInfo, int pageSize, IItemSpec lastItem, string[] propertyNameFilters);

        /// <summary>
        /// Gets the changes for changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="lastItem">The last item.</param>
        /// <param name="itemAttributeFilters">The item attribute filters.</param>
        /// <param name="includeMergeSourceInfo">if set to <c>true</c> [include merge source information].</param>
        /// <returns>IChange[].</returns>
        IChange[] GetChangesForChangeset(int changesetId, bool includeDownloadInfo, int pageSize, IItemSpec lastItem, string[] itemAttributeFilters, bool includeMergeSourceInfo);

        /// <summary>
        /// Gets the changes for changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="lastItem">The last item.</param>
        /// <param name="itemAttributeFilters">The item attribute filters.</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <param name="includeMergeSourceInfo">if set to <c>true</c> [include merge source information].</param>
        /// <returns>IChange[].</returns>
        IChange[] GetChangesForChangeset(int changesetId, bool includeDownloadInfo, int pageSize, IItemSpec lastItem, string[] itemAttributeFilters, string[] itemPropertyFilters, bool includeMergeSourceInfo);

        /// <summary>
        /// Gets the checkin note definitions.
        /// </summary>
        /// <param name="teamProjects">The team projects.</param>
        /// <returns>CheckinNoteFieldDefinition[].</returns>
        ICheckinNoteFieldDefinition[] GetCheckinNoteDefinitions(ITeamProject[] teamProjects);

        /// <summary>
        /// Gets the checkin note definitions for server paths.
        /// </summary>
        /// <param name="serverItems">The server items.</param>
        /// <returns>CheckinNoteFieldDefinition[].</returns>
        ICheckinNoteFieldDefinition[] GetCheckinNoteDefinitionsForServerPaths(string[] serverItems);

        /// <summary>
        /// Gets the checkin policies for server paths.
        /// </summary>
        /// <param name="serverItems">The server items.</param>
        /// <returns>PolicyEnvelope[].</returns>
       IPolicyEnvelope[] GetCheckinPoliciesForServerPaths(string[] serverItems);

        /// <summary>
        /// Gets the effective global permissions.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>System.String[].</returns>
        string[] GetEffectiveGlobalPermissions(string userName);

        /// <summary>
        /// Gets the effective permissions.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="item">The item.</param>
        /// <returns>System.String[].</returns>
        string[] GetEffectivePermissions(string userName, string item);

        /// <summary>
        /// Gets the extended items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>IExtendedItem[][].</returns>
        IExtendedItem[][] GetExtendedItems(IItemSpec[] itemSpecs, IDeletedState deletedState, IItemType itemType);

        /// <summary>
        /// Gets the extended items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>IExtendedItem[].</returns>
        IExtendedItem[] GetExtendedItems(string path, IDeletedState deletedState, IItemType itemType);

        /// <summary>
        /// Gets the extended items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="options">The options.</param>
        /// <returns>IExtendedItem[][].</returns>
        IExtendedItem[][] GetExtendedItems(IItemSpec[] itemSpecs, IDeletedState deletedState, IItemType itemType, GetItemsOptions options);

        /// <summary>
        /// Gets the extended items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="options">The options.</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <returns>IExtendedItem[][].</returns>
        IExtendedItem[][] GetExtendedItems(IItemSpec[] itemSpecs, IDeletedState deletedState, IItemType itemType, GetItemsOptions options, string[] itemPropertyFilters);

        /// <summary>
        /// Gets the file types.
        /// </summary>
        /// <returns>IFileType[].</returns>
        IFileType[] GetFileTypes();

        /// <summary>
        /// Gets the global permissions.
        /// </summary>
        /// <param name="identityNames">The identity names.</param>
        /// <returns>IGlobalSecurity.</returns>
        IGlobalSecurity GetGlobalPermissions(string[] identityNames);

        /// <summary>
        /// Gets the display name of the identity.
        /// </summary>
        /// <param name="identity">The identity.</param>
        /// <returns>System.String.</returns>
        string GetIdentityDisplayName(ITeamFoundationIdentity identity);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>IItem.</returns>
        IItem GetItem(string path);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <returns>IItem.</returns>
        IItem GetItem(int itemId, int changesetNumber);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <returns>IItem.</returns>
        IItem GetItem(string path, IVersionSpec version);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IItem.</returns>
        IItem GetItem(int itemId, int changesetNumber, bool includeDownloadInfo);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <param name="options">The options.</param>
        /// <returns>IItem.</returns>
        IItem GetItem(int itemId, int changesetNumber, GetItemsOptions options);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <returns>IItem.</returns>
        IItem GetItem(string path, IVersionSpec version, IDeletedState deletedState);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <returns>IItem.</returns>
        IItem GetItem(string path, IVersionSpec version, int deletionId);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IItem.</returns>
        IItem GetItem(string path, IVersionSpec version, IDeletedState deletedState, bool includeDownloadInfo);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="options">The options.</param>
        /// <returns>IItem.</returns>
        IItem GetItem(string path, IVersionSpec version, IDeletedState deletedState, GetItemsOptions options);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IItem.</returns>
        IItem GetItem(string path, IVersionSpec version, int deletionId, bool includeDownloadInfo);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <param name="options">The options.</param>
        /// <returns>IItem.</returns>
        IItem GetItem(string path, IVersionSpec version, int deletionId, GetItemsOptions options);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>ITemSet.</returns>
        ITemSet GetItems(string path);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemIds">The item ids.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <returns>IItem[].</returns>
        IItem[] GetItems(int[] itemIds, int changesetNumber);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>ITemSet.</returns>
        ITemSet GetItems(string path, RecursionType recursion);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemIds">The item ids.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IItem[].</returns>
        IItem[] GetItems(int[] itemIds, int changesetNumber, bool includeDownloadInfo);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemIds">The item ids.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <param name="options">The options.</param>
        /// <returns>IItem[].</returns>
        IItem[] GetItems(int[] itemIds, int changesetNumber, GetItemsOptions options);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>ITemSet.</returns>
        ITemSet GetItems(string path, IVersionSpec version, RecursionType recursion);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>ITemSet[].</returns>
        ITemSet[] GetItems(IItemSpec[] itemSpecs, IVersionSpec version, IDeletedState deletedState, IItemType itemType);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>ITemSet.</returns>
        ITemSet GetItems(IItemSpec itemSpec, IVersionSpec version, IDeletedState deletedState, IItemType itemType, bool includeDownloadInfo);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="options">The options.</param>
        /// <returns>ITemSet.</returns>
        ITemSet GetItems(IItemSpec itemSpec, IVersionSpec version, IDeletedState deletedState, IItemType itemType, GetItemsOptions options);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>ITemSet[].</returns>
        ITemSet[] GetItems(IItemSpec[] itemSpecs, IVersionSpec version, IDeletedState deletedState, IItemType itemType, bool includeDownloadInfo);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="options">The options.</param>
        /// <returns>ITemSet[].</returns>
        ITemSet[] GetItems(IItemSpec[] itemSpecs, IVersionSpec version, IDeletedState deletedState, IItemType itemType, GetItemsOptions options);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>ITemSet.</returns>
        ITemSet GetItems(string path, IVersionSpec version, RecursionType recursion, IDeletedState deletedState, IItemType itemType);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>ITemSet.</returns>
        ITemSet GetItems(string path, IVersionSpec version, RecursionType recursion, IDeletedState deletedState, IItemType itemType, bool includeDownloadInfo);

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="options">The options.</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <param name="itemAttributeFilters">The item attribute filters.</param>
        /// <returns>ITemSet[].</returns>
        ITemSet[] GetItems(IItemSpec[] itemSpecs, IVersionSpec version, IDeletedState deletedState, IItemType itemType, GetItemsOptions options, string[] itemPropertyFilters, string[] itemAttributeFilters);

        /// <summary>
        /// Gets the latest changeset identifier.
        /// </summary>
        /// <returns>System.Int32.</returns>
        int GetLatestChangesetId();

        /// <summary>
        /// Gets the merge candidates.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="targetPath">The target path.</param>
        /// <returns>IMergeCandidate[].</returns>
        IMergeCandidate[] GetMergeCandidates(IItemSpec source, string targetPath);

        /// <summary>
        /// Gets the merge candidates.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="options">The options.</param>
        /// <returns>IMergeCandidate[].</returns>
        IMergeCandidate[] GetMergeCandidates(IItemSpec source, string targetPath, IMergeOptionsEx options);

        /// <summary>
        /// Gets the merge candidates.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>IMergeCandidate[].</returns>
        IMergeCandidate[] GetMergeCandidates(string sourcePath, string targetPath, RecursionType recursion);

        /// <summary>
        /// Gets the pending change.
        /// </summary>
        /// <param name="pendingChangeId">The pending change identifier.</param>
        /// <returns>IPendingChange.</returns>
        [Obsolete("Method obsolete since TFS 2010. Please use VersionControlServer.QueryPendingSets, VersionControlServer.QueryShelvedChanges or IWorkSpace.GetPendingChanges instead.")]
        IPendingChange GetPendingChange(int pendingChangeId);

        /// <summary>
        /// Gets the pending change.
        /// </summary>
        /// <param name="pendingChangeId">The pending change identifier.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IPendingChange.</returns>
        [Obsolete("Method obsolete since TFS 2010. Please use VersionControlServer.QueryPendingSets, VersionControlServer.QueryShelvedChanges or IWorkSpace.GetPendingChanges instead.")]
        IPendingChange GetPendingChange(int pendingChangeId, bool includeDownloadInfo);

        /// <summary>
        /// Gets the pending changes.
        /// </summary>
        /// <param name="pendingChangeIds">The pending change ids.</param>
        /// <returns>IPendingChange[].</returns>
        [Obsolete("Method obsolete since TFS 2010. Please use VersionControlServer.QueryPendingSets, VersionControlServer.QueryShelvedChanges or IWorkSpace.GetPendingChanges instead.")]
        IPendingChange[] GetPendingChanges(int[] pendingChangeIds);

        /// <summary>
        /// Gets the pending changes.
        /// </summary>
        /// <param name="pendingChangeIds">The pending change ids.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IPendingChange[].</returns>
        [Obsolete("Method obsolete since TFS 2010. Please use VersionControlServer.QueryPendingSets, VersionControlServer.QueryShelvedChanges or IWorkSpace.GetPendingChanges instead.")]
        IPendingChange[] GetPendingChanges(int[] pendingChangeIds, bool includeDownloadInfo);

        /// <summary>
        /// Gets the pending sets.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] GetPendingSets(string[] items, RecursionType recursion);

        /// <summary>
        /// Gets the permissions.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>ItemSecurity[].</returns>
        IItemSecurity[] GetPermissions(string[] items, RecursionType recursion);

        /// <summary>
        /// Gets the permissions.
        /// </summary>
        /// <param name="identityNames">The identity names.</param>
        /// <param name="items">The items.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>ItemSecurity[].</returns>
        IItemSecurity[] GetPermissions(string[] identityNames, string[] items, RecursionType recursion);

        /// <summary>
        /// Gets the proxies.
        /// </summary>
        /// <returns>IProxyInfo[].</returns>
        IProxyInfo[] GetProxies();

        /// <summary>
        /// Gets the proxies.
        /// </summary>
        /// <param name="proxyUrls">The proxy urls.</param>
        /// <returns>IProxyInfo[].</returns>
        IProxyInfo[] GetProxies(string[] proxyUrls);

        /// <summary>
        /// Gets the proxy.
        /// </summary>
        /// <param name="proxyUrl">The proxy URL.</param>
        /// <returns>IProxyInfo.</returns>
        IProxyInfo GetProxy(string proxyUrl);

        /// <summary>
        /// Gets the server settings with fallback.
        /// </summary>
        /// <param name="fallbackUsed">if set to <c>true</c> [fallback used].</param>
        /// <returns>ServerSettings.</returns>
        IServerSettings GetServerSettingsWithFallback(out bool fallbackUsed);

        /// <summary>
        /// Gets the team project.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>TeamProject.</returns>
        ITeamProject GetTeamProject(string name);

        /// <summary>
        /// Gets the team project for server path.
        /// </summary>
        /// <param name="serverPath">The server path.</param>
        /// <returns>TeamProject.</returns>
        ITeamProject GetTeamProjectForServerPath(string serverPath);

        /// <summary>
        /// Gets the team projects for server paths.
        /// </summary>
        /// <param name="serverPaths">The server paths.</param>
        /// <returns>TeamProject[].</returns>
        ITeamProject[] GetTeamProjectsForServerPaths(string[] serverPaths);

        /// <summary>
        /// Gets the versioned item property.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyNameFilter">The property name filter.</param>
        /// <returns>IArtifactPropertyValue[].</returns>
        [Obsolete("Please use GetItems to retrieve versioned item attributes.", false)]
        IArtifactPropertyValue[] GetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyNameFilter);

        /// <summary>
        /// Gets the versioned item property.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyNameFilters">The property name filters.</param>
        /// <returns>IArtifactPropertyValue[].</returns>
        [Obsolete("Please use GetItems to retrieve versioned item attributes.", false)]
        IArtifactPropertyValue[] GetVersionedItemProperty(IItemSpec[] itemSpecs, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string[] propertyNameFilters);

        /// <summary>
        /// Gets the workspace.
        /// </summary>
        /// <param name="localPath">The local path.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace GetWorkspace(string localPath);

        /// <summary>
        /// Gets the workspace.
        /// </summary>
        /// <param name="workspaceInfo">The workspace information.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace GetWorkspace(IWorkspaceInfo workspaceInfo);

        /// <summary>
        /// Gets the workspace.
        /// </summary>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="workspaceOwner">The workspace owner.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace GetWorkspace(string workspaceName, string workspaceOwner);

        /// <summary>
        /// Queries the branch object ownership.
        /// </summary>
        /// <param name="changesetIds">The changeset ids.</param>
        /// <returns>IBranchObjectOwnership[].</returns>
        IBranchObjectOwnership[] QueryBranchObjectOwnership(int[] changesetIds);

        /// <summary>
        /// Queries the branch object ownership.
        /// </summary>
        /// <param name="changesetIds">The changeset ids.</param>
        /// <param name="pathFilter">The path filter.</param>
        /// <returns>IBranchObjectOwnership[].</returns>
        IBranchObjectOwnership[] QueryBranchObjectOwnership(int[] changesetIds, IItemSpec pathFilter);

        /// <summary>
        /// Queries the branch objects.
        /// </summary>
        /// <param name="rootItem">The root item.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>IBranchObject[].</returns>
        IBranchObject[] QueryBranchObjects(ITemIdentifier rootItem, RecursionType recursion);

        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <returns>IEnumerable&lt;IChangeset&gt;.</returns>
        IEnumerable<IChangeset> QueryHistory(IItemSpec itemSpec);

        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>IEnumerable&lt;IChangeset&gt;.</returns>
        IEnumerable<IChangeset> QueryHistory(IQueryHistoryParameters parameters);

        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <returns>IEnumerable&lt;IChangeset&gt;.</returns>
        IEnumerable<IChangeset> QueryHistory(IItemSpec itemSpec, int maxResults);

        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>IEnumerable&lt;IChangeset&gt;.</returns>
        IEnumerable<IChangeset> QueryHistory(string item, RecursionType recursion);

        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <returns>IEnumerable&lt;IChangeset&gt;.</returns>
        IEnumerable<IChangeset> QueryHistory(string item, RecursionType recursion, int maxResults);

        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="user">The user.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="maxCount">The maximum count.</param>
        /// <param name="includeChanges">if set to <c>true</c> [include changes].</param>
        /// <param name="slotMode">if set to <c>true</c> [slot mode].</param>
        /// <returns>IEnumerable.</returns>
        IEnumerable QueryHistory(string path, IVersionSpec version, int deletionId, RecursionType recursion, string user, IVersionSpec versionFrom, IVersionSpec versionTo, int maxCount, bool includeChanges, bool slotMode);

        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="user">The user.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="maxCount">The maximum count.</param>
        /// <param name="includeChanges">if set to <c>true</c> [include changes].</param>
        /// <param name="slotMode">if set to <c>true</c> [slot mode].</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IEnumerable.</returns>
        IEnumerable QueryHistory(string path, IVersionSpec version, int deletionId, RecursionType recursion, string user, IVersionSpec versionFrom, IVersionSpec versionTo, int maxCount, bool includeChanges, bool slotMode, bool includeDownloadInfo);

        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="user">The user.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="maxCount">The maximum count.</param>
        /// <param name="includeChanges">if set to <c>true</c> [include changes].</param>
        /// <param name="slotMode">if set to <c>true</c> [slot mode].</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="sortAscending">if set to <c>true</c> [sort ascending].</param>
        /// <returns>IEnumerable.</returns>
        IEnumerable QueryHistory(string path, IVersionSpec version, int deletionId, RecursionType recursion, string user, IVersionSpec versionFrom, IVersionSpec versionTo, int maxCount, bool includeChanges, bool slotMode, bool includeDownloadInfo, bool sortAscending);

        /// <summary>
        /// Queries the labels.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="includeItems">if set to <c>true</c> [include items].</param>
        /// <returns>IVersionControlLabel[].</returns>
        IVersionControlLabel[] QueryLabels(string labelName, string labelScope, string owner, bool includeItems);

        /// <summary>
        /// Queries the labels.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="includeItems">if set to <c>true</c> [include items].</param>
        /// <param name="filterItem">The filter item.</param>
        /// <param name="versionFilterItem">The version filter item.</param>
        /// <returns>IVersionControlLabel[].</returns>
        IVersionControlLabel[] QueryLabels(string labelName, string labelScope, string owner, bool includeItems, string filterItem, IVersionSpec versionFilterItem);

        /// <summary>
        /// Queries the labels.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="includeItems">if set to <c>true</c> [include items].</param>
        /// <param name="filterItem">The filter item.</param>
        /// <param name="versionFilterItem">The version filter item.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IVersionControlLabel[].</returns>
        IVersionControlLabel[] QueryLabels(string labelName, string labelScope, string owner, bool includeItems, string filterItem, IVersionSpec versionFilterItem, bool includeDownloadInfo);

        /// <summary>
        /// Queries the merge relationships.
        /// </summary>
        /// <param name="serverItem">The server item.</param>
        /// <returns>ITemIdentifier[].</returns>
        ITemIdentifier[] QueryMergeRelationships(string serverItem);

        /// <summary>
        /// Queries the merges.
        /// </summary>
        /// <param name="sourceItemSpec">The source item spec.</param>
        /// <param name="sourceVersion">The source version.</param>
        /// <param name="targetItemSpec">The target item spec.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <returns>IChangesetMerge[].</returns>
        IChangesetMerge[] QueryMerges(IItemSpec sourceItemSpec, IVersionSpec sourceVersion, IItemSpec targetItemSpec, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo);

        /// <summary>
        /// Queries the merges.
        /// </summary>
        /// <param name="sourceItemSpec">The source item spec.</param>
        /// <param name="sourceVersion">The source version.</param>
        /// <param name="targetItemSpec">The target item spec.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="showAll">if set to <c>true</c> [show all].</param>
        /// <returns>IChangesetMerge[].</returns>
        IChangesetMerge[] QueryMerges(IItemSpec sourceItemSpec, IVersionSpec sourceVersion, IItemSpec targetItemSpec, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo, bool showAll);

        /// <summary>
        /// Queries the merges.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="sourceVersion">The source version.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>IChangesetMerge[].</returns>
        IChangesetMerge[] QueryMerges(string sourcePath, IVersionSpec sourceVersion, string targetPath, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo, RecursionType recursion);

        /// <summary>
        /// Queries the merges.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="sourceVersion">The source version.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="showAll">if set to <c>true</c> [show all].</param>
        /// <returns>IChangesetMerge[].</returns>
        IChangesetMerge[] QueryMerges(string sourcePath, IVersionSpec sourceVersion, string targetPath, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo, RecursionType recursion, bool showAll);

        /// <summary>
        /// Queries the merges extended.
        /// </summary>
        /// <param name="targetItemSpec">The target item spec.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <returns>IEnumerable&lt;ExtendedMerge&gt;.</returns>
        IEnumerable<IExtendedMerge> QueryMergesExtended(IItemSpec targetItemSpec, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo);

        /// <summary>
        /// Queries the merges extended.
        /// </summary>
        /// <param name="targetItemSpec">The target item spec.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="options">The options.</param>
        /// <returns>IEnumerable&lt;ExtendedMerge&gt;.</returns>
        IEnumerable<IExtendedMerge> QueryMergesExtended(IItemSpec targetItemSpec, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo, IQueryMergesExtendedOptions options);

        /// <summary>
        /// Queries the merges with details.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="sourceVersion">The source version.</param>
        /// <param name="sourceDeletionId">The source deletion identifier.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="targetDeletionId">The target deletion identifier.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>IChangesetMergeDetails.</returns>
        IChangesetMergeDetails QueryMergesWithDetails(string sourcePath, IVersionSpec sourceVersion, int sourceDeletionId, string targetPath, IVersionSpec targetVersion, int targetDeletionId, IVersionSpec versionFrom, IVersionSpec versionTo, RecursionType recursion);

        /// <summary>
        /// Queries the merges with details.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="sourceVersion">The source version.</param>
        /// <param name="sourceDeletionId">The source deletion identifier.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="targetDeletionId">The target deletion identifier.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="showAll">if set to <c>true</c> [show all].</param>
        /// <returns>IChangesetMergeDetails.</returns>
        IChangesetMergeDetails QueryMergesWithDetails(string sourcePath, IVersionSpec sourceVersion, int sourceDeletionId, string targetPath, IVersionSpec targetVersion, int targetDeletionId, IVersionSpec versionFrom, IVersionSpec versionTo, RecursionType recursion, bool showAll);

        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryPendingSets(IItemSpec[] itemSpecs, string queryWorkspaceName, string queryUserName);

        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryPendingSets(IItemSpec[] itemSpecs, string queryWorkspaceName, string queryUserName, bool includeDownloadInfo);

        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryPendingSets(string[] items, RecursionType recursion, string queryWorkspaceName, string queryUserName);

        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="includeCandidates">if set to <c>true</c> [include candidates].</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryPendingSets(IItemSpec[] itemSpecs, string queryWorkspaceName, string queryUserName, bool includeDownloadInfo, bool includeCandidates);

        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="includeCandidates">if set to <c>true</c> [include candidates].</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryPendingSets(IItemSpec[] itemSpecs, string queryWorkspaceName, string queryUserName, bool includeDownloadInfo, bool includeCandidates, string[] itemPropertyFilters);

        /// <summary>
        /// Queries the root branch objects.
        /// </summary>
        /// <param name="recursion">The recursion.</param>
        /// <returns>IBranchObject[].</returns>
        IBranchObject[] QueryRootBranchObjects(RecursionType recursion);

        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelveset">The shelveset.</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryShelvedChanges(IShelveset shelveset);

        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelveset">The shelveset.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryShelvedChanges(IShelveset shelveset, IItemSpec[] itemSpecs);

        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryShelvedChanges(string shelvesetName, string shelvesetOwner);

        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryShelvedChanges(string shelvesetName, string shelvesetOwner, IItemSpec[] itemSpecs);

        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryShelvedChanges(string shelvesetName, string shelvesetOwner, IItemSpec[] itemSpecs, bool includeDownloadInfo);

        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="includeDownloadInfo">if set to <c>true</c> [include download information].</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <returns>IPendingSet[].</returns>
        IPendingSet[] QueryShelvedChanges(string shelvesetName, string shelvesetOwner, IItemSpec[] itemSpecs, bool includeDownloadInfo, string[] itemPropertyFilters);

        /// <summary>
        /// Queries the shelvesets.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <returns>IShelveset[].</returns>
        IShelveset[] QueryShelvesets(string shelvesetName, string shelvesetOwner);

        /// <summary>
        /// Queries the shelvesets.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="propertyNameFilters">The property name filters.</param>
        /// <returns>IShelveset[].</returns>
        IShelveset[] QueryShelvesets(string shelvesetName, string shelvesetOwner, string[] propertyNameFilters);

        /// <summary>
        /// Queries the workspaces.
        /// </summary>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="workspaceOwner">The workspace owner.</param>
        /// <param name="computer">The computer.</param>
        /// <returns>IWorkSpace[].</returns>
        IWorkSpace[] QueryWorkspaces(string workspaceName, string workspaceOwner, string computer);

        /// <summary>
        /// Queries the workspaces.
        /// </summary>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="workspaceOwner">The workspace owner.</param>
        /// <param name="computer">The computer.</param>
        /// <param name="permissionsFilter">The permissions filter.</param>
        /// <returns>IWorkSpace[].</returns>
        IWorkSpace[] QueryWorkspaces(string workspaceName, string workspaceOwner, string computer, IWorkspacePermissions permissionsFilter);

        /// <summary>
        /// Raises the changeset reconciled.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void RaiseChangesetReconciled(int changesetId);

        /// <summary>
        /// Renames the name of the checkin note field.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="oldName">The old name.</param>
        /// <param name="newName">The new name.</param>
        void RenameCheckinNoteFieldName(string path, string oldName, string newName);

        /// <summary>
        /// Resets the checkin dates.
        /// </summary>
        /// <param name="lastCheckinDate">The last checkin date.</param>
        void ResetCheckinDates(DateTime lastCheckinDate);

        /// <summary>
        /// Servers the item exists.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool ServerItemExists(string path, IItemType itemType);

        /// <summary>
        /// Servers the item exists.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool ServerItemExists(string path, IVersionSpec version, IDeletedState deletedState, IItemType itemType);

        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyValues">The property values.</param>
        void SetChangesetProperty(int changesetId, List<IPropertyValue> propertyValues);

        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyValues">The property values.</param>
        void SetChangesetProperty(int changesetId, IPropertyValue[] propertyValues);

        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetChangesetProperty(int changesetId, string propertyName, byte[] value);

        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetChangesetProperty(int changesetId, string propertyName, DateTime? value);

        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetChangesetProperty(int changesetId, string propertyName, double? value);

        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetChangesetProperty(int changesetId, string propertyName, int? value);

        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetChangesetProperty(int changesetId, string propertyName, string value);

        /// <summary>
        /// Sets the file types.
        /// </summary>
        /// <param name="fileTypes">The file types.</param>
        void SetFileTypes(IFileType[] fileTypes);

        /// <summary>
        /// Sets the global permissions.
        /// </summary>
        /// <param name="permissionChanges">The permission changes.</param>
        /// <returns>IPermissionChange[].</returns>
        IPermissionChange[] SetGlobalPermissions(IPermissionChange[] permissionChanges);

        /// <summary>
        /// Sets the permissions.
        /// </summary>
        /// <param name="securityChanges">The security changes.</param>
        /// <returns>ISecurityChange[].</returns>
        ISecurityChange[] SetPermissions(ISecurityChange[] securityChanges);

        /// <summary>
        /// Sets the server settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        void SetServerSettings(IServerSettings settings);

        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyValues">The property values.</param>
        void SetVersionedItemAttribute(IItemSpec[] itemSpecs, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, IPropertyValue[] propertyValues);

        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, byte[] value);

        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, DateTime? value);

        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, double? value);

        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, int? value);

        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        void SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, string value);

        /// <summary>
        /// Sets the versioned item property.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyValues">The property values.</param>
        [Obsolete("Please use SetVersionedItemAttribute to set attributes on versioned items.", false)]
        void SetVersionedItemProperty(IItemSpec[] itemSpecs, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, IPropertyValue[] propertyValues);

        /// <summary>
        /// Sets the versioned item property.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        [Obsolete("Please use SetVersionedItemAttribute to set attributes on versioned items.", false)]
        void SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, byte[] value);

        /// <summary>
        /// Sets the versioned item property.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        [Obsolete("Please use SetVersionedItemAttribute to set attributes on versioned items.", false)]
        void SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, DateTime? value);

        /// <summary>
        /// Sets the versioned item property.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        [Obsolete("Please use SetVersionedItemAttribute to set attributes on versioned items.", false)]
        void SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, double? value);

        /// <summary>
        /// Sets the versioned item property.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        [Obsolete("Please use SetVersionedItemAttribute to set attributes on versioned items.", false)]
        void SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, int? value);

        /// <summary>
        /// Sets the versioned item property.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        [Obsolete("Please use SetVersionedItemAttribute to set attributes on versioned items.", false)]
        void SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, string value);

        /// <summary>
        /// Strips the unsupported checkin options.
        /// </summary>
        /// <param name="checkInParameters">The check in parameters.</param>
        void StripUnsupportedCheckinOptions(ICheckInParameters checkInParameters);

        /// <summary>
        /// Tracks the merges.
        /// </summary>
        /// <param name="sourceChangesetIds">The source changeset ids.</param>
        /// <param name="sourceItem">The source item.</param>
        /// <param name="targetItems">The target items.</param>
        /// <param name="pathFilter">The path filter.</param>
        /// <returns>IExtendedMerge[].</returns>
        IExtendedMerge[] TrackMerges(int[] sourceChangesetIds, IItemIdentifier sourceItem, IItemIdentifier[] targetItems, IItemSpec pathFilter);

        /// <summary>
        /// Tracks the merges.
        /// </summary>
        /// <param name="sourceChangesetIds">The source changeset ids.</param>
        /// <param name="sourceItem">The source item.</param>
        /// <param name="targetItems">The target items.</param>
        /// <param name="pathFilter">The path filter.</param>
        /// <param name="partialTargetItems">The partial target items.</param>
        /// <returns>IExtendedMerge[].</returns>
        IExtendedMerge[] TrackMerges(int[] sourceChangesetIds, IItemIdentifier sourceItem, IItemIdentifier[] targetItems, IItemSpec pathFilter, out string[] partialTargetItems);

        /// <summary>
        /// Tries the get team project.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>ITeamProject.</returns>
        ITeamProject TryGetTeamProject(string name);

        /// <summary>
        /// Tries the get team project for server path.
        /// </summary>
        /// <param name="serverPath">The server path.</param>
        /// <returns>ITeamProject.</returns>
        ITeamProject TryGetTeamProjectForServerPath(string serverPath);

        /// <summary>
        /// Tries the get workspace.
        /// </summary>
        /// <param name="localPath">The local path.</param>
        /// <returns>IWorkSpace.</returns>
        IWorkSpace TryGetWorkspace(string localPath);

        /// <summary>
        /// Unlabels the item.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <returns>ILabelResult[].</returns>
        ILabelResult[] UnlabelItem(string labelName, string labelScope, IItemSpec[] itemSpecs, IVersionSpec version);

        /// <summary>
        /// Unlabels the item.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <param name="failureFilter">The failure filter.</param>
        /// <param name="filteredFailures">The filtered failures.</param>
        /// <returns>ILabelResult[].</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        ILabelResult[] UnlabelItem(string labelName, string labelScope, IItemSpec[] itemSpecs, IVersionSpec version, Predicate<IFailure> failureFilter, out IFailure[] filteredFailures);

        /// <summary>
        /// Updates the branch object.
        /// </summary>
        /// <param name="properties">The properties.</param>
        void UpdateBranchObject(IBranchProperties properties);

        /// <summary>
        /// Updates the shelveset.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="updatedShelveset">The updated shelveset.</param>
        void UpdateShelveset(string shelvesetName, string shelvesetOwner, IShelveset updatedShelveset);

        /// <summary>
        /// Updates the name of the user.
        /// </summary>
        void UpdateUserName();
    }

    internal interface IWorkspaceInfo
    {
    }

    internal interface IMapping
    {
    }

    internal delegate void ShelvesetUpdatedEventHandler(object sender, ShelvesetUpdatedEventHandlerArgs args);

    internal class ShelvesetUpdatedEventHandlerArgs
    {
    }

    internal interface IQueryMergesExtendedOptions
    {
    }

    internal interface IMergeOptionsEx
    {
    }

    internal delegate void TeamProjectFolderCreatedEventHandler(object sender, TeamProjectFolderCreatedEventHandlerArgs args);

    internal class TeamProjectFolderCreatedEventHandlerArgs
    {
    }

    internal delegate void ExceptionEventHandler(object sender, ExceptionEventHandlerArgs args);

    internal class ExceptionEventHandlerArgs
    {
    }

    internal interface IPolicyOverrideInfo
    {
    }

    internal interface IServerSettings
    {
    }

    internal interface IPolicyEnvelope
    {
    }

    internal interface ICreateWorkspaceParameters
    {
    }

    internal delegate void PendingChangeEventHandler(object sender, PendingChangeEventHandlerArgs args);

    internal class PendingChangeEventHandlerArgs
    {
    }

    internal interface IItemSecurity
    {
    }

    internal interface ICheckinNoteFieldDefinition
    {
    }

    internal delegate void UnshelveShelvesetEventHandler(object sender, UnshelveShelvesetEventHandlerArgs args);

    internal class UnshelveShelvesetEventHandlerArgs
    {
    }

    internal interface IDestroyFlags
    {
    }

    internal interface IWorkspacePermissionProfile
    {
    }

    internal interface IWorkingFolder
    {
    }

    internal delegate void ResolvedConflictEventHandler(object sender, ResolvedConflictEventHandlerArgs args);

    internal class ResolvedConflictEventHandlerArgs
    {
    }

    internal delegate void SetWorkspaceLocationProgressEventHandler(object sender, SetWorkspaceLocationProgressEventHandlerArgs args);

    internal class SetWorkspaceLocationProgressEventHandlerArgs
    {
    }

    internal delegate void MergeEventHandler(object sender, MergeEventHandlerArgs args);

    internal class MergeEventHandlerArgs
    {
    }

    internal delegate void GettingEventHandler(object sender, GettingEventHandlerArgs args);

    internal class GettingEventHandlerArgs
    {
    }

    internal delegate void FolderContentChangedEventHandler(object sender, FolderContentChangedEventHandlerArgs args);

    internal class FolderContentChangedEventHandlerArgs
    {
    }

    internal delegate void DestroyedEventHandler(object sender, DestroyedEventHandlerArgs args);

    internal class DestroyedEventHandlerArgs
    {
    }

    internal delegate void DeletedShelvesetEventHandler(object sender, DeletedShelvesetEventHandlerArgs args);

    internal class DeletedShelvesetEventHandlerArgs
    {
    }

    internal delegate void ConflictEventHandler(object sender, ConflictEventHandlerArgs args);

    internal class ConflictEventHandlerArgs
    {
    }

    internal delegate void CommittedBranchCreatedEventHandler(object sender, CommittedBranchCreatedEventHandlerArgs args);

    internal class CommittedBranchCreatedEventHandlerArgs
    {
    }

    internal delegate void CommitShelvesetEventHandler(object sender, CommitShelvesetEventHandlerArgs args);

    internal class CommitShelvesetEventHandlerArgs
    {
    }

    internal delegate void CommitCheckinEventHandler(object sender, CommitCheckinEventHandlerArgs args);

    internal class CommitCheckinEventHandlerArgs
    {
    }

    internal delegate void ChangesetReconciledEventHandler(object sender, ChangesetReconciledEventHandlerArgs args);

    internal class ChangesetReconciledEventHandlerArgs
    {
    }

    internal delegate void BranchObjectUpdatedEventHandler(object sender, BranchObjectUpdatedEventHandlerArgs args);

    internal class BranchObjectUpdatedEventHandlerArgs
    {
    }

    internal delegate void BranchObjectDeletedEventHandler(object sender, BranchObjectDeletedEventHandlerArgs args);

    internal class BranchObjectDeletedEventHandlerArgs
    {
    }

    internal delegate void BranchObjectCreatedEventHandler(object sender, BranchObjectCreatedEventHandlerArgs args);

    internal class BranchObjectCreatedEventHandlerArgs
    {
    }

    internal delegate void BeforeWorkItemsUpdateEventHandler(object sender, BeforeWorkItemsUpdateEventHandlerArgs args);

    internal class BeforeWorkItemsUpdateEventHandlerArgs
    {
    }
}

