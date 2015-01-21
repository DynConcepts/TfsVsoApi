using System;
using System.Text;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    // [Ignore] // Cant find detqiled information
    public partial class IMetadataRowSetsWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref IMetadataRowSets real, string callerName)
        {
            CredentialsStore credentials = CredentialsProvider.Read(@"..\..\..\RestCredentials.xml");
            var uri = new Uri(credentials.VsoCollection);
            var tpc = new TfsTeamProjectCollection(uri);

            var workitemserver = tpc.GetService<WorkItemServer>();
            var workitemstore = tpc.GetService<WorkItemStore>();
            var id = 1;
            var workitem = workitemstore.GetWorkItem(id);


            // When you call update you need to pass the revision number that you want to update.
            // Most of the time ist t makes sense to use the latest revision, which is stored in the Rev property
            var revision = workitem.Rev.ToString();
            var date = DateTime.Today;

            // Create the xml package that is needed when calling the server to update a readonly field.   
            // Make sure you pass in the date using XmlConvert.ToString(date, XmlDateTimeSerializationMode.Local)
            // You won't get the correct date if you just call date.ToString()
            var sb = new StringBuilder();
            sb.Append("<Package>");
            sb.AppendFormat("<UpdateWorkItem ObjectType='WorkItem' BypassRules='1' WorkItemID='{0}' Revision='{1}'>", id, revision);
            sb.Append("<Columns>");
            sb.AppendFormat("<Column Column='System.CreatedDate' Type='DateTime'><Value>{0}</Value></Column>",
                XmlConvert.ToString(date, XmlDateTimeSerializationMode.Local));
            sb.Append("</Columns></UpdateWorkItem></Package>");

            /* This is what the XML looks like
                <Package>
                  <UpdateWorkItem ObjectType='WorkItem' BypassRules='1' WorkItemID='1279424' Revision='11'>
                    <Columns>
                       <Column Column='System.CreatedDate' Type='DateTime'><Value>1/1/2012 1:01:01 AM</Value></Column>
                    </Columns>
                  </UpdateWorkItem>
                </Package>
            */


            // Initialize the params that are needed for the service call
            var mthe = new MetadataTableHaveEntry[0];

            // Load the xml string into an XmlDocument so you can pull the document Element that 
            // the service call needs
            var x = new XmlDocument();
            x.LoadXml(sb.ToString());
 

            IMetadataRowSets metadata;
            string dbStamp;
            int count;
            DateTime asOfDate;
            string requestId = "";
            XmlElement psQuery = (XmlElement) x.FirstChild;
            bool useMaster = true;
            workitemserver.QueryWorkitemCount(requestId, psQuery, useMaster, out count, out asOfDate, new MetadataTableHaveEntry[] {}, out dbStamp, out metadata);

            real = metadata;
        }
    }
}