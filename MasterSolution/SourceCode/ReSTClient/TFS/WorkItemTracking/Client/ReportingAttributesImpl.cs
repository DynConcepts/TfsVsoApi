using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ReportingAttributesImpl : IReportingAttributes
    {
        String IReportingAttributes.Name { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IReportingAttributes.ReferenceName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IReportingType IReportingAttributes.Type { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}