using System;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.OriginalManual
{
    /// <summary>
    ///     Class JsonBackedField_UnitTests.
    /// </summary>
    [TestClass]
    public class JsonBackedField_UnitTests
    {
        /// <summary>
        ///     Eval_s the json backed object_ unit test.
        /// </summary>
        [TestMethod]
        public void Eval_JsonBackedObject_UnitTest()
        {
            var instance = new JsonBackedField<String>(ReadFunc);
            const string expectedValue = "TokenValue";
            var property1 = new JProperty("TokenKey", "TokenValue");
            var property2 = new JProperty("TargetField", "OriginalValue");
            var json = new JObject {property1, property2};
            var source = new TestJsonBackedObject(json);
            string result = instance.Eval(source);
            Assert.IsNotNull(instance);
            Assert.AreEqual(expectedValue, result);

            // We read a second time to access the cached value...
            string result2 = instance.Eval(source);
            Assert.IsNotNull(instance);
            Assert.AreEqual(expectedValue, result2);
        }

        /// <summary>
        ///     Eval_s the null_ unit test.
        /// </summary>
        [TestMethod]
        public void Eval_Null_UnitTest()
        {
            var instance = new JsonBackedField<String>(ReadFunc);
            const string expectedValue = default(String);

            string result = instance.Eval((JToken) null);
            Assert.IsNotNull(instance);
            Assert.AreEqual(expectedValue, result);
        }

        /// <summary>
        ///     Eval_s the unit test.
        /// </summary>
        [TestMethod]
        public void Eval_UnitTest()
        {
            var instance = new JsonBackedField<String>(ReadFunc);
            const string expectedValue = TokenKey;
            var property = new JProperty(TokenKey, expectedValue);
            var json = new JObject {property};

            string result = instance.Eval(json);
            Assert.IsNotNull(instance);
            Assert.AreEqual(expectedValue, result);
        }

        /// <summary>
        ///     Jsons the backed field_ constructor_ key_ unit test.
        /// </summary>
        [TestMethod]
        public void JsonBackedField_Constructor_Key_UnitTest()
        {
            var instance = new JsonBackedField<String>(TokenKey);
            Assert.IsNotNull(instance);
        }

        /// <summary>
        ///     Jsons the backed field_ constructor_ read only_ unit test.
        /// </summary>
        [TestMethod]
        public void JsonBackedField_Constructor_ReadOnly_UnitTest()
        {
            var instance = new JsonBackedField<String>(ReadFunc);
            Assert.IsNotNull(instance);
        }


        /// <summary>
        ///     Jsons the backed field_ constructor_ read rwite_ unit test.
        /// </summary>
        [TestMethod]
        public void JsonBackedField_Constructor_ReadRwite_UnitTest()
        {
            var instance = new JsonBackedField<String>(ReadFunc, WriteAction);
            Assert.IsNotNull(instance);
        }

        /// <summary>
        ///     Reads the function.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>System.String.</returns>
        private string ReadFunc(JToken token)
        {
            return token[TokenKey].Value<String>();
        }

        /// <summary>
        ///     Writes the action.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="value">The value.</param>
        private void WriteAction(JToken token, string value)
        {
            token.Replace(JsonBackedDataBase.MakeToken(value));
        }

        /// <summary>
        ///     The token key
        /// </summary>
        private const string TokenKey = "TokenKey";
    }
}