using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ObjectModelClient.Factories;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using DynCon.OSI.VSO.ReSTClient.TFS.Client;

namespace SimpleSamples
{
    internal class Program
    {
        private static void ClassicObjectModel(TfsTeamProjectCollection tfs)
        {
            tfs.EnsureAuthenticated();

            var workitemstore = tfs.GetService<WorkItemStore>();

            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            WorkItemCollection wic = workitemstore.Query(wiql);
            foreach (WorkItem wi in wic)
            {
                if (wi.Rev > 1)
                {
                    Console.WriteLine("{0}:{1}\t{2}", wi.Id, wi.Rev, wi.Title);
                    RevisionCollection revisions = wi.Revisions;
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

        private static void Main(string[] args)
        {
            var t = new Test();
            Action a = t.Bar();
            a();

            TimeSpan warmup = Measure(() => ClassicObjectModel(new TfsTeamProjectCollection(new Uri("*****")))); // TODO Put in appropriate value, then refactor

            TimeSpan classic = Measure(() => ClassicObjectModel(new TfsTeamProjectCollection(new Uri("*****")))); // TODO Put in appropriate value, then refactor

            Console.WriteLine("==========================");
            Console.WriteLine("======   WRAPPED  ========");
            Console.WriteLine("==========================");
            TimeSpan wrapped = Measure(() => TfsVSOApi(APIFactory.Connect(new Uri("*****")))); // TODO Put in appropriate value, then refactor


            RestClientManager.BasicAuthorizationUsername = "*****"; // TODO Put in appropriate value, then refactor
            RestClientManager.BasicAuthorizationPassword = "*****"; // TODO Put in appropriate value, then refactor
            VSOClientManager.VsoCollection = "*****"; // TODO Put in appropriate value, then refactor
            Console.WriteLine("==========================");
            Console.WriteLine("=======   REST  ==========");
            Console.WriteLine("==========================");
            TimeSpan rest = Measure(() => TfsVSOApi(new TfsTeamProjectCollectionImpl(new Uri("*****")))); // TODO Put in appropriate value, then refactor


            //    Console.WriteLine("Warm-Up={0}Sec       Classic={1}Sec    ", warmup.TotalSeconds, classic.TotalSeconds);
            // Console.WriteLine(" Wrapped={0}Sec      ReST={1}Sec", wrapped.TotalSeconds, rest.TotalSeconds);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static TimeSpan Measure(Action action)
        {
            var sw = new Stopwatch();
            sw.Start();
            action();
            TimeSpan elapsed = sw.Elapsed;
            return elapsed;
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

        private static void TfsVSOApi(ITfsTeamProjectCollection tfs)
        {
            tfs.EnsureAuthenticated();
            bool first = true;
            var workitemstore = tfs.GetService<IWorkItemStore>();


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
                    IRevisionCollection revisions = wi.Revisions;
                    foreach (IRevision revision in revisions)
                    {
                        var value = (DateTime) revision.Fields["System.ChangedDate"].Value;
                        Console.WriteLine("\t{0}\t{1}\t{2} {3}", revision.Index, revision.Fields.Count, value, value.Kind);
                        bool dumpFields = false;
                        if (dumpFields && first)
                        {
                            first = false;
                            List<string> names = (from IField field in revision.Fields select field.ReferenceName).ToList();
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

        private static string Write(IRelatedLink link)
        {
            return String.Format(" (RelatedLink) Id:{0} BaseeType:{1} LinkTypeEnd.Name:{2} LinkTypeEnd.ImmutableName:{3}  LinkTypeEnd.Id:{4}, LinmkTypeEnd.IsForward:{5}",
                link.RelatedWorkItemId, link.BaseType, link.LinkTypeEnd.Name, link.LinkTypeEnd.ImmutableName, SafeWriteId(link.LinkTypeEnd), link.LinkTypeEnd.IsForwardLink);
        }

        private static string Write(IWorkItemLink link) { return String.Format("(WorkItemLink) Target Id:{0} Type:{1} ", link.TargetId, link.LinkTypeEnd.Name); }
        private static string Write(IHyperlink link) { return String.Format("(Hyperlink) Location:{0}", link.Location); }

        private static string Write(RelatedLink link) { return String.Format(" (RelatedLink) Id:{0} Type:{1}", link.RelatedWorkItemId, link.LinkTypeEnd.Name); }
        private static string Write(WorkItemLink link) { return String.Format("(WorkItemLink) Target Id:{0} Type:{1} ", link.TargetId, link.LinkTypeEnd.Name); }
        private static string Write(Hyperlink link) { return String.Format("(Hyperlink) Location:{0}", link.Location); }

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
    }

    internal class Test
    {
        public Action Bar()
        {
            int x = 1;
            Foo(ref x);
            Action a = () => { Foo(ref x); };
            a();
            return a;
        }

        public void Foo(ref int x) { ++x; }
    }
}