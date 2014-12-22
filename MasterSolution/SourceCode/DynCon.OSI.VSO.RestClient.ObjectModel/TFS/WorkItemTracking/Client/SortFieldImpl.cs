using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class SortFieldImpl : ISortField
    {
        IFieldDefinition ISortField.FieldDefinition { get { throw new ToBeImplementedException(); } }
        ISortType ISortField.SortType { get { throw new ToBeImplementedException(); } }
    }
}