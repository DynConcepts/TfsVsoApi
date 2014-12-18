using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IAccessControlEntry
  {
    Int32 Allow  { get; set;   }
    Int32 Deny  { get; set;   }
    IIdentityDescriptor Descriptor  { get; set;   }
    IAceExtendedInformation ExtendedInfo  { get; set;   }
    Boolean IsEmpty  { get;   }
  }
}
