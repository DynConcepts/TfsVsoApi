using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

            var wrapped = Measure(() => TfsVSOApi(DynCon.OSI.VSO.ObjectModelClient.Factories.APIFactory.Connect(new Uri("*****"))));  // TODO Put in appropriate value, then refactor


            RestClientManager.BasicAuthorizationUsername = "*****";  // TODO Put in appropriate value, then refactor
            RestClientManager.BasicAuthorizationPassword = "*****";  // TODO Put in appropriate value, then refactor
            VSOClientManager.VsoCollection = "*****";  // TODO Put in appropriate value, then refactor
            var rest = Measure(() => TfsVSOApi(DynCon.OSI.VSO.ReSTClient.Factories.APIFactory.Connect(new Uri("*****"))));  // TODO Put in appropriate value, then refactor
            Console.WriteLine("W@arm-Up={0}Sec", warmup.TotalSeconds);
            Console.WriteLine("Classic={0}Sec     Wrapped={1}Sec      ReST={2}Sec", classic.TotalSeconds, wrapped.TotalSeconds, rest.TotalSeconds);
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

            var workitemstore = tfs.GetService<WorkItemStore>();
            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            WorkItemCollection wic = workitemstore.Query(wiql);
            foreach (var wi in wic)
            {
                //Console.WriteLine("{0}:{1}\t{2}", wi.Id,wi.Rev, wi.Title);
            }
        }
        private static void TfsVSOApi(ITfsTeamProjectCollection tfs)
        {
            tfs.EnsureAuthenticated();

            var workitemstore = tfs.GetService<IWorkItemStore>();
            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            IWorkItemCollection wic = workitemstore.Query(wiql);
            foreach (var wi in wic)
            {
                //Console.WriteLine("{0}:{1}\t{2}", wi.Id,wi.Rev, wi.Title);
            }
        }
    }
}
