namespace App.Business.Services.Abstract
{
    public interface ITokenService
    {
        Task<IDataResult<TokenDto>> CreateAccessTokenAsync(IdentityUser identityUser, AuditablePersonBaseEntityDto auditablePersonBaseEntityDto);
    }
}