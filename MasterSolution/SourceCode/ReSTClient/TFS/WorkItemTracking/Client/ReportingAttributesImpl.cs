using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ReportingAttributesImpl : IReportingAttributes
    {
        String IReportingAttributes.Name { get { throw new ToBeImplementedException(); } }
        String IReportingAttributes.ReferenceName { get { throw new ToBeImplementedException(); } }
        IReportingType IReportingAttributes.Type { get { throw new ToBeImplementedException(); } }
    }
}