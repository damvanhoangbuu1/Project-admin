using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Models.DataSeed
{
    class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasData(new Position
            {
                Id = new Guid("514b3faa-07bb-4c60-9f2e-f78fad36f0b1"),
                Name = "Project Manager"
            },
            new Position
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Name = "HR"
            },
            new Position
            {
                Id = new Guid ("00000000-0000-0000-0000-000000000002"),
                Name = "Dev"
            },
            new Position
            {
                Id = new Guid("00000000-0000-0000-0000-000000000003"),
                Name = "Tester"
            },
            new Position
            {
                Id = new Guid("00000000-0000-0000-0000-000000000004"),
                Name = "QA"
            }
            );
        }
    }
}
