using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class TfvcRestCalls.
    /// </summary>
    internal class TfvcRestCalls
    {
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
        internal static CallSpec ProjectInfo0 { get { return sr_ProjectInfo0; } }

        /// <summary>
        ///     Gets the project info1.
        /// </summary>
        /// <value>The project info1.</value>
        internal static CallSpec ProjectInfo1 { get { return sr_ProjectInfo1; } }

        /// <summary>
        ///     Gets the shelveset changes0.
        /// </summary>
        /// <value>The shelveset changes0.</value>
        internal static CallSpec ShelvesetChanges0 { get { return sr_ShelvesetChanges0; } }

        /// <summary>
        ///     Gets the shelveset changes1.
        /// </summary>
        /// <value>The shelveset changes1.</value>
        internal static CallSpec ShelvesetChanges1 { get { return sr_ShelvesetChanges1; } }

        /// <summary>
        ///     Gets the shelveset work items0.
        /// </summary>
        /// <value>The shelveset work items0.</value>
        internal static CallSpec ShelvesetWorkItems0 { get { return sr_ShelvesetWorkItems0; } }

        /// <summary>
        ///     Gets the shelveset work items1.
        /// </summary>
        /// <value>The shelveset work items1.</value>
        internal static CallSpec ShelvesetWorkItems1 { get { return sr_ShelvesetWorkItems1; } }

        /// <summary>
        ///     Gets the shelvesets0.
        /// </summary>
        /// <value>The shelvesets0.</value>
        internal static CallSpec Shelvesets0 { get { return sr_Shelvesets0; } }

        /// <summary>
        ///     Gets the shelvesets1.
        /// </summary>
        /// <value>The shelvesets1.</value>
        internal static CallSpec Shelvesets1 { get { return sr_Shelvesets1; } }

        /// <summary>
        ///     The SR_ branches
        /// </summary>
        private static readonly CallSpec sr_Branches = new CallSpec("_apis/tfvc/branches/{*path}");

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
        private static readonly CallSpec sr_Changesets = new CallSpec("_apis/tfvc/changesets/{id}");

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
        private static readonly CallSpec sr_Items = new CallSpec("_apis/tfvc/items/{*path}");

        /// <summary>
        ///     The SR_ label items
        /// </summary>
        private static readonly CallSpec sr_LabelItems = new CallSpec("_apis/tfvc/labels/{labelId}/items");

        /// <summary>
        ///     The SR_ labels
        /// </summary>
        private static readonly CallSpec sr_Labels = new CallSpec("_apis/tfvc/labels/{labelId}");

        /// <summary>
        ///     The SR_ project info0
        /// </summary>
        private static readonly CallSpec sr_ProjectInfo0 = new CallSpec("_apis/tfvc/{projectId}/projectInfo");

        /// <summary>
        ///     The SR_ project info1
        /// </summary>
        private static readonly CallSpec sr_ProjectInfo1 = new CallSpec("_apis/tfvc/projectInfo");

        /// <summary>
        ///     The SR_ shelveset changes0
        /// </summary>
        private static readonly CallSpec sr_ShelvesetChanges0 = new CallSpec("_apis/tfvc/shelvesets/{shelvesetId}/changes");

        /// <summary>
        ///     The SR_ shelveset changes1
        /// </summary>
        private static readonly CallSpec sr_ShelvesetChanges1 = new CallSpec("_apis/tfvc/shelvesets/changes");

        /// <summary>
        ///     The SR_ shelveset work items0
        /// </summary>
        private static readonly CallSpec sr_ShelvesetWorkItems0 = new CallSpec("_apis/tfvc/shelvesets/{shelvesetId}/workitems");

        /// <summary>
        ///     The SR_ shelveset work items1
        /// </summary>
        private static readonly CallSpec sr_ShelvesetWorkItems1 = new CallSpec("_apis/tfvc/shelvesets/workitems");

        /// <summary>
        ///     The SR_ shelvesets0
        /// </summary>
        private static readonly CallSpec sr_Shelvesets0 = new CallSpec("_apis/tfvc/shelvesets");

        /// <summary>
        ///     The SR_ shelvesets1
        /// </summary>
        private static readonly CallSpec sr_Shelvesets1 = new CallSpec("_apis/tfvc/shelvesets/{shelvesetId}");
    }
}