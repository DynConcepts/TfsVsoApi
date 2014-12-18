using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    public class TestJsonBackedObject : JsonBackedObjectBase
    {
        public TestJsonBackedObject(JToken json) : base(json) {
        }
    }
}