using System;
using System.Collections;
using System.IO;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ICategoryCollection : IEnumerable
  {
    void Import( Stream stream);
    void Import( String categories);
    void Import( XmlElement categoriesElement);
    XmlDocument Export();
    Boolean Contains( String name);
    Int32 Count  { get;   }
    ICategory this[Int32 index] { get;   }
    ICategory this[String name] { get;   }
  }
}
