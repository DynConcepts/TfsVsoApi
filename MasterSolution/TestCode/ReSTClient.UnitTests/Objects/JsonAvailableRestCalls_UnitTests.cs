using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>
    ///     Class JsonAvailableRestCalls_UnitTests.
    /// </summary>
    [TestClass]
    public class JsonAvailableRestCalls_UnitTests
    {
        /// <summary>
        ///     Gets the all_ unit test.
        /// </summary>
        [TestMethod]
        public void GetAll_UnitTest()
        {
            var api = new VSOApi();
            Task<IReadOnlyList<IAvailableRestCalls>> task = api.GetAvailableRestCalls();
            Assert.IsNotNull(task);
            IReadOnlyList<IAvailableRestCalls> result = task.Result;
            using (var writer = new StreamWriter("RestRequests.csv"))
            {
                writer.WriteLine("Id,Area,ResourceName,RouteTemplate,ResourceVersion,MinVersion,MaxVersion,ReleasedVersion");
                foreach (IAvailableRestCalls item in result)
                {
                    writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",
                        item.Id, item.Area, item.ResourceName, item.RouteTemplate, item.ResourceVersion, item.MinVersion, item.MaxVersion, item.ReleasedVersion);
                }
            }
        }
    }
}