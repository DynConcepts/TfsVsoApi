using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    public interface ITfsTeamProjectCollection : ITfsConnection
    {
        ITfsConfigurationServer ConfigurationServer { get; }
        String DisplayName { get; }
        ITeamFoundationServer TeamFoundationServer { get; }
    }
}