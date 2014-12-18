using System;
using System.Net.Http;
using System.Threading;
using DynCon.OSI.JasonBackedObjects.Communications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.Communications
{
    /// <summary>
    ///     Class HttpClientMock_UnitTests.
    /// </summary>
    [TestClass]
    public class HttpClientMock_UnitTests
    {
        /// <summary>
        ///     Assemblies the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            RestClientManager.BasicAuthorizationUsername = "davidVSO";
            RestClientManager.BasicAuthorizationPassword = "Alternate2014";
        }

        /// <summary>
        ///     Cancels the pending requests_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void CancelPendingRequests_UnitTest()
        {
            var instance = new HttpClientMock();
            instance.CancelPendingRequests();
        }

        /// <summary>
        ///     Deletes the async_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void DeleteAsync_UnitTest()
        {
            var instance = new HttpClientMock();
            instance.DeleteAsync("");
        }

        /// <summary>
        ///     Deletes the async_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void DeleteAsync_UnitTest1()
        {
            var instance = new HttpClientMock();
            instance.DeleteAsync(new Uri("http://example.com"));
        }

        /// <summary>
        ///     Deletes the async_ unit test2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void DeleteAsync_UnitTest2()
        {
            var instance = new HttpClientMock();
            instance.DeleteAsync("", new CancellationToken());
        }

        /// <summary>
        ///     Deletes the async_ unit test3.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void DeleteAsync_UnitTest3()
        {
            var instance = new HttpClientMock();
            instance.DeleteAsync(new Uri("http://example.com"), new CancellationToken());
        }

        /// <summary>
        ///     Dispose_s the unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void Dispose_UnitTest()
        {
            var instance = new HttpClientMock();
            instance.Dispose();
        }

        /// <summary>
        ///     Gets the async_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetAsync_UnitTest()
        {
            var instance = new HttpClientMock();
            instance.GetAsync("");
        }

        /// <summary>
        ///     Gets the async_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetAsync_UnitTest1()
        {
            var instance = new HttpClientMock();
            instance.GetAsync(new Uri("http://example.com"));
        }

        /// <summary>
        ///     Gets the async_ unit test2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetAsync_UnitTest2()
        {
            var instance = new HttpClientMock();
            instance.GetAsync(new Uri("http://example.com"), HttpCompletionOption.ResponseContentRead);
        }

        /// <summary>
        ///     Gets the async_ unit test3.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetAsync_UnitTest3()
        {
            var instance = new HttpClientMock();
            instance.GetAsync(new Uri("http://example.com"), new CancellationToken());
        }

        /// <summary>
        ///     Gets the async_ unit test4.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetAsync_UnitTest4()
        {
            var instance = new HttpClientMock();
            instance.GetAsync(new Uri("http://example.com"), HttpCompletionOption.ResponseContentRead, new CancellationToken());
        }

        /// <summary>
        ///     Gets the async_ unit test5.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetAsync_UnitTest5()
        {
            var instance = new HttpClientMock();
            instance.GetAsync("", HttpCompletionOption.ResponseContentRead);
        }

        /// <summary>
        ///     Gets the async_ unit test6.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetAsync_UnitTest6()
        {
            var instance = new HttpClientMock();
            instance.GetAsync("", new CancellationToken());
        }

        /// <summary>
        ///     Gets the async_ unit test7.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetAsync_UnitTest7()
        {
            var instance = new HttpClientMock();
            instance.GetAsync("", HttpCompletionOption.ResponseContentRead, new CancellationToken());
        }

        /// <summary>
        ///     Gets the byte array async_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetByteArrayAsync_UnitTest()
        {
            var instance = new HttpClientMock();
            instance.GetByteArrayAsync("");
        }

        /// <summary>
        ///     Gets the byte array async_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetByteArrayAsync_UnitTest1()
        {
            var instance = new HttpClientMock();
            instance.GetByteArrayAsync(new Uri("http://example.com"));
        }

        /// <summary>
        ///     Gets the stream async_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetStreamAsync_UnitTest()
        {
            var instance = new HttpClientMock();
            instance.GetStreamAsync("");
        }

        /// <summary>
        ///     Gets the stream async_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetStreamAsync_UnitTest1()
        {
            var instance = new HttpClientMock();
            instance.GetStreamAsync(new Uri("http://example.com"));
        }

        /// <summary>
        ///     Gets the string async_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetStringAsync_UnitTest()
        {
            var instance = new HttpClientMock();
            instance.GetStringAsync("");
        }

        /// <summary>
        ///     Gets the string async_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void GetStringAsync_UnitTest1()
        {
            var instance = new HttpClientMock();
            instance.GetStringAsync(new Uri("http://example.com"));
        }

        /// <summary>
        ///     Posts the async_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void PostAsync_UnitTest()
        {
            var instance = new HttpClientMock();
            instance.PostAsync("", null);
        }

        /// <summary>
        ///     Posts the async_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void PostAsync_UnitTest1()
        {
            var instance = new HttpClientMock();
            instance.PostAsync(new Uri("http://example.com"), null);
        }

        /// <summary>
        ///     Posts the async_ unit test2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void PostAsync_UnitTest2()
        {
            var instance = new HttpClientMock();
            instance.PostAsync(new Uri("http://example.com"), null, new CancellationToken());
        }

        /// <summary>
        ///     Posts the async_ unit test3.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void PostAsync_UnitTest3()
        {
            var instance = new HttpClientMock();
            instance.PostAsync("", null, new CancellationToken());
        }

        /// <summary>
        ///     Puts the async_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void PutAsync_UnitTest()
        {
            var instance = new HttpClientMock();
            instance.PutAsync("", null);
        }

        /// <summary>
        ///     Puts the async_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void PutAsync_UnitTest1()
        {
            var instance = new HttpClientMock();
            instance.PutAsync(new Uri("http://example.com"), null);
        }

        /// <summary>
        ///     Puts the async_ unit test2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void PutAsync_UnitTest2()
        {
            var instance = new HttpClientMock();
            instance.PutAsync(new Uri("http://example.com"), null, new CancellationToken());
        }

        /// <summary>
        ///     Puts the async_ unit test3.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void PutAsync_UnitTest3()
        {
            var instance = new HttpClientMock();
            instance.PutAsync("", null, new CancellationToken());
        }

        /// <summary>
        ///     Sends the async_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void SendAsync_UnitTest()
        {
            var instance = new HttpClientMock();
            var request = new HttpRequestMessage();
            instance.SendAsync(request, new CancellationToken());
        }

        /// <summary>
        ///     Sends the async_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void SendAsync_UnitTest1()
        {
            var instance = new HttpClientMock();
            var request = new HttpRequestMessage();
            instance.SendAsync(request);
        }

        /// <summary>
        ///     Sends the async_ unit test2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void SendAsync_UnitTest2()
        {
            var instance = new HttpClientMock();
            var request = new HttpRequestMessage();
            instance.SendAsync(request, HttpCompletionOption.ResponseContentRead);
        }

        /// <summary>
        ///     Sends the async_ unit test3.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void SendAsync_UnitTest3()
        {
            var instance = new HttpClientMock();
            var request = new HttpRequestMessage();
            instance.SendAsync(request, HttpCompletionOption.ResponseContentRead, new CancellationToken());
        }
    }
}