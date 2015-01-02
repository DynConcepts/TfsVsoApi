using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    public partial class VSOClientManager_UnitTests : DynTestClassBase
    {
        partial void VsoCollection_SetCondition(ref String setValue)
        {
            CredentialsStore credentials = CredentialsProvider.Read(@"..\..\..\RestCredentials.xml");
            setValue = credentials.VsoCollection;
        }
    }
}