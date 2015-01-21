using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.CodeGeneration
{
    /// <summary>
    /// Class GenerateCodeFRomJsonSpecs.
    /// </summary>
    [TestClass, System.Runtime.InteropServices.GuidAttribute("BEC77E32-6058-40CC-B0E3-4A1E4B380FAF")]
    public class GenerateCodeFRomJsonSpecs
    {
        /// <summary>
        /// Creates the call specs.
        /// </summary>
        [TestMethod]
        public void CreateCallSpecs()
        {
            var names = CannedMessages.GetResources();
            List<string> known = new List<string>();
            foreach (var name in names)
            {
                if (name.EndsWith(".json"))
                {
                    var info = CannedMessages.GetResourceFormat(name);
                    string resourceFormat = info.ResourceFormat;
                    int index = resourceFormat.IndexOf('?');
                    if (index >= 0)
                        resourceFormat = resourceFormat.Substring(0, index);
                    string key = info.Method + ": " + resourceFormat;
                    if (!known.Contains(key))
                    {
                        known.Add(key);
                        Console.WriteLine("{0}\t\t{1}\t\t{2}", resourceFormat,info.Method,info.RequestUrl);
                    }
                    ;
                }
            }
        }
    }
}
