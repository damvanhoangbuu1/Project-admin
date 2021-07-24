using DAL.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Models.DataSeed
{
    class RoleConfiguration:IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new Role
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Name = DefaultRole.Admin
            },
            new Role
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                Name = DefaultRole.User
            }
            );
        }
    }
}
