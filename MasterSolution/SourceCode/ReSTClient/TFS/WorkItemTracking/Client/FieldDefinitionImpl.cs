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

        IAllowedValuesCollection IFieldDefinition.AllowedValues { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.CanSortBy { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IFieldType IFieldDefinition.FieldType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IAllowedValuesCollection IFieldDefinition.FilteredAllowedValues(IFieldFilterList filters) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IFieldDefinition.HelpText { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IFieldDefinition.Id { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsCloneable { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsComputed { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsCoreField { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsEditable { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsIndexed { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsInternal { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsLongText { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsQueryable { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsReportable { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsUsedInGlobalWorkflow { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsUsedInWorkItemType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.IsUserNameField { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IFieldDefinition.Name { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IValuesCollection IFieldDefinition.ProhibitedValues { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IPsFieldDefinitionTypeEnum IFieldDefinition.PsFieldType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IFieldDefinition.PsReportingFormula { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IFieldDefinition.PsReportingType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IFieldDefinition.ReferenceName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IReportingAttributes IFieldDefinition.ReportingAttributes { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IFieldDefinition.ReportingName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IFieldDefinition.ReportingReferenceName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IFieldDefinition.SupportsTextQuery { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Type IFieldDefinition.SystemType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IFieldUsages IFieldDefinition.Usage { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IWorkItemStore IFieldDefinition.WorkItemStore { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}