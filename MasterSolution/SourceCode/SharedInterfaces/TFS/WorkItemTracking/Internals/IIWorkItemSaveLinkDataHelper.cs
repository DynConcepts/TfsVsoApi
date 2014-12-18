using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface IIWorkItemSaveLinkDataHelper
  {
    void ResetWorkItemLinkInfo();
    void AddWorkItemLinkInfo( IWorkItemLinkInfo link);
    IEnumerable<ILinkInfo> DeletedLinks  { get;   }
    IEnumerable<ILinkInfo> AddedLinks  { get;   }
    IEnumerable<KeyValuePair<ILinkInfo,ILinkUpdate>> UpdatedLinks  { get;   }
  }
}
