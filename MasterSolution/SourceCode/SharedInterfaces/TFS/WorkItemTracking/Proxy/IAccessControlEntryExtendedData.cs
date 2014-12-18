namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IAccessControlEntryExtendedData
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Int32 EffectiveAllow  { get; set;   }
    System.Int32 EffectiveDeny  { get; set;   }
    System.Int32 InheritedAllow  { get; set;   }
    System.Int32 InheritedDeny  { get; set;   }
  }
}
