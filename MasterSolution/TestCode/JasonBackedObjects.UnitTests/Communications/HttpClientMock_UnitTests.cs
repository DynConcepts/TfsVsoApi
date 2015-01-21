using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.Communications
{
    /// <summary>Generated Test Template</summary>
    public partial class HttpClientMock_UnitTests : DynTestClassBase
    {

        /// <summary>
        ///     Gets the expected exceptions.
        /// </summary>
        /// <value>The expected exceptions.</value>
        protected override Dictionary<String, Type> ExpectedExceptions { get { return m_ExpectedExceptions; } }

        private readonly Dictionary<string, Type> m_ExpectedExceptions =
            new Dictionary<string, Type>
            {
                {"SendAsync_UnitTest", typeof (NotSupportedException)},
                {"PutAsync_UnitTest", typeof (NotSupportedException)},
                {"PostAsync_UnitTest", typeof (NotSupportedException)},
                {"GetStringAsync_UnitTest", typeof (NotSupportedException)},
                {"GetStreamAsync_UnitTest", typeof (NotSupportedException)},
                {"GetByteArrayAsync_UnitTest", typeof (NotSupportedException)},
                {"GetAsync_UnitTest", typeof (NotSupportedException)},
                {"Dispose_UnitTest", typeof (NotSupportedException)},
                {"DeleteAsync_UnitTest", typeof (NotSupportedException)},
                {"CancelPendingRequests_UnitTest", typeof (NotSupportedException)},
            };

    }
}