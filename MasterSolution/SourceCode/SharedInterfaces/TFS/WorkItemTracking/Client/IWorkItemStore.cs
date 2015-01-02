using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemStore
    /// </summary>
    public interface IWorkItemStore : IITfsTeamProjectCollectionObject
    {
        /// <summary>
        /// Batches the save.
        /// </summary>
        /// <param name="workitems">The workitems.</param>
        /// <returns>IBatchSaveError[].</returns>
        IBatchSaveError[] BatchSave(IWorkItem[] workitems);
        /// <summary>
        /// Batches the save.
        /// </summary>
        /// <param name="workitems">The workitems.</param>
        /// <param name="saveFlags">The save flags.</param>
        /// <returns>IBatchSaveError[].</returns>
        IBatchSaveError[] BatchSave(IWorkItem[] workitems, ISaveFlags saveFlags);
        /// <summary>
        /// Caches the constant strings.
        /// </summary>
        void CacheConstantStrings();
        /// <summary>
        /// Destroys the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>IEnumerable&lt;IWorkItemOperationError&gt;.</returns>
        IEnumerable<IWorkItemOperationError> DestroyWorkItems(IEnumerable<Int32> ids);
        /// <summary>
        /// Exports the global lists.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        XmlDocument ExportGlobalLists();
        /// <summary>
        /// Gets the global and project groups.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="includeGlobal">The include global.</param>
        /// <returns>List&lt;String&gt;.</returns>
        List<String> GetGlobalAndProjectGroups(Int32 projectId, Boolean includeGlobal);
        /// <summary>
        /// Gets the node permissions.
        /// </summary>
        /// <param name="nodeId">The node identifier.</param>
        /// <returns>IPsUserRightsMask.</returns>
        IPsUserRightsMask GetNodePermissions(Int32 nodeId);
        /// <summary>
        /// Gets the person name by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>String.</returns>
        String GetPersonNameById(Int32 id);
        /// <summary>
        /// Gets the query definition.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>IQueryDefinition.</returns>
        IQueryDefinition GetQueryDefinition(Guid guid);
        /// <summary>
        /// Gets the query hierarchy.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>IQueryHierarchy.</returns>
        IQueryHierarchy GetQueryHierarchy(IProject project);
        /// <summary>
        /// Gets the referencing work item uris.
        /// </summary>
        /// <param name="referencedUri">The referenced URI.</param>
        /// <returns>Uri[].</returns>
        Uri[] GetReferencingWorkItemUris(Uri referencedUri);
        /// <summary>
        /// Gets the stored query.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>IStoredQuery.</returns>
        IStoredQuery GetStoredQuery(Guid guid);
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(Int32 id);
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="at">At.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(Int32 id, DateTime at);
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(Int32 id, Int32 revision);
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(Uri uri);
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="at">At.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(Uri uri, DateTime at);
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(Uri uri, Int32 revision);
        /// <summary>
        /// Gets the work item ids for artifact uris.
        /// </summary>
        /// <param name="artifactUriList">The artifact URI list.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <returns>Dictionary&lt;String, Int32[]&gt;.</returns>
        Dictionary<String, Int32[]> GetWorkItemIdsForArtifactUris(String[] artifactUriList, DateTime asOfDate);
        /// <summary>
        /// Imports the global lists.
        /// </summary>
        /// <param name="lists">The lists.</param>
        void ImportGlobalLists(String lists);
        /// <summary>
        /// Imports the global lists.
        /// </summary>
        /// <param name="listsElement">The lists element.</param>
        void ImportGlobalLists(XmlElement listsElement);
        /// <summary>
        /// Invalidates the cache stamp.
        /// </summary>
        void InvalidateCacheStamp();
        /// <summary>
        /// Queries the specified wiql.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <returns>IWorkItemCollection.</returns>
        IWorkItemCollection Query(String wiql);
        /// <summary>
        /// Queries the specified wiql.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <param name="context">The context.</param>
        /// <returns>IWorkItemCollection.</returns>
        IWorkItemCollection Query(String wiql, IDictionary context);
        /// <summary>
        /// Queries the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="wiql">The wiql.</param>
        /// <returns>IWorkItemCollection.</returns>
        IWorkItemCollection Query(Int32[] ids, String wiql);
        /// <summary>
        /// Queries the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="revs">The revs.</param>
        /// <param name="wiql">The wiql.</param>
        /// <returns>IWorkItemCollection.</returns>
        IWorkItemCollection Query(Int32[] ids, Int32[] revs, String wiql);
        /// <summary>
        /// Queries the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="wiql">The wiql.</param>
        /// <param name="asof">The asof.</param>
        /// <returns>IWorkItemCollection.</returns>
        IWorkItemCollection Query(Int32[] ids, String wiql, DateTime asof);
        /// <summary>
        /// Queries the specified batch read parameters.
        /// </summary>
        /// <param name="batchReadParams">The batch read parameters.</param>
        /// <param name="wiql">The wiql.</param>
        /// <returns>IWorkItemCollection.</returns>
        IWorkItemCollection Query(IBatchReadParameterCollection batchReadParams, String wiql);
        /// <summary>
        /// Queries the count.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <returns>Int32.</returns>
        Int32 QueryCount(String wiql);
        /// <summary>
        /// Queries the count.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <param name="context">The context.</param>
        /// <returns>Int32.</returns>
        Int32 QueryCount(String wiql, IDictionary context);
        /// <summary>
        /// Refreshes the cache.
        /// </summary>
        /// <param name="forceRefresh">The force refresh.</param>
        void RefreshCache(Boolean forceRefresh);
        /// <summary>
        /// Refreshes the cache.
        /// </summary>
        void RefreshCache();
        /// <summary>
        /// Resets the cached data.
        /// </summary>
        void ResetCachedData();
        /// <summary>
        /// Resets the constant string cache.
        /// </summary>
        void ResetConstantStringCache();
        /// <summary>
        /// Sends the update package.
        /// </summary>
        /// <param name="package">The package.</param>
        /// <param name="result">The result.</param>
        /// <param name="bulk">The bulk.</param>
        void SendUpdatePackage(XmlElement package, out XmlElement result, Boolean bulk);
        /// <summary>
        /// Synchronizes to cache.
        /// </summary>
        /// <returns>Boolean.</returns>
        Boolean SyncToCache();
        /// <summary>
        /// Trees the identifier to path.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>String.</returns>
        String TreeIdToPath(Int32 id);
        /// <summary>
        /// Gets the bypass rules.
        /// </summary>
        /// <value>The bypass rules.</value>
        Boolean BypassRules { get; }
        /// <summary>
        /// Gets or sets the calling process identity.
        /// </summary>
        /// <value>The calling process identity.</value>
        String CallingProcessIdentity { get; set; }
        /// <summary>
        /// Gets the client service.
        /// </summary>
        /// <value>The client service.</value>
        IWorkItemServer ClientService { get; }
        /// <summary>
        /// Gets the culture information.
        /// </summary>
        /// <value>The culture information.</value>
        CultureInfo CultureInfo { get; }
        /// <summary>
        /// Gets the diagnostics.
        /// </summary>
        /// <value>The diagnostics.</value>
        IWorkItemStoreDiagnostics Diagnostics { get; }
        /// <summary>
        /// Gets the field definitions.
        /// </summary>
        /// <value>The field definitions.</value>
        IFieldDefinitionCollection FieldDefinitions { get; }
        /// <summary>
        /// Gets the maximum size of the bulk update batch.
        /// </summary>
        /// <value>The maximum size of the bulk update batch.</value>
        Int32 MaxBulkUpdateBatchSize { get; }
        /// <summary>
        /// Gets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        ICache Metadata { get; }
        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <value>The projects.</value>
        IProjectCollection Projects { get; }
        /// <summary>
        /// Gets the query hierarchy provider.
        /// </summary>
        /// <value>The query hierarchy provider.</value>
        IQueryHierarchyProvider QueryHierarchyProvider { get; }
        /// <summary>
        /// Gets the registered link types.
        /// </summary>
        /// <value>The registered link types.</value>
        IRegisteredLinkTypeCollection RegisteredLinkTypes { get; }
        /// <summary>
        /// Gets the server information.
        /// </summary>
        /// <value>The server information.</value>
        IServerInfo ServerInfo { get; }
        /// <summary>
        /// Gets the server string comparer.
        /// </summary>
        /// <value>The server string comparer.</value>
        StringComparer ServerStringComparer { get; }
        /// <summary>
        /// Gets the team foundation server.
        /// </summary>
        /// <value>The team foundation server.</value>
        ITeamFoundationServer TeamFoundationServer { get; }
        /// <summary>
        /// Gets the team project collection.
        /// </summary>
        /// <value>The team project collection.</value>
        ITfsTeamProjectCollection TeamProjectCollection { get; }
        /// <summary>
        /// Gets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        TimeZone TimeZone { get; }
        /// <summary>
        /// Gets the user display mode.
        /// </summary>
        /// <value>The user display mode.</value>
        IUserDisplayMode UserDisplayMode { get; }
        /// <summary>
        /// Gets the display name of the user.
        /// </summary>
        /// <value>The display name of the user.</value>
        String UserDisplayName { get; }
        /// <summary>
        /// Gets the user sid.
        /// </summary>
        /// <value>The user sid.</value>
        String UserSid { get; }
        /// <summary>
        /// Gets the web service URL.
        /// </summary>
        /// <value>The web service URL.</value>
        String WebServiceUrl { get; }
        /// <summary>
        /// Gets the work item link types.
        /// </summary>
        /// <value>The work item link types.</value>
        IWorkItemLinkTypeCollection WorkItemLinkTypes { get; }
    }
}