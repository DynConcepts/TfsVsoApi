using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryFolder : IQueryItem ,IEnumerable
  {
    Boolean Contains( String name);
    void Add( IQueryItem item);
    Boolean Contains( IQueryItem item);
    Boolean Contains( Guid id);
    IQueryItem this[Guid id] { get;   }
    IQueryItem this[String name] { get;   }
    Int32 Count  { get;   }
    Boolean IsRootNode  { get;   }
  }
}
