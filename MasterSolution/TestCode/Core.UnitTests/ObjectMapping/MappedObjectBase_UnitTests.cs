using DynCon.OSI.DynTest;

namespace DynCon.OSI.Core.ObjectMapping
{
    /// <summary>Generated Test Template</summary>
    public partial class MappedObjectBase_UnitTests : DynTestClassBase
    {
        static partial void InstanceFactory(ref MappedObjectBase instance, string callerName) { instance = new TestMappedObject(); }

        private class TestMappedObject : MappedObjectBase
        {
        }
    }
}