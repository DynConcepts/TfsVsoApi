using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DynCon.OSI.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.Core_UnitTests
{
    /// <summary>
    ///     Class ObjectMapper_UnitTests.
    /// </summary>
    [TestClass]
    public class ObjectMapper_UnitTests
    {
        /// <summary>
        ///     Conversion_s the unit test.
        /// </summary>
        [TestMethod]
        public void Conversion_UnitTest()
        {
            ObjectMapper<A, B> mapper = GetTestInstance();
            List<A> aList;
            List<B> bList;
            CreateData(mapper, out aList, out bList);
            mapper.Purge();
            Assert.AreEqual(1000, aList.Count);
            Assert.AreEqual(1000, bList.Count);
            Assert.AreEqual(1000, mapper.Count);

            foreach (A a in bList.Select(mapper.Convert))
            {
                Assert.IsNotNull(a);
            }
            Assert.AreEqual(1000, aList.Count);
            Assert.AreEqual(1000, bList.Count);
            Assert.AreEqual(1000, mapper.Count);

            bList.Clear();
            RunGC();
            mapper.Purge();
            Assert.AreEqual(1000, aList.Count);
            Assert.AreEqual(0, bList.Count);
            Assert.AreEqual(1000, mapper.Count);

            aList.Clear();
            RunGC();
            mapper.Purge();
            Assert.AreEqual(0, aList.Count);
            Assert.AreEqual(0, bList.Count);
            Assert.IsTrue(mapper.Count < 2);
        }

        private static void CreateData(ObjectMapper<A, B> mapper, out List<A> aList, out List<B> bList)
        {
            aList = new List<A>();
            bList = new List<B>();
            for (int count = 0; count < 1000; ++count)
            {
                var b = new B();
                bList.Add(b);
                aList.Add(mapper.Convert(b));
            }
            Assert.AreEqual(1000, aList.Count);
            Assert.AreEqual(1000, bList.Count);
            Assert.AreEqual(1000, mapper.Count);

            RunGC();
        }


        /// <summary>
        ///     Mapper_s the purge_ unit test.
        /// </summary>
        [TestMethod]
        public void Mapper_Purge_UnitTest()
        {
            ObjectMapper<A, B> mapper = GetTestInstance();
            mapper.PurgeTime = TimeSpan.FromMilliseconds(10);
            List<A> aList;
            List<B> bList;
            CreateData(mapper, out aList, out bList);
            Assert.AreEqual(1000, aList.Count);
            Assert.AreEqual(1000, bList.Count);
            Assert.AreEqual(1000, mapper.Count);

            aList.Clear();
            bList.Clear();
            RunGC();
            Thread.Sleep(TimeSpan.FromMilliseconds(100).Add(mapper.PurgeTime));

            Assert.IsTrue(mapper.Count < 2);
        }

        /// <summary>
        ///     Objects the mapper_ unit test.
        /// </summary>
        [TestMethod]
        public void ObjectMapper_UnitTest()
        {
            ObjectMapper<A, B> mapper = GetTestInstance(); 
            Assert.IsNotNull(mapper);
        }

        /// <summary>
        ///     Gets the test instance.
        /// </summary>
        /// <returns>ObjectMapper&lt;A, B&gt;.</returns>
        private static ObjectMapper<A, B> GetTestInstance() { return new ObjectMapper<A, B>(a => a.B, b => new A(b)); }

        /// <summary>
        ///     Runs the gc.
        /// </summary>
        private static void RunGC()
        {
            GC.Collect(2);
            GC.WaitForPendingFinalizers();
        }

        /// <summary>
        ///     Class A.
        /// </summary>
        private class A
        {
            /// <summary>
            ///     Gets the b.
            /// </summary>
            /// <value>The b.</value>
            public B B { get { return r_B; } }

            /// <summary>
            ///     Initializes a new instance of the <see cref="A" /> class.
            /// </summary>
            /// <param name="b">The b.</param>
            public A(B b) { r_B = b; }

            /// <summary>
            ///     The _b
            /// </summary>
            private readonly B r_B;
        }

        /// <summary>
        ///     Class B.
        /// </summary>
        private class B
        {
        }
    }
}