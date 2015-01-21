using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Build
{
    /// <summary>
    ///     Class JsonBuild.
    /// </summary>
    internal class JsonBuild : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonBuildDefinition.</returns>
        public static JsonBuild FromToken(JToken token)
        {
            var instance = new JsonBuild(token);
            return instance;
        }

        /// <summary>
        ///     Gets the build number.
        /// </summary>
        /// <value>The build number.</value>
        public string BuildNumber { get { return sr_BuildNumber.Eval(this); } }

        /// <summary>
        ///     Gets the definition.
        /// </summary>
        /// <value>The definition.</value>
        public JsonBuildDefinition Definition { get { return r_DefinitionProvider.Value; } }
        private readonly Lazy<JsonBuildDefinition> r_DefinitionProvider;

        /// <summary>
        ///     Gets the drop.
        /// </summary>
        /// <value>The drop.</value>
        public JsonBuildDrop Drop { get { return r_DropProvider.Value; } }
        private readonly Lazy<JsonBuildDrop> r_DropProvider;

        /// <summary>
        ///     Gets the finish time.
        /// </summary>
        /// <value>The finish time.</value>
        public DateTime FinishTime { get { return sr_FinishTime.Eval(this); } }

        /// <summary>
        ///     Gets a value indicating whether this instance has diagnostics.
        /// </summary>
        /// <value><c>true</c> if this instance has diagnostics; otherwise, <c>false</c>.</value>
        public bool HasDiagnostics { get { return sr_HasDiagnostics.Eval(this); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        ///     Gets the last changed by.
        /// </summary>
        /// <value>The last changed by.</value>
        public JsonIdentity LastChangedBy { get { return r_LastChangedByProvider.Value; } }

        private readonly Lazy<JsonIdentity> r_LastChangedByProvider;
        /// <summary>
        ///     Gets the log.
        /// </summary>
        /// <value>The log.</value>
        public string Log { get { return sr_Log.Eval(this); } }

        /// <summary>
        ///     Gets the queue.
        /// </summary>
        /// <value>The queue.</value>
        public JsonBuildQueue Queue { get { return r_QueueProvider.Value; } }
        private Lazy<JsonBuildQueue> r_QueueProvider;

        /// <summary>
        ///     Gets the reason.
        /// </summary>
        /// <value>The reason.</value>
        public string Reason { get { return sr_Reason.Eval(this); } }

        /// <summary>
        ///     Gets the requests.
        /// </summary>
        /// <value>The requests.</value>
        public int Requests { get { return sr_Requests.Eval(this); } }

        /// <summary>
        ///     Gets a value indicating whether [retain indefinitely].
        /// </summary>
        /// <value><c>true</c> if [retain indefinitely]; otherwise, <c>false</c>.</value>
        public bool RetainIndefinitely { get { return sr_RetainIndefinitely.Eval(this); } }

        /// <summary>
        ///     Gets the source get version.
        /// </summary>
        /// <value>The source get version.</value>
        public int SourceGetVersion { get { return sr_SourceGetVersion.Eval(this); } }

        /// <summary>
        ///     Gets the start time.
        /// </summary>
        /// <value>The start time.</value>
        public DateTime StartTime { get { return sr_StartTime.Eval(this); } }

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
        ///     Initializes a new instance of the <see cref="JsonBuild" /> class.
        /// </summary>
        /// <param name="token">The token.</param>
        private JsonBuild(JToken token) : base(token)
        {
            r_DefinitionProvider = new Lazy<JsonBuildDefinition>(() =>
            {
                var src = sr_Definition.Eval(this);
                var definition = JsonBuildDefinition.FromToken(src);
                return definition;
            });
            r_DropProvider = new Lazy<JsonBuildDrop>(() =>
            {
                var src = sr_Drop.Eval(this);
                var drop = JsonBuildDrop.FromToken(src);
                return drop;
            });
            r_QueueProvider = new Lazy<JsonBuildQueue>(() =>
            {
                var src = sr_Queue.Eval(this);
                var queue = JsonBuildQueue.FromToken(src);
                return queue;
            });
            r_LastChangedByProvider = new Lazy<JsonIdentity>(() =>
            {
                var src = sr_LastChangedBy.Eval(this);
                var identity = JsonIdentity.FromToken(src);
                return identity;
            });
        }

        /// <summary>
        ///     The SR_ build number
        /// </summary>
        private static readonly JsonBackedField<string> sr_BuildNumber = new JsonBackedField<string>("buildNumber");

        /// <summary>
        ///     The SR_ definition
        /// </summary>
        private static readonly JsonBackedField<JObject> sr_Definition = new JsonBackedField<JObject>("definition");

        /// <summary>
        ///     The SR_ drop
        /// </summary>
        private static readonly JsonBackedField<JObject> sr_Drop = new JsonBackedField<JObject>("drop");

        /// <summary>
        ///     The SR_ finish time
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_FinishTime = new JsonBackedField<DateTime>("finishTime");

        /// <summary>
        ///     The SR_ has diagnostics
        /// </summary>
        private static readonly JsonBackedField<bool> sr_HasDiagnostics = new JsonBackedField<bool>("hasDiagnostics");

        /// <summary>
        ///     The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");

        /// <summary>
        ///     The SR_ last changed by
        /// </summary>
        private static readonly JsonBackedField<JObject> sr_LastChangedBy = new JsonBackedField<JObject>("lastChangedBy");

        /// <summary>
        ///     The SR_ log
        /// </summary>
        private static readonly JsonBackedField<string> sr_Log = new JsonBackedField<string>("log");

        /// <summary>
        ///     The SR_ queue
        /// </summary>
        private static readonly JsonBackedField<JObject> sr_Queue = new JsonBackedField<JObject>("queue");

        /// <summary>
        ///     The SR_ reason
        /// </summary>
        private static readonly JsonBackedField<string> sr_Reason = new JsonBackedField<string>("reason");

        /// <summary>
        ///     The SR_ requests
        /// </summary>
        private static readonly JsonBackedField<int> sr_Requests = new JsonBackedField<int>("requests");

        /// <summary>
        ///     The SR_ retain indefinitely
        /// </summary>
        private static readonly JsonBackedField<bool> sr_RetainIndefinitely = new JsonBackedField<bool>("retainIndefinitely");

        /// <summary>
        ///     The SR_ source get version
        /// </summary>
        private static readonly JsonBackedField<int> sr_SourceGetVersion = new JsonBackedField<int>("sourceGetVersion");

        /// <summary>
        ///     The SR_ start time
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_StartTime = new JsonBackedField<DateTime>("startTime");

        /// <summary>
        ///     The SR_ status
        /// </summary>
        private static readonly JsonBackedField<string> sr_Status = new JsonBackedField<string>("status");

        /// <summary>
        ///     The SR_ URI
        /// </summary>
        private static readonly JsonBackedField<string> sr_Uri = new JsonBackedField<string>("uri");

        /// <summary>
        ///     The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}