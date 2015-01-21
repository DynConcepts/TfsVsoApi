using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    internal class JsonBuildDetails : JsonBackedObjectBase
    {
        public JsonBuildDetails(JToken json) : base(json) {
        }

        public  static JsonBuildDetails FromToken(JToken token)
        { 
            var instance = new JsonBuildDetails(token);
            return instance;
        }
        public int NodeId { get { return sr_NodeId.Eval(this); } }
        private static readonly JsonBackedField<int> sr_NodeId = new JsonBackedField<int>("nodeId");
        public string BuildType { get { return sr_BuildType.Eval(this); } }
        private static readonly JsonBackedField<string> sr_BuildType = new JsonBackedField<string>("type");
        public DateTime LastModifiedDate { get { return sr_LastModifiedDate.Eval(this); } }
        private static readonly JsonBackedField<DateTime> sr_LastModifiedDate = new JsonBackedField<DateTime>("lastModifiedDate");
        public string LastModifiedBy { get { return sr_LastModifiedBy.Eval(this); } }
        private static readonly JsonBackedField<string> sr_LastModifiedBy = new JsonBackedField<string>("lastModifiedBy");
        public object Fields { get { return sr_Fields.Eval(this); } }
        private static readonly JsonBackedField<object> sr_Fields = new JsonBackedField<object>("fields");
/*
{
  "value": [
    {
      "nodeId": 1,
      "type": "BuildError",
      "lastModifiedDate": "2014-11-22T00:50:26.127Z",
      "lastModifiedBy": "LOCAL AUTHORITY\\Elastic Build (davidvcorbin)",
      "fields": {
        "Code": "",
        "EndLineNumber": "-1",
        "ErrorType": "",
        "File": "",
        "LineNumber": "-1",
        "Message": "TF215097: An error occurred while initializing a build for build definition \\RestPlaypen\\Dummy Build Definition: \r\nException Message: The process parameter BuildSettings is required but no value was set. A value must be set on the definition or when the build is queued (Category: #100 Required, Display Name: Items to Build). (type ArgumentException)\r\nException Data Dictionary:\r\nMS.TF.Diagnostics.Logged = True\r\n\r\n\r\nException Stack Trace:    at Microsoft.TeamFoundation.Build.Hosting.BuildWorkflowInstance.ValidateParameters(BuildWorkflowDefinition definition, IDictionary`2 passedInParameterValues)\r\n   at Microsoft.TeamFoundation.Build.Hosting.BuildWorkflowInstance.Initialize(BuildWorkflowDefinition definition, IDictionary`2 dataContext)\r\n   at Microsoft.TeamFoundation.Build.Hosting.BuildWorkflowManager.TryStartWorkflow(WorkflowRequest request, WorkflowManagerActivity activity, BuildWorkflowInstance& workflowInstance, Exception& error, Boolean& syncLockTaken)\r\n",
        "ServerPath": "",
        "Timestamp": "2014-11-22T00:50:25.7924425Z"
      }
    }
  ],
  "count": 1
}
*/



    }
}