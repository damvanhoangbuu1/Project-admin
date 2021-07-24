using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Models.DataSeed
{
    class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasData(new Skill {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Name = ".NET Core",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                Name = "Java",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000003"),
                Name = "Android",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000004"),
                Name = "iOS",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000005"),
                Name = "ReactJS",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000006"),
                Name = "React Native",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000007"),
                Name = "Flutter",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000008"),
                Name = "Angular",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000009"),
                Name = "VueJS",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000010"),
                Name = "Ruby",
                EntityStatus = 0
            },
            new Skill
            {
                Id = new Guid("00000000-0000-0000-0000-000000000011"),
                Name = "ModeJS",
                EntityStatus = 0
            }
            );
        }
    }
}
