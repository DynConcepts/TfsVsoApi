using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class FieldDefinitionImpl.
    /// </summary>
    internal class FieldDefinitionImpl : JsonFieldDefinition, IFieldDefinition
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>FieldDefinitionImpl.</returns>
        public new static FieldDefinitionImpl FromToken(JToken value)
        {
            var instance = new FieldDefinitionImpl(value);
            return instance;
        }


        /// <summary>
        ///     Gets the allowed values.
        /// </summary>
        /// <value>The allowed values.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAllowedValuesCollection IFieldDefinition.AllowedValues { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the can sort by.
        /// </summary>
        /// <value>The can sort by.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.CanSortBy { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IFieldType IFieldDefinition.FieldType { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Filtereds the allowed values.
        /// </summary>
        /// <param name="filters">The filters.</param>
        /// <returns>IAllowedValuesCollection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAllowedValuesCollection IFieldDefinition.FilteredAllowedValues(IFieldFilterList filters) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the help text.
        /// </summary>
        /// <value>The help text.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IFieldDefinition.HelpText { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IFieldDefinition.Id { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is cloneable.
        /// </summary>
        /// <value>The is cloneable.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsCloneable { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is computed.
        /// </summary>
        /// <value>The is computed.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsComputed { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is core field.
        /// </summary>
        /// <value>The is core field.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsCoreField { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is editable.
        /// </summary>
        /// <value>The is editable.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsEditable { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is indexed.
        /// </summary>
        /// <value>The is indexed.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsIndexed { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is internal.
        /// </summary>
        /// <value>The is internal.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsInternal { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is long text.
        /// </summary>
        /// <value>The is long text.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsLongText { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is queryable.
        /// </summary>
        /// <value>The is queryable.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsQueryable { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is reportable.
        /// </summary>
        /// <value>The is reportable.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsReportable { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is used in global workflow.
        /// </summary>
        /// <value>The is used in global workflow.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsUsedInGlobalWorkflow { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type of the is used in work item.
        /// </summary>
        /// <value>The type of the is used in work item.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsUsedInWorkItemType { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is user name field.
        /// </summary>
        /// <value>The is user name field.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.IsUserNameField { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IFieldDefinition.Name { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the prohibited values.
        /// </summary>
        /// <value>The prohibited values.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IValuesCollection IFieldDefinition.ProhibitedValues { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type of the ps field.
        /// </summary>
        /// <value>The type of the ps field.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IPsFieldDefinitionTypeEnum IFieldDefinition.PsFieldType { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the ps reporting formula.
        /// </summary>
        /// <value>The ps reporting formula.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IFieldDefinition.PsReportingFormula { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type of the ps reporting.
        /// </summary>
        /// <value>The type of the ps reporting.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IFieldDefinition.PsReportingType { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IFieldDefinition.ReferenceName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the reporting attributes.
        /// </summary>
        /// <value>The reporting attributes.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IReportingAttributes IFieldDefinition.ReportingAttributes { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name of the reporting.
        /// </summary>
        /// <value>The name of the reporting.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IFieldDefinition.ReportingName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name of the reporting reference.
        /// </summary>
        /// <value>The name of the reporting reference.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IFieldDefinition.ReportingReferenceName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the supports text query.
        /// </summary>
        /// <value>The supports text query.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldDefinition.SupportsTextQuery { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type of the system.
        /// </summary>
        /// <value>The type of the system.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Type IFieldDefinition.SystemType { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the usage.
        /// </summary>
        /// <value>The usage.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IFieldUsages IFieldDefinition.Usage { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the work item store.
        /// </summary>
        /// <value>The work item store.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemStore IFieldDefinition.WorkItemStore { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public FieldDefinitionImpl(JToken json)
            : base(json) { }
    }
}