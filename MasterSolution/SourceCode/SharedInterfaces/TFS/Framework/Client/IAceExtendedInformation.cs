using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IAceExtendedInformation
  {
    void ToXml( XmlWriter writer, String element);
    Int32 InheritedAllow  { get;   }
    Int32 InheritedDeny  { get;   }
    Int32 EffectiveAllow  { get;   }
    Int32 EffectiveDeny  { get;   }
  }
}
