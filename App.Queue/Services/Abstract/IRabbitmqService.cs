namespace App.Queue.Services.Abstract
{
    public interface IRabbitmqService
    {
        Task<IChannel> CreateChannelAsync();
    }
}