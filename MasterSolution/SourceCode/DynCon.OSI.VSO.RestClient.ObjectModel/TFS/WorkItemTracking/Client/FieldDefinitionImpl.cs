using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class FieldDefinitionImpl : JsonFieldDefinition, IFieldDefinition
    {
        public new static FieldDefinitionImpl FromToken(JToken value)
        {
            var instance = new FieldDefinitionImpl(value);
            return instance;
        }
        

        public FieldDefinitionImpl(JToken json)
            : base(json)
        {
        }

        IAllowedValuesCollection IFieldDefinition.AllowedValues { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.CanSortBy { get { throw new ToBeImplementedException(); } }
        IFieldType IFieldDefinition.FieldType { get { throw new ToBeImplementedException(); } }
        IAllowedValuesCollection IFieldDefinition.FilteredAllowedValues(IFieldFilterList filters) { throw new ToBeImplementedException(); }
        String IFieldDefinition.HelpText { get { throw new ToBeImplementedException(); } }
        Int32 IFieldDefinition.Id { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsCloneable { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsComputed { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsCoreField { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsEditable { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsIndexed { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsInternal { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsLongText { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsQueryable { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsReportable { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsUsedInGlobalWorkflow { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsUsedInWorkItemType { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsUserNameField { get { throw new ToBeImplementedException(); } }
        String IFieldDefinition.Name { get { throw new ToBeImplementedException(); } }
        IValuesCollection IFieldDefinition.ProhibitedValues { get { throw new ToBeImplementedException(); } }
        IPsFieldDefinitionTypeEnum IFieldDefinition.PsFieldType { get { throw new ToBeImplementedException(); } }
        Int32 IFieldDefinition.PsReportingFormula { get { throw new ToBeImplementedException(); } }
        Int32 IFieldDefinition.PsReportingType { get { throw new ToBeImplementedException(); } }
        String IFieldDefinition.ReferenceName { get { throw new ToBeImplementedException(); } }
        IReportingAttributes IFieldDefinition.ReportingAttributes { get { throw new ToBeImplementedException(); } }
        String IFieldDefinition.ReportingName { get { throw new ToBeImplementedException(); } }
        String IFieldDefinition.ReportingReferenceName { get { throw new ToBeImplementedException(); } }
        Boolean IFieldDefinition.SupportsTextQuery { get { throw new ToBeImplementedException(); } }
        Type IFieldDefinition.SystemType { get { throw new ToBeImplementedException(); } }
        IFieldUsages IFieldDefinition.Usage { get { throw new ToBeImplementedException(); } }
        IWorkItemStore IFieldDefinition.WorkItemStore { get { throw new ToBeImplementedException(); } }
    }
}