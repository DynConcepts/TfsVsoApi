using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class FieldFilterImpl : IFieldFilter
    {
        IFieldDefinition IFieldFilter.FieldDefinition { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Object IFieldFilter.Value { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}