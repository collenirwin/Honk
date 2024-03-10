using EntityFramework.Exceptions.PostgreSQL;
using Honk.Server.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Honk.Server.Data;

/// <summary>
/// This application's primary database abstraction.
/// </summary>
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    /// <summary>
    /// Collation dbo name for case insensitive comparison.
    /// </summary>
    public const string CaseInsensiveCollationName = "case_insensitive_collation";

    public DbSet<Album> Albums => Set<Album>();
    public DbSet<AlbumComment> AlbumComments => Set<AlbumComment>();
    public DbSet<AlbumCommentNotification> AlbumCommentNotifications => Set<AlbumCommentNotification>();
    public DbSet<Photo> Photos => Set<Photo>();
    public DbSet<PhotoComment> PhotoComments => Set<PhotoComment>();
    public DbSet<PhotoCommentNotification> PhotoCommentNotifications => Set<PhotoCommentNotification>();
    public DbSet<Friendship> Friendships => Set<Friendship>();
    public DbSet<FriendRequestNotification> FriendRequestNotifications => Set<FriendRequestNotification>();
    public DbSet<Block> Blocks => Set<Block>();
    public DbSet<Tag> Tags => Set<Tag>();

    /// <inheritdoc />
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    ///<inheritdoc />
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseExceptionProcessor();
    }

    ///<inheritdoc />
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.HasCollation(
            name: CaseInsensiveCollationName,
            provider: "icu",
            locale: "@colStrength=primary", // ignore accent and case differences
            deterministic: false);

        builder.Entity<Tag>()
            .Property(tag => tag.TagText)
            .UseCollation(CaseInsensiveCollationName);

        // map friendships both ways
        builder.Entity<Friendship>()
            .HasOne(f => f.User1)
            .WithMany()
            .HasForeignKey(f => f.User1Id);

        builder.Entity<Friendship>()
            .HasOne(f => f.User2)
            .WithMany()
            .HasForeignKey(f => f.User2Id);
    }

    ///<inheritdoc />
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var timeTrackedEntries = ChangeTracker.Entries()
            .Where(entry => entry.Entity is ITimeTracked)
            .Where(entry => entry.State == EntityState.Added || entry.State == EntityState.Modified);

        foreach (var entry in timeTrackedEntries)
        {
            var timeTracked = (ITimeTracked)entry.Entity;

            if (entry.State == EntityState.Added)
            {
                timeTracked.CreatedOn = DateTime.UtcNow;
            }
            else
            {
                timeTracked.UpdatedOn = DateTime.UtcNow;

                // make sure we don't modify the CreatedOn if we're not inserting
                Entry(timeTracked).Property(a => a.CreatedOn).IsModified = false;
            }
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}
