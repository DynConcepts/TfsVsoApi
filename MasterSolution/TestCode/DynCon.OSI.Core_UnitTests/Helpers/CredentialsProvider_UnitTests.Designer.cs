using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.Core_UnitTests.Helpers
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CredentialsProvider_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Read_UnitTest()
        {
            String filePath = default(String);
            CredentialsStore _retVal = default(CredentialsStore);
            ExecuteMethod(
                () =>
                {
                    filePath = default(String); //No Constructor
                    Read_PreCondition(ref filePath);
                },
                () => { _retVal = CredentialsProvider.Read(filePath); },
                () => { Read_PostValidate(filePath, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Write_UnitTest()
        {
            String filePath = default(String);
            CredentialsStore credentials = default(CredentialsStore);
            ExecuteMethod(
                () =>
                {
                    filePath = default(String); //No Constructor
                    credentials = new CredentialsStore();
                    Write_PreCondition(ref filePath, ref credentials);
                },
                () => { CredentialsProvider.Write(filePath, credentials); },
                () => { Write_PostValidate(filePath, credentials); });
        }

        partial void Read_PostValidate(String filePath, CredentialsStore _retVal);
        partial void Read_PreCondition(ref String filePath);
        partial void Write_PostValidate(String filePath, CredentialsStore credentials);
        partial void Write_PreCondition(ref String filePath, ref CredentialsStore credentials);
    }
}