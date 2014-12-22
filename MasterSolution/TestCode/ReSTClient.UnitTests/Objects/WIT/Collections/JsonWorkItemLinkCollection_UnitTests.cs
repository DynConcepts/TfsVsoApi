using System;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT.Collections
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonWorkItemLinkCollection_UnitTests : DynTestClassBase
    {
        partial void Add_PreCondition(ref JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item) { item = JsonWorkItemLink_UnitTests.GetInstance(); }

        partial void CopyTo_PreCondition(ref JsonWorkItemLinkCollection instance, ref JsonWorkItemLink[] array, ref Int32 arrayIndex)
        {
            array = new JsonWorkItemLink[instance.Count + 1];
            arrayIndex = 1;
        }

        partial void IndexOf_PreCondition(ref JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item)
        {
            item = JsonWorkItemLink_UnitTests.GetInstance();
            instance.Add(item);
        }

        partial void Insert_PreCondition(ref JsonWorkItemLinkCollection instance, ref Int32 index, ref JsonWorkItemLink item)
        {
            item = JsonWorkItemLink_UnitTests.GetInstance();
            instance.Add(item);
        }

        partial void RemoveAt_PreCondition(ref JsonWorkItemLinkCollection instance, ref Int32 index)
        {
            JsonWorkItemLink item = JsonWorkItemLink_UnitTests.GetInstance();
            instance.Add(item);
            index = instance.Count - 1;
        }

        partial void Remove_PreCondition(ref JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item)
        {
            item = JsonWorkItemLink_UnitTests.GetInstance();
            instance.Add(item);
        }
    }
}