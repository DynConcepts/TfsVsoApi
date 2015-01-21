using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class IssuedTokenProviderWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref IssuedTokenProvider real, string callerName)
        {
            real = (TemporaryMock)FormatterServices.GetUninitializedObject(typeof(TemporaryMock));
        }

        class TemporaryMock : IssuedTokenProvider
        {
            public TemporaryMock(IssuedTokenCredential credential, Uri serverUrl, Uri signInUrl) : base(credential, serverUrl, signInUrl) {
            }

            protected override IssuedToken OnGetToken(IssuedToken failedToken, TimeSpan timeout) { return default(IssuedToken); }

            protected override IAsyncResult OnBeginGetToken(IssuedToken failedToken, TimeSpan timeout, AsyncCallback callback, object state) { return default(IAsyncResult); }

            protected override IssuedToken OnEndGetToken(IAsyncResult result) { return default(IssuedToken); }

            public override bool GetTokenIsInteractive { get { return default(bool); } }
        }

        partial void BeginGetToken_PreCondition(IIssuedTokenProvider instance, ref TimeSpan timeout, ref AsyncCallback callback, ref Object state) { callback = ar => { }; }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "BeginGetToken_UnitTest",
            "EndGetToken_UnitTest",
            "GetToken_UnitTest",
        };
    }
}