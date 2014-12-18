using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace SimpleSamples
{
    class Program
    {
        private static void Main(string[] args)
        {
            var warmup = Measure(() => ClassicObjectModel(new TfsTeamProjectCollection(new Uri("*****"))));  // TODO Put in appropriate value, then refactor

            var classic = Measure(() => ClassicObjectModel(new TfsTeamProjectCollection(new Uri("*****"))));  // TODO Put in appropriate value, then refactor

            Console.WriteLine("==========================");
            Console.WriteLine("======   WRAPPED  ========");
            Console.WriteLine("==========================");
            var wrapped = Measure(() => TfsVSOApi(DynCon.OSI.VSO.ObjectModelClient.Factories.APIFactory.Connect(new Uri("*****"))));  // TODO Put in appropriate value, then refactor


            RestClientManager.BasicAuthorizationUsername = "*****";  // TODO Put in appropriate value, then refactor
            RestClientManager.BasicAuthorizationPassword = "*****";  // TODO Put in appropriate value, then refactor
            VSOClientManager.VsoCollection = "*****";  // TODO Put in appropriate value, then refactor
            Console.WriteLine("==========================");
            Console.WriteLine("=======   REST  ==========");
            Console.WriteLine("==========================");
            var rest = Measure(() => TfsVSOApi(DynCon.OSI.VSO.ReSTClient.Factories.APIFactory.Connect(new Uri("*****"))));  // TODO Put in appropriate value, then refactor


            //    Console.WriteLine("Warm-Up={0}Sec       Classic={1}Sec    ", warmup.TotalSeconds, classic.TotalSeconds);
            // Console.WriteLine(" Wrapped={0}Sec      ReST={1}Sec", wrapped.TotalSeconds, rest.TotalSeconds);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        static TimeSpan Measure(Action action)
        {
            var sw = new Stopwatch();
            sw.Start();
            action();
            var elapsed = sw.Elapsed;
            return elapsed;
        }

        private static void ClassicObjectModel(TfsTeamProjectCollection tfs)
        {
            tfs.EnsureAuthenticated();

            WorkItemStore workitemstore = tfs.GetService<WorkItemStore>();

            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            WorkItemCollection wic = workitemstore.Query(wiql);
            foreach (WorkItem wi in wic)
            {
                if (wi.Rev > 1)
                {
                    Console.WriteLine("{0}:{1}\t{2}", wi.Id, wi.Rev, wi.Title);
                    var revisions = wi.Revisions;
                    foreach (Revision revision in revisions)
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", revision.Index, revision.Fields.Count, revision.Fields["System.ChangedDate"].Value);
                    }
                }
                if (wi.Links.Count > 0)
                {
                    Console.WriteLine("{0}:{1}\t{2}", wi.Id, wi.Rev, wi.Title);
                    Console.WriteLine("\t{0} Links", wi.Links.Count);
                    foreach (Link link in wi.Links)
                    {
                        Console.WriteLine("\t\t{0}\tComment: {1}", WriteSpecific(link), SafeWriteComment(link));
                    }
                }
            }
        }
        private static void TfsVSOApi(ITfsTeamProjectCollection tfs)
        {
            tfs.EnsureAuthenticated();
            bool first = true;
            IWorkItemStore workitemstore = tfs.GetService<IWorkItemStore>();


            //var linkTester = workitemstore.GetWorkItem(195);
            //var links = linkTester.Links;
            //var count = links.Count;
            //foreach (ILink link in links)
            //{
            //    Console.WriteLine("\t\t{0}\tComment: {1}", WriteSpecific(link), SafeWriteComment(link));
            //}
 
            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            IWorkItemCollection wic = workitemstore.Query(wiql);

            foreach (IWorkItem wi in wic)
            {
                if (wi.Rev > 1)
                {
                    Console.WriteLine("{0}:{1}\t{2}", wi.Id, wi.Rev, wi.Title);
                    var revisions = wi.Revisions;
                    foreach (IRevision revision in revisions)
                    {
                        var value = (DateTime) revision.Fields["System.ChangedDate"].Value;
                        Console.WriteLine("\t{0}\t{1}\t{2} {3}", revision.Index, revision.Fields.Count, value, value.Kind);
                        bool dumpFields = false;
                        if (dumpFields && first)
                        {
                            first = false;
                            var names = (from IField field in revision.Fields select field.ReferenceName).ToList();
                            names.Sort();
                            foreach (string name in names)
                            {
                                Console.WriteLine("\t\t{0}", name);
                            }
                        }
                    }
                }
                if (wi.Links.Count > 0)
                {
                    Console.WriteLine("{0}:{1}\t{2}", wi.Id, wi.Rev, wi.Title);
                    Console.WriteLine("\t{0} Links", wi.Links.Count);
                    foreach (ILink link in wi.Links)
                    {
                        Console.WriteLine("\t\t{0}\tComment: {1}", WriteSpecific(link), SafeWriteComment(link));
                    }
                }
            }
        }

        private static string SafeWriteComment(ILink link)
        {
            try
            {
                return link.Comment;
            }
            catch (Exception ex)
            {
                return String.Format("{0}:{1}", ex.GetType().Name, ex.Message);
            }
        }

        private static string WriteSpecific(ILink link)
        {
            var asRelated = link as IRelatedLink;
            if (asRelated != null) return Write(asRelated);
            var asWorkItem = link as IWorkItemLink;
            if (asWorkItem != null) return Write(asWorkItem);
            var asHyper = link as IHyperlink;
            if (asHyper != null) return Write(asHyper);
            return link.GetType().Name;
        }

        static string Write(IRelatedLink link) 
        {
            return String.Format(" (RelatedLink) Id:{0} BaseeType:{1} LinkTypeEnd.Name:{2} LinkTypeEnd.ImmutableName:{3}  LinkTypeEnd.Id:{4}, LinmkTypeEnd.IsForward:{5}",
            link.RelatedWorkItemId, link.BaseType, link.LinkTypeEnd.Name, link.LinkTypeEnd.ImmutableName, SafeWriteId(link.LinkTypeEnd), link.LinkTypeEnd.IsForwardLink); 
        }

        private static String SafeWriteId(IWorkItemLinkTypeEnd workItemLinkTypeEnd)
        {
            try
            {
                return String.Format("{0}", workItemLinkTypeEnd.Id);
            }
            catch (Exception ex)
            {
                return String.Format("{0}:{1}", ex.GetType().Name, ex.Message);
            }
        }

        static string Write(IWorkItemLink link) { return String.Format("(WorkItemLink) Target Id:{0} Type:{1} ", link.TargetId, link.LinkTypeEnd.Name); }
        static string Write(IHyperlink link)
        {
            return String.Format("(Hyperlink) Location:{0}", link.Location);
        }
        private static string SafeWriteComment(Link link)
        {
            try
            {
                return link.Comment;
            }
            catch (Exception ex)
            {
                return String.Format("{0}:{1}", ex.GetType().Name, ex.Message);
            }
        }

        private static string WriteSpecific(Link link)
        {
            var asRelated = link as RelatedLink;
            if (asRelated != null) return Write(asRelated);
            var asWorkItem = link as WorkItemLink;
            if (asWorkItem != null) return Write(asWorkItem);
            var asHyper = link as Hyperlink;
            if (asHyper != null) return Write(asHyper);
            return link.GetType().Name;
        }

        static string Write(RelatedLink link) { return String.Format(" (RelatedLink) Id:{0} Type:{1}", link.RelatedWorkItemId, link.LinkTypeEnd.Name); }
        static string Write(WorkItemLink link) { return String.Format("(WorkItemLink) Target Id:{0} Type:{1} ", link.TargetId, link.LinkTypeEnd.Name); }
        static string Write(Hyperlink link)
        {
            return String.Format("(Hyperlink) Location:{0}", link.Location);
        }
    }
}
