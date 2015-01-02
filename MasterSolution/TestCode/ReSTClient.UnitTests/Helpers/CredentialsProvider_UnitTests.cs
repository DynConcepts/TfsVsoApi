using DynCon.OSI.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers
{
    /// <summary>
    ///     Class CredentialsProvider_UnitTests.
    /// </summary>
    [TestClass]
    public class CredentialsProvider_UnitTests
    {
        /// <summary>
        ///     Reads the write_ unit test.
        /// </summary>
        [TestMethod]
        public void ReadWrite_UnitTest()
        {
            const string fileName = "ReST_Credentiials.xml";
            var sourceData = new CredentialsStore();
            sourceData.BasicAuthorizationUsername = "MyUserName";
            sourceData.BasicAuthorizationPassword = "MyPAssword";
            sourceData.VsoCollection = "MyVsoCollection";
            Assert.AreEqual(3, sourceData.Values.Count);
            CredentialsProvider.Write(fileName, sourceData);
            CredentialsStore resultData = CredentialsProvider.Read(fileName);
            Assert.AreEqual(sourceData.BasicAuthorizationUsername, resultData.BasicAuthorizationUsername);
            Assert.AreEqual(sourceData.BasicAuthorizationPassword, resultData.BasicAuthorizationPassword);
            Assert.AreEqual(sourceData.VsoCollection, resultData.VsoCollection);
        }
    }
}