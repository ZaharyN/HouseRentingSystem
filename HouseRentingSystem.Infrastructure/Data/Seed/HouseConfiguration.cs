using HouseRentingSystem.Infrastructure.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Infrastructure.Data.Seed
{
    internal class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder
               .HasOne(h => h.Category)
                   .WithMany(c => c.Houses)
               .HasForeignKey(h => h.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(h => h.Agent)
                    .WithMany()
                .HasForeignKey(h => h.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            SeedData data = new();

            builder.HasData(new House[]
            {
                data.FirstHouse,
                data.SecondHouse,
                data.ThirdHouse,
            });
        }
    }
}
