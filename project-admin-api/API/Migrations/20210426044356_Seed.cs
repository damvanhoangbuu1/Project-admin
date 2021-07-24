using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "CreatedTime", "EntityStatus", "Name", "UpdatedTime" },
                values: new object[] { new Guid("514b3faa-07bb-4c60-9f2e-f78fad36f0b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0, "ABC", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedTime", "EntityStatus", "Name", "UpdatedTime" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0, "Admin", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedTime", "EntityStatus", "Name", "UpdatedTime" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0, "User", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "AllowTokensSince", "AvatarUrl", "BirthDate", "CreatedTime", "Description", "Email", "EntityStatus", "FullName", "Gender", "Location", "PasswordHash", "PasswordSalt", "Phone", "PositionId", "SocialLink", "UpdatedTime", "UserName" },
                values: new object[] { new Guid("c0e9aa05-db0c-41d1-97ba-243900bd18ba"), "80 Nguyen Chanh - Lien Chieu - Da Nang", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, null, 0, null, new byte[] { 234, 220, 245, 55, 207, 41, 54, 146, 227, 253, 170, 210, 97, 74, 223, 91, 173, 21, 254, 61, 21, 24, 122, 107, 190, 198, 163, 77, 211, 111, 177, 6 }, new byte[] { 112, 128, 203, 210, 249, 206, 61, 37, 252, 192, 202, 87, 64, 13, 137, 13, 3, 199, 254, 90, 116, 82, 39, 150, 22, 196, 118, 229, 4, 148, 218, 60, 13, 37, 27, 13, 75, 43, 241, 193, 131, 194, 14, 133, 157, 203, 178, 148, 4, 22, 69, 110, 23, 28, 193, 224, 33, 53, 252, 206, 231, 168, 160, 69 }, null, new Guid("514b3faa-07bb-4c60-9f2e-f78fad36f0b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "damvanhoangbuu1" });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedTime", "EntityStatus", "RoleId", "UpdatedTime", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0, new Guid("00000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("c0e9aa05-db0c-41d1-97ba-243900bd18ba") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c0e9aa05-db0c-41d1-97ba-243900bd18ba"));

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: new Guid("514b3faa-07bb-4c60-9f2e-f78fad36f0b1"));
        }
    }
}
