using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Identity;

namespace Site.Areas.Identity.Data;

public class UserContext : IdentityDbContext<ApplicationUser>
{
    public UserContext(DbContextOptions<UserContext> options)
       : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}