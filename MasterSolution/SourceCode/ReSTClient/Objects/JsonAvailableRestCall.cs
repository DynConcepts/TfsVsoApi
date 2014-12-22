using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    ///     Class JsonAvailableRestCall.
    /// </summary>
    public class JsonAvailableRestCall : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>IAvailableRestCalls.</returns>
        public static JsonAvailableRestCall FromToken(JToken token)
        {
            var instance = new JsonAvailableRestCall(token);
            return instance;
        }

        /// <summary>
        ///     Gets the area.
        /// </summary>
        /// <value>The area.</value>
        public String Area { get { return sr_Area.Eval(this); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get { return Guid.Parse(sr_Id.Eval(this)); } }

        /// <summary>
        ///     Gets the maximum version.
        /// </summary>
        /// <value>The maximum version.</value>
        public String MaxVersion { get { return sr_MaxVersion.Eval(this); } }

        /// <summary>
        ///     Gets the minimum version.
        /// </summary>
        /// <value>The minimum version.</value>
        public String MinVersion { get { return sr_MinVersion.Eval(this); } }

        /// <summary>
        ///     Gets the released version.
        /// </summary>
        /// <value>The released version.</value>
        public String ReleasedVersion { get { return sr_ReleasedVersion.Eval(this); } }

        /// <summary>
        ///     Gets the name of the resource.
        /// </summary>
        /// <value>The name of the resource.</value>
        public String ResourceName { get { return sr_ResourceName.Eval(this); } }

        /// <summary>
        ///     Gets the resource version.
        /// </summary>
        /// <value>The resource version.</value>
        public String ResourceVersion { get { return sr_ResourceVersion.Eval(this); } }

        /// <summary>
        ///     Gets the route template.
        /// </summary>
        /// <value>The route template.</value>
        public String RouteTemplate { get { return sr_RouteTemplate.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonAvailableRestCall" /> class.
        /// </summary>
        /// <param name="token">The token.</param>
        private JsonAvailableRestCall(JToken token) : base(token) { }

        /// <summary>
        ///     The _area
        /// </summary>
        private static readonly JsonBackedField<String> sr_Area = new JsonBackedField<String>("area");

        /// <summary>
        ///     The _id
        /// </summary>
        private static readonly JsonBackedField<String> sr_Id = new JsonBackedField<String>("id");

        /// <summary>
        ///     The _max version
        /// </summary>
        private static readonly JsonBackedField<String> sr_MaxVersion = new JsonBackedField<String>("maxVersion");

        /// <summary>
        ///     The _min version
        /// </summary>
        private static readonly JsonBackedField<String> sr_MinVersion = new JsonBackedField<String>("minVersion");

        /// <summary>
        ///     The _released version
        /// </summary>
        private static readonly JsonBackedField<String> sr_ReleasedVersion = new JsonBackedField<String>("releasedVersion");

        /// <summary>
        ///     The _resource name
        /// </summary>
        private static readonly JsonBackedField<String> sr_ResourceName = new JsonBackedField<String>("resourceName");

        /// <summary>
        ///     The _resource version
        /// </summary>
        private static readonly JsonBackedField<String> sr_ResourceVersion = new JsonBackedField<String>("resourceVersion");

        /// <summary>
        ///     The _route template
        /// </summary>
        private static readonly JsonBackedField<String> sr_RouteTemplate = new JsonBackedField<String>("routeTemplate");
    }
}