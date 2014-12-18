using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class FieldFilterImpl : IFieldFilter
    {
        IFieldDefinition IFieldFilter.FieldDefinition { get { throw new ToBeImplementedException(); } }
        Object IFieldFilter.Value { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}