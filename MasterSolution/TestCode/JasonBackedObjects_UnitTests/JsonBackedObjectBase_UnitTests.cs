using System;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    [TestClass()]
    public class JsonBackedObjectBase_UnitTests
    {
        [TestMethod()]
        public void ToJSonString_UnitTest()
        {
            var instance = GetInstance();
            var result = instance.ToJSonString();
            Assert.IsNotNull(result);
        }

        public static JsonBackedObjectBase GetInstance()
        {
            const string expectedValue = "TokenValue";
            var property = new JProperty("TokenKey", expectedValue);
            var json = new JObject {property};
            JsonBackedObjectBase instance = new TestJsonBackedObject(json);
            Assert.IsNotNull(instance);
            return instance;
        }

        [TestMethod()]
        public void TryGetValue_UnitTest()
        {
            var instance = GetInstance();
            JsonBackedDataBase<string> source = new JsonBackedField<string>((Func<JToken, string>) null);
            string target;
            bool result = instance.TryGetValue(source, out target);
            Assert.IsFalse(result);
            Assert.IsNull(target);

        }

        [TestMethod()]
        public void SetValue_UnitTest()
        {
            var instance = GetInstance();
            JsonBackedDataBase<string> source = new JsonBackedField<string>((Func<JToken, string>)null); ;
            string target = "Target Value";
            instance.SetValue(source, target);
        }
    }
}
