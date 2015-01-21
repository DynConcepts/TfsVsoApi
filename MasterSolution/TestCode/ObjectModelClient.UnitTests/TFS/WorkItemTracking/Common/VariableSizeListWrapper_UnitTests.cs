using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Common
{
    /// <summary>Generated Test Template</summary>
    public partial class VariableSizeListWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref VariableSizeList real, string callerName)
        {
            real = new TemporaryMock();
        }

        class TemporaryMock : VariableSizeList
        {
            public override void RemoveAt(int index) { }

            public override int Count { get { return int.MinValue;  } }

            public override void Clear() { }

            protected override object GetItem(int index) { return null; }

            protected override int AddItem(object value) { return int.MinValue; }
        }

    }
}