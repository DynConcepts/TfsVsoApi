using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DynCon.OSI.Core.Helpers.UnitTests
{
    /// <summary>
    /// Class StringFormatter_UnitTests.
    /// </summary>
    [TestClass()]
    public class StringFormatter_UnitTests
    {
        /// <summary>
        /// Build_s the unit test.
        /// </summary>
        [TestMethod()]
        public void Build_UnitTest()
        {
            var template = "{project}/_apis/{area}/workitemtypes/{type}/fields/{field}";
            var values = new Dictionary<string, string>
            {
                {"{project}", "MyProject"},
                {"{area}", "MyArea"},
                {"{type}", "MyType"},
                {"{field}", "MyField"},
            };
            var actual = StringFormatter.Build(template, values);
            Console.WriteLine(actual);
        }
    }
}
