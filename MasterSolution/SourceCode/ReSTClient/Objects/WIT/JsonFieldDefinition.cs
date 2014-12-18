using System;
using System.Collections.Generic;
using System.Diagnostics;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    ///     Implements Functionallity of a JSON Backed TFS/VSO WorkItemFieldDefinition.
    /// </summary>
    [DebuggerDisplay("{ReferenceName}")]
    public class JsonFieldDefinition : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <returns>JsonFieldDefinition.</returns>
        public static JsonFieldDefinition FromToken(JToken entry)
        {
            var fieldDefinition = new JsonFieldDefinition(entry);
            foreach (JProperty property in entry)
            {
                switch (property.Name)
                {
                    case "supportedOperations":
                    case "helpText":
                    case "url":
                        break;
                }
            }
             return fieldDefinition;
        }
    
   
   
        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }

    
        /// <summary>
        ///     Gets a value indicating whether [read o inly].
        /// </summary>
        /// <value><c>true</c> if [read o inly]; otherwise, <c>false</c>.</value>
        public bool ReadOnly { get { return sr_ReadOnly.Eval(this); } }

        /// <summary>
        ///     Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        public string ReferenceName { get { return sr_ReferenceName.Eval(this); } }

  
  
    
        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public Type Type { get { return sr_TypeMap[sr_Type.Eval(this)]; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonFieldDefinition(JToken json) : base(json)
        {
            if (ReferenceName == "System.WorkItemType")
                Console.WriteLine();
        }

        /// <summary>
        ///     The SR_ name
        /// </summary>
        private static readonly JsonBackedField<String> sr_Name = new JsonBackedField<String>("name");

        /// <summary>
        ///     The SR_ read only
        /// </summary>
        private static readonly JsonBackedField<bool> sr_ReadOnly = new JsonBackedField<bool>("readOnly");

        /// <summary>
        ///     The SR_ reference name
        /// </summary>
        private static readonly JsonBackedField<String> sr_ReferenceName = new JsonBackedField<String>("referenceName");

        /// <summary>
        ///     The SR_ type
        /// </summary>
        private static readonly JsonBackedField<String> sr_Type = new JsonBackedField<String>("type");

        /// <summary>
        ///     The _type map
        /// </summary>
        private static readonly Dictionary<string, Type> sr_TypeMap = new Dictionary<string, Type>
        {
            {"integer", typeof (Int32)},
            {"string", typeof (String)},
            {"plainText", typeof (String)},
            {"html", typeof (String)},
            {"history", typeof (String)},
            {"dateTime", typeof (DateTime)},
            {"double", typeof (Double)},
            {"boolean", typeof (Boolean)},
            {"treePath", typeof (String)}
        };
    }

    public enum PsFieldDefinitionTypeEnum
    {
    }

}