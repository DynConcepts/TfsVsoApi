using System;
using DynCon.OSI.DynTest.Comparisions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.DynTest_UnitTests.Comparisions
{
    [TestClass()]
    public class DeepCompare_UnitTests
    {

        class Foo
        {
#pragma warning disable 169
#pragma warning disable 649
            public int a;
            public double b;
            public string c;
            public DateTime vd;
            public Foo e;
#pragma warning restore 649
#pragma warning restore 169

        }

        [TestMethod()]
        public void CompareGraph_Identical_UnitTest()
        {
            var left = new Foo();
            var right = new Foo();
            var result = DeepCompare.CompareGraph(left, right);
        }
        [TestMethod()]
        public void CompareGraph_Same_UnitTest()
        {
            var left = new Foo { e = new Foo() };
            var right = new Foo { e = new Foo() };
            var result = DeepCompare.CompareGraph(left, right);
        }

        [TestMethod()]
        public void CompareGraph_Loop_UnitTest()
        {
            var left = new Foo();
            var right = new Foo();
            left.e = left;
            right.e = right;
            var result = DeepCompare.CompareGraph(left, right);
        }
    }
}
