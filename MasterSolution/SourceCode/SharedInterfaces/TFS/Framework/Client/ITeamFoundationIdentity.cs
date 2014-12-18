namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ITeamFoundationIdentity
  {
    System.Boolean TryGetProperty( System.String name,out System.Object value);
    System.Boolean TryGetProperty( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IIdentityPropertyScope propertyScope, System.String name,out System.Object value);
    System.Object GetProperty( System.String name);
    System.Object GetProperty( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IIdentityPropertyScope propertyScope, System.String name);
    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>> GetProperties();
    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>> GetProperties( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IIdentityPropertyScope propertyScope);
    void SetProperty( System.String name, System.Object value);
    void SetProperty( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IIdentityPropertyScope propertyScope, System.String name, System.Object value);
    void RemoveProperty( System.String name);
    void RemoveProperty( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IIdentityPropertyScope propertyScope, System.String name);
    System.String GetAttribute( System.String name, System.String defaultValue);
    void SetAttribute( System.String name, System.String value);
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Boolean IsContainer  { get;   }
    System.String UniqueName  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor Descriptor  { get; set;   }
    System.String DisplayName  { get; set;   }
    System.Boolean IsActive  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor[] MemberOf  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor[] Members  { get; set;   }
    System.Guid TeamFoundationId  { get; set;   }
    System.Int32 UniqueUserId  { get; set;   }
  }
}
