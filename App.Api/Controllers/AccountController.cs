namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IAppUserService appUserService;
        public AccountController(UserManager<AppUser> userManager, IAppUserService appUserService)
        {
            this.userManager = userManager;
            this.appUserService = appUserService;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(AppUserAddDto appUserAddDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var appUser = await appUserService.AddAsync(appUserAddDto);
            if (appUserAddDto is null) return BadRequest();
            return Ok();
        }
    }
}