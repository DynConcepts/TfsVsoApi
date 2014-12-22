class tfvcRestCalls
{
 internal static CallSpec projectInfo_0 { get { return sr_projectInfo_0; } }
 private static readonly CallSpec sr_projectInfo_0= new CallSpec("_apis/tfvc/{projectId}/projectInfo");
 internal static CallSpec projectInfo_1 { get { return sr_projectInfo_1; } }
 private static readonly CallSpec sr_projectInfo_1= new CallSpec("_apis/tfvc/projectInfo");
 internal static CallSpec items { get { return sr_items; } }
 private static readonly CallSpec sr_items= new CallSpec("_apis/tfvc/items/{*path}");
 internal static CallSpec itemBatch { get { return sr_itemBatch; } }
 private static readonly CallSpec sr_itemBatch= new CallSpec("_apis/tfvc/itemBatch");
 internal static CallSpec changesetChanges { get { return sr_changesetChanges; } }
 private static readonly CallSpec sr_changesetChanges= new CallSpec("_apis/tfvc/changesets/{id}/changes");
 internal static CallSpec changesetWorkItems { get { return sr_changesetWorkItems; } }
 private static readonly CallSpec sr_changesetWorkItems= new CallSpec("_apis/tfvc/changesets/{id}/workItems");
 internal static CallSpec changesets { get { return sr_changesets; } }
 private static readonly CallSpec sr_changesets= new CallSpec("_apis/tfvc/changesets/{id}");
 internal static CallSpec changesetsBatch { get { return sr_changesetsBatch; } }
 private static readonly CallSpec sr_changesetsBatch= new CallSpec("_apis/tfvc/changesetsBatch");
 internal static CallSpec shelvesetChanges_0 { get { return sr_shelvesetChanges_0; } }
 private static readonly CallSpec sr_shelvesetChanges_0= new CallSpec("_apis/tfvc/shelvesets/{shelvesetId}/changes");
 internal static CallSpec shelvesetChanges_1 { get { return sr_shelvesetChanges_1; } }
 private static readonly CallSpec sr_shelvesetChanges_1= new CallSpec("_apis/tfvc/shelvesets/changes");
 internal static CallSpec shelvesetWorkItems_0 { get { return sr_shelvesetWorkItems_0; } }
 private static readonly CallSpec sr_shelvesetWorkItems_0= new CallSpec("_apis/tfvc/shelvesets/{shelvesetId}/workitems");
 internal static CallSpec shelvesetWorkItems_1 { get { return sr_shelvesetWorkItems_1; } }
 private static readonly CallSpec sr_shelvesetWorkItems_1= new CallSpec("_apis/tfvc/shelvesets/workitems");
 internal static CallSpec shelvesets_0 { get { return sr_shelvesets_0; } }
 private static readonly CallSpec sr_shelvesets_0= new CallSpec("_apis/tfvc/shelvesets");
 internal static CallSpec shelvesets_1 { get { return sr_shelvesets_1; } }
 private static readonly CallSpec sr_shelvesets_1= new CallSpec("_apis/tfvc/shelvesets/{shelvesetId}");
 internal static CallSpec labels { get { return sr_labels; } }
 private static readonly CallSpec sr_labels= new CallSpec("_apis/tfvc/labels/{labelId}");
 internal static CallSpec labelItems { get { return sr_labelItems; } }
 private static readonly CallSpec sr_labelItems= new CallSpec("_apis/tfvc/labels/{labelId}/items");
 internal static CallSpec branches { get { return sr_branches; } }
 private static readonly CallSpec sr_branches= new CallSpec("_apis/tfvc/branches/{*path}");
}
