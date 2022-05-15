using Entities.Api;
using Microsoft.EntityFrameworkCore;

namespace DEVTRACK.API.Persistence
{
    public class DevTrackContext : DbContext
    {
        public DevTrackContext(DbContextOptions<DevTrackContext> options) : base(options)
        {

        }

        public DbSet<Package> Package { get; set; }

        public DbSet<PackageUpdate>  PackageUpdates {get; set;}


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Package>(
                a=>{
                a.ToTable("tb_Packahse");
                a.HasKey(p=> p.Id);
                a.HasMany(p=> p.Updates).WithOne().HasForeignKey(pu=> pu.PackageId)
                .OnDelete(DeleteBehavior.Restrict);
                });

                builder.Entity<PackageUpdate>(
                    e=> {
                        e.HasKey(m=> m.PackageId);
                    }
                );

        }
    }

}