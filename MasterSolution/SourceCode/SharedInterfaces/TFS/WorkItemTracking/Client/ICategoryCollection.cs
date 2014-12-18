namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ICategoryCollection : System.Collections.IEnumerable
  {
    void Import( System.IO.Stream stream);
    void Import( System.String categories);
    void Import( System.Xml.XmlElement categoriesElement);
    System.Xml.XmlDocument Export();
    System.Boolean Contains( System.String name);
    System.Int32 Count  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ICategory this[System.Int32 index] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ICategory this[System.String name] { get;   }
  }
}
