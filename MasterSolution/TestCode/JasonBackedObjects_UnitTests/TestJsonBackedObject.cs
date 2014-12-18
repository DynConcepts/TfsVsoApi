using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    /// <summary>
    ///     Class TestJsonBackedObject.
    /// </summary>
    public class TestJsonBackedObject : JsonBackedObjectBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public TestJsonBackedObject(JToken json) : base(json) { }
    }
}