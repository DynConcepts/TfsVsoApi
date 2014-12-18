using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DynCon.OSI.JasonBackedObjects.UnitTests
{
    [TestClass()]
    public class JsonBackedDataBase_UnitTests
    {
        [TestMethod()]
        public void MakeToken_UnitTest()
        {
            string source = "Hello";
            var result = JsonBackedDataBase<Object>.MakeToken(source);
            Assert.IsNotNull(result);
        }
    }
}
