using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Build
{
    /// <summary>
    /// Class JsonBuildDefinition.
    /// </summary>
    internal class JsonBuildDefinition : JsonBackedObjectBase
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonBuildDefinition.</returns>
        public static JsonBuildDefinition FromToken(JToken token)
        {
            var instance = new JsonBuildDefinition(token);
            return instance;
        }

        /// <summary>
        /// Gets the size of the batch.
        /// </summary>
        /// <value>The size of the batch.</value>
        public string BatchSize { get { return sr_BatchSize.Eval(this); } }

        /// <summary>
        /// Gets the build arguments.
        /// </summary>
        /// <value>The build arguments.</value>
        public string BuildArgs { get { return sr_BuildArgs.Eval(this); } }

        /// <summary>
        /// Gets the date created.
        /// </summary>
        /// <value>The date created.</value>
        public DateTime DateCreated { get { return sr_DateCreated.Eval(this); } }

        /// <summary>
        /// Gets the default drop location.
        /// </summary>
        /// <value>The default drop location.</value>
        public string DefaultDropLocation { get { return sr_DefaultDropLocation.Eval(this); } }

        /// <summary>
        /// Gets the type of the definition.
        /// </summary>
        /// <value>The type of the definition.</value>
        public string DefinitionType { get { return sr_DefinitionType.Eval(this); } }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return sr_Description.Eval(this); } }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        /// Gets the last build.
        /// </summary>
        /// <value>The last build.</value>
        public string LastBuild { get { return sr_LastBuild.Eval(this); } }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }

        /// <summary>
        /// Gets the queue.
        /// </summary>
        /// <value>The queue.</value>
        public string Queue { get { return sr_Queue.Eval(this); } }

        /// <summary>
        /// Gets the supported reasons.
        /// </summary>
        /// <value>The supported reasons.</value>
        public string SupportedReasons { get { return sr_SupportedReasons.Eval(this); } }

        /// <summary>
        /// Gets the type of the trigger.
        /// </summary>
        /// <value>The type of the trigger.</value>
        public string TriggerType { get { return sr_TriggerType.Eval(this); } }

        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        public string Uri { get { return sr_Uri.Eval(this); } }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBuildDefinition" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonBuildDefinition(JToken json)
            : base(json) { }

        /// <summary>
        /// The SR_ batch size
        /// </summary>
        private static readonly JsonBackedField<string> sr_BatchSize = new JsonBackedField<string>("batchSize");

        /// <summary>
        /// The SR_ build arguments
        /// </summary>
        private static readonly JsonBackedField<string> sr_BuildArgs = new JsonBackedField<string>("buildArgs");

        /// <summary>
        /// The SR_ date created
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_DateCreated = new JsonBackedField<DateTime>("dateCreated");

        /// <summary>
        /// The SR_ default drop location
        /// </summary>
        private static readonly JsonBackedField<string> sr_DefaultDropLocation = new JsonBackedField<string>("defaultDropLocation");

        /// <summary>
        /// The SR_ definition type
        /// </summary>
        private static readonly JsonBackedField<string> sr_DefinitionType = new JsonBackedField<string>("definitionType");

        /// <summary>
        /// The SR_ description
        /// </summary>
        private static readonly JsonBackedField<string> sr_Description = new JsonBackedField<string>("description");

        /// <summary>
        /// The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<string> sr_Id = new JsonBackedField<string>("id");

        /// <summary>
        /// The SR_ last build
        /// </summary>
        private static readonly JsonBackedField<string> sr_LastBuild = new JsonBackedField<string>("lastBuild");

        /// <summary>
        /// The SR_ name
        /// </summary>
        private static readonly JsonBackedField<string> sr_Name = new JsonBackedField<string>("name");

        /// <summary>
        /// The SR_ queue
        /// </summary>
        private static readonly JsonBackedField<string> sr_Queue = new JsonBackedField<string>("queue");

        /// <summary>
        /// The SR_ supported reasons
        /// </summary>
        private static readonly JsonBackedField<string> sr_SupportedReasons = new JsonBackedField<string>("supportedReasons");

        /// <summary>
        /// The SR_ trigger type
        /// </summary>
        private static readonly JsonBackedField<string> sr_TriggerType = new JsonBackedField<string>("triggerType");

        /// <summary>
        /// The SR_ URI
        /// </summary>
        private static readonly JsonBackedField<string> sr_Uri = new JsonBackedField<string>("uri");

        /// <summary>
        /// The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");

/*
 * {
  "batchSize": 1,
  "uri": "vstfs:///Build/Definition/2",
  "queue": {
    "queueType": "buildController",
    "id": 10961,
    "name": "Hosted Build Controller",
    "url": "https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/build/Queues/10961"
  },
  "triggerType": "none",
  "defaultDropLocation": "#/",
  "description": "Silly Description",
  "buildArgs": "",
  "dateCreated": "2014-11-22T00:48:47.82Z",
  "supportedReasons": "all",
  "lastBuild": {
    "id": 11,
    "url": "https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/build/Builds/11"
  },
  "definitionType": "xaml",
  "id": 2,
  "name": "Dummy Build Definition",
  "url": "https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/build/Definitions/2"
}
 */
    }
}