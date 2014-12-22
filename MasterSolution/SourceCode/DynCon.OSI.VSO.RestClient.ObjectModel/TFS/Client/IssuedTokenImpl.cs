using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class IssuedTokenImpl : IIssuedToken
    {
        Boolean IIssuedToken.IsAuthenticated { get { throw new ToBeImplementedException(); } }
    }
}