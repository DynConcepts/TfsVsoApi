using System;
using System.Collections.Generic;
using System.IO;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonAvailableRestCall_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Dummies this instance.
        /// </summary>
        //[TestMethod]
        public void dummy()
        {
            JObject jobject = JObject.Parse(CannedMessages.AvailableRestCalls);
            var array = jobject["value"].Value<JArray>();
            var summary = new Dictionary<string, Dictionary<string, List<string>>>();
            foreach (JToken element in array)
            {
                var area = element["area"].Value<String>();
                var resource = element["resourceName"].Value<String>();
                var route = element["routeTemplate"].Value<String>();
                Dictionary<string, List<string>> dictionary;
                if (!summary.TryGetValue(area, out dictionary))
                {
                    dictionary = new Dictionary<string, List<string>>();
                    summary.Add(area, dictionary);
                }
                List<string> list;
                if (!dictionary.TryGetValue(resource, out list))
                {
                    list = new List<string>();
                    dictionary.Add(resource, list);
                }
                list.Add(route);
            }
            foreach (KeyValuePair<string, Dictionary<string, List<string>>> pair1 in summary)
            {
                using (var sw = new StreamWriter(String.Format("C:\\Repos\\visualstudio.dynconcepts\\TFSVSO API (OpenSource )\\MasterSolution\\SourceCode\\ReSTClient\\RestCalls\\{0}RestCalls.cs", pair1.Key)))
                {
                    sw.WriteLine("class {0}RestCalls", pair1.Key);
                    sw.WriteLine("{");
                    foreach (KeyValuePair<string, List<string>> pair2 in pair1.Value)
                    {
                        foreach (string item in pair2.Value)
                        {
#pragma warning disable 219
                            bool isProjectLEvel = false;
#pragma warning restore 219
                            string route = item.Replace("{area}", pair1.Key);
                            route = route.Replace("{resource}", pair2.Key);
                            //if (route.StartsWith("{project}/_apis"))
                            //{
                            //    isProjectLEvel = true;
                            //    route = route.Substring(14);
                            //}
                            //else
                            //    if (route.StartsWith("_apis"))
                            //    {
                            //        isProjectLEvel = false;
                            //        route = route.Substring(5);
                            //    }

                            sw.Write(" internal static CallSpec {0}", pair2.Key);
                            if (pair2.Value.Count > 1)
                                sw.Write("_{0}", pair2.Value.IndexOf(item));
                            sw.Write(" { get { return ");
                            sw.Write("sr_{0}", pair2.Key);
                            if (pair2.Value.Count > 1)
                                sw.Write("_{0}", pair2.Value.IndexOf(item));
                            sw.Write("; } }");
                            sw.WriteLine();
                            sw.Write(" private static readonly CallSpec sr_{0}", pair2.Key);
                            if (pair2.Value.Count > 1)
                                sw.Write("_{0}", pair2.Value.IndexOf(item));
                            sw.Write("= new CallSpec(\"{0}\");", route);
                            //sw.Write("= new CallSpec(\"{0}\",{1});", route, isProjectLEvel.ToString().ToLowerInvariant());
                            sw.WriteLine();
                        }
                    }
                    sw.WriteLine("}");
                }
            }
        }

        partial void FromToken_PreCondition(JsonAvailableRestCall instance, ref JToken json)
        {
            JObject jobject = JObject.Parse(CannedMessages.AvailableRestCalls);
            var array = jobject["value"].Value<JArray>();
            json = array[0];
        }

        static partial void JsonSource(ref JToken json)
        {
            JObject jobject = JObject.Parse(CannedMessages.AvailableRestCalls);
            var array = jobject["value"].Value<JArray>();
            json = array[0];
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>();
    }
}