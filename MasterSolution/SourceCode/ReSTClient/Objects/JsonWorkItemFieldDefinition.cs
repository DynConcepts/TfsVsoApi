using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    ///     Implements Functionallity of a JSON Backed TFS/VSO WorkItemFieldDefinition.
    /// </summary>
    internal class JsonWorkItemFieldDefinition : IWorkItemFieldDefinition
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <returns>IWorkItemFieldDefinition.</returns>
        public static IWorkItemFieldDefinition FromToken(JToken entry)
        {
            var fieldDefinition = new JsonWorkItemFieldDefinition();
            foreach (JProperty property in entry)
            {
                switch (property.Name)
                {
                    case "name":
                        fieldDefinition.Name = (String) property;
                        break;
                    case "referenceName":
                        fieldDefinition.ReferenceName = (String) property;
                        break;
                    case "type":
                        fieldDefinition.Type = sr_TypeMap[(String) property];
                        break;
                    case "readOnly":
                        fieldDefinition.ReadOInly = (bool) property;
                        break;
                    case "supportedOperations":
                        break;
                    default:
                        break;
                    case "helpText":
                        break;
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
        public string Name { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether [read o inly].
        /// </summary>
        /// <value><c>true</c> if [read o inly]; otherwise, <c>false</c>.</value>
        public bool ReadOInly { get; private set; }

        /// <summary>
        ///     Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        public string ReferenceName { get; private set; }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public Type Type { get; private set; }

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
}