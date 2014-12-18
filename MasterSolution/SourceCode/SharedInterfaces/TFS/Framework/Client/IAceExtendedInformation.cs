namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IAceExtendedInformation
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Int32 InheritedAllow  { get;   }
    System.Int32 InheritedDeny  { get;   }
    System.Int32 EffectiveAllow  { get;   }
    System.Int32 EffectiveDeny  { get;   }
  }
}
