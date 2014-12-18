using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Server
{
  public interface IIdentity : IComparable ,IITfsXmlSerializable
  {
    void ToXml( XmlWriter writer, String element);
    IIdentityType Type  { get; set;   }
    String Sid  { get; set;   }
    Guid TeamFoundationId  { get; set;   }
    String DisplayName  { get; set;   }
    String Description  { get; set;   }
    String Domain  { get; set;   }
    String AccountName  { get; set;   }
    String DistinguishedName  { get; set;   }
    String MailAddress  { get; set;   }
    IApplicationGroupSpecialType SpecialType  { get; set;   }
    Boolean Deleted  { get; set;   }
    String[] Members  { get; set;   }
    String[] MemberOf  { get; set;   }
    Boolean SecurityGroup  { get; set;   }
  }
}
