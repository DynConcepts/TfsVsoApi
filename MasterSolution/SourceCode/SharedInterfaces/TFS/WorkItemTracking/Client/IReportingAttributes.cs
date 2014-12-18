using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IReportingAttributes
  {
    String Name  { get;   }
    String ReferenceName  { get;   }
    IReportingType Type  { get;   }
  }
}
