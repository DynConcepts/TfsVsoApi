using System;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonBackedObjectBase_UnitTests : DynTestClassBase
    {
        static partial void InstanceFactory(ref JsonBackedObjectBase instance, string callerName)
        {
            instance = new JsonUnitTestObject(String.Empty);
        }



        internal class JsonUnitTestObject : JsonBackedObjectBase
        {
            public JsonUnitTestObject(JToken json) : base(json)
            {
            }
        }
    }
    
}