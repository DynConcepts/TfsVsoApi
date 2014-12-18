using System;
using DynCon.OSI.JasonBackedObjects_UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.JasonBackedObjects.UnitTests
{
    [TestClass()]
    public class JsonBackedDictionary_UnitTests
    {

        public static JsonBackedDictionary<String> GetInstance()
        {
            var instance = new JsonBackedDictionary<string>("key", null);
            Assert.IsNotNull(instance);
            return instance;
        }

        [TestMethod()]
        public void JsonBackedDictionary_UnitTest()
        {
            var instance = new JsonBackedDictionary<string>("key", null);
            Assert.IsNotNull(instance);
        }

        [TestMethod()]
        public void Eval_UnitTest()
        {
            var instance = GetInstance();
            JsonBackedObjectBase source = new TestJsonBackedObject(null);
            var result = instance.Eval(source);
            Assert.IsNotNull(result);
        }

        public void SetValue_UnitTest()
        {
            var instance = GetInstance();
            JsonBackedObjectBase source = new TestJsonBackedObject(null);
            const string fieldName = "TargetField";
            const string value = "TargetValue";
            instance.SetValue(source, fieldName, value);
        }
    }
}
