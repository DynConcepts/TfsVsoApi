using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using AfterWorkItemsUpdatedEventHandler = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.AfterWorkItemsUpdatedEventHandler;
using GetItemsOptions = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.GetItemsOptions;
using IBranchHistoryTreeItem = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.IBranchHistoryTreeItem;
using LabelChildOption = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.LabelChildOption;
using OperationEventHandler = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.OperationEventHandler;
using ProcessingChangeEventHandler = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.ProcessingChangeEventHandler;
using RecursionType = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.RecursionType;
using TeamProjectFolderOptions = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.TeamProjectFolderOptions;
using WorkItemUpdatedEventHandler = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.WorkItemUpdatedEventHandler;
using WorkspaceCancelEventHandler = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.WorkspaceCancelEventHandler;
using WorkspaceEventHandler = DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces.TFVC.WorkspaceEventHandler;

namespace DynCon.OSI.VSO.ObjectModelClient.Helpers
{
    /// <summary>
    /// Class VersionControlServerHelper.
    /// </summary>
    internal class VersionControlServerHelper : IVersionControlServerHelper
    {
        /// <summary>
        /// The r_ instance
        /// </summary>
        private readonly VersionControlServer r_Instance;
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionControlServerHelper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
         public VersionControlServerHelper(VersionControlServer instance) { r_Instance = instance; }

