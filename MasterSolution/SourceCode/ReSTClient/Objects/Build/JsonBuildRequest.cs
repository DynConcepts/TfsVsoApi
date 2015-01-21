using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Build
{
    /// <summary>
    ///     Class JsonBuildRequest.
    /// </summary>
    internal class JsonBuildRequest : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonBuildRequest.</returns>
        public static JsonBuildRequest FromToken(JToken token)
        {
            var instance = new JsonBuildRequest(token);
            return instance;
        }

        /// <summary>
        ///     Gets the builds.
        /// </summary>
        /// <value>The builds.</value>
        public IReadOnlyList<JsonBuild> Builds { get{return r_BuildsProvider.Value; } }

        private readonly Lazy<IReadOnlyList<JsonBuild>> r_BuildsProvider;
        /// <summary>
        ///     Gets the custom get version.
        /// </summary>
        /// <value>The custom get version.</value>
        public string CustomGetVersion { get { return sr_CustomGetVersion.Eval(this); } }

        /// <summary>
        ///     Gets the definition.
        /// </summary>
        /// <value>The definition.</value>
        public JsonBuildDefinition Definition { get { return r_DefinitionProvider.Value; } }
        private readonly Lazy<JsonBuildDefinition> r_DefinitionProvider;

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        ///     Gets the priority.
        /// </summary>
        /// <value>The priority.</value>
        public string Priority { get { return sr_Priority.Eval(this); } }

        /// <summary>
        ///     Gets the project.
        /// </summary>
        /// <value>The project.</value>
        public string Project { get { return sr_Project.Eval(this); } }

        /// <summary>
        ///     Gets the queue.
        /// </summary>
        /// <value>The queue.</value>
        public JsonBuildQueue Queue { get { return r_QueueProvider.Value; } }
        private Lazy<JsonBuildQueue> r_QueueProvider;

        /// <summary>
        ///     Gets the queue position.
        /// </summary>
        /// <value>The queue position.</value>
        public int QueuePosition { get { return sr_QueuePosition.Eval(this); } }

        /// <summary>
        ///     Gets the queue time.
        /// </summary>
        /// <value>The queue time.</value>
        public DateTime QueueTime { get { return sr_QueueTime.Eval(this); } }

        /// <summary>
        ///     Gets the reason.
        /// </summary>
        /// <value>The reason.</value>
        public string Reason { get { return sr_Reason.Eval(this); } }

        /// <summary>
        ///     Gets the request drop location.
        /// </summary>
        /// <value>The request drop location.</value>
        public string RequestDropLocation { get { return sr_RequestDropLocation.Eval(this); } }

        /// <summary>
        ///     Gets the requested by.
        /// </summary>
        /// <value>The requested by.</value>
        public JsonIdentity RequestedBy { get { return r_RequesteddByProvider.Value; } }
        private readonly Lazy<JsonIdentity> r_RequesteddByProvider;

        /// <summary>
        ///     Gets the requested for.
        /// </summary>
        /// <value>The requested for.</value>
        public JsonIdentity RequestedFor { get { return r_RequesteddForProvider.Value; } }
        private readonly Lazy<JsonIdentity> r_RequesteddForProvider;

        /// <summary>
        ///     Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public string Status { get { return sr_Status.Eval(this); } }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        public string Uri { get { return sr_Uri.Eval(this); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonBuildRequest(JToken json) : base(json)
        {
            r_BuildsProvider = new Lazy<IReadOnlyList<JsonBuild>>(() =>
            {
                var array = sr_Builds.Eval(this);
                List<JsonBuild> items = JsonParsers.JArrayToObjects(array, JsonBuild.FromToken);
                return items;
            });
            r_DefinitionProvider = new Lazy<JsonBuildDefinition>(() =>
            {
                var src = sr_Definition.Eval(this);
                var definition = JsonBuildDefinition.FromToken(src);
                return definition;
            });
            r_QueueProvider = new Lazy<JsonBuildQueue>(() =>
            {
                var src = sr_Queue.Eval(this);
                var queue = JsonBuildQueue.FromToken(src);
                return queue;
            });
            r_RequesteddByProvider = new Lazy<JsonIdentity>(() =>
            {
                var src = sr_RequestedBy.Eval(this);
                var identity = JsonIdentity.FromToken(src);
                return identity;
            });
            r_RequesteddForProvider = new Lazy<JsonIdentity>(() =>
            {
                var src = sr_RequestedFor.Eval(this);
                var identity = JsonIdentity.FromToken(src);
                return identity;
            });

        }

        /// <summary>
        ///     The r_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");

        /// <summary>
        ///     The SR_ builds
        /// </summary>
        private static readonly JsonBackedField<JArray> sr_Builds = new JsonBackedField<JArray>("builds");

        /// <summary>
        ///     The SR_ custom get version
        /// </summary>
        private static readonly JsonBackedField<string> sr_CustomGetVersion = new JsonBackedField<string>("customGetVersion");

        /// <summary>
        ///     The SR_ definition
        /// </summary>
        private static readonly JsonBackedField<JObject> sr_Definition = new JsonBackedField<JObject>("definition");

        /// <summary>
        ///     The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");

        /// <summary>
        ///     The SR_ priority
        /// </summary>
        private static readonly JsonBackedField<string> sr_Priority = new JsonBackedField<string>("priority");

        /// <summary>
        ///     The SR_ project
        /// </summary>
        private static readonly JsonBackedField<string> sr_Project = new JsonBackedField<string>("project");

        /// <summary>
        ///     The SR_ queue
        /// </summary>
        private static readonly JsonBackedField<JObject> sr_Queue = new JsonBackedField<JObject>("queue");

        /// <summary>
        ///     The SR_ queue position
        /// </summary>
        private static readonly JsonBackedField<int> sr_QueuePosition = new JsonBackedField<int>("queuePosition");

        /// <summary>
        ///     The SR_ queue time
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_QueueTime = new JsonBackedField<DateTime>("queueTime");

        /// <summary>
        ///     The SR_ reason
        /// </summary>
        private static readonly JsonBackedField<string> sr_Reason = new JsonBackedField<string>("reason");

        /// <summary>
        ///     The SR_ request drop location
        /// </summary>
        private static readonly JsonBackedField<string> sr_RequestDropLocation = new JsonBackedField<string>("requestDropLocation");

        /// <summary>
        ///     The SR_ requested by
        /// </summary>
        private static readonly JsonBackedField<JObject> sr_RequestedBy = new JsonBackedField<JObject>("requestedBy");

        /// <summary>
        ///     The SR_ requested for
        /// </summary>
        private static readonly JsonBackedField<JObject> sr_RequestedFor = new JsonBackedField<JObject>("requestedFor");

        /// <summary>
        ///     The SR_ status
        /// </summary>
        private static readonly JsonBackedField<string> sr_Status = new JsonBackedField<string>("status");

        /// <summary>
        ///     The SR_ URI
        /// </summary>
        private static readonly JsonBackedField<string> sr_Uri = new JsonBackedField<string>("uri");
    }
}