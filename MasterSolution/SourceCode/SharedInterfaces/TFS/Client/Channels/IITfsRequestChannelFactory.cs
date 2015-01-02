namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
    /// <summary>
    /// Interface IITfsRequestChannelFactory
    /// </summary>
    public interface IITfsRequestChannelFactory
    {
        /// <summary>
        /// Creates the channel.
        /// </summary>
        /// <param name="innerChannel">The inner channel.</param>
        /// <returns>IITfsRequestChannel.</returns>
        IITfsRequestChannel CreateChannel(IITfsRequestChannel innerChannel);
    }
}