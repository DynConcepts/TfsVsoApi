using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.OriginalManual
{
    /// <summary>
    ///     Class JsonBackedList_UnitTests.
    /// </summary>
    [TestClass]
    public class JsonBackedList_UnitTests
    {
        /// <summary>
        ///     Eval_s the unit test.
        /// </summary>
        [TestMethod]
        public void Eval_UnitTest()
        {
            var instance = new JsonBackedList<string>(Func);
            Assert.IsNotNull(instance);
            const string expectedValue = "TokenValue";
            var property = new JProperty("TokenKey", expectedValue);
            var json = new JObject {property};
            IReadOnlyList<string> result = instance.Eval(json);
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Eval_s the unit test1.
        /// </summary>
        [TestMethod]
        public void Eval_UnitTest1()
        {
            var instance = new JsonBackedList<string>(Func);
            Assert.IsNotNull(instance);
            const string expectedValue = "TokenValue";
            var property = new JProperty("TokenKey", expectedValue);
            var json = new JObject {property};
            JsonBackedObjectBase source = new TestJsonBackedObject(json);
            IReadOnlyList<string> result = instance.Eval(source);
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Jsons the backed list_ constructor_ unit test.
        /// </summary>
        [TestMethod]
        public void JsonBackedList_Constructor_UnitTest()
        {
            var instance = new JsonBackedList<string>(Func);
            Assert.IsNotNull(instance);
        }

        /// <summary>
        ///     Functions the specified token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>IReadOnlyList&lt;System.String&gt;.</returns>
        private IReadOnlyList<string> Func(JToken token)
        {
            return new List<string>();
        }
    }
}