using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>
    ///     Generated Test Template
    /// </summary>
    public partial class JsonBuildAPI_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Gets the build details_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="buildId">The build identifier.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetBuildDetails_PostValidate(JsonBuildAPI instance, String project, Int32 buildId, Task<IReadOnlyList<JsonBuildDetails>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }


        /// <summary>
        ///     Gets the build details_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="buildId">The build identifier.</param>
        partial void GetBuildDetails_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 buildId)
        {
            project = "RestPlaypen";
            buildId = 11;
        }

        /// <summary>
        ///     Gets the build_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="buildId">The build identifier.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetBuild_PostValidate(JsonBuildAPI instance, String project, Int32 buildId, Task<JsonBuild> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the build_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="buildId">The build identifier.</param>
        partial void GetBuild_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 buildId)
        {
            project = "RestPlaypen";
            buildId = 11;
        }

        /// <summary>
        ///     Gets the builds_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetBuilds_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonBuild>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the builds_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        partial void GetBuilds_PreCondition(JsonBuildAPI instance, ref String project)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the definition_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="definitionId">The definition identifier.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetDefinition_PostValidate(JsonBuildAPI instance, String project, Int32 definitionId, Task<JsonBuildDefinition> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the definition_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="definitionId">The definition identifier.</param>
        partial void GetDefinition_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 definitionId)
        {
            project = "RestPlaypen";
            definitionId = 2;
        }

        /// <summary>
        ///     Gets the definitions_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetDefinitions_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonBuildDefinition>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the definitions_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        partial void GetDefinitions_PreCondition(JsonBuildAPI instance, ref String project)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the qualities_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetQualities_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonBuildQuality>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the qualities_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        partial void GetQualities_PreCondition(JsonBuildAPI instance, ref String project)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the quality_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="qualityId">The quality identifier.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetQuality_PostValidate(JsonBuildAPI instance, String project, Int32 qualityId, Task<JsonBuildQuality> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the quality_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="qualityId">The quality identifier.</param>
        partial void GetQuality_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 qualityId)
        {
            project = "RestPlaypen";
            qualityId = 1;
        }

        /// <summary>
        ///     Gets the queue_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="queueId">The queue identifier.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetQueue_PostValidate(JsonBuildAPI instance, Int32 queueId, Task<JsonBuildQueue> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the queue_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="queueId">The queue identifier.</param>
        partial void GetQueue_PreCondition(JsonBuildAPI instance, ref Int32 queueId)
        {
            queueId = 10961;
        }

        /// <summary>
        ///     Gets the queues_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetQueues_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonBuildQueue>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the queues_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        partial void GetQueues_PreCondition(JsonBuildAPI instance)
        {
        }

        /// <summary>
        ///     Gets the request_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetRequest_PostValidate(JsonBuildAPI instance, String project, Int32 requestId, Task<JsonBuildRequest> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the request_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="requestId">The request identifier.</param>
        partial void GetRequest_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 requestId)
        {
            project = "RestPlaypen";
            requestId = instance.GetRequests(project).Result[0].Id;
        }

        /// <summary>
        ///     Gets the requests_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetRequests_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonBuildRequest>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        ///     Gets the requests_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        partial void GetRequests_PreCondition(JsonBuildAPI instance, ref String project)
        {
            project = "RestPlaypen";
        }
    }
}