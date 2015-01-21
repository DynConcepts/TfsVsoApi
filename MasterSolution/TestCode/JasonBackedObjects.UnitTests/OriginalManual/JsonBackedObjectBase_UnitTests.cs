using System;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.OriginalManual
{
    /// <summary>
    ///     Class JsonBackedObjectBase_UnitTests.
    /// </summary>
    [TestClass]
    public class JsonBackedObjectBase_UnitTests
    {
        /// <summary>
        ///     Gets the instance.
        /// </summary>
        /// <returns>JsonBackedObjectBase.</returns>
        public static JsonBackedObjectBase GetInstance()
        {
            const string expectedValue = "TokenValue";
            var property = new JProperty("TokenKey", expectedValue);
            var json = new JObject {property};
            JsonBackedObjectBase instance = new TestJsonBackedObject(json);
            Assert.IsNotNull(instance);
            return instance;
        }

        /// <summary>
        ///     Sets the value_ unit test.
        /// </summary>
        [TestMethod]
        public void SetValue_UnitTest()
        {
            JsonBackedObjectBase instance = GetInstance();
            JsonBackedDataBase source = new JsonBackedField<string>((Func<JToken, string>) null);
            const string target = "Target Value";
            instance.SetValue(source, target);
        }

        /// <summary>
        ///     To the j son string_ unit test.
        /// </summary>
        [TestMethod]
        public void ToJSonString_UnitTest()
        {
            JsonBackedObjectBase instance = GetInstance();
            string result = instance.ToJSonString();
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Tries the get value_ unit test.
        /// </summary>
        [TestMethod]
        public void TryGetValue_UnitTest()
        {
            JsonBackedObjectBase instance = GetInstance();
            JsonBackedDataBase source = new JsonBackedField<string>((Func<JToken, string>) null);
            string target;
            bool result = instance.TryGetValue(source, out target);
            Assert.IsFalse(result);
            Assert.IsNull(target);
        }
    }
}