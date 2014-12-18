using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    [TestClass()]
    public class JsonBackedList_UnitTests
    {
        [TestMethod()]
        public void JsonBackedList_Constructor_UnitTest()
        {
            var instance = new JsonBackedList<string>(Func);
            Assert.IsNotNull(instance);
        }

        private IReadOnlyList<string> Func(JToken token)
        {
            return new List<string>();
        }


        [TestMethod()]
        public void Eval_UnitTest()
        {
            var instance = new JsonBackedList<string>(Func);
            Assert.IsNotNull(instance);
            const string expectedValue = "TokenValue";
            var property = new JProperty("TokenKey", expectedValue);
            var json = new JObject { property };
            var result = instance.Eval(json);
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void Eval_UnitTest1()
        {
            var instance = new JsonBackedList<string>(Func);
            Assert.IsNotNull(instance);
            const string expectedValue = "TokenValue";
            var property = new JProperty("TokenKey", expectedValue);
            var json = new JObject { property };
            JsonBackedObjectBase source = new TestJsonBackedObject(json);
            var result = instance.Eval(source);
            Assert.IsNotNull(result);
        }
    }
}
