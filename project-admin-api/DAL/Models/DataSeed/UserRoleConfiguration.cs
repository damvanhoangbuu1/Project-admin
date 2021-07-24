using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Models.DataSeed
{
    class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(new UserRole
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                RoleId = new Guid("00000000-0000-0000-0000-000000000001"),
                UserId = new Guid("c0e9aa05-db0c-41d1-97ba-243900bd18ba")
            });
        }
    }
}
