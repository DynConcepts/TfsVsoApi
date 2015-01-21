using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.Core_UnitTests.Helpers
{
    /// <summary>Generated Test Template</summary>
    public partial class CredentialsProvider_UnitTests : DynTestClassBase
    {
        partial void Read_PreCondition(ref String filePath) { filePath = "TestingCredentials.xml"; }

        partial void Write_PreCondition(ref String filePath, ref CredentialsStore credentials) { filePath = "TestingOutputCredentials.xml"; }
    }
}