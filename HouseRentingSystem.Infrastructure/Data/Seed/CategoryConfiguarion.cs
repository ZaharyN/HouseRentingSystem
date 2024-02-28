using HouseRentingSystem.Infrastructure.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Data.Seed
{
    internal class CategoryConfiguarion : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            SeedData data = new();

            builder.HasData(new Category[]
            {
                data.CottageCategory,
                data.DuplexCategory,
                data.SingleCategory
            });
        }
    }
}
