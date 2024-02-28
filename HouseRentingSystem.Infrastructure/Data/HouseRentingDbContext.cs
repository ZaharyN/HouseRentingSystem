using HouseRentingSystem.Infrastructure.Data.DataModels;
using HouseRentingSystem.Infrastructure.Data.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HouseRentingSystem.Infrastrucure.Data
{
    public class HouseRentingDbContext : IdentityDbContext
    {
        public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Agent> Agents { get; set; } = null!;
        public DbSet<House> Houses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguarion());
            builder.ApplyConfiguration(new AgentConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguarion());
            builder.ApplyConfiguration(new HouseConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
