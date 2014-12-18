using System;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    [TestClass()]
    public class JsonBackedField_UnitTests
    {
        [TestMethod()]
        public void JsonBackedField_Constructor_ReadOnly_UnitTest()
        {
            var instance = new JsonBackedField<String>(ReadFunc);
            Assert.IsNotNull(instance);
        }


        [TestMethod()]
        public void JsonBackedField_Constructor_ReadRwite_UnitTest()
        {
            var instance = new JsonBackedField<String>(ReadFunc, WriteAction);
            Assert.IsNotNull(instance);
        }

        [TestMethod()]
        public void JsonBackedField_Constructor_Key_UnitTest()
        {
            var instance = new JsonBackedField<String>(tokenKey);
            Assert.IsNotNull(instance);
        }

        [TestMethod()]
        public void Eval_UnitTest()
        {
            var instance = new JsonBackedField<String>(ReadFunc);
            const string expectedValue = "TokenValue";
            var property = new JProperty(tokenKey, expectedValue);
            var json = new JObject { property };

            var result = instance.Eval(json);
            Assert.IsNotNull(instance);
            Assert.AreEqual(expectedValue, result);
        }

        private void WriteAction(JToken token, string value) { token.Replace(JsonBackedDataBase<Object>.MakeToken(value)); }
        private string ReadFunc(JToken token) { return token[tokenKey].Value<String>(); }

        private const string tokenKey = "key";

    }
}
