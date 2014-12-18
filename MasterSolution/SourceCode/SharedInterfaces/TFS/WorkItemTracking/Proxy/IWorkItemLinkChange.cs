namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IWorkItemLinkChange
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.DateTime ChangedDate  { get; set;   }
    System.Boolean IsActive  { get; set;   }
    System.String LinkType  { get; set;   }
    System.Int64 RowVersion  { get; set;   }
    System.Int32 SourceID  { get; set;   }
    System.Int32 TargetID  { get; set;   }
  }
}
