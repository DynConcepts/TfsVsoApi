using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemStoreImpl.
    /// </summary>
    public class WorkItemStoreImpl : IWorkItemStore, IITfsTeamProjectCollectionObject
    {
        /// <summary>
        ///     Batches the save.
        /// </summary>
        /// <param name="workitems">The workitems.</param>
        /// <returns>IBatchSaveError[].</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IBatchSaveError[] IWorkItemStore.BatchSave(IWorkItem[] workitems)
        {
            var errors = new List<IBatchSaveError>();
            foreach (IWorkItem workItem in workitems)
            {
                try
                {
                    workItem.Save();
                }
                catch (Exception ex)
                {
                    var error = new BatchSaveErrorImpl(ex, workItem);
                    errors.Add(error);
                }
            }
            return errors.ToArray();
        }

        /// <summary>
        ///     Batches the save.
        /// </summary>
        /// <param name="workitems">The workitems.</param>
        /// <param name="saveFlags">The save flags.</param>
        /// <returns>IBatchSaveError[].</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IBatchSaveError[] IWorkItemStore.BatchSave(IWorkItem[] workitems, ISaveFlags saveFlags)
        {
            var errors = new List<IBatchSaveError>();
            foreach (IWorkItem workItem in workitems)
            {
                try
                {
                    workItem.Save(saveFlags);
                }
                catch (Exception ex)
                {
                    var error = new BatchSaveErrorImpl(ex, workItem);
                    errors.Add(error);
                }
            }
            return errors.ToArray();
        }


        /// <summary>
        ///     Gets the bypass rules.
        /// </summary>
        /// <value>The bypass rules.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IWorkItemStore.BypassRules { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Caches the constant strings.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemStore.CacheConstantStrings() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the calling process identity.
        /// </summary>
        /// <value>The calling process identity.</value>
        /// <exception cref="ToBeImplementedException">
        /// </exception>
        String IWorkItemStore.CallingProcessIdentity { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the client service.
        /// </summary>
        /// <value>The client service.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemServer IWorkItemStore.ClientService { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the culture information.
        /// </summary>
        /// <value>The culture information.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        CultureInfo IWorkItemStore.CultureInfo { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Destroys the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>IEnumerable&lt;IWorkItemOperationError&gt;.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IEnumerable<IWorkItemOperationError> IWorkItemStore.DestroyWorkItems(IEnumerable<Int32> ids) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the diagnostics.
        /// </summary>
        /// <value>The diagnostics.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemStoreDiagnostics IWorkItemStore.Diagnostics { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Exports the global lists.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        XmlDocument IWorkItemStore.ExportGlobalLists() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the field definitions.
        /// </summary>
        /// <value>The field definitions.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldDefinitionCollection IWorkItemStore.FieldDefinitions { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the global and project groups.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="includeGlobal">The include global.</param>
        /// <returns>List&lt;String&gt;.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        List<String> IWorkItemStore.GetGlobalAndProjectGroups(Int32 projectId, Boolean includeGlobal) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the node permissions.
        /// </summary>
        /// <param name="nodeId">The node identifier.</param>
        /// <returns>IPsUserRightsMask.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IPsUserRightsMask IWorkItemStore.GetNodePermissions(Int32 nodeId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the person name by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>String.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemStore.GetPersonNameById(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the query definition.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>IQueryDefinition.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IQueryDefinition IWorkItemStore.GetQueryDefinition(Guid guid) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the query hierarchy.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>IQueryHierarchy.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IQueryHierarchy IWorkItemStore.GetQueryHierarchy(IProject project) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the referencing work item uris.
        /// </summary>
        /// <param name="referencedUri">The referenced URI.</param>
        /// <returns>Uri[].</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Uri[] IWorkItemStore.GetReferencingWorkItemUris(Uri referencedUri) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the stored query.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>IStoredQuery.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IStoredQuery IWorkItemStore.GetStoredQuery(Guid guid) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItem IWorkItemStore.GetWorkItem(Int32 id)
        {
            WorkItemImpl result = JsonWorkItem.APIFactory().GetWorkItem(id, WorkItemImpl.FromToken).Result;
            return result;
        }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="at">At.</param>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItem IWorkItemStore.GetWorkItem(Int32 id, DateTime at) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItem IWorkItemStore.GetWorkItem(Int32 id, Int32 revision) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItem IWorkItemStore.GetWorkItem(Uri uri) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="at">At.</param>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItem IWorkItemStore.GetWorkItem(Uri uri, DateTime at) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItem IWorkItemStore.GetWorkItem(Uri uri, Int32 revision) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item ids for artifact uris.
        /// </summary>
        /// <param name="artifactUriList">The artifact URI list.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <returns>Dictionary&lt;String, Int32[]&gt;.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Dictionary<String, Int32[]> IWorkItemStore.GetWorkItemIdsForArtifactUris(String[] artifactUriList, DateTime asOfDate) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the global lists.
        /// </summary>
        /// <param name="lists">The lists.</param>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemStore.ImportGlobalLists(String lists) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the global lists.
        /// </summary>
        /// <param name="listsElement">The lists element.</param>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemStore.ImportGlobalLists(XmlElement listsElement) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Initializes the specified project collection.
        /// </summary>
        /// <param name="projectCollection">The project collection.</param>
        /// <exception cref="ToBeImplementedException"></exception>
        void IITfsTeamProjectCollectionObject.Initialize(ITfsTeamProjectCollection projectCollection) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Invalidates the cache stamp.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemStore.InvalidateCacheStamp() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the maximum size of the bulk update batch.
        /// </summary>
        /// <value>The maximum size of the bulk update batch.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Int32 IWorkItemStore.MaxBulkUpdateBatchSize { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ICache IWorkItemStore.Metadata { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the projects.
        /// </summary>
        /// <value>The projects.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IProjectCollection IWorkItemStore.Projects
        {
            get
            {
                var api = new ProjectsAPI();
                IReadOnlyList<ProjectImpl> result = api.GetProjects(ProjectImpl.FromToken).Result;
                return new ProjectCollectionImpl(result);
            }
        }

        /// <summary>
        ///     Queries the specified wiql.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <returns>IWorkItemCollection.</returns>
        IWorkItemCollection IWorkItemStore.Query(String wiql)
        {
            IReadOnlyList<WorkItemImpl> result = JsonWorkItem.APIFactory().WiqlQuery(wiql, true, WorkItemImpl.FromToken).Result;
            return new WorkItemCollectionImpl(this, result);
        }

        /// <summary>
        ///     Queries the specified wiql.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <param name="context">The context.</param>
        /// <returns>IWorkItemCollection.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemCollection IWorkItemStore.Query(String wiql, IDictionary context) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="wiql">The wiql.</param>
        /// <returns>IWorkItemCollection.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemCollection IWorkItemStore.Query(Int32[] ids, String wiql) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="revs">The revs.</param>
        /// <param name="wiql">The wiql.</param>
        /// <returns>IWorkItemCollection.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemCollection IWorkItemStore.Query(Int32[] ids, Int32[] revs, String wiql) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="wiql">The wiql.</param>
        /// <param name="asof">The asof.</param>
        /// <returns>IWorkItemCollection.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemCollection IWorkItemStore.Query(Int32[] ids, String wiql, DateTime asof) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the specified batch read parameters.
        /// </summary>
        /// <param name="batchReadParams">The batch read parameters.</param>
        /// <param name="wiql">The wiql.</param>
        /// <returns>IWorkItemCollection.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemCollection IWorkItemStore.Query(IBatchReadParameterCollection batchReadParams, String wiql) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the count.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <returns>Int32.</returns>
        Int32 IWorkItemStore.QueryCount(String wiql)
        {
            IReadOnlyList<JsonWorkItem> result = JsonWorkItem.APIFactory().WiqlQuery(wiql, true).Result;
            return result.Count;
        }

        /// <summary>
        ///     Queries the count.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <param name="context">The context.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Int32 IWorkItemStore.QueryCount(String wiql, IDictionary context) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the query hierarchy provider.
        /// </summary>
        /// <value>The query hierarchy provider.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IQueryHierarchyProvider IWorkItemStore.QueryHierarchyProvider { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Refreshes the cache.
        /// </summary>
        /// <param name="forceRefresh">The force refresh.</param>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemStore.RefreshCache(Boolean forceRefresh) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Refreshes the cache.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemStore.RefreshCache() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the registered link types.
        /// </summary>
        /// <value>The registered link types.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IRegisteredLinkTypeCollection IWorkItemStore.RegisteredLinkTypes { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Resets the cached data.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemStore.ResetCachedData() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Resets the constant string cache.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemStore.ResetConstantStringCache() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sends the update package.
        /// </summary>
        /// <param name="package">The package.</param>
        /// <param name="result">The result.</param>
        /// <param name="bulk">The bulk.</param>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemStore.SendUpdatePackage(XmlElement package, out XmlElement result, Boolean bulk) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the server information.
        /// </summary>
        /// <value>The server information.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IServerInfo IWorkItemStore.ServerInfo { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the server string comparer.
        /// </summary>
        /// <value>The server string comparer.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        StringComparer IWorkItemStore.ServerStringComparer { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Synchronizes to cache.
        /// </summary>
        /// <returns>Boolean.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IWorkItemStore.SyncToCache() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the team foundation server.
        /// </summary>
        /// <value>The team foundation server.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ITeamFoundationServer IWorkItemStore.TeamFoundationServer { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the team project collection.
        /// </summary>
        /// <value>The team project collection.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ITfsTeamProjectCollection IWorkItemStore.TeamProjectCollection { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        TimeZone IWorkItemStore.TimeZone { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Trees the identifier to path.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>String.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemStore.TreeIdToPath(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the user display mode.
        /// </summary>
        /// <value>The user display mode.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IUserDisplayMode IWorkItemStore.UserDisplayMode { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the display name of the user.
        /// </summary>
        /// <value>The display name of the user.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemStore.UserDisplayName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the user sid.
        /// </summary>
        /// <value>The user sid.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemStore.UserSid { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the web service URL.
        /// </summary>
        /// <value>The web service URL.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemStore.WebServiceUrl { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the work item link types.
        /// </summary>
        /// <value>The work item link types.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemLinkTypeCollection IWorkItemStore.WorkItemLinkTypes { get { throw new ToBeImplementedException(); } }
    }
}