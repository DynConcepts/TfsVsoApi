using System;
using System.IO;
using System.Xml;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class CatalogNodeWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref CatalogNode real, string callerName)
        {
            IServiceProvider serviceProvider = new DummyServiceProvider();
            string content = "";
            using (XmlReader reader = XmlReader.Create(new StringReader(content)))
            {
                real = CatalogNode.FromXml(serviceProvider, reader);
            }
        }

        private class DummyServiceProvider : IServiceProvider
        {
            public object GetService(Type serviceType) { throw new NotImplementedException(); }
        }
    }
}