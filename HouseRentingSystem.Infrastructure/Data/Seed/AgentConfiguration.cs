using HouseRentingSystem.Infrastructure.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Infrastructure.Data.Seed
{
    internal class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            SeedData data = new SeedData();

            builder.HasData(new Agent[]
            {
                data.Agent
            });
        }
    }
}
