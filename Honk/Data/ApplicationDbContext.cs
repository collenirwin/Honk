using Honk.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Honk.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    /// <inheritdoc />
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
