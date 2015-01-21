using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    public partial class TfsMessageHeaderWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref TfsMessageHeader real, string callerName) { real = new TemporaryMock(); }


        class TemporaryMock : TfsMessageHeader
        {
            protected override void OnWriteHeaderContents(XmlDictionaryWriter writer) { }

            public override string Name { get { return string.Empty; } }

            public override string Namespace { get { return string.Empty; } }
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetReader_UnitTest",
            "Write_UnitTest",
        };
    }
}