namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface ILinkInfo
  {
    System.String Comment  { get; set;   }
    System.Int32 FieldId  { get; set;   }
    System.DateTime AuthorizedAddedDate  { get; set;   }
    System.DateTime AuthorizedRemovedDate  { get; set;   }
  }
}
