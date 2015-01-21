using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.Build
{
    /// <summary>
    ///     Generated Test Template
    /// </summary>
    public partial class JsonBuildQueue_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Froms the token_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="token">The token.</param>
        partial void FromToken_PreCondition(JsonBuildQueue instance, ref JToken token) { token = TestData; }

        /// <summary>
        ///     Jsons the source.
        /// </summary>
        /// <param name="json">The json.</param>
        static partial void JsonSource(ref JToken json) { json = TestData; }

        /// <summary>
        ///     Gets the test data.
        /// </summary>
        /// <value>The test data.</value>
        private static JToken TestData
        {
            get
            {
                JObject jobject = CannedMessages.SampleBuildQueues;
                var array = jobject["value"].Value<JArray>();
                JToken json = array[0];
                return json;
            }
        }
    }
}