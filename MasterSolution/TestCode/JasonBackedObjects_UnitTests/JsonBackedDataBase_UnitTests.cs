using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    /// <summary>
    ///     Class JsonBackedDataBase_UnitTests.
    /// </summary>
    [TestClass]
    public class JsonBackedDataBase_UnitTests
    {
        /// <summary>
        ///     Makes the token_ unit test.
        /// </summary>
        [TestMethod]
        public void MakeToken_UnitTest()
        {
            const string source = "Hello";
            JToken result = JsonBackedDataBase.MakeToken(source);
            Assert.IsNotNull(result);
        }
    }
}