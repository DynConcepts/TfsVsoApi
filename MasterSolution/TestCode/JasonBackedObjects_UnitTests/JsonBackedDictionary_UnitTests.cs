using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    /// <summary>
    ///     Class JsonBackedDictionary_UnitTests.
    /// </summary>
    [TestClass]
    public class JsonBackedDictionary_UnitTests
    {
        /// <summary>
        ///     Gets the instance.
        /// </summary>
        /// <returns>JsonBackedDictionary&lt;String&gt;.</returns>
        public static JsonBackedDictionary<String> GetInstance()
        {
            var instance = new JsonBackedDictionary<string>("key", Func);
            Assert.IsNotNull(instance);
            return instance;
        }

        /// <summary>
        ///     Eval_s the unit test.
        /// </summary>
        [TestMethod]
        public void Eval_UnitTest()
        {
            JsonBackedDictionary<string> instance = GetInstance();
            JsonBackedObjectBase source = new TestJsonBackedObject(SourceJsonObject());
            IReadOnlyDictionary<string, string> result = instance.Eval(source);
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Jsons the backed dictionary_ unit test.
        /// </summary>
        [TestMethod]
        public void JsonBackedDictionary_UnitTest()
        {
            var instance = new JsonBackedDictionary<string>("key", Func);
            Assert.IsNotNull(instance);
        }

        /// <summary>
        ///     Sets the value_ unit test.
        /// </summary>
        [TestMethod]
        public void SetValue_UnitTest()
        {
            JsonBackedDictionary<string> instance = GetInstance();
            JsonBackedObjectBase source = new TestJsonBackedObject(SourceJsonObject());
            const string fieldName = "TargetField";
            const string value = "TargetValue";
            instance.SetValue(source, fieldName, value);
        }

        /// <summary>
        ///     Functions the specified token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>System.String.</returns>
        private static string Func(JToken token) { return (string) token; }

        /// <summary>
        ///     Sources the json object.
        /// </summary>
        /// <returns>JObject.</returns>
        private JObject SourceJsonObject()
        {
            var property1 = new JProperty("TokenKey", "TokenValue");
            var property2 = new JProperty("TargetField", "OriginalValue");
            var child = new JObject {property1, property2};
            var json = new JObject {{"key", child}};
            return json;
        }
    }
}