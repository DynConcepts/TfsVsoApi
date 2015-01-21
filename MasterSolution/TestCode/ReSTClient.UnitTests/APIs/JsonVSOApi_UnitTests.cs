using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonVSOApi_UnitTests : DynTestClassBase
    {
        partial void GetAvailableRestCalls_PostValidate(JsonVSOApi instance, Task<IReadOnlyList<JsonAvailableRestCall>> _retVal)
        {
            var result = _retVal.Result;
            foreach (var item in result)
            Console.WriteLine(item.RouteTemplate);
        }

    }
}