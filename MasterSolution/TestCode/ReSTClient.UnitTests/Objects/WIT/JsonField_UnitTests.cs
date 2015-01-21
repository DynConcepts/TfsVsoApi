using System;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonField_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context)
        {
            var api = new JsonWitAPI();
            Assert.IsNotNull(api);
        }

        partial void FromToken_PreCondition(JsonField instance, ref JToken json) { json = new JProperty("System.Title", "WorkItem Created by Unit Testing"); }

        static partial void InstanceFactory(ref JsonField instance, string callerName)
        {
            var json = new JProperty("System.Title", "WorkItem Created by Unit Testing");
            instance = JsonField.FromToken(json);
        }

        partial void Value_SetCondition(ref JsonField instance, ref Object setValue)
        {
            setValue = "Title For Setting Value";
            ExpectEvent("ListChanged{Newtonsoft.Json.Linq.JContainer}");
            ExpectEvent("CollectionChanged{Newtonsoft.Json.Linq.JContainer}");
        }
    }
}