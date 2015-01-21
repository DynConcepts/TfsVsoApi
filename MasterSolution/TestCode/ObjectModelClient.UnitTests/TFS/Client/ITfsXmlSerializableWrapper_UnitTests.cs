using System.Xml;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ITfsXmlSerializableWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref ITfsXmlSerializable real, string callerName) { real = new TemporaryMock(); }

        class TemporaryMock : ITfsXmlSerializable
        {
            public void WriteXml(XmlWriter writer, string xmlElement) {  }

            public void ReadXml(XmlReader reader, string xmlElement) {  }
        }
    }
}
