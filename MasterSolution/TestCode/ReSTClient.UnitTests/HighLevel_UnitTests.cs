using System;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Factories;
using DynCon.OSI.VSO.ReSTClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests
{
    /// <summary>
    ///     Class HighLevel_UnitTests.
    /// </summary>
    [TestClass]
    public class HighLevel_UnitTests
    {
        /// <summary>
        ///     Scan_s the work items_ unit test.
        /// </summary>
        [TestMethod]
        public void Scan_WorkItems_UnitTest()
        {
            ITfsTeamProjectCollection tfs = new TfsTeamProjectCollectionImpl(new Uri(VSOClientManager.VsoCollection));
            tfs.EnsureAuthenticated();

            var workitemstore = tfs.GetService<IWorkItemStore>();

            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            IWorkItemCollection wic = workitemstore.Query(wiql);

            bool first = true;
            foreach (IWorkItem wi in wic)
            {
                if (wi.Rev > 1)
                {
                    //Console.WriteLine("{0}:{1}\t{2}", wi.Id, wi.Rev, wi.Title);
                    IRevisionCollection revisions = wi.Revisions;
                    foreach (IRevision revision in revisions)
                    {
                        var value = (DateTime) revision.Fields["System.ChangedDate"].Value;
                        //Console.WriteLine("\t{0}\t{1}\t{2} {3}", revision.Index, revision.Fields.Count, value, value.Kind);
                        bool dumpFields = true;
                        if (dumpFields && first)
                        {
                            first = false;
                            List<string> names = (from IField field in revision.Fields select field.ReferenceName).ToList();
                            names.Sort();
                            foreach (string name in names)
                            {
                                //Console.WriteLine("\t\t{0}", name);
                            }
                        }
                    }
                }
                if (wi.Links.Count > 0)
                {
                    //Console.WriteLine("{0}:{1}\t{2}", wi.Id, wi.Rev, wi.Title);
                    //Console.WriteLine("\t{0} Links", wi.Links.Count);
                    foreach (ILink link in wi.Links)
                    {
                        //Console.WriteLine("\t\t{0}\tComment: {1}", WriteSpecific(link), SafeWriteComment(link));
                    }
                }
            }
        }
    }
}