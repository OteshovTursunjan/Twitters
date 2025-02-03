using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.Identity;
using Twitters.Core.Common;
using Twitters.Core.Enitites;
using Twitters.Shared;

namespace Twitter.DataAccess;

public class DatabaseContext : IdentityDbContext<ApplicationUser>
{
    private readonly IClaimService? _claimService;

    public DatabaseContext(DbContextOptions<DatabaseContext> options, IClaimService? claimService = null)
        : base(options)
    {
        _claimService = claimService;
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
    }


public DbSet<CreatePost> CreatePost { get; set; }
    public DbSet<Post> Post { get; set; }
    public DbSet<PostLikes> PostLikes { get; set; }
    public DbSet<Saves> Saves { get; set; }
    public DbSet<WriteComment> WriteComment { get; set; }

    public DbSet<User> User { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
    public new async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        foreach (var entry in ChangeTracker.Entries<IAuditedEnity>())
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatBy = _claimService.GetUserId();
                    entry.Entity.CreatedOn = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdateBY = _claimService.GetUserId();
                    entry.Entity.UpdatedOn = DateTime.Now;
                    break;
            }
        return await base.SaveChangesAsync(cancellationToken);
    }

}
