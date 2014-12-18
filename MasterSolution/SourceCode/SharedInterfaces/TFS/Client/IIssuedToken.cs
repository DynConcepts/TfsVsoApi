using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IIssuedToken
  {
    Boolean IsAuthenticated  { get;   }
  }
}