        // Summary:
        //     Gets the artifact provider for the server.
        //
        // Returns:
        //     The artifact provider for the server.
        /// <summary>
        /// Gets the artifact provider.
        /// </summary>
        /// <value>The artifact provider.</value>
         IVersionControlArtifactProvider IVersionControlServerHelper.ArtifactProvider { get { return VersionControlArtifactProviderWrapper.GetWrapper(r_Instance.ArtifactProvider); } }
        //
        // Summary:
        //     Gets the identity that the server used to authenticate the user.
        //
        // Returns:
        //     The identity that the server used to authenticate the user.
        /// <summary>
        /// Gets the authenticated user.
        /// </summary>
        /// <value>The authenticated user.</value>
        [Obsolete(@"This property has been deprecated. If you are looking for the 'active' user who the requests are being made on behalf of, 
                   the AuthorizedUser property should be used. If you actually need the authenticated user then use the TeamProjectCollection.GetAuthenticatedUser() method", false)]
         string IVersionControlServerHelper.AuthenticatedUser { get { return r_Instance.AuthenticatedUser; } }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.Framework.Client.ITeamFoundationIdentity.
        /// <summary>
        /// Gets the authorized identity.
        /// </summary>
        /// <value>The authorized identity.</value>
        ITeamFoundationIdentity IVersionControlServerHelper.AuthorizedIdentity { get { return TeamFoundationIdentityWrapper.GetWrapper(r_Instance.AuthorizedIdentity); } }
        //
        // Summary:
        //     Gets the user who is authorized to use the specified server.
        //
        // Returns:
        //     The user name to use in order to access the specified repository.
        /// <summary>
        /// Gets the authorized user.
        /// </summary>
        /// <value>The authorized user.</value>
        string IVersionControlServerHelper.AuthorizedUser { get { return r_Instance.AuthorizedUser; } }
        //
        //
        // Returns:
        //     Returns System.String.
        /// <summary>
        /// Gets the baseline folder name prefix.
        /// </summary>
        /// <value>The baseline folder name prefix.</value>
        public static string BaselineFolderNamePrefix { get { return VersionControlServer.BaselineFolderNamePrefix; } }
        //
        // Summary:
        //     Gets or sets a flag that describes whether the user has requested cancellation
        //     of the current operation.
        //
        // Returns:
        //     True if the user has requested cancellation of the current operation; otherwise,
        //     false.
        /// <summary>
        /// Gets or sets the canceled.
        /// </summary>
        /// <value>The canceled.</value>
        bool IVersionControlServerHelper.Canceled { get; set; }
        //
        // Summary:
        //     Gets or sets the tracing level for all instances of VersionControlServer.
        //
        // Returns:
        //     The tracing level for all instances of VersionControlServer.
        /// <summary>
        /// Gets or sets the client tracing.
        /// </summary>
        /// <value>The client tracing.</value>
        public static TraceSwitch ClientTracing { get; set; }
        //
        // Summary:
        //     Gets or sets the command that is executed on the client side.
        //
        // Returns:
        //     The command that is executed on the client side.
        /// <summary>
        /// Gets or sets the current command.
        /// </summary>
        /// <value>The current command.</value>
        string IVersionControlServerHelper.CurrentCommand { get; set; }
        //
        //
        // Returns:
        //     Returns System.String.
        /// <summary>
        /// Gets the name of the ignore file.
        /// </summary>
        /// <value>The name of the ignore file.</value>
        public static string IgnoreFileName { get { return VersionControlServer.IgnoreFileName; } }
        //
        // Summary:
        //     Gets or sets the maximum number of background threads that will be used for
        //     file uploads and downloads.
        //
        // Returns:
        //     The maximum number of background threads that will be used for file uploads
        //     and downloads.
        /// <summary>
        /// Gets or sets the maximum background threads.
        /// </summary>
        /// <value>The maximum background threads.</value>
        public static int MaxBackgroundThreads { get; set; }
        //
        // Summary:
        //     Gets or sets the maximum number of Get operation results that the server
        //     may return from a single call.
        //
        // Returns:
        //     The maximum number of Get operation results that the server may return from
        //     a single call.
        /// <summary>
        /// Gets or sets the maximum results.
        /// </summary>
        /// <value>The maximum results.</value>
        public static int MaxResults { get; set; }
        //
        // Summary:
        //     Gets the GUID of the Version Control Server repository.
        //
        // Returns:
        //     The GUID of the Version Control Server repository.
        /// <summary>
        /// Gets the server unique identifier.
        /// </summary>
        /// <value>The server unique identifier.</value>
         Guid IVersionControlServerHelper.ServerGuid { get { return r_Instance.ServerGuid; } }
        //
        // Summary:
        //     Gets the features supported by the Version Control Server.
        /// <summary>
        /// Gets the supported features.
        /// </summary>
        /// <value>The supported features.</value>
         int IVersionControlServerHelper.SupportedFeatures { get { return r_Instance.SupportedFeatures; } }
   
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.Client.ITfsTeamProjectCollection that owns
        //     this VersionControlServer instance.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.Client.ITfsTeamProjectCollection that owns this
        //     VersionControlServer instance.
        /// <summary>
        /// Gets the team project collection.
        /// </summary>
        /// <value>The team project collection.</value>
         ITfsTeamProjectCollection IVersionControlServerHelper.TeamProjectCollection { get { return TfsTeamProjectCollectionWrapper.GetWrapper(r_Instance.TeamProjectCollection); } }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.IWebServiceLevel.
        /// <summary>
        /// Gets the web service level.
        /// </summary>
        /// <value>The web service level.</value>
         IWebServiceLevel IVersionControlServerHelper.WebServiceLevel { get { return WebServiceLevelWrapper.GetWrapper(r_Instance.WebServiceLevel); } }

        // Summary:
        //     Raised after updating work items with a check-in.
        /// <summary>
        /// Occurs when [after work items updated].
        /// </summary>
         event AfterWorkItemsUpdatedEventHandler IVersionControlServerHelper.AfterWorkItemsUpdated { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised before checking in a Microsoft.TeamFoundation.VersionControl.Client.PendingChange.
        /// <summary>
        /// Occurs when [before checkin pending change].
        /// </summary>
         event ProcessingChangeEventHandler IVersionControlServerHelper.BeforeCheckinPendingChange { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised before deleting an existing Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        /// <summary>
        /// Occurs when [before delete workspace].
        /// </summary>
         event WorkspaceCancelEventHandler IVersionControlServerHelper.BeforeDeleteWorkspace { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised before shelving a Microsoft.TeamFoundation.VersionControl.Client.PendingChange.
        /// <summary>
        /// Occurs when [before shelve pending change].
        /// </summary>
         event ProcessingChangeEventHandler IVersionControlServerHelper.BeforeShelvePendingChange { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised before updating work items with a check-in.
        /// <summary>
        /// Occurs when [before work items update].
        /// </summary>
         event BeforeWorkItemsUpdateEventHandler IVersionControlServerHelper.BeforeWorkItemsUpdate { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     This event is fired when a Microsoft.TeamFoundation.VersionControl.Client.BranchObject
        //     is created.
        /// <summary>
        /// Occurs when [branch object created].
        /// </summary>
         event BranchObjectCreatedEventHandler IVersionControlServerHelper.BranchObjectCreated { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     This event is fired when a Microsoft.TeamFoundation.VersionControl.Client.BranchObject
        //     is deleted.
        /// <summary>
        /// Occurs when [branch object deleted].
        /// </summary>
         event BranchObjectDeletedEventHandler IVersionControlServerHelper.BranchObjectDeleted { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     This event is fired when a Microsoft.TeamFoundation.VersionControl.Client.BranchObject
        //     is updated.
        /// <summary>
        /// Occurs when [branch object updated].
        /// </summary>
         event BranchObjectUpdatedEventHandler IVersionControlServerHelper.BranchObjectUpdated { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised after a Microsoft.TeamFoundation.VersionControl.Client.Workspace was
        //     reconciled to a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        /// <summary>
        /// Occurs when [changeset reconciled].
        /// </summary>
         event ChangesetReconciledEventHandler IVersionControlServerHelper.ChangesetReconciled { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised on the commit of a new check-in.
        /// <summary>
        /// Occurs when [commit checkin].
        /// </summary>
         event CommitCheckinEventHandler IVersionControlServerHelper.CommitCheckin { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised on the creation of a new Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        /// <summary>
        /// Occurs when [commit shelveset].
        /// </summary>
         event CommitShelvesetEventHandler IVersionControlServerHelper.CommitShelveset { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     This event is fired when a committed branch is created.
        /// <summary>
        /// Occurs when [committed branch created].
        /// </summary>
         event CommittedBranchCreatedEventHandler IVersionControlServerHelper.CommittedBranchCreated { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised when a Microsoft.TeamFoundation.VersionControl.Client.Conflict is
        //     created.
        /// <summary>
        /// Occurs when [conflict].
        /// </summary>
         event ConflictEventHandler IVersionControlServerHelper.Conflict { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised when a Microsoft.TeamFoundation.VersionControl.Client.Workspace is
        //     created.
        /// <summary>
        /// Occurs when [created workspace].
        /// </summary>
         event WorkspaceEventHandler IVersionControlServerHelper.CreatedWorkspace { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised on the deletion of a Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        /// <summary>
        /// Occurs when [deleted shelveset].
        /// </summary>
         event DeletedShelvesetEventHandler IVersionControlServerHelper.DeletedShelveset { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised when a Microsoft.TeamFoundation.VersionControl.Client.Workspace is
        //     deleted.
        /// <summary>
        /// Occurs when [deleted workspace].
        /// </summary>
         event WorkspaceEventHandler IVersionControlServerHelper.DeletedWorkspace { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     This event is fired when a tree or an item is destroyed.
        /// <summary>
        /// Occurs when [destroyed].
        /// </summary>
        public event DestroyedEventHandler Destroyed;
        /// <summary>
        /// Handles the <see cref="E:Destroyed"/> event.
        /// </summary>
        /// <param name="e">The <see cref="Microsoft.TeamFoundation.VersionControl.Client.DestroyEventArgs"/> instance containing the event data.</param>
        protected virtual void OnDestroyed(DestroyedEventHandlerArgs e)
        {
            var handler = Destroyed;
            if (handler != null) handler(this, e);
        }

        /// <summary>
        /// Occurs when [folder content changed].
        /// </summary>
         event FolderContentChangedEventHandler IVersionControlServerHelper.FolderContentChanged { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised when a get operation completes on a Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        /// <summary>
        /// Occurs when [get completed].
        /// </summary>
         event WorkspaceEventHandler IVersionControlServerHelper.GetCompleted { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised during a get operation.
        /// <summary>
        /// Occurs when [getting].
        /// </summary>
         event GettingEventHandler IVersionControlServerHelper.Getting { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised during a merge operation.
        /// <summary>
        /// Occurs when [merging].
        /// </summary>
         event MergeEventHandler IVersionControlServerHelper.Merging { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        //
        // Summary:
        //     Raised on the creation of a new Microsoft.TeamFoundation.VersionControl.Client.PendingChange.
        /// <summary>
        /// Occurs when [new pending change].
        /// </summary>
         event PendingChangeEventHandler IVersionControlServerHelper.NewPendingChange { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        //
        // Summary:
        //     Raised on errors that do not prevent the operation from completing.
        /// <summary>
        /// Occurs when [non fatal error].
        /// </summary>
         event ExceptionEventHandler IVersionControlServerHelper.NonFatalError { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        //
        // Summary:
        //     This event is sent when an operation, such as pending a set of changes, is
        //     finished.
        /// <summary>
        /// Occurs when [operation finished].
        /// </summary>
         event OperationEventHandler IVersionControlServerHelper.OperationFinished { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        //
        // Summary:
        //     This event is raised when an operation, such as pending a set of changes,
        //     begins.
        /// <summary>
        /// Occurs when [operation starting].
        /// </summary>
         event OperationEventHandler IVersionControlServerHelper.OperationStarting { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        /// <summary>
        /// Occurs when [pending change candidates changed].
        /// </summary>
         event WorkspaceEventHandler IVersionControlServerHelper.PendingChangeCandidatesChanged { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        //
        // Summary:
        //     Raised when a workspace's set of pending changes is modified.
        /// <summary>
        /// Occurs when [pending changes changed].
        /// </summary>
         event WorkspaceEventHandler IVersionControlServerHelper.PendingChangesChanged { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        //
        // Summary:
        //     Raised when a Microsoft.TeamFoundation.VersionControl.Client.Conflict is
        //     resolved.
        /// <summary>
        /// Occurs when [resolved conflic].
        /// </summary>
         event ResolvedConflictEventHandler IVersionControlServerHelper.ResolvedConflic { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        
        /// <summary>
        /// Occurs when [set workspace location progress].
        /// </summary>
         event SetWorkspaceLocationProgressEventHandler IVersionControlServerHelper.SetWorkspaceLocationProgress { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        /// <summary>
        /// Occurs when [shelveset updated].
        /// </summary>
         event ShelvesetUpdatedEventHandler IVersionControlServerHelper.ShelvesetUpdated { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        /// <summary>
        /// Occurs when [team project folder created].
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
         event TeamProjectFolderCreatedEventHandler IVersionControlServerHelper.TeamProjectFolderCreated { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        //
        // Summary:
        //     Raised when an existing Microsoft.TeamFoundation.VersionControl.Client.PendingChange
        //     is undone.
        /// <summary>
        /// Occurs when [undone pending change].
        /// </summary>
         event PendingChangeEventHandler IVersionControlServerHelper.UndonePendingChange { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        /// <summary>
        /// Occurs when [unshelve conflict].
        /// </summary>
         event ConflictEventHandler IVersionControlServerHelper.UnshelveConflict { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        //
        // Summary:
        //     Raised when unshelving a Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        /// <summary>
        /// Occurs when [unshelve shelveset].
        /// </summary>
         event UnshelveShelvesetEventHandler IVersionControlServerHelper.UnshelveShelveset { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        //
        // Summary:
        //     Raised when an existing Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     is updated.
        /// <summary>
        /// Occurs when [updated workspace].
        /// </summary>
         event WorkspaceEventHandler IVersionControlServerHelper.UpdatedWorkspace { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
        //
        // Summary:
        //     Raised when a work item has been updated with a check-in.
        /// <summary>
        /// Occurs when [work item updated].
        /// </summary>
         event WorkItemUpdatedEventHandler IVersionControlServerHelper.WorkItemUpdated { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

        // Summary:
        //     Adds a new proxy server record.
        //
        // Parameters:
        //   proxy:
        //     The proxy record to add.
        /// <summary>
        /// Adds the proxy.
        /// </summary>
        /// <param name="proxy">The proxy.</param>
         void IVersionControlServerHelper.AddProxy(IProxyInfo proxy) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Adds a new proxy server record.
        //
        // Parameters:
        //   url:
        //     The URL of the proxy.
        /// <summary>
        /// Adds the proxy.
        /// </summary>
        /// <param name="url">The URL.</param>
         void IVersionControlServerHelper.AddProxy(string url) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Adds a new proxy server record.
        //
        // Parameters:
        //   url:
        //     The URL of the proxy.
        //
        //   friendlyName:
        //     The name of the proxy server. This may be an empty string.
        /// <summary>
        /// Adds the proxy.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="friendlyName">Name of the friendly.</param>
         void IVersionControlServerHelper.AddProxy(string url, string friendlyName) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Submit an existing Microsoft.TeamFoundation.VersionControl.Client.Shelveset
        //     for check in to the repository.
        //
        // Parameters:
        //   checkinParameters:
        //     Microsoft.TeamFoundation.VersionControl.Client.ShelvesetCheckInParameters
        //     that describe the shelveset to be checked in.
        //
        // Returns:
        //     The changeset ID created if successful.
        /// <summary>
        /// Checks the in shelveset.
        /// </summary>
        /// <param name="checkinParameters">The checkin parameters.</param>
        /// <returns>System.Int32.</returns>
         int IVersionControlServerHelper.CheckInShelveset(IShelvesetCheckInParameters checkinParameters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Submit an existing Microsoft.TeamFoundation.VersionControl.Client.Shelveset
        //     for check in to the repository.
        //
        // Parameters:
        //   shelvesetName:
        //     The name of the shelveset to submit.
        //
        //   ownerName:
        //     The owner of the shelveset.
        //
        // Returns:
        //     The changeset ID created if successful.
        /// <summary>
        /// Checks the in shelveset.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="ownerName">Name of the owner.</param>
        /// <returns>System.Int32.</returns>
         int IVersionControlServerHelper.CheckInShelveset(string shelvesetName, string ownerName) { throw new NotImplementedException(); }
        /// <summary>
        /// Compares the labels.
        /// </summary>
        /// <param name="startLabelName">Start name of the label.</param>
        /// <param name="startLabelScope">The start label scope.</param>
        /// <param name="endLabelName">End name of the label.</param>
        /// <param name="endLabelScope">The end label scope.</param>
        /// <param name="minChangeSet">The minimum change set.</param>
        /// <param name="maxCount">The maximum count.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset[].</returns>
         IChangeset[] IVersionControlServerHelper.CompareLabels(string startLabelName, string startLabelScope, string endLabelName, string endLabelScope, int minChangeSet, int maxCount) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Configures the specified proxy.
        //
        // Parameters:
        //   proxy:
        //     The proxy to configure.
        /// <summary>
        /// Configures the proxy.
        /// </summary>
        /// <param name="proxy">The proxy.</param>
         void IVersionControlServerHelper.ConfigureProxy(IProxyInfo proxy) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Configures the specified proxy URL.
        //
        // Parameters:
        //   proxyUrl:
        //     The URL of the proxy to configure.
        /// <summary>
        /// Configures the proxy.
        /// </summary>
        /// <param name="proxyUrl">The proxy URL.</param>
         void IVersionControlServerHelper.ConfigureProxy(string proxyUrl) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a branch on the server and checks it in without downloading the branch
        //     to the client.
        //
        // Parameters:
        //   sourcePath:
        //     Source path of the branch - must be a server path.
        //
        //   targetPath:
        //     Target path of the branch - must be a server path.
        //
        //   version:
        //     Microsoft.TeamFoundation.VersionControl.Client.Changeset or System.DateTime
        //     version spec with which to create the branch.
        //
        // Returns:
        //     Microsoft.TeamFoundation.VersionControl.Client.Changeset identifier for the
        //     check-in of the branch.
        /// <summary>
        /// Creates the branch.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="version">The version.</param>
        /// <returns>System.Int32.</returns>
         int IVersionControlServerHelper.CreateBranch(string sourcePath, string targetPath, IVersionSpec version) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a branch on the server and checks it in without downloading the branch
        //     to the client.
        //
        // Parameters:
        //   sourcePath:
        //     Source path of the branch - must be a server path.
        //
        //   targetPath:
        //     Target path of the branch - must be a server path.
        //
        //   version:
        //     Microsoft.TeamFoundation.VersionControl.Client.Changeset or System.DateTime
        //     version spec with which to create the branch.
        //
        //   owner:
        //     Owner of the Microsoft.TeamFoundation.VersionControl.Client.Changeset. If
        //     null, defaults to the authenticated user.
        //
        //   comment:
        //     Comment on the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //     Can be null.
        //
        //   checkinNote:
        //     Microsoft.TeamFoundation.VersionControl.Client.ICheckinNote. Can be null.
        //
        //   policyOverride:
        //     Microsoft.TeamFoundation.VersionControl.Client.PolicyOverrideInfo. Can be
        //     null.
        //
        //   mappings:
        //     An array of mappings under the target path to include or exclude from the
        //     branch.
        //
        // Returns:
        //     Microsoft.TeamFoundation.VersionControl.Client.Changeset identifier for the
        //     check in of the branch.
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
         int IVersionControlServerHelper.CreateBranch(string sourcePath, string targetPath, IVersionSpec version, string owner, string comment, ICheckinNote checkinNote, IPolicyOverrideInfo policyOverride, IMapping[] mappings) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a Microsoft.TeamFoundation.VersionControl.Client.BranchObject in
        //     Team Foundation Server.
        //
        // Parameters:
        //   properties:
        //     Properties of the branch object to create.
        /// <summary>
        /// Creates the branch object.
        /// </summary>
        /// <param name="properties">The properties.</param>
         void IVersionControlServerHelper.CreateBranchObject(IBranchProperties properties) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Create or update a label.
        //
        // Parameters:
        //   label:
        //     The label definition to create or update.
        //
        //   itemSpecs:
        //     The item specs included in the label.
        //
        //   options:
        //     Options to handle existing items in a label.
        //
        // Returns:
        //     Results of the label operations.
        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="options">The options.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.LabelResult[].</returns>
         ILabelResult[] IVersionControlServerHelper.CreateLabel(IVersionControlLabel label, ILabelItemSpec[] itemSpecs, LabelChildOption options) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.LabelResult.
        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="options">The options.</param>
        /// <param name="failures">The failures.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.LabelResult[].</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
         ILabelResult[] IVersionControlServerHelper.CreateLabel(IVersionControlLabel label, ILabelItemSpec[] itemSpecs, LabelChildOption options, out IFailure[] failures) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a team project root folder and configures it.
        //
        // Parameters:
        //   options:
        //     Options for the creation of the team project folder.
        /// <summary>
        /// Creates the team project folder.
        /// </summary>
        /// <param name="options">The options.</param>
         void IVersionControlServerHelper.CreateTeamProjectFolder(TeamProjectFolderOptions options) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="createWorkspaceParameters">The create workspace parameters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.CreateWorkspace(ICreateWorkspaceParameters createWorkspaceParameters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a new Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Parameters:
        //   name:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create. Must be unique for this owner.
        //
        // Returns:
        //     The newly created Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     object.
        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.CreateWorkspace(string name) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a new Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Parameters:
        //   name:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create. Must be unique for this owner.
        //
        //   owner:
        //     The owner of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create.
        //
        // Returns:
        //     The newly created Microsoft.TeamFoundation.VersionControl.Client.Workspaceobject.
        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.CreateWorkspace(string name, string owner) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a new Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Parameters:
        //   name:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create. Must be unique for this owner.
        //
        //   owner:
        //     The owner of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create.
        //
        //   comment:
        //     A descriptive comment for the Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Returns:
        //     The newly created Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     object.
        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.CreateWorkspace(string name, string owner, string comment) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a new Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Parameters:
        //   name:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create. Must be unique for this owner.
        //
        //   owner:
        //     The owner of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create.
        //
        //   comment:
        //     A descriptive comment for the Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        //   mappings:
        //     An array of working folders to establish for the Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Returns:
        //     The newly created Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     object.
        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="mappings">The mappings.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.CreateWorkspace(string name, string owner, string comment, IWorkingFolder[] mappings) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a new Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Parameters:
        //   name:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create. Must be unique for this owner.
        //
        //   owner:
        //     The owner of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create.
        //
        //   comment:
        //     A descriptive comment for the Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        //   mappings:
        //     An array of working folders to establish for the Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        //   computer:
        //     The computer where the Microsoft.TeamFoundation.VersionControl.Client.Workspacewill
        //     exist.
        //
        // Returns:
        //     The newly created Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     object.
        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="mappings">The mappings.</param>
        /// <param name="computer">The computer.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.CreateWorkspace(string name, string owner, string comment, IWorkingFolder[] mappings, string computer) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a new Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Parameters:
        //   name:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create. Must be unique for this owner.
        //
        //   owner:
        //     The owner of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create.
        //
        //   comment:
        //     A descriptive comment for the Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        //   mappings:
        //     An array of working folders to establish for the Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        //   computer:
        //     The computer where the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     will exist.
        //
        //   removeUnparentedCloaks:
        //     When true, will remove mapping errors that can be safely ignored.
        //
        // Returns:
        //     The newly created Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     object.
        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="mappings">The mappings.</param>
        /// <param name="computer">The computer.</param>
        /// <param name="removeUnparentedCloaks">The remove unparented cloaks.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.CreateWorkspace(string name, string owner, string comment, IWorkingFolder[] mappings, string computer, bool removeUnparentedCloaks) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Creates a new Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Parameters:
        //   name:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create. Must be unique for this owner.
        //
        //   owner:
        //     The owner of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to create.
        //
        //   comment:
        //     A descriptive comment for the Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        //   mappings:
        //     An array of working folders to establish for the Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        //   computer:
        //     The computer where the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     will exist.
        //
        //   permissionProfile:
        //     The permission profile for this Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        //   removeUnparentedCloaks:
        //     When true, will remove mapping errors that can be safely ignored.
        //
        // Returns:
        //     A reference to a workspace object that represents the new Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        /// <summary>
        /// Creates the workspace.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="mappings">The mappings.</param>
        /// <param name="computer">The computer.</param>
        /// <param name="permissionProfile">The permission profile.</param>
        /// <param name="removeUnparentedCloaks">The remove unparented cloaks.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.CreateWorkspace(string name, string owner, string comment, IWorkingFolder[] mappings, string computer, IWorkspacePermissionProfile permissionProfile, bool removeUnparentedCloaks) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Deletes a Microsoft.TeamFoundation.VersionControl.Client.BranchObject and
        //     all associated properties from Team Foundation Server.
        //
        // Parameters:
        //   branch:
        //     IItem identifier of the Microsoft.TeamFoundation.VersionControl.Client.BranchObject
        //     to delete.
        /// <summary>
        /// Deletes the branch object.
        /// </summary>
        /// <param name="branch">The branch.</param>
         void IVersionControlServerHelper.DeleteBranchObject(ITemIdentifier branch) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Deletes the label with the specified name and scope.
        //
        // Parameters:
        //   labelName:
        //     The name of the label to delete.
        //
        //   labelScope:
        //     The repository path representing the scope at which the label is defined.
        //
        // Returns:
        //     Results of the label operation.
        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.LabelResult[].</returns>
         ILabelResult[] IVersionControlServerHelper.DeleteLabel(string labelName, string labelScope) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Deletes the proxy server record for the specified proxy URL.
        //
        // Parameters:
        //   proxyUrl:
        //     URL of the proxy record to delete.
        /// <summary>
        /// Deletes the proxy.
        /// </summary>
        /// <param name="proxyUrl">The proxy URL.</param>
         void IVersionControlServerHelper.DeleteProxy(string proxyUrl) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Removes a Microsoft.TeamFoundation.VersionControl.Client.Shelveset from the
        //     server.
        //
        // Parameters:
        //   shelveset:
        //     The Microsoft.TeamFoundation.VersionControl.Client.Shelveset to remove.
        /// <summary>
        /// Deletes the shelveset.
        /// </summary>
        /// <param name="shelveset">The shelveset.</param>
         void IVersionControlServerHelper.DeleteShelveset(IShelveset shelveset) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Removes a Microsoft.TeamFoundation.VersionControl.Client.Shelveset from the
        //     server.
        //
        // Parameters:
        //   shelvesetName:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Shelveset
        //     to remove.
        //
        //   shelvesetOwner:
        //     The owner of the Microsoft.TeamFoundation.VersionControl.Client.Shelveset
        //     to remove.
        /// <summary>
        /// Deletes the shelveset.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
         void IVersionControlServerHelper.DeleteShelveset(string shelvesetName, string shelvesetOwner) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Deletes the Microsoft.TeamFoundation.VersionControl.Client.Shelveset that
        //     has the specified name and owner.
        //
        // Parameters:
        //   workspaceName:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Shelveset
        //     to delete.
        //
        //   workspaceOwner:
        //     The owner of the Microsoft.TeamFoundation.VersionControl.Client.Shelveset
        //     to delete.
        //
        // Returns:
        //     True if the workspace was deleted. False if it was canceled.
        /// <summary>
        /// Deletes the workspace.
        /// </summary>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="workspaceOwner">The workspace owner.</param>
        /// <returns>System.Boolean.</returns>
         bool IVersionControlServerHelper.DeleteWorkspace(string workspaceName, string workspaceOwner) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Permanently deletes the subtree, starting at the specified item.
        //
        // Parameters:
        //   itemSpec:
        //     The local or server path of an item that will be recursively destroyed.
        //
        //   versionSpec:
        //     The version of the item.
        //
        //   stopAt:
        //     The version spec (not label or workspace) that influences keepHistory mode
        //     behavior.
        //
        //   flags:
        //     The set of destroy flags that affects the Destroy: operation. KeepHistory:
        //     True to remove only the content of every version of a file up to but not
        //     including the changeset that is represented by stopAt. Force: True to asynchronously
        //     initialize content garbage collection. Preview: True to make sure that no
        //     database data will be deleted. Only a list of items that would have been
        //     destroyed is returned.
        //
        // Returns:
        //     The array of items that were destroyed.
        /// <summary>
        /// Destroys the specified item spec.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="stopAt">The stop at.</param>
        /// <param name="flags">The flags.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem[].</returns>
         IItem[] IVersionControlServerHelper.Destroy(IItemSpec itemSpec, IVersionSpec versionSpec, IVersionSpec stopAt, IDestroyFlags flags) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Permanently deletes the subtree, starting at the specified item.
        //
        // Parameters:
        //   itemSpec:
        //     The local or server path of an item that will be recursively destroyed.
        //
        //   versionSpec:
        //     The version of the item.
        //
        //   stopAt:
        //     The version spec (not label or workspace) that influences keepHistory mode
        //     behavior.
        //
        //   flags:
        //     The set of destroy flags that affects the Destroy: operation. KeepHistory:
        //     True to remove only the content of every version of a file up to but not
        //     including the changeset that is represented by stopAt. Force: True to asynchronously
        //     initialize content garbage collection. Preview: True to make sure that no
        //     database data will be deleted. Only a list of items that would have been
        //     destroyed is returned. Silent: True to return no data to the client. AffectedChanges:
        //     True to enable that pending changes and shelved changes that will be destroyed
        //     will be returned in affectedPendingChanges and affectedShelvedChanges. This
        //     can be set only if Preview is set. If set, the return value array will be
        //     empty.
        //
        //   affectedPendingChanges:
        //     The pending changes that will be destroyed.
        //
        //   affectedShelvedChanges:
        //     The shelved changes that will be destroyed.
        //
        // Returns:
        //     The array of items that were destroyed. Null if the Silent flag is specified.
        /// <summary>
        /// Destroys the specified item spec.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="stopAt">The stop at.</param>
        /// <param name="flags">The flags.</param>
        /// <param name="affectedPendingChanges">The affected pending changes.</param>
        /// <param name="affectedShelvedChanges">The affected shelved changes.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem[].</returns>
         IItem[] IVersionControlServerHelper.Destroy(IItemSpec itemSpec, IVersionSpec versionSpec, IVersionSpec stopAt, IDestroyFlags flags, out IPendingSet[] affectedPendingChanges, out IPendingSet[] affectedShelvedChanges) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Downloads the latest version of a file from the server to a local file.
        //
        // Parameters:
        //   serverPath:
        //     The repository path of the file to download.
        //
        //   localFileName:
        //     The local path where the local file should be stored.
        /// <summary>
        /// Downloads the file.
        /// </summary>
        /// <param name="serverPath">The server path.</param>
        /// <param name="localFileName">Name of the local file.</param>
         void IVersionControlServerHelper.DownloadFile(string serverPath, string localFileName) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Downloads the specified version of a file from the server to a local file.
        //
        // Parameters:
        //   serverPath:
        //     The repository path of the file to download.
        //
        //   deletionId:
        //     The deletion ID of the file if it has been deleted.
        //
        //   version:
        //     The version of the file to download.
        //
        //   localFileName:
        //     The local path where the local file should be stored.
        /// <summary>
        /// Downloads the file.
        /// </summary>
        /// <param name="serverPath">The server path.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <param name="version">The version.</param>
        /// <param name="localFileName">Name of the local file.</param>
         void IVersionControlServerHelper.DownloadFile(string serverPath, int deletionId, IVersionSpec version, string localFileName) { throw new NotImplementedException(); }
        /// <summary>
        /// Downloads the file by URL.
        /// </summary>
        /// <param name="downloadUrl">The download URL.</param>
        /// <returns>System.IO.Stream.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
         Stream IVersionControlServerHelper.DownloadFileByUrl(string downloadUrl) { throw new NotImplementedException(); }
        /// <summary>
        /// Downloads the file by URL.
        /// </summary>
        /// <param name="downloadUrl">The download URL.</param>
        /// <param name="localFileName">Name of the local file.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
         void IVersionControlServerHelper.DownloadFileByUrl(string downloadUrl, string localFileName) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of all the check-in note fields used in this database.
        //
        // Returns:
        //     An array of check-in note field names.
        /// <summary>
        /// Gets all checkin note field names.
        /// </summary>
        /// <returns>System.String[].</returns>
         string[] IVersionControlServerHelper.GetAllCheckinNoteFieldNames() { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.TeamProject objects
        //     in the repository.
        //
        // Parameters:
        //   refresh:
        //     True to refresh the team project cache by calling the server. False to return
        //     cached projects without a call to server.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.VersionControl.Client.TeamProject objects in
        //     the repository.
        /// <summary>
        /// Gets all team projects.
        /// </summary>
        /// <param name="refresh">The refresh.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.TeamProject[].</returns>
         ITeamProject[] IVersionControlServerHelper.GetAllTeamProjects(bool refresh) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets a list of recommended proxy servers returned in preferential order for
        //     the given site.
        //
        // Parameters:
        //   site:
        //     The site to retrieve recommended proxies for.
        //
        // Returns:
        //     A list of Microsoft.TeamFoundation.VersionControl.Client.ProxyInfo records
        //     corresponding to the best proxy matches for the given site, or an empty list
        //     if no recommended matches are found.
        /// <summary>
        /// Gets the best proxies.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns>System.Collections.Generic.List&lt;DynCon.OSI.VSO.ObjectModelClient.Helpers.ProxyInfo&gt;.</returns>
         List<IProxyInfo> IVersionControlServerHelper.GetBestProxies(string site) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the branch history of the requested items.
        //
        // Parameters:
        //   itemSpecs:
        //     Array of requested Microsoft.TeamFoundation.VersionControl.Client.IItem specifiers.
        //
        //   version:
        //     The version of the Microsoft.TeamFoundation.VersionControl.Client.Items.
        //
        // Returns:
        //     Array of Microsoft.TeamFoundation.VersionControl.Client.IBranchHistoryTreeItem
        //     arrays.
        /// <summary>
        /// Gets the branch history.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IBranchHistoryTreeItem[][].</returns>
         IBranchHistoryTreeItem[][] IVersionControlServerHelper.GetBranchHistory(IItemSpec[] itemSpecs, IVersionSpec version) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the details of a Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     (comment, changes, etc.).
        //
        // Parameters:
        //   changesetId:
        //     The ID for the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.VersionControl.Client.Changeset object specifying
        //     these details.
        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset.</returns>
         IChangeset IVersionControlServerHelper.GetChangeset(int changesetId) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the details of a Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     (comment, changes, etc.).
        //
        // Parameters:
        //   changesetId:
        //     The ID of the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        //   includeChanges:
        //     True to include the changes in the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //     False to include only metadata.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     A reference to a Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     object specifying these details.
        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeChanges">The include changes.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset.</returns>
         IChangeset IVersionControlServerHelper.GetChangeset(int changesetId, bool includeChanges, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the details of a Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     (comment, changes, etc.).
        //
        // Parameters:
        //   changesetId:
        //     The ID of the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        //   includeChanges:
        //     True to include the changes in the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //     False to include only metadata.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        //   includeSourceRenames:
        //     Include rename sources in the changes returned.
        //
        // Returns:
        //     A reference to a Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     object specifying these details.
        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeChanges">The include changes.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="includeSourceRenames">The include source renames.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset.</returns>
         IChangeset IVersionControlServerHelper.GetChangeset(int changesetId, bool includeChanges, bool includeDownloadInfo, bool includeSourceRenames) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the details of a Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     (comment, changes, etc.).
        //
        // Parameters:
        //   changesetId:
        //     The ID of the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        //   includeChanges:
        //     True to include the changes in the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //     False to include only metadata.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        //   changesetPropertyFilters:
        //     List of the property name filters to filter the result.
        //
        // Returns:
        //     A reference to a Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     object specifying these details.
        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeChanges">The include changes.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="changesetPropertyFilters">The changeset property filters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset.</returns>
         IChangeset IVersionControlServerHelper.GetChangeset(int changesetId, bool includeChanges, bool includeDownloadInfo, string[] changesetPropertyFilters) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        /// <summary>
        /// Gets the changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeChanges">The include changes.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="changesetPropertyFilters">The changeset property filters.</param>
        /// <param name="itemAttributeFilters">The item attribute filters.</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset.</returns>
         IChangeset IVersionControlServerHelper.GetChangeset(int changesetId, bool includeChanges, bool includeDownloadInfo, string[] changesetPropertyFilters, string[] itemAttributeFilters, string[] itemPropertyFilters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the property value of a Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     specified by Microsoft.TeamFoundation.VersionControl.Client.Changeset ID
        //     and property name filter.
        //
        // Parameters:
        //   changesetId:
        //     The Microsoft.TeamFoundation.VersionControl.Client.Changeset ID.
        //
        //   propertyNameFilter:
        //     The property name filter.
        //
        // Returns:
        //     An ArtifactPropertyValue object, which contains the property value. Null
        //     if the property does not exist on the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        /// <summary>
        /// Gets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyNameFilter">The property name filter.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ArtifactPropertyValue.</returns>
         IArtifactPropertyValue IVersionControlServerHelper.GetChangesetProperty(int changesetId, string propertyNameFilter) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the property value of a Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     specified by Microsoft.TeamFoundation.VersionControl.Client.Changeset ID
        //     and an array of property name filters.
        //
        // Parameters:
        //   changesetId:
        //     The Microsoft.TeamFoundation.VersionControl.Client.Changeset ID.
        //
        //   propertyNameFilters:
        //     The array of property name filters.
        //
        // Returns:
        //     An ArtifactPropertyValue object, which contains the set of property values.
        //     Null if none of the properties exist on the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        /// <summary>
        /// Gets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyNameFilters">The property name filters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ArtifactPropertyValue.</returns>
         IArtifactPropertyValue IVersionControlServerHelper.GetChangesetProperty(int changesetId, string[] propertyNameFilters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.Change objects within
        //     a Microsoft.TeamFoundation.VersionControl.Client.Changeset. Allows the caller
        //     to page changes back from the server.
        //
        // Parameters:
        //   changesetId:
        //     The Microsoft.TeamFoundation.VersionControl.Client.Changeset for which to
        //     get Microsoft.TeamFoundation.VersionControl.Client.Change objects.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        //   pageSize:
        //     The number of items to return.
        //
        //   lastItem:
        //     Instructs the server to return items which sort after this item. If null,
        //     the server will begin from the start of the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Returns:
        //     Array of Microsoft.TeamFoundation.VersionControl.Client.Change objects.
        /// <summary>
        /// Gets the changes for changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="lastItem">The last item.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Change[].</returns>
         IChange[] IVersionControlServerHelper.GetChangesForChangeset(int changesetId, bool includeDownloadInfo, int pageSize, IItemSpec lastItem) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the changes within a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //     Allows the caller to page changes back from the server.
        //
        // Parameters:
        //   changesetId:
        //     The Microsoft.TeamFoundation.VersionControl.Client.Changeset for which to
        //     get Microsoft.TeamFoundation.VersionControl.Client.Change objects.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        //   pageSize:
        //     The number of items to return.
        //
        //   lastItem:
        //     Instructs the server to return items which sort after this item. If null,
        //     the server will begin from the start of the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        //   propertyNameFilters:
        //     Array of the property name filters to apply to each result.
        //
        // Returns:
        //     Array of Microsoft.TeamFoundation.VersionControl.Client.Change objects.
        /// <summary>
        /// Gets the changes for changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="lastItem">The last item.</param>
        /// <param name="propertyNameFilters">The property name filters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Change[].</returns>
         IChange[] IVersionControlServerHelper.GetChangesForChangeset(int changesetId, bool includeDownloadInfo, int pageSize, IItemSpec lastItem, string[] propertyNameFilters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the changes within a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //     Allows the caller to page changes back from the server.
        //
        // Parameters:
        //   changesetId:
        //     The Microsoft.TeamFoundation.VersionControl.Client.Changeset for which to
        //     get changes.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        //   pageSize:
        //     The number of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     to return.
        //
        //   lastItem:
        //     Instructs the server to return items which sort after this item. If null,
        //     the server will begin from the start of the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        //   itemAttributeFilters:
        //     Array of the property name filters to apply to each result.
        //
        //   includeMergeSourceInfo:
        //     True to include source information about renames / merges. False to not include
        //     these.
        //
        // Returns:
        //     Array of Microsoft.TeamFoundation.VersionControl.Client.Change objects.
        /// <summary>
        /// Gets the changes for changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="lastItem">The last item.</param>
        /// <param name="itemAttributeFilters">The item attribute filters.</param>
        /// <param name="includeMergeSourceInfo">The include merge source information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Change[].</returns>
         IChange[] IVersionControlServerHelper.GetChangesForChangeset(int changesetId, bool includeDownloadInfo, int pageSize, IItemSpec lastItem, string[] itemAttributeFilters, bool includeMergeSourceInfo) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.Change.
        /// <summary>
        /// Gets the changes for changeset.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="lastItem">The last item.</param>
        /// <param name="itemAttributeFilters">The item attribute filters.</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <param name="includeMergeSourceInfo">The include merge source information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Change[].</returns>
         IChange[] IVersionControlServerHelper.GetChangesForChangeset(int changesetId, bool includeDownloadInfo, int pageSize, IItemSpec lastItem, string[] itemAttributeFilters, string[] itemPropertyFilters, bool includeMergeSourceInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.CheckinNoteFieldDefinition
        //     objects supported for Microsoft.TeamFoundation.VersionControl.Client.ICheckinNote
        //     data.
        //
        // Parameters:
        //   teamProjects:
        //     List of Microsoft.TeamFoundation.VersionControl.Client.TeamProject objects
        //     to search through.
        //
        // Returns:
        //     Microsoft.TeamFoundation.VersionControl.Client.CheckinNoteFieldDefinition
        //     array that combines the fields of the server items.
        /// <summary>
        /// Gets the checkin note definitions.
        /// </summary>
        /// <param name="teamProjects">The team projects.</param>
        /// <returns>Microsoft.TeamFoundation.VersionControl.Client.CheckinNoteFieldDefinition[].</returns>
         ICheckinNoteFieldDefinition[] IVersionControlServerHelper.GetCheckinNoteDefinitions(ITeamProject[] teamProjects) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.CheckinNoteFieldDefinition
        //     objects supported for Microsoft.TeamFoundation.VersionControl.Client.ICheckinNote
        //     data.
        //
        // Parameters:
        //   serverItems:
        //     Server items to look up.
        //
        // Returns:
        //     Microsoft.TeamFoundation.VersionControl.Client.CheckinNoteFieldDefinition
        //     array that unions the fields of the server items.
        /// <summary>
        /// Gets the checkin note definitions for server paths.
        /// </summary>
        /// <param name="serverItems">The server items.</param>
        /// <returns>Microsoft.TeamFoundation.VersionControl.Client.CheckinNoteFieldDefinition[].</returns>
         ICheckinNoteFieldDefinition[] IVersionControlServerHelper.GetCheckinNoteDefinitionsForServerPaths(string[] serverItems) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.CheckinNoteFieldDefinition
        //     supported for Microsoft.TeamFoundation.VersionControl.Client.ICheckinNote
        //     data.
        //
        // Parameters:
        //   serverItems:
        //     Server items to look up.
        //
        // Returns:
        //     Microsoft.TeamFoundation.VersionControl.Client.CheckinNoteFieldDefinition
        //     array that unions the fields of the server items.
        /// <summary>
        /// Gets the checkin policies for server paths.
        /// </summary>
        /// <param name="serverItems">The server items.</param>
        /// <returns>Microsoft.TeamFoundation.VersionControl.Client.PolicyEnvelope[].</returns>
         IPolicyEnvelope[] IVersionControlServerHelper.GetCheckinPoliciesForServerPaths(string[] serverItems) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the global permissions of a user.
        //
        // Parameters:
        //   userName:
        //     Name of user to check.
        //
        // Returns:
        //     Array of permission names.
        /// <summary>
        /// Gets the effective global permissions.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>System.String[].</returns>
         string[] IVersionControlServerHelper.GetEffectiveGlobalPermissions(string userName) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the permissions of a user for a particular Microsoft.TeamFoundation.VersionControl.Client.IItem.
        //
        // Parameters:
        //   userName:
        //     Name of user to check.
        //
        //   item:
        //     The path to the Microsoft.TeamFoundation.VersionControl.Client.IItem to check
        //     (server or local path).
        //
        // Returns:
        //     Array of permission names.                                                fr
        /// <summary>
        /// Gets the effective permissions.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="item">The item.</param>
        /// <returns>System.String[].</returns>
         string[] IVersionControlServerHelper.GetEffectivePermissions(string userName, string item) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.ExtendedItem
        //     objects in the repository that match the specified criteria, for each Microsoft.TeamFoundation.VersionControl.Client.ItemSpec.
        //
        // Parameters:
        //   itemSpecs:
        //     The item specifiers for the item(s), may be server or local.
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        // Returns:
        //     An array containing the matching Microsoft.TeamFoundation.VersionControl.Client.ExtendedItem
        //     instances associated with each specified Microsoft.TeamFoundation.VersionControl.Client.ItemSpec.
        /// <summary>
        /// Gets the extended items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ExtendedItem[][].</returns>
         IExtendedItem[][] IVersionControlServerHelper.GetExtendedItems(IItemSpec[] itemSpecs, IDeletedState deletedState, IItemType itemType) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.ExtendedItem
        //     objects in the repository that match the specified criteria.
        //
        // Parameters:
        //   path:
        //     The path to the item(s), may be server or local.
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        // Returns:
        //     An array containing the matching Microsoft.TeamFoundation.VersionControl.Client.ExtendedItem
        //     instances.
        /// <summary>
        /// Gets the extended items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ExtendedItem[].</returns>
         IExtendedItem[] IVersionControlServerHelper.GetExtendedItems(string path, IDeletedState deletedState, IItemType itemType) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.ExtendedItem
        //     objects in the repository that match the specified criteria, for each Microsoft.TeamFoundation.VersionControl.Client.ItemSpec.
        //
        // Parameters:
        //   itemSpecs:
        //     The item specifiers for the item(s), may be server or local.
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        //   options:
        //     Options for the get operation (see Microsoft.TeamFoundation.VersionControl.Client.GetItemsOptions).
        //
        // Returns:
        //     An array containing the matching Microsoft.TeamFoundation.VersionControl.Client.ExtendedItem
        //     instances associated with each specified Microsoft.TeamFoundation.VersionControl.Client.ItemSpec.
        /// <summary>
        /// Gets the extended items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="options">The options.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ExtendedItem[][].</returns>
         IExtendedItem[][] IVersionControlServerHelper.GetExtendedItems(IItemSpec[] itemSpecs, IDeletedState deletedState, IItemType itemType, GetItemsOptions options) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.ExtendedItem.
        /// <summary>
        /// Gets the extended items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="options">The options.</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ExtendedItem[][].</returns>
         IExtendedItem[][] IVersionControlServerHelper.GetExtendedItems(IItemSpec[] itemSpecs, IDeletedState deletedState, IItemType itemType, GetItemsOptions options, string[] itemPropertyFilters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the array of Microsoft.TeamFoundation.VersionControl.Client.IFileType
        //     objects registered on the server.
        //
        // Returns:
        //     The array Microsoft.TeamFoundation.VersionControl.Client.IFileType objects
        //     registered on the server.
        /// <summary>
        /// Gets the file types.
        /// </summary>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IFileType[].</returns>
         IFileType[] IVersionControlServerHelper.GetFileTypes() { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the global permissions of the selected users in the repository.
        //
        // Parameters:
        //   identityNames:
        //     The user or group names (specify null for all identities).
        //
        // Returns:
        //     The permissions from the repository.
        /// <summary>
        /// Gets the global permissions.
        /// </summary>
        /// <param name="identityNames">The identity names.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.GlobalSecurity.</returns>
         IGlobalSecurity IVersionControlServerHelper.GetGlobalPermissions(string[] identityNames) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns System.String.
        /// <summary>
        /// Gets the display name of the identity.
        /// </summary>
        /// <param name="identity">The identity.</param>
        /// <returns>System.String.</returns>
         string IVersionControlServerHelper.GetIdentityDisplayName(ITeamFoundationIdentity identity) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.IItem at the specified
        //     path.
        //
        // Parameters:
        //   path:
        //     The path to the item, may be server or local.
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Throws
        //     an exception if an item is not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(string path) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an Microsoft.TeamFoundation.VersionControl.Client.IItem from the repository,
        //     based on itemId and changesetNumber.
        //
        // Parameters:
        //   itemId:
        //     IItem ID.
        //
        //   changesetNumber:
        //     Changeset version of the item.
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Null if
        //     not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(int itemId, int changesetNumber) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.IItem at the specified
        //     path.
        //
        // Parameters:
        //   path:
        //     The path to the item, may be server or local.
        //
        //   version:
        //     The version of the item.
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Throws
        //     an exception if an item is not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(string path, IVersionSpec version) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an Microsoft.TeamFoundation.VersionControl.Client.IItem from the repository,
        //     based on itemId and changesetNumber.
        //
        // Parameters:
        //   itemId:
        //     IItem ID.
        //
        //   changesetNumber:
        //     Changeset version of the item.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Null if
        //     not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(int itemId, int changesetNumber, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an Microsoft.TeamFoundation.VersionControl.Client.IItem from the repository,
        //     based on itemId, changesetNumber, and options.
        //
        // Parameters:
        //   itemId:
        //     IItem ID.
        //
        //   changesetNumber:
        //     Changeset version of the item.
        //
        //   options:
        //     Additional behavior flags (see Microsoft.TeamFoundation.VersionControl.Client.GetItemsOptions).
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Null if
        //     not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <param name="options">The options.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(int itemId, int changesetNumber, GetItemsOptions options) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.IItem at the specified
        //     path.
        //
        // Parameters:
        //   path:
        //     The path to the item, may be server or local.
        //
        //   version:
        //     The version of the item.
        //
        //   deletedState:
        //     A flag describing to return deleted items and/or non-deleted items.
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Throws
        //     an exception if an item is not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(string path, IVersionSpec version, IDeletedState deletedState) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.IItem at the specified
        //     path.
        //
        // Parameters:
        //   path:
        //     The path to the item, may be server or local.
        //
        //   version:
        //     The version of the item.
        //
        //   deletionId:
        //     The deletion ID of the specified item.
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Throws
        //     an exception if an item is not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(string path, IVersionSpec version, int deletionId) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.IItem at the specified
        //     path.
        //
        // Parameters:
        //   path:
        //     The path to the item, may be server or local.
        //
        //   version:
        //     The version of the item.
        //
        //   deletedState:
        //     A flag describing to return deleted items and/or non-deleted items.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Throws
        //     an exception if an item is not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(string path, IVersionSpec version, IDeletedState deletedState, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.IItem at the specified
        //     path.
        //
        // Parameters:
        //   path:
        //     The path to the item, may be server or local.
        //
        //   version:
        //     The version of the item.
        //
        //   deletedState:
        //     A flag describing to return deleted items and/or non-deleted items.
        //
        //   options:
        //     Additional behavior flags (see Microsoft.TeamFoundation.VersionControl.Client.GetItemsOptions).
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Throws
        //     an exception if an item is not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="options">The options.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(string path, IVersionSpec version, IDeletedState deletedState, GetItemsOptions options) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.IItem at the specified
        //     path.
        //
        // Parameters:
        //   path:
        //     The path to the item, may be server or local.
        //
        //   version:
        //     The version of the item.
        //
        //   deletionId:
        //     The deletion ID of the specified item.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Throws
        //     an exception if an item is not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(string path, IVersionSpec version, int deletionId, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.IItem at the specified
        //     path.
        //
        // Parameters:
        //   path:
        //     The path to the item, may be server or local.
        //
        //   version:
        //     The version of the item.
        //
        //   deletionId:
        //     The deletion ID of the specified item.
        //
        //   options:
        //     Additional behavior flags (see GetItemsOptions).
        //
        // Returns:
        //     The specified Microsoft.TeamFoundation.VersionControl.Client.IItem. Throws
        //     an exception if an item is not found.
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletionId">The deletion identifier.</param>
        /// <param name="options">The options.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem.</returns>
         IItem IVersionControlServerHelper.GetItem(string path, IVersionSpec version, int deletionId, GetItemsOptions options) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     from repository that match the specified path.
        //
        // Parameters:
        //   path:
        //     The path to the item(s), may be server or local.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects matching
        //     the path.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet.</returns>
         ITemSet IVersionControlServerHelper.GetItems(string path) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     from repository, based on itemIds and changesetNumber.
        //
        // Parameters:
        //   itemIds:
        //     IItem ID.
        //
        //   changesetNumber:
        //     Changeset version of the item.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects that
        //     match the parameters.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemIds">The item ids.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem[].</returns>
         IItem[] IVersionControlServerHelper.GetItems(int[] itemIds, int changesetNumber) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     from repository that match the specified path.
        //
        // Parameters:
        //   path:
        //     The path to the item(s), may be server or local.
        //
        //   recursion:
        //     A flag describing whether the items should be listed from subfolders.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects matching
        //     the path.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet.</returns>
         ITemSet IVersionControlServerHelper.GetItems(string path, RecursionType recursion) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     from repository, based on itemIds and changesetNumber.
        //
        // Parameters:
        //   itemIds:
        //     IItem ID.
        //
        //   changesetNumber:
        //     Changeset version of the item.
        //
        //   includeDownloadInfo:
        //     True to include information to download files from the server.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects that
        //     match the parameters.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemIds">The item ids.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem[].</returns>
         IItem[] IVersionControlServerHelper.GetItems(int[] itemIds, int changesetNumber, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     from repository, based on itemIds and changesetNumber.
        //
        // Parameters:
        //   itemIds:
        //     IItem ID.
        //
        //   changesetNumber:
        //     Changeset version of the item.
        //
        //   options:
        //     Options for the query.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects that
        //     match the parameters.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemIds">The item ids.</param>
        /// <param name="changesetNumber">The changeset number.</param>
        /// <param name="options">The options.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IItem[].</returns>
         IItem[] IVersionControlServerHelper.GetItems(int[] itemIds, int changesetNumber, GetItemsOptions options) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     from repository that match the specified path.
        //
        // Parameters:
        //   path:
        //     The path to the item(s), may be server or local.
        //
        //   version:
        //     The version of the item(s).
        //
        //   recursion:
        //     A flag describing whether the items should be listed from subfolders.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects matching
        //     the path.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet.</returns>
         ITemSet IVersionControlServerHelper.GetItems(string path, IVersionSpec version, RecursionType recursion) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     in the repository that match the specified path and version.
        //
        // Parameters:
        //   itemSpecs:
        //     The item specifier for the item(s), may be server or local.
        //
        //   version:
        //     The version of the item(s).
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        // Returns:
        //     An array of items matching the path.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet[].</returns>
         ITemSet[] IVersionControlServerHelper.GetItems(IItemSpec[] itemSpecs, IVersionSpec version, IDeletedState deletedState, IItemType itemType) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     in the repository that match the specified path and version.
        //
        // Parameters:
        //   itemSpec:
        //     The item specifier for the item(s), may be server or local.
        //
        //   version:
        //     The version of the item(s).
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     An array of items matching the path.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet.</returns>
         ITemSet IVersionControlServerHelper.GetItems(IItemSpec itemSpec, IVersionSpec version, IDeletedState deletedState, IItemType itemType, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     in the repository that match the specified path and version.
        //
        // Parameters:
        //   itemSpec:
        //     The item specifier for the item(s), may be server or local.
        //
        //   version:
        //     The version of the item(s).
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        //   options:
        //     Additional behavior flags (see Microsoft.TeamFoundation.VersionControl.Client.GetItemsOptions).
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects matching
        //     the path.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="options">The options.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet.</returns>
         ITemSet IVersionControlServerHelper.GetItems(IItemSpec itemSpec, IVersionSpec version, IDeletedState deletedState, IItemType itemType, GetItemsOptions options) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     in the repository that match the specified path and version.
        //
        // Parameters:
        //   itemSpecs:
        //     The item specifier for the item(s), may be server or local.
        //
        //   version:
        //     The version of the item(s).
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     An array of items matching the path.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet[].</returns>
         ITemSet[] IVersionControlServerHelper.GetItems(IItemSpec[] itemSpecs, IVersionSpec version, IDeletedState deletedState, IItemType itemType, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     in the repository that match the specified path and version.
        //
        // Parameters:
        //   itemSpecs:
        //     The item specifier for the item(s), may be server or local.
        //
        //   version:
        //     The version of the item(s).
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        //   options:
        //     Additional behavior flags (see Microsoft.TeamFoundation.VersionControl.Client.GetItemsOptions).
        //
        // Returns:
        //     An array of items matching the path.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="options">The options.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet[].</returns>
         ITemSet[] IVersionControlServerHelper.GetItems(IItemSpec[] itemSpecs, IVersionSpec version, IDeletedState deletedState, IItemType itemType, GetItemsOptions options) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     from repository that match the specified path.
        //
        // Parameters:
        //   path:
        //     The path to the item(s), may be server or local.
        //
        //   version:
        //     The version of the item(s).
        //
        //   recursion:
        //     A flag describing whether the items should be listed from subfolders.
        //
        //   deletedState:
        //     A flag describing to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects matching
        //     the path.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet.</returns>
         ITemSet IVersionControlServerHelper.GetItems(string path, IVersionSpec version, RecursionType recursion, IDeletedState deletedState, IItemType itemType) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.IItem objects
        //     from repository that match the specified path.
        //
        // Parameters:
        //   path:
        //     The path to the item(s), may be server or local.
        //
        //   version:
        //     The version of the item(s).
        //
        //   recursion:
        //     A flag describing whether the items should be listed from subfolders.
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     An Microsoft.TeamFoundation.VersionControl.Client.ItemSet object containing
        //     a collection of matching Microsoft.TeamFoundation.VersionControl.Client.IItem
        //     objects.
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet.</returns>
         ITemSet IVersionControlServerHelper.GetItems(string path, IVersionSpec version, RecursionType recursion, IDeletedState deletedState, IItemType itemType, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.ItemSet.
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
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemSet[].</returns>
         ITemSet[] IVersionControlServerHelper.GetItems(IItemSpec[] itemSpecs, IVersionSpec version, IDeletedState deletedState, IItemType itemType, GetItemsOptions options, string[] itemPropertyFilters, string[] itemAttributeFilters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.Changeset ID for
        //     the latest Microsoft.TeamFoundation.VersionControl.Client.Changeset in the
        //     repository.
        //
        // Returns:
        //     The latest Microsoft.TeamFoundation.VersionControl.Client.ChangesetID.
        /// <summary>
        /// Gets the latest changeset identifier.
        /// </summary>
        /// <returns>System.Int32.</returns>
         int IVersionControlServerHelper.GetLatestChangesetId() { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the candidates for merging between the requested items.
        //
        // Parameters:
        //   source:
        //     The source Microsoft.TeamFoundation.VersionControl.Client.ItemSpec for the
        //     potential merge.
        //
        //   targetPath:
        //     The path of the target for the potential merge.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.MergeCandidate
        //     objects.
        /// <summary>
        /// Gets the merge candidates.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="targetPath">The target path.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.MergeCandidate[].</returns>
         IMergeCandidate[] IVersionControlServerHelper.GetMergeCandidates(IItemSpec source, string targetPath) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.MergeCandidate.
        /// <summary>
        /// Gets the merge candidates.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="options">The options.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.MergeCandidate[].</returns>
         IMergeCandidate[] IVersionControlServerHelper.GetMergeCandidates(IItemSpec source, string targetPath, IMergeOptionsEx options) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the candidates for merging between the requested items.
        //
        // Parameters:
        //   sourcePath:
        //     The path of the source for the potential merge.
        //
        //   targetPath:
        //     The path of the target for the potential merge.
        //
        //   recursion:
        //     The level of recursion to apply in the search.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.MergeCandidate
        //     objects.
        /// <summary>
        /// Gets the merge candidates.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="targetPath">The target path.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.MergeCandidate[].</returns>
         IMergeCandidate[] IVersionControlServerHelper.GetMergeCandidates(string sourcePath, string targetPath, RecursionType recursion) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.PendingChange object
        //     from the repository, with the specified ID.
        //
        // Parameters:
        //   pendingChangeId:
        //     The Microsoft.TeamFoundation.VersionControl.Client.PendingChange ID.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.VersionControl.Client.PendingChange that matches
        //     the specified ID. Otherwise, null.
        /// <summary>
        /// Gets the pending change.
        /// </summary>
        /// <param name="pendingChangeId">The pending change identifier.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingChange.</returns>
        [Obsolete("Method obsolete since TFS 2010. Please use VersionControlServer.QueryPendingSets, VersionControlServer.QueryShelvedChanges or Workspace.GetPendingChanges instead.")]
         IPendingChange IVersionControlServerHelper.GetPendingChange(int pendingChangeId) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.PendingChange object
        //     from the repository, with the specified ID. Also gets information to download
        //     files.
        //
        // Parameters:
        //   pendingChangeId:
        //     The Microsoft.TeamFoundation.VersionControl.Client.PendingChange ID.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth, if downloading is not necessary.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.VersionControl.Client.PendingChange that matches
        //     the specified ID. Otherwise, null.
        /// <summary>
        /// Gets the pending change.
        /// </summary>
        /// <param name="pendingChangeId">The pending change identifier.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingChange.</returns>
        [Obsolete("Method obsolete since TFS 2010. Please use VersionControlServer.QueryPendingSets, VersionControlServer.QueryShelvedChanges or Workspace.GetPendingChanges instead.")]
         IPendingChange IVersionControlServerHelper.GetPendingChange(int pendingChangeId, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.PendingChange objects
        //     from the repository with the specified IDs.
        //
        // Parameters:
        //   pendingChangeIds:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingChange
        //     IDs.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingChange
        //     objects that match the specified IDs.
        /// <summary>
        /// Gets the pending changes.
        /// </summary>
        /// <param name="pendingChangeIds">The pending change ids.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingChange[].</returns>
        [Obsolete("Method obsolete since TFS 2010. Please use VersionControlServer.QueryPendingSets, VersionControlServer.QueryShelvedChanges or Workspace.GetPendingChanges instead.")]
         IPendingChange[] IVersionControlServerHelper.GetPendingChanges(int[] pendingChangeIds) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.PendingChange objects
        //     from the repository with the specified IDs. Also gets information to download
        //     files.
        //
        // Parameters:
        //   pendingChangeIds:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingChange
        //     IDs.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth, if downloading is not necessary.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingChange
        //     objects that match the specified IDs.
        /// <summary>
        /// Gets the pending changes.
        /// </summary>
        /// <param name="pendingChangeIds">The pending change ids.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingChange[].</returns>
        [Obsolete("Method obsolete since TFS 2010. Please use VersionControlServer.QueryPendingSets, VersionControlServer.QueryShelvedChanges or Workspace.GetPendingChanges instead.")]
         IPendingChange[] IVersionControlServerHelper.GetPendingChanges(int[] pendingChangeIds, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     for the specified query.
        //
        // Parameters:
        //   items:
        //     An array of paths to the items to query for pending changes.
        //
        //   recursion:
        //     Recursion level to query pending changes.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     that contain the Microsoft.TeamFoundation.VersionControl.Client.PendingChange
        //     objects for each of the specified items. If a path in items did not resolve
        //     to an Microsoft.TeamFoundation.VersionControl.Client.IItem, the element in
        //     the corresponding index of the returned array will be null.
        /// <summary>
        /// Gets the pending sets.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.GetPendingSets(string[] items, RecursionType recursion) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the permissions of the specified Microsoft.TeamFoundation.VersionControl.Client.Items.
        //
        // Parameters:
        //   items:
        //     Array of paths to the items to get permissions for.
        //
        //   recursion:
        //     The recursion level to use for querying items.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ItemSecurity objects
        //     representing the permissions of the corresponding items.
        /// <summary>
        /// Gets the permissions.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>Microsoft.TeamFoundation.VersionControl.Client.ItemSecurity[].</returns>
         IItemSecurity[] IVersionControlServerHelper.GetPermissions(string[] items, RecursionType recursion) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the permissions of the specified Microsoft.TeamFoundation.VersionControl.Client.Items.
        //
        // Parameters:
        //   identityNames:
        //     The user or group names (may be null).
        //
        //   items:
        //     An array of paths to the items to get permissions for.
        //
        //   recursion:
        //     The recursion level to use for querying items.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ItemSecurity objects
        //     representing the permissions of the corresponding items.
        /// <summary>
        /// Gets the permissions.
        /// </summary>
        /// <param name="identityNames">The identity names.</param>
        /// <param name="items">The items.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>Microsoft.TeamFoundation.VersionControl.Client.ItemSecurity[].</returns>
         IItemSecurity[] IVersionControlServerHelper.GetPermissions(string[] identityNames, string[] items, RecursionType recursion) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of all configured proxy servers.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ProxyInfo records
        //     for all known proxies configured for the server, or null if there are no
        //     proxy records.
        /// <summary>
        /// Gets the proxies.
        /// </summary>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ProxyInfo[].</returns>
         IProxyInfo[] IVersionControlServerHelper.GetProxies() { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of proxy server records based on the specified URLs.
        //
        // Parameters:
        //   proxyUrls:
        //     An array of proxy server URLs.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ProxyInfo records
        //     for all known proxies configured for the server.
        /// <summary>
        /// Gets the proxies.
        /// </summary>
        /// <param name="proxyUrls">The proxy urls.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ProxyInfo[].</returns>
         IProxyInfo[] IVersionControlServerHelper.GetProxies(string[] proxyUrls) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the record for a proxy server at the specified URL.
        //
        // Parameters:
        //   proxyUrl:
        //     URL of the proxy record to get.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ProxyInfo object corresponding
        //     to the specified URL. Null if one is not found.
        /// <summary>
        /// Gets the proxy.
        /// </summary>
        /// <param name="proxyUrl">The proxy URL.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ProxyInfo.</returns>
         IProxyInfo IVersionControlServerHelper.GetProxy(string proxyUrl) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.ServerSettings.
        /// <summary>
        /// Gets the server settings with fallback.
        /// </summary>
        /// <param name="fallbackUsed">The fallback used.</param>
        /// <returns>Microsoft.TeamFoundation.VersionControl.Client.ServerSettings.</returns>
         IServerSettings IVersionControlServerHelper.GetServerSettingsWithFallback(out bool fallbackUsed) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.TeamProject in the
        //     repository with the specified name.
        //
        // Parameters:
        //   name:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.TeamProject
        //     to get.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.VersionControl.Client.TeamProject with the specified
        //     name.
        //
        // Exceptions:
        //   Microsoft.TeamFoundation.VersionControl.Client.VersionControlException:
        //     Thrown if the specified path does resolve to a Microsoft.TeamFoundation.VersionControl.Client.TeamProject.
        /// <summary>
        /// Gets the team project.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.TeamProject.</returns>
         ITeamProject IVersionControlServerHelper.GetTeamProject(string name) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.TeamProject for the
        //     specified server path.
        //
        // Parameters:
        //   serverPath:
        //     The server path of the Microsoft.TeamFoundation.VersionControl.Client.TeamProject
        //     to get.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.VersionControl.Client.TeamProject with the specified
        //     path.
        //
        // Exceptions:
        //   Microsoft.TeamFoundation.VersionControl.Client.VersionControlException:
        //     Thrown if the specified path does not resolve to a Microsoft.TeamFoundation.VersionControl.Client.TeamProject.
        /// <summary>
        /// Gets the team project for server path.
        /// </summary>
        /// <param name="serverPath">The server path.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.TeamProject.</returns>
         ITeamProject IVersionControlServerHelper.GetTeamProjectForServerPath(string serverPath) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.TeamProject objects
        //     in the repository with the specified paths.
        //
        // Parameters:
        //   serverPaths:
        //     The server paths of the projects to get.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.TeamProject objects
        //     with the specified paths. Elements in the array will be null if a corresponding
        //     project was not found for specified path.
        /// <summary>
        /// Gets the team projects for server paths.
        /// </summary>
        /// <param name="serverPaths">The server paths.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.TeamProject[].</returns>
         ITeamProject[] IVersionControlServerHelper.GetTeamProjectsForServerPaths(string[] serverPaths) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets a property value for the specified item.
        //
        // Parameters:
        //   itemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemSpec for which the
        //     property value is desired.
        //
        //   versionSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        //   propertyNameFilter:
        //     The property name to query.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.Framework.Client.ArtifactPropertyValue
        //     objects matched by the filters which have the requested property set on it.
        /// <summary>
        /// Gets the versioned item property.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyNameFilter">The property name filter.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ArtifactPropertyValue[].</returns>
        [Obsolete("Please use GetItems to retrieve versioned item attributes.", false)]
         IArtifactPropertyValue[] IVersionControlServerHelper.GetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyNameFilter) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets a set of property values for the specified items.
        //
        // Parameters:
        //   itemSpecs:
        //     Array of Microsoft.TeamFoundation.VersionControl.Client.ItemSpec objects
        //     for which the property value is desired.
        //
        //   versionSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   deletedState:
        //     A flag describing whether to return deleted items and/or non-deleted items.
        //
        //   itemType:
        //     A flag describing whether to return files and/or folders.
        //
        //   propertyNameFilters:
        //     An array of properties filters to query.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.Framework.Client.ArtifactPropertyValue
        //     object matched by the filters which have at least one of the specified properties
        //     set.
        /// <summary>
        /// Gets the versioned item property.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyNameFilters">The property name filters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ArtifactPropertyValue[].</returns>
        [Obsolete("Please use GetItems to retrieve versioned item attributes.", false)]
         IArtifactPropertyValue[] IVersionControlServerHelper.GetVersionedItemProperty(IItemSpec[] itemSpecs, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string[] propertyNameFilters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.Workspace that is
        //     mapped to the specified local path.
        //
        // Parameters:
        //   localPath:
        //     The local path of the desired Microsoft.TeamFoundation.VersionControl.Client.Workspace.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.VersionControl.Client.Workspace object that
        //     is associated with the specified local path.
        //
        // Exceptions:
        //   Microsoft.TeamFoundation.VersionControl.Client.ItemNotMappedException:
        //     Thrown if no Microsoft.TeamFoundation.VersionControl.Client.Workspace is
        //     found associated with the specified Microsoft.TeamFoundation.VersionControl.Client.WorkspaceInfo.
        /// <summary>
        /// Gets the workspace.
        /// </summary>
        /// <param name="localPath">The local path.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.GetWorkspace(string localPath) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.Workspace associated
        //     with the specified Microsoft.TeamFoundation.VersionControl.Client.WorkspaceInfo
        //     object.
        //
        // Parameters:
        //   workspaceInfo:
        //     The Microsoft.TeamFoundation.VersionControl.Client.WorkspaceInfo object to
        //     get the Microsoft.TeamFoundation.VersionControl.Client.Workspace for.
        //
        // Returns:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.Workspace associated
        //     with the specified Microsoft.TeamFoundation.VersionControl.Client.WorkspaceInfo
        //     object.
        //
        // Exceptions:
        //   Microsoft.TeamFoundation.VersionControl.Client.ItemNotMappedException:
        //     Thrown if no Microsoft.TeamFoundation.VersionControl.Client.Workspace is
        //     found associated with the specified Microsoft.TeamFoundation.VersionControl.Client.WorkspaceInfo.
        /// <summary>
        /// Gets the workspace.
        /// </summary>
        /// <param name="workspaceInfo">The workspace information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.GetWorkspace(IWorkspaceInfo workspaceInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.Workspace associated
        //     with the specified name and owner.
        //
        // Parameters:
        //   workspaceName:
        //     The name of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to get.
        //
        //   workspaceOwner:
        //     The owner of the Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     to get.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.VersionControl.Client.Workspace that is associated
        //     with the specified name and owner.
        //
        // Exceptions:
        //   Microsoft.TeamFoundation.VersionControl.Client.ItemNotMappedException:
        //     Thrown if no Microsoft.TeamFoundation.VersionControl.Client.Workspace is
        //     found associated with the specified Microsoft.TeamFoundation.VersionControl.Client.WorkspaceInfo.
        /// <summary>
        /// Gets the workspace.
        /// </summary>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="workspaceOwner">The workspace owner.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace.</returns>
         IWorkSpace IVersionControlServerHelper.GetWorkspace(string workspaceName, string workspaceOwner) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.BranchObjectOwnership
        //     objects associated with the specified Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     IDs.
        //
        // Parameters:
        //   changesetIds:
        //     Array of Microsoft.TeamFoundation.VersionControl.Client.Changeset IDs to
        //     query.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.BranchObjectOwnership
        //     objects associated with the specified Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     IDs.
        /// <summary>
        /// Queries the branch object ownership.
        /// </summary>
        /// <param name="changesetIds">The changeset ids.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.BranchObjectOwnership[].</returns>
         IBranchObjectOwnership[] IVersionControlServerHelper.QueryBranchObjectOwnership(int[] changesetIds) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.VersionControl.Client.BranchObjectOwnership
        //     objects associated with the specified Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     IDs, constrained by the specified path filter.
        //
        // Parameters:
        //   changesetIds:
        //     Array of Microsoft.TeamFoundation.VersionControl.Client.Changeset IDs to
        //     query.
        //
        //   pathFilter:
        //     Optional path filter restricts the paths traversed in the Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.BranchObjectOwnership
        //     objects associated with the specified Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     IDs.
        /// <summary>
        /// Queries the branch object ownership.
        /// </summary>
        /// <param name="changesetIds">The changeset ids.</param>
        /// <param name="pathFilter">The path filter.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.BranchObjectOwnership[].</returns>
         IBranchObjectOwnership[] IVersionControlServerHelper.QueryBranchObjectOwnership(int[] changesetIds, IItemSpec pathFilter) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Queries a Microsoft.TeamFoundation.VersionControl.Client.BranchObject.
        //
        // Parameters:
        //   rootItem:
        //     The item identifier of the Microsoft.TeamFoundation.VersionControl.Client.BranchObject
        //     to traverse.
        //
        //   recursion:
        //     The number of levels to traverse. Microsoft.TeamFoundation.VersionControl.Client.RecursionType.None
        //     will only return the branch object. Microsoft.TeamFoundation.VersionControl.Client.RecursionType.OneLevel
        //     will return children. Microsoft.TeamFoundation.VersionControl.Client.RecursionType.Full
        //     will return all descendants.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.BranchObject objects.
        /// <summary>
        /// Queries the branch objects.
        /// </summary>
        /// <param name="rootItem">The root item.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.BranchObject[].</returns>
         IBranchObject[] IVersionControlServerHelper.QueryBranchObjects(ITemIdentifier rootItem, RecursionType recursion) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns System.Collections.Generic.IEnumerable<T>.
        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <returns>System.Collections.Generic.IEnumerable&lt;DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset&gt;.</returns>
         IEnumerable<IChangeset> IVersionControlServerHelper.QueryHistory(IItemSpec itemSpec) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns System.Collections.Generic.IEnumerable<T>.
        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>System.Collections.Generic.IEnumerable&lt;DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset&gt;.</returns>
         IEnumerable<IChangeset> IVersionControlServerHelper.QueryHistory(IQueryHistoryParameters parameters) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns System.Collections.Generic.IEnumerable<T>.
        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <returns>System.Collections.Generic.IEnumerable&lt;DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset&gt;.</returns>
         IEnumerable<IChangeset> IVersionControlServerHelper.QueryHistory(IItemSpec itemSpec, int maxResults) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns System.Collections.Generic.IEnumerable<T>.
        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="recursion">The recursion.</param>
        /// <returns>System.Collections.Generic.IEnumerable&lt;DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset&gt;.</returns>
         IEnumerable<IChangeset> IVersionControlServerHelper.QueryHistory(string item, RecursionType recursion) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns System.Collections.Generic.IEnumerable<T>.
        /// <summary>
        /// Queries the history.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <returns>System.Collections.Generic.IEnumerable&lt;DynCon.OSI.VSO.ObjectModelClient.Helpers.Changeset&gt;.</returns>
         IEnumerable<IChangeset> IVersionControlServerHelper.QueryHistory(string item, RecursionType recursion, int maxResults) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets a collection of Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     objects matching the specified items and versions.
        //
        // Parameters:
        //   path:
        //     The local path to an item for which history will be queried. This parameter
        //     can include wildcards.
        //
        //   version:
        //     The version of the item for which history will be queried.
        //
        //   deletionId:
        //     The unique deletion ID for the item, if it is deleted. Otherwise, specify
        //     0.
        //
        //   recursion:
        //     A flag describing whether history will be recursively queried.
        //
        //   user:
        //     The user for whom history will be queried. Specify null for any user.
        //
        //   versionFrom:
        //     The earliest version for which history will be queried. Specify null to begin
        //     with the first changeset.
        //
        //   versionTo:
        //     The latest version for which history will be queried. Specify null to end
        //     with the latest changeset.
        //
        //   maxCount:
        //     The maximum number of history entries to return. Specify Int32.MaxValue to
        //     get all changes.
        //
        //   includeChanges:
        //     A flag that describes whether the individual item changes will be included
        //     with the changesets. Otherwise, only changeset metadata is included.
        //
        //   slotMode:
        //     A flag that describes how history entries are searched. If 'true', the returned
        //     history entries may reflect multiple different items that have occupied the
        //     requested path in the repository. If 'false', the returned history entries
        //     will reflect the single item currently occupying the requested path.
        //
        // Returns:
        //     A collection of Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     objects matching the query.
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
        /// <param name="includeChanges">The include changes.</param>
        /// <param name="slotMode">The slot mode.</param>
        /// <returns>System.Collections.IEnumerable.</returns>
         IEnumerable IVersionControlServerHelper.QueryHistory(string path, IVersionSpec version, int deletionId, RecursionType recursion, string user, IVersionSpec versionFrom, IVersionSpec versionTo, int maxCount, bool includeChanges, bool slotMode) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets a collection of Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     objects matching the specified items and versions.
        //
        // Parameters:
        //   path:
        //     The local path to an item for which history will be queried. This parameter
        //     can include wildcards.
        //
        //   version:
        //     The version of the item for which history will be queried.
        //
        //   deletionId:
        //     The unique deletion ID for the item, if it is deleted. Otherwise, specify
        //     0.
        //
        //   recursion:
        //     A flag describing whether history will be recursively queried.
        //
        //   user:
        //     The user for whom history will be queried. Specify null for any user.
        //
        //   versionFrom:
        //     The earliest version for which history will be queried. Specify null to begin
        //     with the first changeset.
        //
        //   versionTo:
        //     The latest version for which history will be queried. Specify null to end
        //     with the latest changeset.
        //
        //   maxCount:
        //     The maximum number of history entries to return. Specify Int32.MaxValue to
        //     get all changes.
        //
        //   includeChanges:
        //     A flag that describes whether the individual item changes will be included
        //     with the changesets. Otherwise, only changeset metadata is included.
        //
        //   slotMode:
        //     A flag that describes how history entries are searched. If 'true', the returned
        //     history entries may reflect multiple different items that have occupied the
        //     requested path in the repository. If 'false', the returned history entries
        //     will reflect the single item currently occupying the requested path.
        //
        //   includeDownloadInfo:
        //     A flag that describes whether to get the information necessary to download
        //     the changesets from the server.
        //
        // Returns:
        //     A collection of Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     objects matching the query.
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
        /// <param name="includeChanges">The include changes.</param>
        /// <param name="slotMode">The slot mode.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>System.Collections.IEnumerable.</returns>
         IEnumerable IVersionControlServerHelper.QueryHistory(string path, IVersionSpec version, int deletionId, RecursionType recursion, string user, IVersionSpec versionFrom, IVersionSpec versionTo, int maxCount, bool includeChanges, bool slotMode, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets a collection of Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     objects matching the specified items and versions.
        //
        // Parameters:
        //   path:
        //     The local path to an item for which history will be queried. This parameter
        //     can include wildcards.
        //
        //   version:
        //     The version of the item for which history will be queried.
        //
        //   deletionId:
        //     The unique deletion ID for the item, if it is deleted. Otherwise, specify
        //     0.
        //
        //   recursion:
        //     A flag describing whether history will be recursively queried.
        //
        //   user:
        //     The user for whom history will be queried. Specify null for any user.
        //
        //   versionFrom:
        //     The earliest version for which history will be queried. Specify null to begin
        //     with the first changeset.
        //
        //   versionTo:
        //     The latest version for which history will be queried. Specify null to end
        //     with the latest changeset.
        //
        //   maxCount:
        //     The maximum number of history entries to return. Specify System.Int32.MaxValue
        //     to get all changes.
        //
        //   includeChanges:
        //     A flag that describes whether the individual item changes will be included
        //     with the changesets. Otherwise, only changeset metadata is included.
        //
        //   slotMode:
        //     A flag that describes how history entries are searched. If 'true', the returned
        //     history entries may reflect multiple different items that have occupied the
        //     requested path in the repository. If 'false', the returned history entries
        //     will reflect the single item currently occupying the requested path.
        //
        //   includeDownloadInfo:
        //     A flag that describes whether to get the information necessary to download
        //     the changesets from the server.
        //
        //   sortAscending:
        //     A flag that describes whether to sort the results in ascending order. Specify
        //     false to not sort the results.
        //
        // Returns:
        //     A collection of Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     objects matching the query.
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
        /// <param name="includeChanges">The include changes.</param>
        /// <param name="slotMode">The slot mode.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="sortAscending">The sort ascending.</param>
        /// <returns>System.Collections.IEnumerable.</returns>
         IEnumerable IVersionControlServerHelper.QueryHistory(string path, IVersionSpec version, int deletionId, RecursionType recursion, string user, IVersionSpec versionFrom, IVersionSpec versionTo, int maxCount, bool includeChanges, bool slotMode, bool includeDownloadInfo, bool sortAscending) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Queries for an array of Microsoft.TeamFoundation.VersionControl.Client.VersionControlLabel
        //     objects applied to items in the repository.
        //
        // Parameters:
        //   labelName:
        //     The name of the label being queried.
        //
        //   labelScope:
        //     The repository path representing the scope at which the label is defined.
        //
        //   owner:
        //     The user who created the label. Specify null to match all owners.
        //
        //   includeItems:
        //     True to include items in the labels. False to not include.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.VersionControlLabel
        //     objects resulting from the query.
        /// <summary>
        /// Queries the labels.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="includeItems">The include items.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.VersionControlLabel[].</returns>
         IVersionControlLabel[] IVersionControlServerHelper.QueryLabels(string labelName, string labelScope, string owner, bool includeItems) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Queries for an array of Microsoft.TeamFoundation.VersionControl.Client.VersionControlLabel
        //     objects applied to items in the repository.
        //
        // Parameters:
        //   labelName:
        //     The name of the label being queried.
        //
        //   labelScope:
        //     The repository path representing the scope at which the label is defined.
        //
        //   owner:
        //     The user who created the label. Specify null to match all owners.
        //
        //   includeItems:
        //     True to include items in the labels. False to not include.
        //
        //   filterItem:
        //     If not-null, returns only labels containing this item (server or local path).
        //
        //   versionFilterItem:
        //     Microsoft.TeamFoundation.VersionControl.Client.VersionSpec for filterItem.
        //     Ignored if filterItem is null.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.VersionControlLabel
        //     objects resulting from the query.
        /// <summary>
        /// Queries the labels.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="includeItems">The include items.</param>
        /// <param name="filterItem">The filter item.</param>
        /// <param name="versionFilterItem">The version filter item.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.VersionControlLabel[].</returns>
         IVersionControlLabel[] IVersionControlServerHelper.QueryLabels(string labelName, string labelScope, string owner, bool includeItems, string filterItem, IVersionSpec versionFilterItem) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Queries for an array of Microsoft.TeamFoundation.VersionControl.Client.VersionControlLabel
        //     objects applied to items in the repository.
        //
        // Parameters:
        //   labelName:
        //     The name of the label being queried.
        //
        //   labelScope:
        //     The repository path representing the scope at which the label is defined.
        //
        //   owner:
        //     The user who created the label. Specify null to match all owners.
        //
        //   includeItems:
        //     True to include items in the labels. False to not include.
        //
        //   filterItem:
        //     If not-null, returns only labels containing this item (server or local path).
        //
        //   versionFilterItem:
        //     Microsoft.TeamFoundation.VersionControl.Client.VersionSpec for filterItem.
        //     Ignored if filterItem is null.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.VersionControlLabel
        //     objects applied to items in the repository.
        /// <summary>
        /// Queries the labels.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="includeItems">The include items.</param>
        /// <param name="filterItem">The filter item.</param>
        /// <param name="versionFilterItem">The version filter item.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.VersionControlLabel[].</returns>
         IVersionControlLabel[] IVersionControlServerHelper.QueryLabels(string labelName, string labelScope, string owner, bool includeItems, string filterItem, IVersionSpec versionFilterItem, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of all items that have a merge relationship to the specified
        //     item.
        //
        // Parameters:
        //   serverItem:
        //     Path to the server item to query.
        //
        // Returns:
        //     Array of Microsoft.TeamFoundation.VersionControl.Client.ItemIdentifier objects.
        /// <summary>
        /// Queries the merge relationships.
        /// </summary>
        /// <param name="serverItem">The server item.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ItemIdentifier[].</returns>
         ITemIdentifier[] IVersionControlServerHelper.QueryMergeRelationships(string serverItem) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the merge history of the specified target item with an optional source.
        //
        // Parameters:
        //   sourceItemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemSpec of the optional
        //     source item.
        //
        //   sourceVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the optional
        //     source item.
        //
        //   targetItemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemSpec of the required
        //     target item.
        //
        //   targetVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the required
        //     target item.
        //
        //   versionFrom:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     earliest point of the merge history range to query. Specify null for "start
        //     of time".
        //
        //   versionTo:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     latest point of the merge history range. Specify null for "end of time".
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ChangesetMerge
        //     objects.
        /// <summary>
        /// Queries the merges.
        /// </summary>
        /// <param name="sourceItemSpec">The source item spec.</param>
        /// <param name="sourceVersion">The source version.</param>
        /// <param name="targetItemSpec">The target item spec.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ChangesetMerge[].</returns>
         IChangesetMerge[] IVersionControlServerHelper.QueryMerges(IItemSpec sourceItemSpec, IVersionSpec sourceVersion, IItemSpec targetItemSpec, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the merge history of the requested item with an optional source.
        //
        // Parameters:
        //   sourceItemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemSpec of the optional
        //     source item.
        //
        //   sourceVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the optional
        //     source item.
        //
        //   targetItemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemSpec of the required
        //     target item.
        //
        //   targetVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the required
        //     target item.
        //
        //   versionFrom:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     earliest point of the merge history range to query. Specify null for "start
        //     of time".
        //
        //   versionTo:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     latest point of the merge history range. Specify null for "end of time".
        //
        //   showAll:
        //     True to include merge history of renamed items. False to not include.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ChangesetMerge
        //     objects.
        /// <summary>
        /// Queries the merges.
        /// </summary>
        /// <param name="sourceItemSpec">The source item spec.</param>
        /// <param name="sourceVersion">The source version.</param>
        /// <param name="targetItemSpec">The target item spec.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="showAll">The show all.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ChangesetMerge[].</returns>
         IChangesetMerge[] IVersionControlServerHelper.QueryMerges(IItemSpec sourceItemSpec, IVersionSpec sourceVersion, IItemSpec targetItemSpec, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo, bool showAll) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the merge history of the requested item with an optional source.
        //
        // Parameters:
        //   sourcePath:
        //     The local or server path to the optional source item.
        //
        //   sourceVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the optional
        //     source item.
        //
        //   targetPath:
        //     The local or server path to the required target item.
        //
        //   targetVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the required
        //     target item.
        //
        //   versionFrom:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     earliest point of the merge history range to query. Specify null for "start
        //     of time".
        //
        //   versionTo:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     latest point of the merge history range. Specify null for "end of time".
        //
        //   recursion:
        //     The level of recursion applied to the target search.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ChangesetMerge
        //     objects.
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
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ChangesetMerge[].</returns>
         IChangesetMerge[] IVersionControlServerHelper.QueryMerges(string sourcePath, IVersionSpec sourceVersion, string targetPath, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo, RecursionType recursion) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the merge history of the requested item with an optional source.
        //
        // Parameters:
        //   sourcePath:
        //     The local or server path to the optional source item.
        //
        //   sourceVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the optional
        //     source item.
        //
        //   targetPath:
        //     The local or server path to the required target item.
        //
        //   targetVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the required
        //     target item.
        //
        //   versionFrom:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     earliest point of the merge history range to query. Specify null for "start
        //     of time".
        //
        //   versionTo:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     latest point of the merge history range. Specify null for "end of time".
        //
        //   recursion:
        //     The level of recursion applied to the target search.
        //
        //   showAll:
        //     True to include merge history of renamed items. False to not include.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ChangesetMerge
        //     objects.
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
        /// <param name="showAll">The show all.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ChangesetMerge[].</returns>
         IChangesetMerge[] IVersionControlServerHelper.QueryMerges(string sourcePath, IVersionSpec sourceVersion, string targetPath, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo, RecursionType recursion, bool showAll) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the merge history for a specific item and version range.
        //
        // Parameters:
        //   targetItemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemSpec of the target
        //     item of the merge.
        //
        //   targetVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the target
        //     item.
        //
        //   versionFrom:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     earliest point of the merge history range to query. Specify null for "start
        //     of time".
        //
        //   versionTo:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     latest point of the merge history range to query. Specify null for "end of
        //     time".
        //
        // Returns:
        //     A set of Microsoft.TeamFoundation.VersionControl.Client.IExtendedMerge objects
        //     for the specified item and version range.
        /// <summary>
        /// Queries the merges extended.
        /// </summary>
        /// <param name="targetItemSpec">The target item spec.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <returns>System.Collections.Generic.IEnumerable&lt;Microsoft.TeamFoundation.VersionControl.Client.ExtendedMerge&gt;.</returns>
         IEnumerable<IExtendedMerge> IVersionControlServerHelper.QueryMergesExtended(IItemSpec targetItemSpec, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the merge history for a specific item and version range.
        //
        // Parameters:
        //   targetItemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemSpec of the target
        //     item of the merge.
        //
        //   targetVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the target
        //     item.
        //
        //   versionFrom:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     earliest point of the merge history range to query. Specify null for "start
        //     of time".
        //
        //   versionTo:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     latest point of the merge history range to query. Specify null for "end of
        //     time".
        //
        //   options:
        //     Options for the query.
        //
        // Returns:
        //     A set of Microsoft.TeamFoundation.VersionControl.Client.IExtendedMerge objects
        //     for the specified item and version range.
        /// <summary>
        /// Queries the merges extended.
        /// </summary>
        /// <param name="targetItemSpec">The target item spec.</param>
        /// <param name="targetVersion">The target version.</param>
        /// <param name="versionFrom">The version from.</param>
        /// <param name="versionTo">The version to.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.Collections.Generic.IEnumerable&lt;Microsoft.TeamFoundation.VersionControl.Client.ExtendedMerge&gt;.</returns>
         IEnumerable<IExtendedMerge> IVersionControlServerHelper.QueryMergesExtended(IItemSpec targetItemSpec, IVersionSpec targetVersion, IVersionSpec versionFrom, IVersionSpec versionTo, IQueryMergesExtendedOptions options) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the merge history with details of the specified target item with an
        //     optional source.
        //
        // Parameters:
        //   sourcePath:
        //     The local or server path of the optional source item.
        //
        //   sourceVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the optional
        //     source item.
        //
        //   sourceDeletionId:
        //     The deletion ID of the optional source item.
        //
        //   targetPath:
        //     The local or server path of the required target item.
        //
        //   targetVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the required
        //     target item.
        //
        //   targetDeletionId:
        //     The deletion ID of the target item.
        //
        //   versionFrom:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     earliest point of the merge history range to query. Specify null for "start
        //     of time".
        //
        //   versionTo:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     latest point of the merge history range to query. Specify null for "end of
        //     time".
        //
        //   recursion:
        //     The level of recursion applied to the target search.
        //
        // Returns:
        //     Microsoft.TeamFoundation.VersionControl.Client.ChangesetMergeDetails object.
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
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ChangesetMergeDetails.</returns>
         IChangesetMergeDetails IVersionControlServerHelper.QueryMergesWithDetails(string sourcePath, IVersionSpec sourceVersion, int sourceDeletionId, string targetPath, IVersionSpec targetVersion, int targetDeletionId, IVersionSpec versionFrom, IVersionSpec versionTo, RecursionType recursion) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the merge history with details of the specified target item with an
        //     optional source.
        //
        // Parameters:
        //   sourcePath:
        //     The local or server path of the optional source item.
        //
        //   sourceVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the optional
        //     source item.
        //
        //   sourceDeletionId:
        //     The deletion ID of the optional source item.
        //
        //   targetPath:
        //     The local or server path of the required target item.
        //
        //   targetVersion:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the required
        //     target item.
        //
        //   targetDeletionId:
        //     The deletion ID of the target item.
        //
        //   versionFrom:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     earliest point of the merge history range to query. Specify null for "start
        //     of time".
        //
        //   versionTo:
        //     A Microsoft.TeamFoundation.VersionControl.Client.VersionSpec denoting the
        //     latest point of the merge history range to query. Specify null for "end of
        //     time".
        //
        //   recursion:
        //     The level of recursion applied to the target search.
        //
        //   showAll:
        //     True to include merge history of renamed items. False to not include.
        //
        // Returns:
        //     Microsoft.TeamFoundation.VersionControl.Client.ChangesetMergeDetails object.
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
        /// <param name="showAll">The show all.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ChangesetMergeDetails.</returns>
         IChangesetMergeDetails IVersionControlServerHelper.QueryMergesWithDetails(string sourcePath, IVersionSpec sourceVersion, int sourceDeletionId, string targetPath, IVersionSpec targetVersion, int targetDeletionId, IVersionSpec versionFrom, IVersionSpec versionTo, RecursionType recursion, bool showAll) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the pending changes for the specified query.
        //
        // Parameters:
        //   itemSpecs:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ItemSpec objects
        //     representing the items to query.
        //
        //   queryWorkspaceName:
        //     The workspace name (may be null).
        //
        //   queryUserName:
        //     The user name (may be null), which is the workspace owner if the workspace
        //     name is not null.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     containing the pending changes for the specified server items.
        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryPendingSets(IItemSpec[] itemSpecs, string queryWorkspaceName, string queryUserName) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the pending changes for the specified query.
        //
        // Parameters:
        //   itemSpecs:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ItemSpec objects
        //     representing the items to query.
        //
        //   queryWorkspaceName:
        //     The workspace name (may be null).
        //
        //   queryUserName:
        //     The user name (may be null), which is the workspace owner if the workspace
        //     name is not null.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     containing the pending changes for the specified server items.
        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryPendingSets(IItemSpec[] itemSpecs, string queryWorkspaceName, string queryUserName, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the pending changes for the specified query.
        //
        // Parameters:
        //   items:
        //     An array of local or server paths to the items to query for.
        //
        //   recursion:
        //     Recursion level for the query.
        //
        //   queryWorkspaceName:
        //     The workspace name (may be null).
        //
        //   queryUserName:
        //     The user name (may be null), which is the workspace owner if the workspace
        //     name is not null.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     containing the pending changes for the specified server items.
        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="recursion">The recursion.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryPendingSets(string[] items, RecursionType recursion, string queryWorkspaceName, string queryUserName) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.PendingSet.
        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="includeCandidates">The include candidates.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryPendingSets(IItemSpec[] itemSpecs, string queryWorkspaceName, string queryUserName, bool includeDownloadInfo, bool includeCandidates) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.PendingSet.
        /// <summary>
        /// Queries the pending sets.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="queryWorkspaceName">Name of the query workspace.</param>
        /// <param name="queryUserName">Name of the query user.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="includeCandidates">The include candidates.</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryPendingSets(IItemSpec[] itemSpecs, string queryWorkspaceName, string queryUserName, bool includeDownloadInfo, bool includeCandidates, string[] itemPropertyFilters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Queries all Microsoft.TeamFoundation.VersionControl.Client.BranchObject objects
        //     that have no parent.
        //
        // Parameters:
        //   recursion:
        //     The number of levels to traverse. Microsoft.TeamFoundation.VersionControl.Client.RecursionType.None
        //     will only return the branch object. Microsoft.TeamFoundation.VersionControl.Client.RecursionType.OneLevel
        //     will return children. Microsoft.TeamFoundation.VersionControl.Client.RecursionType.Full
        //     will return all descendants.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.BranchObject objects.
        /// <summary>
        /// Queries the root branch objects.
        /// </summary>
        /// <param name="recursion">The recursion.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.BranchObject[].</returns>
         IBranchObject[] IVersionControlServerHelper.QueryRootBranchObjects(RecursionType recursion) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the shelved changes in the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        //
        // Parameters:
        //   shelveset:
        //     The shelveset to query.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     with the pending changes for the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelveset">The shelveset.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryShelvedChanges(IShelveset shelveset) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the shelved changes in the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        //
        // Parameters:
        //   shelveset:
        //     The shelveset to query.
        //
        //   itemSpecs:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ItemSpec objects
        //     for the items to query.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     with the pending changes for the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelveset">The shelveset.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryShelvedChanges(IShelveset shelveset, IItemSpec[] itemSpecs) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the shelved changes in the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        //
        // Parameters:
        //   shelvesetName:
        //     The shelveset name. May be null.
        //
        //   shelvesetOwner:
        //     The shelveset owner. May be null.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     with the pending changes for the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryShelvedChanges(string shelvesetName, string shelvesetOwner) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the shelved changes in the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        //
        // Parameters:
        //   shelvesetName:
        //     The shelveset name. May be null.
        //
        //   shelvesetOwner:
        //     The shelveset owner. May be null.
        //
        //   itemSpecs:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ItemSpec objects
        //     for the items to query.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     with the pending changes for the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryShelvedChanges(string shelvesetName, string shelvesetOwner, IItemSpec[] itemSpecs) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the shelved changes in the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        //
        // Parameters:
        //   shelvesetName:
        //     The shelveset name. May be null.
        //
        //   shelvesetOwner:
        //     The shelveset owner. May be null.
        //
        //   itemSpecs:
        //     Gets the shelved changes in the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        //
        //   includeDownloadInfo:
        //     True to get the information needed to download files. Specify false to save
        //     bandwidth if not necessary.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PendingSet objects
        //     with the pending changes for the specified Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryShelvedChanges(string shelvesetName, string shelvesetOwner, IItemSpec[] itemSpecs, bool includeDownloadInfo) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.PendingSet.
        /// <summary>
        /// Queries the shelved changes.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="includeDownloadInfo">The include download information.</param>
        /// <param name="itemPropertyFilters">The item property filters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PendingSet[].</returns>
         IPendingSet[] IVersionControlServerHelper.QueryShelvedChanges(string shelvesetName, string shelvesetOwner, IItemSpec[] itemSpecs, bool includeDownloadInfo, string[] itemPropertyFilters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Queries an array of Microsoft.TeamFoundation.VersionControl.Client.Shelveset
        //     objects with the specified name and/or owner.
        //
        // Parameters:
        //   shelvesetName:
        //     The name of the shelveset to look for. Specify null to match all shelvesets
        //     regardless of name.
        //
        //   shelvesetOwner:
        //     The owner of the shelvesets to look for. Specify null to match all shelvesets
        //     regardless of owner.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.Shelveset objects
        //     matching the query.
        /// <summary>
        /// Queries the shelvesets.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IShelveset[].</returns>
         IShelveset[] IVersionControlServerHelper.QueryShelvesets(string shelvesetName, string shelvesetOwner) { throw new NotImplementedException(); }
        //
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.VersionControl.Client.Shelveset.
        /// <summary>
        /// Queries the shelvesets.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="propertyNameFilters">The property name filters.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IShelveset[].</returns>
         IShelveset[] IVersionControlServerHelper.QueryShelvesets(string shelvesetName, string shelvesetOwner, string[] propertyNameFilters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     objects that match the specified name, owner, computer, or any combination
        //     of these criteria.
        //
        // Parameters:
        //   workspaceName:
        //     The name of the workspace, or null to query all workspace names.
        //
        //   workspaceOwner:
        //     The user name of the owner, or null to query all users.
        //
        //   computer:
        //     The name of the host computer, or null to query all computers.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.Workspace objects
        //     that match the specified filters.
        /// <summary>
        /// Queries the workspaces.
        /// </summary>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="workspaceOwner">The workspace owner.</param>
        /// <param name="computer">The computer.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace[].</returns>
         IWorkSpace[] IVersionControlServerHelper.QueryWorkspaces(string workspaceName, string workspaceOwner, string computer) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets an array of Microsoft.TeamFoundation.VersionControl.Client.Workspace
        //     objects that match the specified name, owner, computer, or any combination
        //     of these criteria. Also allows filtering by permission.
        //
        // Parameters:
        //   workspaceName:
        //     The name of the workspace, or null for all workspace names.
        //
        //   workspaceOwner:
        //     The user name of the owner, or null for all users.
        //
        //   computer:
        //     The name of the host computer, or null for all computers.
        //
        //   permissionsFilter:
        //     Microsoft.TeamFoundation.VersionControl.Client.IWorkspacePermissions to use
        //     to filter by the authorization level. Specify Microsoft.TeamFoundation.VersionControl.Client.IWorkspacePermissions.NoneOrNotSupported
        //     to not use permission filtering.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.Workspace objects
        //     that match the specified filters.
        /// <summary>
        /// Queries the workspaces.
        /// </summary>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="workspaceOwner">The workspace owner.</param>
        /// <param name="computer">The computer.</param>
        /// <param name="permissionsFilter">The permissions filter.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.Workspace[].</returns>
         IWorkSpace[] IVersionControlServerHelper.QueryWorkspaces(string workspaceName, string workspaceOwner, string computer, IWorkspacePermissions permissionsFilter) { throw new NotImplementedException(); }
        /// <summary>
        /// Raises the changeset reconciled.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
         void IVersionControlServerHelper.RaiseChangesetReconciled(int changesetId) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Rename all instances of the specified Microsoft.TeamFoundation.VersionControl.Client.ICheckinNote
        //     field to the new specified name for the given team project folder.
        //
        // Parameters:
        //   path:
        //     The path to a team project folder.
        //
        //   oldName:
        //     Old check-in note field name.
        //
        //   newName:
        //     New check-in note field name.
        /// <summary>
        /// Renames the name of the checkin note field.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="oldName">The old name.</param>
        /// <param name="newName">The new name.</param>
         void IVersionControlServerHelper.RenameCheckinNoteFieldName(string path, string oldName, string newName) { throw new NotImplementedException(); }
        /// <summary>
        /// Resets the checkin dates.
        /// </summary>
        /// <param name="lastCheckinDate">The last checkin date.</param>
         void IVersionControlServerHelper.ResetCheckinDates(DateTime lastCheckinDate) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Checks to see if the item of the specified path and type exists in the repository.
        //
        // Parameters:
        //   path:
        //     The path of the item to check for, may be server or local.
        //
        //   itemType:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemType of the item.
        //
        // Returns:
        //     True if the specified item is in the repository. False otherwise.
        /// <summary>
        /// Servers the item exists.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>System.Boolean.</returns>
         bool IVersionControlServerHelper.ServerItemExists(string path, IItemType itemType) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Checks to see if the item of the specified path, version, and type exists
        //     in the repository.
        //
        // Parameters:
        //   path:
        //     The path of the item to check for, may be server or local.
        //
        //   version:
        //     The version of the item to check for.
        //
        //   deletedState:
        //     Whether the item must be non-deleted, deleted, or any state.
        //
        //   itemType:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemType of the item to
        //     check for.
        //
        // Returns:
        //     True if the specified item in the repository. False otherwise.
        /// <summary>
        /// Servers the item exists.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="version">The version.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <returns>System.Boolean.</returns>
         bool IVersionControlServerHelper.ServerItemExists(string path, IVersionSpec version, IDeletedState deletedState, IItemType itemType) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a list of Microsoft.TeamFoundation.Framework.Client.PropertyValue objects
        //     to a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Parameters:
        //   changesetId:
        //     A valid changeset ID.
        //
        //   propertyValues:
        //     A list of Microsoft.TeamFoundation.Framework.Client.PropertyValue objects.
        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyValues">The property values.</param>
         void IVersionControlServerHelper.SetChangesetProperty(int changesetId, List<IPropertyValue> propertyValues) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a list of Microsoft.TeamFoundation.Framework.Client.PropertyValue objects
        //     to a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Parameters:
        //   changesetId:
        //     A valid changeset ID.
        //
        //   propertyValues:
        //     A list of Microsoft.TeamFoundation.Framework.Client.PropertyValue objects.
        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyValues">The property values.</param>
         void IVersionControlServerHelper.SetChangesetProperty(int changesetId, IPropertyValue[] propertyValues) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a Microsoft.TeamFoundation.Framework.Client.PropertyValue object to
        //     a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Parameters:
        //   changesetId:
        //     The changeset ID.
        //
        //   propertyName:
        //     The name of the property.
        //
        //   value:
        //     The value to assign to the property.
        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetChangesetProperty(int changesetId, string propertyName, byte[] value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a Microsoft.TeamFoundation.Framework.Client.PropertyValue object to
        //     a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Parameters:
        //   changesetId:
        //     The changeset ID.
        //
        //   propertyName:
        //     The name of the property.
        //
        //   value:
        //     The value to assign to the property.
        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetChangesetProperty(int changesetId, string propertyName, DateTime? value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a Microsoft.TeamFoundation.Framework.Client.PropertyValue object to
        //     a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Parameters:
        //   changesetId:
        //     The changeset ID.
        //
        //   propertyName:
        //     The name of the property.
        //
        //   value:
        //     The value to assign to the property.
        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetChangesetProperty(int changesetId, string propertyName, double? value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a of Microsoft.TeamFoundation.Framework.Client.PropertyValue object
        //     to a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Parameters:
        //   changesetId:
        //     The changeset ID.
        //
        //   propertyName:
        //     The name of the property.
        //
        //   value:
        //     The value to assign to the property.
        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetChangesetProperty(int changesetId, string propertyName, int? value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a of Microsoft.TeamFoundation.Framework.Client.PropertyValue object
        //     to a Microsoft.TeamFoundation.VersionControl.Client.Changeset.
        //
        // Parameters:
        //   changesetId:
        //     The changeset ID.
        //
        //   propertyName:
        //     The name of the property.
        //
        //   value:
        //     The value to assign to the property.
        /// <summary>
        /// Sets the changeset property.
        /// </summary>
        /// <param name="changesetId">The changeset identifier.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetChangesetProperty(int changesetId, string propertyName, string value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets the file types registered on the server.
        //
        // Parameters:
        //   fileTypes:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IFileType objects
        //     to register on the server.
        /// <summary>
        /// Sets the file types.
        /// </summary>
        /// <param name="fileTypes">The file types.</param>
         void IVersionControlServerHelper.SetFileTypes(IFileType[] fileTypes) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets the permissions for items in the repository.
        //
        // Parameters:
        //   permissionChanges:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PermissionChange
        //     objects to send to the server.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.PermissionChange
        //     objects representing the successful changes returned from the server.
        /// <summary>
        /// Sets the global permissions.
        /// </summary>
        /// <param name="permissionChanges">The permission changes.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.PermissionChange[].</returns>
         IPermissionChange[] IVersionControlServerHelper.SetGlobalPermissions(IPermissionChange[] permissionChanges) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets the permissions for items in the repository.
        //
        // Parameters:
        //   securityChanges:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ISecurityChange
        //     objects to send to the server.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ISecurityChange
        //     representing the successful changes to the server.
        /// <summary>
        /// Sets the permissions.
        /// </summary>
        /// <param name="securityChanges">The security changes.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ISecurityChange[].</returns>
         ISecurityChange[] IVersionControlServerHelper.SetPermissions(ISecurityChange[] securityChanges) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the server settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
         void IVersionControlServerHelper.SetServerSettings(IServerSettings settings) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyValues">The property values.</param>
         void IVersionControlServerHelper.SetVersionedItemAttribute(IItemSpec[] itemSpecs, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, IPropertyValue[] propertyValues) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, byte[] value) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, DateTime? value) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, double? value) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, int? value) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the versioned item attribute.
        /// </summary>
        /// <param name="itemSpec">The item spec.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
         void IVersionControlServerHelper.SetVersionedItemAttribute(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, string value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a property on an array of versioned items.
        //
        // Parameters:
        //   itemSpecs:
        //     The array of Microsoft.TeamFoundation.VersionControl.Client.VersionSpec objects
        //     of the items.
        //
        //   versionSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   deletedState:
        //     A flag describing whether to set the property on deleted items and/or non-deleted
        //     items.
        //
        //   itemType:
        //     A flag describing whether to set the property on files and/or folders.
        //
        //   propertyValues:
        //     The property values to set.
        /// <summary>
        /// Sets the versioned item property.
        /// </summary>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="versionSpec">The version spec.</param>
        /// <param name="deletedState">State of the deleted.</param>
        /// <param name="itemType">Type of the item.</param>
        /// <param name="propertyValues">The property values.</param>
        [Obsolete("Please use SetVersionedItemAttribute to set attributes on versioned items.", false)]
         void IVersionControlServerHelper.SetVersionedItemProperty(IItemSpec[] itemSpecs, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, IPropertyValue[] propertyValues) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a property on a versioned item.
        //
        // Parameters:
        //   itemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemSpec of the item.
        //
        //   versionSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   deletedState:
        //     A flag describing whether to set the property on deleted items and/or non-deleted
        //     items.
        //
        //   itemType:
        //     A flag describing whether to set the property on files and/or folders.
        //
        //   propertyName:
        //     The property to set.
        //
        //   value:
        //     The property value to set.
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
         void IVersionControlServerHelper.SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, byte[] value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a property on a versioned item.
        //
        // Parameters:
        //   itemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.ItemSpec of the item.
        //
        //   versionSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   deletedState:
        //     A flag describing whether to set the property on deleted items and/or non-deleted
        //     items.
        //
        //   itemType:
        //     A flag describing whether to set the property on files and/or folders.
        //
        //   propertyName:
        //     The property to set.
        //
        //   value:
        //     The property value to set.
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
         void IVersionControlServerHelper.SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, DateTime? value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a property on a versioned item.
        //
        // Parameters:
        //   itemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   versionSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   deletedState:
        //     A flag describing whether to set the property on deleted items and/or non-deleted
        //     items.
        //
        //   itemType:
        //     A flag describing whether to set the property on files and/or folders.
        //
        //   propertyName:
        //     The property to set.
        //
        //   value:
        //     The property value to set.
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
         void IVersionControlServerHelper.SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, double? value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a property on a versioned item.
        //
        // Parameters:
        //   itemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   versionSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   deletedState:
        //     A flag describing whether to set the property on deleted items and/or non-deleted
        //     items.
        //
        //   itemType:
        //     A flag describing whether to set the property on files and/or folders.
        //
        //   propertyName:
        //     The property to set.
        //
        //   value:
        //     The property value to set.
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
         void IVersionControlServerHelper.SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, int? value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Sets a property on a versioned items.
        //
        // Parameters:
        //   itemSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   versionSpec:
        //     The Microsoft.TeamFoundation.VersionControl.Client.VersionSpec of the item.
        //
        //   deletedState:
        //     A flag describing whether to set the property on deleted items and/or non-deleted
        //     items.
        //
        //   itemType:
        //     A flag describing whether to set the property on files and/or folders.
        //
        //   propertyName:
        //     The property to set.
        //
        //   value:
        //     The property value to set.
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
         void IVersionControlServerHelper.SetVersionedItemProperty(IItemSpec itemSpec, IVersionSpec versionSpec, IDeletedState deletedState, IItemType itemType, string propertyName, string value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Remove unsupported check-in parameters from a Microsoft.TeamFoundation.VersionControl.Client.CheckInParameters
        //     instance.
        //
        // Parameters:
        //   checkInParameters:
        //     The Microsoft.TeamFoundation.VersionControl.Client.CheckInParameters instance
        //     to modify.
        /// <summary>
        /// Strips the unsupported checkin options.
        /// </summary>
        /// <param name="checkInParameters">The check in parameters.</param>
         void IVersionControlServerHelper.StripUnsupportedCheckinOptions(ICheckInParameters checkInParameters) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets merges that occurred from a source item to a set of target items, for
        //     a list of source Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     IDs.
        //
        // Parameters:
        //   sourceChangesetIds:
        //     An array of source changeset IDs.
        //
        //   sourceItem:
        //     Source item to track merges from (recursive).
        //
        //   targetItems:
        //     Target item to track merges to (recursive).
        //
        //   pathFilter:
        //     Optional path filter to reduce the scope of source item.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IExtendedMerge
        //     objects representing the changes from the source item to the target item.
        //     Returns an empty array if no merge chain exists.
        /// <summary>
        /// Tracks the merges.
        /// </summary>
        /// <param name="sourceChangesetIds">The source changeset ids.</param>
        /// <param name="sourceItem">The source item.</param>
        /// <param name="targetItems">The target items.</param>
        /// <param name="pathFilter">The path filter.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IExtendedMerge[].</returns>
         IExtendedMerge[] IVersionControlServerHelper.TrackMerges(int[] sourceChangesetIds, IItemIdentifier sourceItem, IItemIdentifier[] targetItems, IItemSpec pathFilter) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets merges that occurred from a source item to a set of target items, for
        //     a list of source Microsoft.TeamFoundation.VersionControl.Client.Changeset
        //     IDs.
        //
        // Parameters:
        //   sourceChangesetIds:
        //     An array of source changeset IDs.
        //
        //   sourceItem:
        //     Source item to track merges from (recursive).
        //
        //   targetItems:
        //     Target item to track merges to (recursive).
        //
        //   pathFilter:
        //     Optional path filter to reduce the scope of source item.
        //
        //   partialTargetItems:
        //     An array of target items where the source changeset has only been partially
        //     merged.
        //
        // Returns:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.IExtendedMerge
        //     objects representing the changes from the source item to the target item.
        //     Returns an empty array if no merge chain exists.
        /// <summary>
        /// Tracks the merges.
        /// </summary>
        /// <param name="sourceChangesetIds">The source changeset ids.</param>
        /// <param name="sourceItem">The source item.</param>
        /// <param name="targetItems">The target items.</param>
        /// <param name="pathFilter">The path filter.</param>
        /// <param name="partialTargetItems">The partial target items.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IExtendedMerge[].</returns>
         IExtendedMerge[] IVersionControlServerHelper.TrackMerges(int[] sourceChangesetIds, IItemIdentifier sourceItem, IItemIdentifier[] targetItems, IItemSpec pathFilter, out string[] partialTargetItems) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the team project in the repository with the specified name.
        //
        // Parameters:
        //   name:
        //     The name of the team project to get.
        //
        // Returns:
        //     The team project with the specified name. Null if a project was not found.
        /// <summary>
        /// Tries the get team project.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ITeamProject.</returns>
         ITeamProject IVersionControlServerHelper.TryGetTeamProject(string name) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the team project for the specified server path.
        //
        // Parameters:
        //   serverPath:
        //     The server path of the team project to get.
        //
        // Returns:
        //     The team project with the specified path. Null otherwise.
        /// <summary>
        /// Tries the get team project for server path.
        /// </summary>
        /// <param name="serverPath">The server path.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ITeamProject.</returns>
         ITeamProject IVersionControlServerHelper.TryGetTeamProjectForServerPath(string serverPath) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets the workspace that is mapped to the specified local path. Does not throw
        //     an exception.
        //
        // Parameters:
        //   localPath:
        //     The local path of the desired workspace.
        //
        // Returns:
        //     The workspace object that is associated with the specified local path. Null
        //     if a workspace is not found.
        /// <summary>
        /// Tries the get workspace.
        /// </summary>
        /// <param name="localPath">The local path.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.IWorkSpace.</returns>
         IWorkSpace IVersionControlServerHelper.TryGetWorkspace(string localPath) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Removes a label applied to an item.
        //
        // Parameters:
        //   labelName:
        //     The name of the label to remove.
        //
        //   labelScope:
        //     The repository path representing the scope at which the label is defined.
        //
        //   itemSpecs:
        //     An array of Microsoft.TeamFoundation.VersionControl.Client.ItemSpec objects
        //     from which to remove the specified label.
        //
        //   version:
        //     The version of the items to remove -- typically the label's LabelVersionSpec.
        //
        // Returns:
        //     Results of the label operations.
        /// <summary>
        /// Unlabels the item.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ILabelResult[].</returns>
         ILabelResult[] IVersionControlServerHelper.UnlabelItem(string labelName, string labelScope, IItemSpec[] itemSpecs, IVersionSpec version) { throw new NotImplementedException(); }
        /// <summary>
        /// Unlabels the item.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="labelScope">The label scope.</param>
        /// <param name="itemSpecs">The item specs.</param>
        /// <param name="version">The version.</param>
        /// <param name="failureFilter">The failure filter.</param>
        /// <param name="filteredFailures">The filtered failures.</param>
        /// <returns>DynCon.OSI.VSO.ObjectModelClient.Helpers.ILabelResult[].</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
         ILabelResult[] IVersionControlServerHelper.UnlabelItem(string labelName, string labelScope, IItemSpec[] itemSpecs, IVersionSpec version, Predicate<IFailure> failureFilter, out IFailure[] filteredFailures) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Updates an existing Microsoft.TeamFoundation.VersionControl.Client.BranchObject
        //     in Team Foundation Server.
        //
        // Parameters:
        //   properties:
        //     Microsoft.TeamFoundation.VersionControl.Client.Changeset to update.
        /// <summary>
        /// Updates the branch object.
        /// </summary>
        /// <param name="properties">The properties.</param>
         void IVersionControlServerHelper.UpdateBranchObject(IBranchProperties properties) { throw new NotImplementedException(); }
        /// <summary>
        /// Updates the shelveset.
        /// </summary>
        /// <param name="shelvesetName">Name of the shelveset.</param>
        /// <param name="shelvesetOwner">The shelveset owner.</param>
        /// <param name="updatedShelveset">The updated shelveset.</param>
         void IVersionControlServerHelper.UpdateShelveset(string shelvesetName, string shelvesetOwner, IShelveset updatedShelveset) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Fixes the display name for the current user on this server.
        /// <summary>
        /// Updates the name of the user.
        /// </summary>
         void IVersionControlServerHelper.UpdateUserName() { throw new NotImplementedException(); }

    }

    internal class WebServiceLevelWrapper
    {
        public static IWebServiceLevel GetWrapper(WebServiceLevel webServiceLevel) { throw new NotImplementedException(); }
    }


    internal class VersionControlArtifactProviderWrapper
    {
        public static IVersionControlArtifactProvider GetWrapper(VersionControlArtifactProvider artifactProvider) { throw new NotImplementedException(); }
    }

    internal class TeamFoundationIdentityWrapper
    {
        internal static ITeamFoundationIdentity GetWrapper(TeamFoundationIdentity authorizedIdentity) { throw new NotImplementedException(); }
    }
}