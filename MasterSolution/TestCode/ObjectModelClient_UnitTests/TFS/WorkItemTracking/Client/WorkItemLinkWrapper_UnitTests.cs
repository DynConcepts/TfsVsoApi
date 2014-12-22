using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemLinkWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref WorkItemLink real, string callerName)
        {
            WorkItemLinkCollection collection = WorkItemLinkCollectionWrapper_UnitTests.GetRealInstance();
            real = collection[0];
        }

        /// <summary>
        ///     Gets the expected exceptions.
        /// </summary>
        /// <value>The expected exceptions.</value>
        protected override Dictionary<String, Type> ExpectedExceptions { get { return m_ExpectedExceptions; } }

        private readonly Dictionary<string, Type> m_ExpectedExceptions =
            new Dictionary<string, Type>
            {
                {"SourceId_UnitTest", typeof (ValidationException)},
                {"TargetId_UnitTest", typeof (ValidationException)}
            };
    }
}