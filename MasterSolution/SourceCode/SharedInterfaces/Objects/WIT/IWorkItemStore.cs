using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
{
    /// <summary>
    /// public interface IWorkItemStoreHelper
    /// </summary>
    public interface IWorkItemStore
    {
        // Summary:
        //     Gets/sets whether the work item store object bypass rules
        //
        // Returns:
        //     Returns System.Boolean.
        /// <summary>
        /// Gets a value indicating whether [bypass rules].
        /// </summary>
        /// <value><c>true</c> if [bypass rules]; otherwise, <c>false</c>.</value>
        bool BypassRules { get; }
        //
        // Summary:
        //     Gets or sets the string that identifies the calling process to the server.
        //
        // Returns:
        //     The string that identifies the calling process to the server.
        /// <summary>
        /// Gets or sets the calling process identity.
        /// </summary>
        /// <value>The calling process identity.</value>
        [Obsolete("Use TfsConnection.ApplicationName instead.")]
        string CallingProcessIdentity { get; set; }
        /// <summary>
        /// Gets the client service.
        /// </summary>
        /// <value>The client service.</value>
        //[CLSCompliant(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        IWorkItemServer ClientService { get; }
        //
        // Summary:
        //     Gets the localization environment that is used by the client.
        //
        // Returns:
        //     The localization environment that is used by the client.
        /// <summary>
        /// Gets the culture information.
        /// </summary>
        /// <value>The culture information.</value>
        CultureInfo CultureInfo { get; }
        //
        // Summary:
        //     Gets the diagnostics object that is associated with this server connection.
        //
        // Returns:
        //     The diagnostics object that is associated with this server connection.
        /// <summary>
        /// Gets the diagnostics.
        /// </summary>
        /// <value>The diagnostics.</value>
        IWorkItemStoreDiagnostics Diagnostics { get; }
        //
        // Summary:
        //     Gets the collection of field definitions that are associated with this WorkItemStore
        //     instance.
        //
        // Returns:
        //     The collection of field definitions that are associated with this WorkItemStore
        //     instance.
        /// <summary>
        /// Gets the field definitions.
        /// </summary>
        /// <value>The field definitions.</value>
        IFieldDefinitionCollection FieldDefinitions { get; }
        /// <summary>
        /// Gets the maximum size of the bulk update batch.
        /// </summary>
        /// <value>The maximum size of the bulk update batch.</value>
        int MaxBulkUpdateBatchSize { get; }
        /// <summary>
        /// Gets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        ICache Metadata { get; }
        //
        // Summary:
        //     Gets the collection of Microsoft.TeamFoundation.WorkItemTracking.Client.Projects
        //     that is associated with this WorkItemStore instance.
        //
        // Returns:
        //     Gets the collection of Microsoft.TeamFoundation.WorkItemTracking.Client.Projects
        //     that is associated with this WorkItemStore instance.
        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <value>The projects.</value>
        IProjectCollection Projects { get; }
        /// <summary>
        /// Gets the query hierarchy provider.
        /// </summary>
        /// <value>The query hierarchy provider.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        IQueryHierarchyProvider QueryHierarchyProvider { get; }
        //
        // Summary:
        //     Gets the cached Microsoft.TeamFoundation.WorkItemTracking.Client.RegisteredLinkTypeCollection
        //     that is associated with this server.
        //
        // Returns:
        //     The cached Microsoft.TeamFoundation.WorkItemTracking.Client.RegisteredLinkTypeCollection
        //     that is associated with this server.
        /// <summary>
        /// Gets the registered link types.
        /// </summary>
        /// <value>The registered link types.</value>
        IRegisteredLinkTypeCollection RegisteredLinkTypes { get; }
        //
        // Summary:
        //     Gets the server information object that contains all features that are supported
        //     by the server.
        //
        // Returns:
        //     The server information object that contains all features that are supported
        //     by the server.
        /// <summary>
        /// Gets the server information.
        /// </summary>
        /// <value>The server information.</value>
        IServerInfo ServerInfo { get; }
        /// <summary>
        /// Gets the server string comparer.
        /// </summary>
        /// <value>The server string comparer.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        StringComparer ServerStringComparer { get; }
        //
        // Summary:
        //     Gets the connection to the server that is running Team Foundation Server.
        //
        // Returns:
        //     The connection to the server that is running Team Foundation Server.
        /// <summary>
        /// Gets the team foundation server.
        /// </summary>
        /// <value>The team foundation server.</value>
        [Obsolete("The TeamFoundationServer class is obsolete and so is this property. Use the corresponding property of type TfsTeamProjectCollection instead.")]
        ITeamFoundationServer TeamFoundationServer { get; }
        //
        // Summary:
        //     Gets the connection to the server that is running Team Foundation Server.
        //
        // Returns:
        //     The connection to the server that is running Team Foundation Server.
        /// <summary>
        /// Gets the team project collection.
        /// </summary>
        /// <value>The team project collection.</value>
        ITfsTeamProjectCollection TeamProjectCollection { get; }
        //
        // Summary:
        //     Gets the time zone of the client.
        //
        // Returns:
        //     The time zone of the client.
        /// <summary>
        /// Gets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        TimeZone TimeZone { get; }
        //
        // Summary:
        //     Gets the mode in which user account information is displayed for this work
        //     item store.
        //
        // Returns:
        //     The mode in which user account information is displayed for this work item
        //     store.
        /// <summary>
        /// Gets the user display mode.
        /// </summary>
        /// <value>The user display mode.</value>
       IUserDisplayMode UserDisplayMode { get; }
       /// <summary>
       /// Gets the display name of the user.
       /// </summary>
       /// <value>The display name of the user.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        string UserDisplayName { get; }
        /// <summary>
        /// Gets the user sid.
        /// </summary>
        /// <value>The user sid.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        string UserSid { get; }
        /// <summary>
        /// Gets the web service URL.
        /// </summary>
        /// <value>The web service URL.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        string WebServiceUrl { get; }
        //
        // Summary:
        //     Gets the cached Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLinkTypeCollection
        //     that is associated with the server.
        //
        // Returns:
        //     The cached Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLinkTypeCollection
        //     that is associated with the server.
        /// <summary>
        /// Gets the work item link types.
        /// </summary>
        /// <value>The work item link types.</value>
        IWorkItemLinkTypeCollection WorkItemLinkTypes { get; }

        // Summary:
        //     An event that occurs during ImportGlobalLists call.
        /// <summary>
        /// Occurs when [import event handler].
        /// </summary>
        event ImportEventHandler ImportEventHandler;
        //
        // Summary:
        //     An event that occurs when metadata is changed after the change is processed
        //     by the object model.
        /// <summary>
        /// Occurs when [metadata changed].
        /// </summary>
        event MetadataChangeEventHandler MetadataChanged;
        //
        // Summary:
        //     An event that occurs when metadata is changed before the change is processed
        //     by the object model.
        /// <summary>
        /// Occurs when [metadata changing].
        /// </summary>
        [Obsolete("This event is obsolete, will be removed in RTM tree. Use MetadataChanged instead.")]
        event MetadataChangeEventHandler MetadataChanging;

        // Summary:
        //     Commits multiple items in a branch and returns a list of errors if one or
        //     more items fail.
        //
        // Parameters:
        //   workitems:
        //     An array of work items to commit.
        //
        // Returns:
        //     An array of errors that result from the save.
        /// <summary>
        /// Batches the save.
        /// </summary>
        /// <param name="workitems">The workitems.</param>
        /// <returns>IBatchSaveError[].</returns>
        IBatchSaveError[] BatchSave(IWorkItem[] workitems);
        //
        // Summary:
        //     Commits multiple items in a branch and returns a list of errors if one or
        //     more items fail.
        //
        // Parameters:
        //   workitems:
        //     An array of work items to commit.
        //
        //   saveFlags:
        //     If set to SaveFlags.MergeLinks, the method does not return errors for "link
        //     being added already exists" or "link being removed already removed" scenarios.
        //
        // Returns:
        //     An array of errors that result from the save.
        /// <summary>
        /// Batches the save.
        /// </summary>
        /// <param name="workitems">The workitems.</param>
        /// <param name="saveFlags">The save flags.</param>
        /// <returns>IBatchSaveError[].</returns>
        IBatchSaveError[] BatchSave(IWorkItem[] workitems, SaveFlags saveFlags);
        /// <summary>
        /// Caches the constant strings.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void CacheConstantStrings();
        //
        // Summary:
        //     Destroys work items that have the specified IDs.
        //
        // Parameters:
        //   ids:
        //     An enumerable collection of work item IDs that are associated with the work
        //     items to destroy.
        //
        // Returns:
        //     An enumerable collection of errors that occurred during the destroy operation.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     The ids parameter was null.
        /// <summary>
        /// Destroys the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>IEnumerable&lt;IWorkItemOperationError&gt;.</returns>
        IEnumerable<IWorkItemOperationError> DestroyWorkItems(IEnumerable<int> ids);
        //
        // Summary:
        //     Exports all data that is stored in the database global lists to an System.Xml.XmlDocument.
        //
        // Returns:
        //     Returns an System.Xml.XmlDocument that has all global lists.
        /// <summary>
        /// Exports the global lists.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        XmlDocument ExportGlobalLists();
        /// <summary>
        /// Gets the global and project groups.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="includeGlobal">if set to <c>true</c> [include global].</param>
        /// <returns>List&lt;System.String&gt;.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        List<string> GetGlobalAndProjectGroups(int projectId, bool includeGlobal);
        /// <summary>
        /// Gets the node permissions.
        /// </summary>
        /// <param name="nodeId">The node identifier.</param>
        /// <returns>IPsUserRightsMask.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        IPsUserRightsMask GetNodePermissions(int nodeId);
        /// <summary>
        /// Gets the person name by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>System.String.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        string GetPersonNameById(int id);
        //
        // Summary:
        //     Gets a query definition that is identified by the specified GUID.
        //
        // Parameters:
        //   guid:
        //     The ID of the query definition.
        //
        // Returns:
        //     The query definition.
        //
        // Exceptions:
        //   System.UnauthorizedAccessException:
        //     A query definition that has the specified GUID was not found.
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
        [EditorBrowsable(EditorBrowsableState.Never)]
        IQueryHierarchy GetQueryHierarchy(IProject project);
        //
        // Summary:
        //     Gets an array of work item uniform resource identifiers (URIs) that point
        //     to the specified work item.
        //
        // Parameters:
        //   referencedUri:
        //     The work item from which to get an array of referencing work items.
        //
        // Returns:
        //     An array of work item URIs that reference the work item that is specified
        //     by referencedUri.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     The referencedUri parameter is null.
        //
        //   System.UriFormatException:
        //     The referencedUri parameter is incorrectly formatted. See System.Uri for
        //     examples of correct formatting.
        /// <summary>
        /// Gets the referencing work item uris.
        /// </summary>
        /// <param name="referencedUri">The referenced URI.</param>
        /// <returns>Uri[].</returns>
        Uri[] GetReferencingWorkItemUris(Uri referencedUri);
        //
        // Summary:
        //     Gets a stored query by GUID.
        //
        // Parameters:
        //   guid:
        //     The GUID of the query to get.
        //
        // Returns:
        //     The query instance that is associated with the specified GUID.
        /// <summary>
        /// Gets the stored query.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>IStoredQuery.</returns>
        [Obsolete("Please use GetQueryDefinition instead")]
        IStoredQuery GetStoredQuery(Guid guid);
        //
        // Summary:
        //     Gets the work item that has the specified ID.
        //
        // Parameters:
        //   id:
        //     The work item ID.
        //
        // Returns:
        //     The work item that has the specified ID.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     The id was null.
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(int id);
        //
        // Summary:
        //     Gets the work item at the specified URI.
        //
        // Parameters:
        //   uri:
        //     The URI of the work item.
        //
        // Returns:
        //     The work item at the specified URI.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     The uri parameter was null.
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(Uri uri);
        //
        // Summary:
        //     Gets the previous state of a work item that is specified by ID and date.
        //
        // Parameters:
        //   id:
        //     The work item ID.
        //
        //   at:
        //     The date of the desired work item state.
        //
        // Returns:
        //     The work item state from a specific time.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     At least one parameter was null.
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="at">At.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(int id, DateTime at);
        //
        // Summary:
        //     Gets the previous state of a work item that is specified by ID and revision
        //     number.
        //
        // Parameters:
        //   id:
        //     The work item ID.
        //
        //   revision:
        //     The work item revision number.
        //
        // Returns:
        //     The work item state from a specific revision.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     At least one parameter was null.
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(int id, int revision);
        //
        // Summary:
        //     Gets the work item state from a specific time for viewing.
        //
        // Parameters:
        //   uri:
        //     The URI of the work item.
        //
        //   at:
        //     The date of the desired work item state.
        //
        // Returns:
        //     The work item state from a specific time.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     At least one parameter was null.
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="at">At.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem GetWorkItem(Uri uri, DateTime at);
        //
        // Summary:
        //     Gets the work item state from a specific revision for viewing.
        //
        // Parameters:
        //   uri:
        //     The URI of the work item.
        //
        //   revision:
        //     The work item revision number.
        //
        // Returns:
        //     The work item state from a specific revision.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     At least one parameter was null.
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>WorkItem.</returns>
        IWorkItem GetWorkItem(Uri uri, int revision);
        //
        // Summary:
        //     A list of artifact links that are paired with their referencing work items.
        //
        // Parameters:
        //   artifactUriList:
        //     An array of artifact links for which to retrieve work item IDs.
        //
        //   asOfDate:
        //     A date at which to execute the request.
        //
        // Returns:
        //     A dictionary of work item URIs that reference the artifacts that are specified
        //     by artifactUriList.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     At least one parameter was null.
        //
        //   System.ArgumentException:
        //     The artifactUriList has zero length or one of the elements in the list is
        //     null.
        /// <summary>
        /// Gets the work item ids for artifact uris.
        /// </summary>
        /// <param name="artifactUriList">The artifact URI list.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <returns>Dictionary&lt;System.String, System.Int32[]&gt;.</returns>
        Dictionary<string, int[]> GetWorkItemIdsForArtifactUris(string[] artifactUriList, DateTime asOfDate);
        //
        // Summary:
        //     Imports specified global lists (in XML format) into the database.
        //
        // Parameters:
        //   lists:
        //     An XML-formatted document that has list definitions.
        /// <summary>
        /// Imports the global lists.
        /// </summary>
        /// <param name="lists">The lists.</param>
        void ImportGlobalLists(string lists);
        //
        // Summary:
        //     Imports global lists into the database.
        //
        // Parameters:
        //   listsElement:
        //     An XML element that contains global list definitions.
        /// <summary>
        /// Imports the global lists.
        /// </summary>
        /// <param name="listsElement">The lists element.</param>
        void ImportGlobalLists(XmlElement listsElement);
        /// <summary>
        /// Invalidates the cache stamp.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void InvalidateCacheStamp();
        //
        // Summary:
        //     Executes the query that is described in wiql and returns a collection of
        //     work items.
        //
        // Parameters:
        //   wiql:
        //     The work item query string.
        //
        // Returns:
        //     A collection of work items that result from the query.
        /// <summary>
        /// Queries the specified wiql.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <returns>WorkItemCollection.</returns>
        IWorkItemCollection Query(string wiql);
        //
        // Summary:
        //     Gets the set of fields that is referred to in Wiql for the work items that
        //     are specified by the ID/revision pairs in batchReadParams.
        //
        // Parameters:
        //   batchReadParams:
        //     A collection of ID/revision pairs.
        //
        //   wiql:
        //     The definition of fields to return.
        //
        // Returns:
        //     A collection of work items that result from the query.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     At least one parameter is null.
        //
        //   System.ArgumentException:
        //     The batchReadParams list is empty.
        /// <summary>
        /// Queries the specified batch read parameters.
        /// </summary>
        /// <param name="batchReadParams">The batch read parameters.</param>
        /// <param name="wiql">The wiql.</param>
        /// <returns>WorkItemCollection.</returns>
        IWorkItemCollection Query(IBatchReadParameterCollection batchReadParams, string wiql);
        //
        // Summary:
        //     Gets the set of fields that is referred to in wiql for the work items that
        //     are specified by an ID number (ids)..
        //
        // Parameters:
        //   ids:
        //     A collection of work item IDs.
        //
        //   wiql:
        //     The definition of fields to return.
        //
        // Returns:
        //     A collection of work items that result from the query.
        /// <summary>
        /// Queries the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="wiql">The wiql.</param>
        /// <returns>WorkItemCollection.</returns>
       IWorkItemCollection Query(int[] ids, string wiql);
        //
        // Summary:
        //     Executes the query that is described in wiql and the parameters that are
        //     described in context.
        //
        // Parameters:
        //   wiql:
        //     The work item query string.
        //
        //   context:
        //     Parameters for the work item query.
        //
        // Returns:
        //     A collection of work items that result from the query.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     The wiql parameter is null.
        /// <summary>
        /// Queries the specified wiql.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <param name="context">The context.</param>
        /// <returns>WorkItemCollection.</returns>
        IWorkItemCollection Query(string wiql, IDictionary context);
        //
        // Summary:
        //     Gets the set of fields that is referred to in wiql for the work items that
        //     are specified by an ID number, ids, and revision (revs).
        //
        // Parameters:
        //   ids:
        //     A collection of work item IDs.
        //
        //   revs:
        //     A collection of work item revision numbers.
        //
        //   wiql:
        //     The definition of fields to return.
        //
        // Returns:
        //     A collection of work items that result from the query.
        /// <summary>
        /// Queries the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="revs">The revs.</param>
        /// <param name="wiql">The wiql.</param>
        /// <returns>WorkItemCollection.</returns>
        IWorkItemCollection Query(int[] ids, int[] revs, string wiql);
        //
        // Summary:
        //     Gets the set of fields that is referred to in wiql for the work items that
        //     are specified by an ID number (ids) as of the date that is specified in asof.
        //
        // Parameters:
        //   ids:
        //     A collection of work item IDs.
        //
        //   wiql:
        //     The definition of fields to return.
        //
        //   asof:
        //     The earliest server time to process the query.
        //
        // Returns:
        //     A collection of work items that result from the query.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     At least one parameter is null.
        //
        //   System.ArgumentException:
        //     The ids list is empty or asof is out of the supported range.
        /// <summary>
        /// Queries the specified ids.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="wiql">The wiql.</param>
        /// <param name="asof">The asof.</param>
        /// <returns>WorkItemCollection.</returns>
        IWorkItemCollection Query(int[] ids, string wiql, DateTime asof);
        //
        // Summary:
        //     Gets the number of items that would be returned if the query was executed.
        //
        // Parameters:
        //   wiql:
        //     The query to execute.
        //
        // Returns:
        //     The number of items that are returned by the query.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     The wiql is null.
        /// <summary>
        /// Queries the count.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <returns>System.Int32.</returns>
        int QueryCount(string wiql);
        //
        // Summary:
        //     Gets the number of items that would be returned if the query was executed.
        //
        // Parameters:
        //   wiql:
        //     The query to execute.
        //
        //   context:
        //     The parameters for the work item query.
        //
        // Returns:
        //     The number of items that is returned by the query.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     The wiql is null.
        /// <summary>
        /// Queries the count.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <param name="context">The context.</param>
        /// <returns>System.Int32.</returns>
        int QueryCount(string wiql, IDictionary context);
        //
        // Summary:
        //     Calls the back end to refresh cached metadata.
        /// <summary>
        /// Refreshes the cache.
        /// </summary>
        void RefreshCache();
        /// <summary>
        /// Refreshes the cache.
        /// </summary>
        /// <param name="forceRefresh">if set to <c>true</c> [force refresh].</param>
        void RefreshCache(bool forceRefresh);
        /// <summary>
        /// Resets the cached data.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void ResetCachedData();
        /// <summary>
        /// Resets the constant string cache.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void ResetConstantStringCache();
        /// <summary>
        /// Sends the update package.
        /// </summary>
        /// <param name="package">The package.</param>
        /// <param name="result">The result.</param>
        /// <param name="bulk">if set to <c>true</c> [bulk].</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void SendUpdatePackage(XmlElement package, out XmlElement result, bool bulk);
        //
        // Summary:
        //     Sync to the last version of the cache.
        //
        // Returns:
        //     True if the operation succeeded. False if the operation failed.
        /// <summary>
        /// Synchronizes to cache.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool SyncToCache();
        /// <summary>
        /// Trees the identifier to path.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>System.String.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        string TreeIdToPath(int id);
    }

    /// <summary>
    /// Interface ICache
    /// </summary>
    public interface ICache
    {
    }

    /// <summary>
    /// Interface IFieldDefinitionCollection
    /// </summary>
    public interface IFieldDefinitionCollection : IReadOnlyList<IFieldDefinition>
    {
    }

    /// <summary>
    /// Interface IQueryHierarchyProvider
    /// </summary>
    public interface IQueryHierarchyProvider
    {
    }

    /// <summary>
    /// Interface IBatchSaveError
    /// </summary>
    public interface IBatchSaveError
    {
    }

    /// <summary>
    /// Interface IPsUserRightsMask
    /// </summary>
    public interface IPsUserRightsMask
    {
    }

    /// <summary>
    /// Interface IQueryHierarchy
    /// </summary>
    public interface IQueryHierarchy
    {
    }

    /// <summary>
    /// Enum SaveFlags
    /// </summary>
    public enum SaveFlags
    {

        // Summary:
        //     No save flags set.
        /// <summary>
        /// The none
        /// </summary>
        None = 0,
        //
        // Summary:
        //     Merge links on save.
        /// <summary>
        /// The merge links
        /// </summary>
        MergeLinks = 1,
        //
        /// <summary>
        /// The merge all
        /// </summary>
        MergeAll = 2,
    }

    /// <summary>
    /// Interface IStoredQuery
    /// </summary>
    public interface IStoredQuery
    {
    }

    /// <summary>
    /// Interface ITeamFoundationServer
    /// </summary>
    public interface ITeamFoundationServer
    {
    }

    /// <summary>
    /// Interface IUserDisplayMode
    /// </summary>
    public interface IUserDisplayMode
    {
    }

    /// <summary>
    /// Interface IQueryDefinition
    /// </summary>
    public interface IQueryDefinition
    {
    }

    /// <summary>
    /// Interface IRegisteredLinkTypeCollection
    /// </summary>
    public interface IRegisteredLinkTypeCollection
    {
    }

    /// <summary>
    /// Interface IBatchReadParameterCollection
    /// </summary>
    public interface IBatchReadParameterCollection
    {
    }

    /// <summary>
    /// Interface IServerInfo
    /// </summary>
    public interface IServerInfo
    {
    }

    /// <summary>
    /// Interface IWorkItemOperationError
    /// </summary>
    public interface IWorkItemOperationError
    {
    }

    /// <summary>
    /// Delegate MetadataChangeEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="args">The arguments.</param>
    public delegate void MetadataChangeEventHandler(object sender, IMetadataChangeEventHandlerArgs args);

    /// <summary>
    /// Interface IMetadataChangeEventHandlerArgs
    /// </summary>
    public interface IMetadataChangeEventHandlerArgs
    {
    }

    /// <summary>
    /// Delegate ImportEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="args">The arguments.</param>
    public delegate void ImportEventHandler(object sender, IImportEventHandlerArgs args);

    /// <summary>
    /// Interface IImportEventHandlerArgs
    /// </summary>
    public interface IImportEventHandlerArgs
    {
    }

    /// <summary>
    /// Interface IWorkItemLinkTypeCollection
    /// </summary>
    public interface IWorkItemLinkTypeCollection
    {
    }

    /// <summary>
    /// Interface IWorkItemStoreDiagnostics
    /// </summary>
    public interface IWorkItemStoreDiagnostics
    {
    }

    /// <summary>
    /// Interface IProjectCollection
    /// </summary>
    public interface IProjectCollection
    {
    }

    /// <summary>
    /// Interface IWorkItemServer
    /// </summary>
    public interface IWorkItemServer
    {
    }

    /// <summary>
    /// public interface IProject
    /// </summary>
    public interface IProject
    {
        /// <summary>
        /// Gets or sets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        IWorkItemTypeCollection WorkItemTypes { get; set; }
        /// <summary>
        /// Gets or sets the area root nodes.
        /// </summary>
        /// <value>The area root nodes.</value>
        IEnumerable<INode> AreaRootNodes { get; set; }
        /// <summary>
        /// Gets or sets the iteration root nodes.
        /// </summary>
        /// <value>The iteration root nodes.</value>
        IEnumerable<INode> IterationRootNodes { get; set; }
        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>The categories.</value>
        ICategoryCollection Categories { get; set; }
    }

    /// <summary>
    /// public interface ICategoryCollection
    /// </summary>
    public interface ICategoryCollection
    {
    }

    /// <summary>
    /// public interface INode
    /// </summary>
    public interface INode
    {
    }

    /// <summary>
    /// public interface IWorkItemTypeCollection
    /// </summary>
    public interface IWorkItemTypeCollection
    {
    }

    /// <summary>
    /// public interface IWorkItemCollection
    /// </summary>
    public interface IWorkItemCollection : IReadOnlyList<IWorkItem>
    {
    }
}