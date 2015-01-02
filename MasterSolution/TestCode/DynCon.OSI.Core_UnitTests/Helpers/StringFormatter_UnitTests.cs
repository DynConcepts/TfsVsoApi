using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;

namespace DynCon.OSI.Core_UnitTests.Helpers
{
    /// <summary>
    ///     Class StringFormatter_UnitTests.
    /// </summary>
    public partial class StringFormatter_UnitTests
    {
        partial void Build_PreCondition(ref StringFormatter instance, ref String template, ref Dictionary<String, String> values)
        {
            template = "{project}/_apis/{area}/workitemtypes/{type}/fields/{field}";
            values = new Dictionary<string, string>
            {
                {"{project}", "MyProject"},
                {"{area}", "MyArea"},
                {"{type}", "MyType"},
                {"{field}", "MyField"},
            };
        }


        partial void Parse_PreCondition(ref StringFormatter instance, ref String template) { template = "{project}/_apis/{area}/workitemtypes/{type}/fields/{field}"; }
    }
}