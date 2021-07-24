using System;
using System.Collections.Generic;
using System.Text;
using DAL.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Models.DataSeed
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var (salt, hash) = PasswordHelper.GenerateSecurePassword("Hoangbuu1998");
            builder.HasData(
                new User
                {
                    Id = new Guid("c0e9aa05-db0c-41d1-97ba-243900bd18ba"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("514b3faa-07bb-4c60-9f2e-f78fad36f0b1"),
                },

                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000001"),
                    UserName = "damvanhoangbuu1",
                    FullName = "An Nguyen",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000002"),
                    UserName = "damvanhoangbuu1",
                    FullName = "Van Truong",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000003"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Tu Chau",
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000004"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Suong Tran",
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000005"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Quy Tran",
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000006"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Quy Nguyen",
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000007"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Son Nguyen",
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000008"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Tu Nguyen",
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000009"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Tu Phan",
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000010"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Tu Tran",
                },
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000011"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    FullName = "Anh Phan",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000001"),
                    UserName = "damvanhoangbuu1",
                    FullName = "Anh Nguyen",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000002"),
                    UserName = "damvanhoangbuu1",
                    FullName = "Tue Anh Nguyen",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000003"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Huyen Nguyen",
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000004"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Kieu Bui",
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000005"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Kieu Tran",
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000006"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Mi Tran",
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000007"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "My Nguyen",
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000008"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Ha Nguyen",
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000009"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Ha Tran",
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000010"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                    FullName = "Ha Phan",
                },
                new User
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000011"),
                    UserName = "damvanhoangbuu1",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                    Address = "80 Nguyen Chanh - Lien Chieu - Da Nang",
                    FullName = "Buu Dam",
                    PositionId = new Guid("00000000-0000-0000-0000-000000000002"),
                }
            );
        }
    }
}
