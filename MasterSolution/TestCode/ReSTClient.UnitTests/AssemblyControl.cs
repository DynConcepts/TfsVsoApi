using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects.AdvancedLogging;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests
{
    /// <summary>
    /// Class AssemblyControl.
    /// </summary>
    [TestClass]
    public class AssemblyControl
    {
        /// <summary>
        ///     Assemblies the cleanup.
        /// </summary>
        [AssemblyCleanup]
        public static void AssemblyCleanup() { StructuredExchangeLogger.Uninstall(); }

        /// <summary>
        ///     Assemblies the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            //CredentialsStore credentials = new CredentialsStore();
            //credentials.BasicAuthorizationUsername = "*****";
            //credentials.BasicAuthorizationPassword = "*****";
            //credentials.VsoCollection = "https://*****.visualstudio.com/defaultcollection";
            //CredentialsProvider.Write(@"..\..\RestCredentials.xml", credentials);
            var location = Directory.GetCurrentDirectory();
            CredentialsStore credentials = CredentialsProvider.Read(@"..\..\..\RestCredentials.xml");

            RestClientManager.BasicAuthorizationUsername = credentials.BasicAuthorizationUsername;
            RestClientManager.BasicAuthorizationPassword = credentials.BasicAuthorizationPassword;
            VSOClientManager.VsoCollection = credentials.VsoCollection;

            StructuredExchangeLogger.Install();
        }

    }
}
