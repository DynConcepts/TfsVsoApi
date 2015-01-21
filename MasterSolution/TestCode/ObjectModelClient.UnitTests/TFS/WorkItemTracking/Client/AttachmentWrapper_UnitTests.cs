using System;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class AttachmentWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref Attachment real, string callerName)
        {
            string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";
            ;
            using (var writer = File.Create(fileName))
            {
            }
            real = new Attachment(fileName);
        }

    }
}