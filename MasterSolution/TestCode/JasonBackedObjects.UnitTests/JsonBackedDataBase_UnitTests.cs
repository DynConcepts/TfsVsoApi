using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonBackedDataBase_UnitTests : DynTestClassBase
    {
        static partial void InstanceFactory(ref JsonBackedDataBase instance, string callerName)
        {
            instance = new JsonUnitTestObject();
        }


        internal class JsonUnitTestObject : JsonBackedDataBase
        {
        }
    }
}