using System;
using System.Diagnostics;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldImpl.
    /// </summary>
    [DebuggerDisplay("{ReferenceName}={Value}")]
    internal class FieldImpl : JsonField, IField
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        private FieldImpl(JToken json) : base(json) {
        }

        /// <summary>
        /// Gets the allowed values.
        /// </summary>
        /// <value>The allowed values.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IAllowedValuesCollection IField.AllowedValues { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the field definition.
        /// </summary>
        /// <value>The field definition.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldDefinition IField.FieldDefinition { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the has allowed values list.
        /// </summary>
        /// <value>The has allowed values list.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.HasAllowedValuesList { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the has pattern match.
        /// </summary>
        /// <value>The has pattern match.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.HasPatternMatch { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Int32 IField.Id { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the is changed by user.
        /// </summary>
        /// <value>The is changed by user.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.IsChangedByUser { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the is changed in revision.
        /// </summary>
        /// <value>The is changed in revision.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.IsChangedInRevision { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the is computed.
        /// </summary>
        /// <value>The is computed.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.IsComputed { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.IsDirty { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the is editable.
        /// </summary>
        /// <value>The is editable.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.IsEditable { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the is limited to allowed values.
        /// </summary>
        /// <value>The is limited to allowed values.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.IsLimitedToAllowedValues { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the is required.
        /// </summary>
        /// <value>The is required.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.IsRequired { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the is valid.
        /// </summary>
        /// <value>The is valid.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IField.IsValid { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String IField.Name { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the original value.
        /// </summary>
        /// <value>The original value.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Object IField.OriginalValue { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the prohibited values.
        /// </summary>
        /// <value>The prohibited values.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IValuesCollection IField.ProhibitedValues { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        String IField.ReferenceName { get { return ReferenceName; } }
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldStatus IField.Status { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        /// s
        Object IField.Value { get { return Value; } set { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the value with server default.
        /// </summary>
        /// <value>The value with server default.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Object IField.ValueWithServerDefault { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItem IField.WorkItem { get { throw new ToBeImplementedException(); } }

        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>IField.</returns>
        public static new IField FromToken(JToken token)
        {
            var instance = new FieldImpl(token);
            return instance;
        }
    }
}