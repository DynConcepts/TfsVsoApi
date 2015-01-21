using System;
using System.IO;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class CatalogNodeWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref CatalogNode real, string callerName)
        {
            //    IServiceProvider serviceProvider = new DummyServiceProvider();
            //    string content = "";
            //    using (XmlReader reader = XmlReader.Create(new StringReader(content)))
            //    {
            //        real = CatalogNode.FromXml(serviceProvider, reader);
            //    }
            //CredentialsStore credentials = CredentialsProvider.Read(@"..\..\..\RestCredentials.xml");
            //var uri = new Uri(credentials.VsoCollection);
            var uri = new Uri("http://localhost:8080/tfs");
            TfsConfigurationServer tf = TfsConfigurationServerFactory.GetConfigurationServer(uri);
            real = tf.CatalogNode;
        }

        private class DummyServiceProvider : IServiceProvider
        {
            public object GetService(Type serviceType) { throw new NotImplementedException(); }
        }
    }
}