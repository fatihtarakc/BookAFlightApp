namespace App.Business.Services.Abstract
{
    public interface IAccountService
    {
        Task<bool> AnyAsync(Expression<Func<IdentityUser, bool>> expression);

        Task<IdentityResult> AddAsync(IdentityUser identityUser, Role role);

        Task<IdentityUser> FindByEmailAsync(string email);

        Task<IdentityUser> FindByIdAsync(string id);

        Task<IdentityUser> FindByNameAsync(string username);

        Task<Role?> GetRoleAsync(IdentityUser identityUser);

        Task<SignInResult> PasswordSignInAsync(IdentityUser identityUser, string password, bool isPersistent = false, bool isLockoutOnFailure = false);

        Task SignOutAsync();
    }
}