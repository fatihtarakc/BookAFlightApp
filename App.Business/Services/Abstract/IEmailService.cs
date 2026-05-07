namespace App.Business.Services.Abstract
{
    public interface IEmailService
    {
        Task<IResult> SendingEmailForNewAppUserAsync(EmailForNewAppUserDto emailForNewAppUserDto);

        Task<IResult> SendingEmailForEmailVerificationCodeAsync(EmailForVerificationCodeDto emailForVerificationCodeDto);
    }
}