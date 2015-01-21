using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class BuildRestCalls.
    /// </summary>
    internal class BuildRestCalls
    {
/*
/build/builds/{build3}		            DELETE	{project}/_apis/build/builds/345?api-version=1.0
/build/builds		                    GET		{project}/_apis/build/builds?api-version=1.0
/build/builds/{build1}		            GET		{project}/_apis/build/builds/348?api-version=1.0
/build/builds/{build1}/details		    GET		{project}/_apis/build/builds/348/details?api-version=1.0
/build/builds/{build1}		            PATCH	{project}/_apis/build/builds/348?api-version=1.0
/build/builds/{build2}		            PATCH	{project}/_apis/build/builds/347?api-version=1.0
/build/builds/{build3}		            PATCH	{project}/_apis/build/builds/345?api-version=1.0
/build/definitions		                GET		{project}/_apis/build/definitions?api-version=1.0
/build/definitions/{definitionId}		GET		{project}/_apis/build/definitions/3?api-version=1.0
/build/qualities/{quality}		        DELETE	{project}/_apis/build/qualities/To%20be%20evaluated?api-version=1.0
/build/qualities		                GET		{project}/_apis/build/qualities?api-version=1.0
/build/qualities/{quality}		        PUT		{project}/_apis/build/qualities/To%20be%20evaluated?api-version=1.0
/build/queues		                    GET		_apis/build/queues?api-version=1.0
/build/queues/{queueId}		            GET	    _apis/build/queues/274?api-version=1.0
/build/requests/{requestToDelete}		DELETE	{project}/_apis/build/requests/433?api-version=1.0
/build/requests		                    GET 	{project}/_apis/build/requests?api-version=1.0
/build/requests/{request}		        PATCH	{project}/_apis/build/requests/398?api-version=1.0
/build/requests		                    POST	{project}/_apis/build/requests?api-version=1.0
*/

        /// <summary>
        ///     Gets the build.
        /// </summary>
        /// <value>The build.</value>
        internal static CallSpec Build { get { return sr_Build; } }

        /// <summary>
        ///     Gets the build details.
        /// </summary>
        /// <value>The build details.</value>
        internal static CallSpec BuildDetails { get { return sr_BuildDetails; } }

        /// <summary>
        ///     Gets the builds.
        /// </summary>
        /// <value>The builds.</value>
        internal static CallSpec Builds { get { return sr_Builds; } }

        /// <summary>
        ///     Gets the definition.
        /// </summary>
        /// <value>The definition.</value>
        internal static CallSpec Definition { get { return sr_Definition; } }

        /// <summary>
        ///     Gets the definitions.
        /// </summary>
        /// <value>The definitions.</value>
        internal static CallSpec Definitions { get { return sr_Definitions; } }

        /// <summary>
        ///     Gets the qualities.
        /// </summary>
        /// <value>The qualities.</value>
        internal static CallSpec Qualities { get { return sr_Qualities; } }

        /// <summary>
        ///     Gets the quality.
        /// </summary>
        /// <value>The quality.</value>
        internal static CallSpec Quality { get { return sr_Quality; } }

        /// <summary>
        ///     Gets the queue.
        /// </summary>
        /// <value>The queue.</value>
        internal static CallSpec Queue { get { return sr_Queue; } }

        /// <summary>
        ///     Gets the queues.
        /// </summary>
        /// <value>The queues.</value>
        internal static CallSpec Queues { get { return sr_Queues; } }

        /// <summary>
        ///     Gets the request.
        /// </summary>
        /// <value>The request.</value>
        internal static CallSpec Request { get { return sr_Request; } }

        /// <summary>
        ///     Gets the requests.
        /// </summary>
        /// <value>The requests.</value>
        internal static CallSpec Requests { get { return sr_Requests; } }

        /// <summary>
        ///     The SR_ build
        /// </summary>
        private static readonly CallSpec sr_Builds = new CallSpec("{project}/_apis/build/builds");

        /// <summary>
        ///     The SR_ build details
        /// </summary>
        private static readonly CallSpec sr_BuildDetails = new CallSpec("{project}/_apis/build/builds/{buildId}/details");

        /// <summary>
        ///     The SR_ builds
        /// </summary>
        private static readonly CallSpec sr_Build = new CallSpec("{project}/_apis/build/builds/{buildId}");

        /// <summary>
        ///     The SR_ definition
        /// </summary>
        private static readonly CallSpec sr_Definition = new CallSpec("{project}/_apis/build/definitions/{definitionId}");

        /// <summary>
        ///     The SR_ definitions
        /// </summary>
        private static readonly CallSpec sr_Definitions = new CallSpec("{project}/_apis/build/definitions");

        /// <summary>
        ///     The SR_ qualities
        /// </summary>
        private static readonly CallSpec sr_Qualities = new CallSpec("{project}/_apis/build/qualities");

        /// <summary>
        ///     The SR_ quality
        /// </summary>
        private static readonly CallSpec sr_Quality = new CallSpec("{project}/_apis/build/qualities/{quality}");

        /// <summary>
        ///     The SR_ queue
        /// </summary>
        private static readonly CallSpec sr_Queue = new CallSpec("_apis/build/queues/{queueId}");

        /// <summary>
        ///     The SR_ queues
        /// </summary>
        private static readonly CallSpec sr_Queues = new CallSpec("_apis/build/queues");

        /// <summary>
        ///     The SR_ request
        /// </summary>
        private static readonly CallSpec sr_Request = new CallSpec("{project}/_apis/build/requests/{requestId}");

        /// <summary>
        ///     The SR_ requests
        /// </summary>
        private static readonly CallSpec sr_Requests = new CallSpec("{project}/_apis/build/requests");
    }
}