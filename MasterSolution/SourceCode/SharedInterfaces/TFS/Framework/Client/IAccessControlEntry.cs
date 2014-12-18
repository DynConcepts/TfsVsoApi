namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IAccessControlEntry
  {
    System.Int32 Allow  { get; set;   }
    System.Int32 Deny  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor Descriptor  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAceExtendedInformation ExtendedInfo  { get; set;   }
    System.Boolean IsEmpty  { get;   }
  }
}
