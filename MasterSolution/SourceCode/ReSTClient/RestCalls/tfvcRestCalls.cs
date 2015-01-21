using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class TfvcRestCalls.
    /// </summary>
    internal class TfvcRestCalls
    {
        /*
         /tfvc/branches		GET		_apis/tfvc/branches?api-version=1.0-preview.1
        /tfvc/branches/{deleted}		GET		https://Fabrikam-Fiber-inc.VisualStudio.com/DefaultCollection/_apis/tfvc/branches/$/Fabrikam-Fiber-TFVC/MyBranch?includeDeleted=true&api-version=1.0-preview.1
        /tfvc/branches/{path}		GET		https://Fabrikam-Fiber-inc.VisualStudio.com/DefaultCollection/_apis/tfvc/branches/$/Fabrikam-Fiber-TFVC/AuthSample-Dev?api-version=1.0-preview.1
        /tfvc/changesets		GET		_apis/tfvc/changesets?api-version=1.0
        /tfvc/changesets/{id}		GET		_apis/tfvc/changesets/16?api-version=1.0
        /tfvc/changesets/{id}/changes		GET		_apis/tfvc/changesets/16/changes?api-version=1.0
        /tfvc/changesets/{id}/workitems		GET		_apis/tfvc/changesets/16/workitems?api-version=1.0
        /tfvc/changesetsBatch		POST		_apis/tfvc/changesetsBatch?api-version=1.0
        /tfvc/items		GET		_apis/tfvc/items?scopePath=$/Fabrikam-Fiber-TFVC/AuthSample&api-version=1.0-preview.1
        /tfvc/items/{itempath}		GET		_apis/tfvc/items/$/Fabrikam-Fiber-TFVC/AuthSample/AuthSample.sln?versionType=Changeset&version=9&api-version=1.0-preview.1
        /tfvc/itemBatch		POST		_apis/tfvc/itemBatch?api-version=1.0-preview.1
        /tfvc/labels		GET		_apis/tfvc/labels?api-version=1.0-preview.1
        /tfvc/labels/{labelId}		GET		_apis/tfvc/labels/2883?api-version=1.0-preview.1
        /tfvc/labels/{labelId}/items		GET		_apis/tfvc/labels/2883/items?api-version=1.0-preview.1
        /tfvc/shelvesets		GET		_apis/tfvc/shelvesets?api-version=1.0-preview.1
        /tfvc/shelvesets/{shelvesetId}		GET		_apis/tfvc/shelvesets/My%20first%20shelveset;d6245f20-2af8-44f4-9451-8107cb2767db?api-version=1.0-preview.1
        /tfvc/shelvesets/{shelvesetId}/changes		GET		_apis/tfvc/shelvesets/My%20first%20shelveset;d6245f20-2af8-44f4-9451-8107cb2767db/changes?api-version=1.0-preview.1
        /tfvc/shelvesets/{shelvesetId}/workitems		GET		_apis/tfvc/shelvesets/My%20first%20shelveset;d6245f20-2af8-44f4-9451-8107cb2767db/workitems?api-version=1.0-preview.1
        */
        /// <summary>
        ///     Gets the branches.
        /// </summary>
        /// <value>The branches.</value>
        internal static CallSpec Branches { get { return sr_Branches; } }

        /// <summary>
        ///     Gets the changeset changes.
        /// </summary>
        /// <value>The changeset changes.</value>
        internal static CallSpec ChangesetChanges { get { return sr_ChangesetChanges; } }

        /// <summary>
        ///     Gets the changeset work items.
        /// </summary>
        /// <value>The changeset work items.</value>
        internal static CallSpec ChangesetWorkItems { get { return sr_ChangesetWorkItems; } }

        /// <summary>
        ///     Gets the changesets.
        /// </summary>
        /// <value>The changesets.</value>
        internal static CallSpec Changesets { get { return sr_Changesets; } }

        /// <summary>
        ///     Gets the changesets batch.
        /// </summary>
        /// <value>The changesets batch.</value>
        internal static CallSpec ChangesetsBatch { get { return sr_ChangesetsBatch; } }

        /// <summary>
        ///     Gets the item batch.
        /// </summary>
        /// <value>The item batch.</value>
        internal static CallSpec ItemBatch { get { return sr_ItemBatch; } }

        /// <summary>
        ///     Gets the items.
        /// </summary>
        /// <value>The items.</value>
        internal static CallSpec Items { get { return sr_Items; } }

        /// <summary>
        ///     Gets the label items.
        /// </summary>
        /// <value>The label items.</value>
        internal static CallSpec LabelItems { get { return sr_LabelItems; } }

        /// <summary>
        ///     Gets the labels.
        /// </summary>
        /// <value>The labels.</value>
        internal static CallSpec Labels { get { return sr_Labels; } }

        /// <summary>
        ///     Gets the project info0.
        /// </summary>
        /// <value>The project info0.</value>
        internal static CallSpec ProjectSpecificInfo { get { return sr_ProjectSpecificInfo; } }

        /// <summary>
        ///     Gets the project info1.
        /// </summary>
        /// <value>The project info1.</value>
        internal static CallSpec AllProjectInfo { get { return sr_AllProjectInfo; } }

        /// <summary>
        ///     Gets the shelveset changes0.
        /// </summary>
        /// <value>The shelveset changes0.</value>
        internal static CallSpec ShelvesetChanges { get { return sr_ShelvesetChanges; } }

   
        /// <summary>
        ///     Gets the shelveset work items0.
        /// </summary>
        /// <value>The shelveset work items0.</value>
        internal static CallSpec ShelvesetWorkItems { get { return sr_ShelvesetWorkItems; } }

        /// <summary>
        ///     Gets the shelvesets0.
        /// </summary>
        /// <value>The shelvesets0.</value>
        internal static CallSpec AllShelvesets { get { return sr_AllShelvesets; } }

         /// <summary>
        ///     The SR_ branches
        /// </summary>
        private static readonly CallSpec sr_Branches = new CallSpec("_apis/tfvc/branches");
        private static readonly CallSpec sr_BranchesInPath = new CallSpec("_apis/tfvc/branches/{*path}");

        /// <summary>
        ///     The SR_ changeset changes
        /// </summary>
        private static readonly CallSpec sr_ChangesetChanges = new CallSpec("_apis/tfvc/changesets/{id}/changes");

        /// <summary>
        ///     The SR_ changeset work items
        /// </summary>
        private static readonly CallSpec sr_ChangesetWorkItems = new CallSpec("_apis/tfvc/changesets/{id}/workItems");

        /// <summary>
        ///     The SR_ changesets
        /// </summary>
        private static readonly CallSpec sr_Changesets = new CallSpec("_apis/tfvc/changesets");
        private static readonly CallSpec sr_Changeset = new CallSpec("_apis/tfvc/changesets/{id}");

        /// <summary>
        ///     The SR_ changesets batch
        /// </summary>
        private static readonly CallSpec sr_ChangesetsBatch = new CallSpec("_apis/tfvc/changesetsBatch");

        /// <summary>
        ///     The SR_ item batch
        /// </summary>
        private static readonly CallSpec sr_ItemBatch = new CallSpec("_apis/tfvc/itemBatch");

        /// <summary>
        ///     The SR_ items
        /// </summary>
        private static readonly CallSpec sr_Items = new CallSpec("_apis/tfvc/items");
        private static readonly CallSpec sr_Item = new CallSpec("_apis/tfvc/items/{*path}");

        /// <summary>
        ///     The SR_ label items
        /// </summary>
        private static readonly CallSpec sr_LabelItems = new CallSpec("_apis/tfvc/labels/{labelId}/items");

        /// <summary>
        ///     The SR_ labels
        /// </summary>
        private static readonly CallSpec sr_Labels = new CallSpec("_apis/tfvc/labels");
        private static readonly CallSpec sr_Label = new CallSpec("_apis/tfvc/labels/{labelId}");

        /// <summary>
        ///     The SR_ project info0
        /// </summary>
        private static readonly CallSpec sr_ProjectSpecificInfo = new CallSpec("_apis/tfvc/{projectId}/projectInfo");

        /// <summary>
        ///     The SR_ project info1
        /// </summary>
        private static readonly CallSpec sr_AllProjectInfo = new CallSpec("_apis/tfvc/projectInfo");

        /// <summary>
        /// The SR_ shelveset changes
        /// </summary>
        private static readonly CallSpec sr_ShelvesetChanges = new CallSpec("_apis/tfvc/shelvesets/{shelvesetId}/changes");
        /// <summary>
        /// The SR_ shelveset work items
        /// </summary>
        private static readonly CallSpec sr_ShelvesetWorkItems = new CallSpec("_apis/tfvc/shelvesets/{shelvesetId}/workitems");


        /// <summary>
        /// The SR_ all shelvesets
        /// </summary>
        private static readonly CallSpec sr_AllShelvesets = new CallSpec("_apis/tfvc/shelvesets");

        /// <summary>
        /// The SR_ single shelveset
        /// </summary>
        private static readonly CallSpec sr_SingleShelveset = new CallSpec("_apis/tfvc/shelvesets/{shelvesetId}");
    }
}