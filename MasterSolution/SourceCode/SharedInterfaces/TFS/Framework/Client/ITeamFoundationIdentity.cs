using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ITeamFoundationIdentity
  {
    Boolean TryGetProperty( String name,out Object value);
    Boolean TryGetProperty( IIdentityPropertyScope propertyScope, String name,out Object value);
    Object GetProperty( String name);
    Object GetProperty( IIdentityPropertyScope propertyScope, String name);
    IEnumerable<KeyValuePair<String,Object>> GetProperties();
    IEnumerable<KeyValuePair<String,Object>> GetProperties( IIdentityPropertyScope propertyScope);
    void SetProperty( String name, Object value);
    void SetProperty( IIdentityPropertyScope propertyScope, String name, Object value);
    void RemoveProperty( String name);
    void RemoveProperty( IIdentityPropertyScope propertyScope, String name);
    String GetAttribute( String name, String defaultValue);
    void SetAttribute( String name, String value);
    void ToXml( XmlWriter writer, String element);
    Boolean IsContainer  { get;   }
    String UniqueName  { get;   }
    IIdentityDescriptor Descriptor  { get; set;   }
    String DisplayName  { get; set;   }
    Boolean IsActive  { get; set;   }
    IIdentityDescriptor[] MemberOf  { get; set;   }
    IIdentityDescriptor[] Members  { get; set;   }
    Guid TeamFoundationId  { get; set;   }
    Int32 UniqueUserId  { get; set;   }
  }
}
