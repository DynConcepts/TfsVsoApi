using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    public partial class TfsMessageWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref TfsMessage real, string callerName) { real = (TfsMessage) FormatterServices.GetUninitializedObject(typeof (TfsMessage)); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "CreateException_UnitTest",
            "Headers_UnitTest",
        };
    }
}