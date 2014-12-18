using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemLinkWrapper_UnitTests
    {
        private Dictionary<string, Type> m_ExpectedExceptions =
            new Dictionary<string, Type>
            {
                {"SourceId_UnitTest", typeof (ValidationException)},
                {"TargetId_UnitTest", typeof (ValidationException)}
            };

        static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLink real, string callerName)
        {
            var collection = WorkItemLinkCollectionWrapper_UnitTests.GetRealInstance();
            real = collection[0];
        }

        /// <summary>
        /// Gets the expected exceptions.
        /// </summary>
        /// <value>The expected exceptions.</value>
        protected override Dictionary<String, Type> ExpectedExceptions { get { return m_ExpectedExceptions; } }

    }
}
