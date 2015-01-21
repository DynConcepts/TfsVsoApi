using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>Generated Test Template</summary>
    public partial class CacheWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref Cache real, string callerName)
        {
            real = (Cache)FormatterServices.GetUninitializedObject(typeof(Cache));
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetSnapshot_UnitTest",
        };

    }
}