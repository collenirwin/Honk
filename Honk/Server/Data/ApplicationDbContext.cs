﻿using Honk.Server.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Honk.Server.Data;

/// <summary>
/// This application's primary database abstraction.
/// </summary>
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    /// <inheritdoc />
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
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
