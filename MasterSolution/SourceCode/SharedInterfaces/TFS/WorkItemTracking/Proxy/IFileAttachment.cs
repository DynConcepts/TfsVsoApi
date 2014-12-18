namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IFileAttachment
  {
    System.Guid FileNameGUID  { get; set;   }
    System.String AreaNodeUri  { get; set;   }
    System.String ProjectUri  { get; set;   }
    System.IO.Stream LocalFile  { get; set;   }
  }
}
