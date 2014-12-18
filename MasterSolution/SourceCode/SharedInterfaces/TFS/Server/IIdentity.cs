namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Server
{
  public interface IIdentity : System.IComparable ,DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsXmlSerializable
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentityType Type  { get; set;   }
    System.String Sid  { get; set;   }
    System.Guid TeamFoundationId  { get; set;   }
    System.String DisplayName  { get; set;   }
    System.String Description  { get; set;   }
    System.String Domain  { get; set;   }
    System.String AccountName  { get; set;   }
    System.String DistinguishedName  { get; set;   }
    System.String MailAddress  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IApplicationGroupSpecialType SpecialType  { get; set;   }
    System.Boolean Deleted  { get; set;   }
    System.String[] Members  { get; set;   }
    System.String[] MemberOf  { get; set;   }
    System.Boolean SecurityGroup  { get; set;   }
  }
}
