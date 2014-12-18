using System;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class FieldImpl : JsonField, IField
    {
        private FieldImpl(JToken json) : base(json) {
        }

        IAllowedValuesCollection IField.AllowedValues { get { throw new ToBeImplementedException(); } }
        IFieldDefinition IField.FieldDefinition { get { throw new ToBeImplementedException(); } }
        Boolean IField.HasAllowedValuesList { get { throw new ToBeImplementedException(); } }
        Boolean IField.HasPatternMatch { get { throw new ToBeImplementedException(); } }
        Int32 IField.Id { get { throw new ToBeImplementedException(); } }
        Boolean IField.IsChangedByUser { get { throw new ToBeImplementedException(); } }
        Boolean IField.IsChangedInRevision { get { throw new ToBeImplementedException(); } }
        Boolean IField.IsComputed { get { throw new ToBeImplementedException(); } }
        Boolean IField.IsDirty { get { throw new ToBeImplementedException(); } }
        Boolean IField.IsEditable { get { throw new ToBeImplementedException(); } }
        Boolean IField.IsLimitedToAllowedValues { get { throw new ToBeImplementedException(); } }
        Boolean IField.IsRequired { get { throw new ToBeImplementedException(); } }
        Boolean IField.IsValid { get { throw new ToBeImplementedException(); } }
        String IField.Name { get { throw new ToBeImplementedException(); } }
        Object IField.OriginalValue { get { throw new ToBeImplementedException(); } }
        IValuesCollection IField.ProhibitedValues { get { throw new ToBeImplementedException(); } }
        String IField.ReferenceName { get { return base.ReferenceName; } }
        IFieldStatus IField.Status { get { throw new ToBeImplementedException(); } }
        Object IField.Value { get { return base.Value; } set { throw new ToBeImplementedException(); } }
        Object IField.ValueWithServerDefault { get { throw new ToBeImplementedException(); } }
        IWorkItem IField.WorkItem { get { throw new ToBeImplementedException(); } }

        public static new IField FromToken(JToken token)
        {
            var instance = new FieldImpl(token);
            return instance;
        }
    }
}