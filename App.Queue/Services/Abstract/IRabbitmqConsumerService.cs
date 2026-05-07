namespace App.Queue.Services.Abstract
{
    public interface IRabbitmqConsumerService
    {
        Task<IResult> StartSendingEmailForNewAppUserAsync();

        Task<IResult> StartSendingEmailForEmailVerificationCodeAsync();
    }
}