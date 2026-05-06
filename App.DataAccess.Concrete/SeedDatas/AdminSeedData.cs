namespace App.DataAccess.Concrete.SeedDatas
{
    internal static class AdminSeedData
    {
        private const string email = "admin@bookaflightapp.com";
        private const string username = "00000000000";
        private const string password = "Admin2026+-!?";
        internal static async Task AddAsync(IConfiguration configuration, IOptions<ConnectionOptions> iOptionsConnectionOptions, UserManager<IdentityUser> userManager)
        {
            var connectionOptions = iOptionsConnectionOptions.Value;
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<BookAFlightAppDbContext>();
            dbContextOptionsBuilder.UseSqlServer(connectionOptions?.MssqlServer);

            using BookAFlightAppDbContext db = new(dbContextOptionsBuilder.Options);
            if (!(await db.Roles.AnyAsync())) await AddRolesAsync(db);

            var identityUserByEmail = await userManager.FindByEmailAsync(email);
            var identityUserByUsername = await userManager.FindByNameAsync(username);
            if (identityUserByEmail is null && identityUserByUsername is null) await AddAdminAsync(db, userManager);

            await Task.CompletedTask;
        }

        private static async Task AddAdminAsync(BookAFlightAppDbContext db, UserManager<IdentityUser> userManager)
        {
            IdentityUser identityUser = new()
            {
                EmailConfirmed = true,
                Email = email.ToLowerInvariant(),
                UserName = username.ToLowerInvariant(),
                NormalizedEmail = email.ToUpperInvariant(),
                NormalizedUserName = username.ToUpperInvariant()
            };
            identityUser.PasswordHash = userManager.PasswordHasher.HashPassword(identityUser, password);
            await userManager.CreateAsync(identityUser);
            await userManager.AddToRoleAsync(identityUser, Role.Admin.ToString());

            Admin admin = new()
            {
                Email = email.ToLowerInvariant(),
                IdentityId = identityUser.Id
            };
            await db.Admins.AddAsync(admin);
            await db.SaveChangesAsync();
        }

        private static async Task AddRolesAsync(BookAFlightAppDbContext db)
        {
            List<Role> roles = Enum.GetValues<Role>().Cast<Role>().ToList();
            foreach (var role in roles)
            {
                if (await db.Roles.AnyAsync(dbRole => dbRole.Name == role.ToString())) continue;

                await db.Roles.AddAsync(new IdentityRole { Name = role.ToString(), NormalizedName = role.ToString().ToUpperInvariant() });
                await db.SaveChangesAsync();
            }
        }
    }
}