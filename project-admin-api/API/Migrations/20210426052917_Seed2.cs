using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c0e9aa05-db0c-41d1-97ba-243900bd18ba"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 } });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "AllowTokensSince", "AvatarUrl", "BirthDate", "CreatedTime", "Description", "Email", "EntityStatus", "FullName", "Gender", "Location", "PasswordHash", "PasswordSalt", "Phone", "PositionId", "SocialLink", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000009"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Ha Tran", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Ha Nguyen", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "My Nguyen", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Mi Tran", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Kieu Tran", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Kieu Bui", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Huyen Nguyen", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Tue Anh Nguyen", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000001"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Anh Nguyen", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Ha Phan", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Anh Phan", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Tu Phan", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Tu Nguyen", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Son Nguyen", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Quy Nguyen", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Quy Tran", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Suong Tran", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Tu Chau", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Van Truong", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "An Nguyen", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Tu Tran", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Buu Dam", 0, null, new byte[] { 95, 32, 72, 16, 82, 4, 40, 199, 74, 89, 63, 121, 6, 183, 232, 74, 217, 79, 42, 143, 35, 209, 67, 46, 227, 68, 153, 46, 143, 3, 66, 146 }, new byte[] { 113, 185, 201, 153, 102, 169, 39, 242, 205, 86, 24, 128, 188, 12, 116, 189, 46, 187, 141, 81, 26, 22, 166, 92, 146, 238, 56, 142, 85, 105, 228, 10, 156, 47, 91, 76, 33, 80, 228, 236, 170, 240, 169, 106, 75, 125, 66, 53, 77, 167, 225, 57, 177, 33, 209, 25, 205, 223, 1, 118, 31, 53, 121, 74 }, null, new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c0e9aa05-db0c-41d1-97ba-243900bd18ba"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 117, 208, 76, 166, 80, 186, 3, 170, 147, 205, 175, 120, 73, 58, 66, 141, 33, 22, 146, 9, 25, 249, 57, 150, 60, 103, 173, 15, 72, 115, 147, 132 }, new byte[] { 130, 223, 146, 105, 33, 226, 12, 138, 184, 96, 31, 71, 161, 227, 196, 42, 130, 173, 76, 46, 168, 8, 235, 153, 166, 22, 90, 174, 70, 197, 9, 47, 10, 179, 96, 17, 223, 157, 127, 88, 136, 166, 200, 234, 138, 74, 67, 150, 186, 113, 39, 111, 181, 84, 76, 169, 221, 86, 217, 16, 128, 85, 219, 54 } });
        }
    }
}
