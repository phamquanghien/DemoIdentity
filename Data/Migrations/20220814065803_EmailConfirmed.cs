using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoIdentity.Data.Migrations
{
    public partial class EmailConfirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0d657f6-7a63-4352-bc82-1680af90a365", "0d9a1b5f-3b04-434c-9a17-15b0f1538aee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "61b2c913-f480-41d3-a6f1-f379e2b8a11f", "76d04124-4d1a-4d0c-9add-92bf73cd05e2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61b2c913-f480-41d3-a6f1-f379e2b8a11f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0d657f6-7a63-4352-bc82-1680af90a365");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d9a1b5f-3b04-434c-9a17-15b0f1538aee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76d04124-4d1a-4d0c-9add-92bf73cd05e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09ec502a-22b7-42d0-ba0b-79c9ed6754e7", "8282512a-fdbf-44a6-92e3-7b706f2df006", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9119d57-0edd-48bc-ab81-673ba41e0078", "e5be5cf0-f677-4297-8dae-460806b4c064", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "386f7392-871f-4f05-9366-88b4169488c6", 0, "158b3bc0-0fdf-4a25-a6a2-93359457beb0", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEO7GMUoabsUJ/vGIvRzI8fKFhv6O2wtBToxsIRIG/o1EKQWCPmwzucCTsOVHuNXxRA==", null, false, "99c77be0-b13c-4424-8b00-d151c00c443e", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cba56991-4ec3-4fad-be08-cbdcaf3982ad", 0, "20689676-ec6b-4d49-9c85-80dcd6677f3a", "pqh.cntt@gmail.com", true, false, null, "PQH.CNTT@GMAIL.COM", "PQH.CNTT@GMAIL.COM", "AQAAAAEAACcQAAAAEBy9GXTTSnMOwLBMthrsv/ynnOPccMpuLFetll1au0sRoNGTFjyXEkP2gqknWHsrCw==", null, false, "6d0f975b-75c5-4d98-aca8-b14c4fc2d8c7", false, "pqh.cntt@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f9119d57-0edd-48bc-ab81-673ba41e0078", "386f7392-871f-4f05-9366-88b4169488c6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09ec502a-22b7-42d0-ba0b-79c9ed6754e7", "cba56991-4ec3-4fad-be08-cbdcaf3982ad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f9119d57-0edd-48bc-ab81-673ba41e0078", "386f7392-871f-4f05-9366-88b4169488c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09ec502a-22b7-42d0-ba0b-79c9ed6754e7", "cba56991-4ec3-4fad-be08-cbdcaf3982ad" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09ec502a-22b7-42d0-ba0b-79c9ed6754e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9119d57-0edd-48bc-ab81-673ba41e0078");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "386f7392-871f-4f05-9366-88b4169488c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba56991-4ec3-4fad-be08-cbdcaf3982ad");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61b2c913-f480-41d3-a6f1-f379e2b8a11f", "a703d63e-cb50-4508-88e6-deed2773471a", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0d657f6-7a63-4352-bc82-1680af90a365", "fc1375c4-b7e9-4614-9157-6537605cc1c2", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0d9a1b5f-3b04-434c-9a17-15b0f1538aee", 0, "c8ab481b-18dc-4306-970d-a49fb7edb567", "admin@gmail.com", false, false, null, "ABC@GMAIL.COM", "ABC@GMAIL.COM", "AQAAAAEAACcQAAAAEICr0R8x5sPWDxe27Js3GVG593zAzPbjZSS9V1QzlVTMfLZbb2xsYSOgiVFWuTz7MA==", null, false, "f3abb4bc-80f0-4a06-8440-09ce9470140b", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "76d04124-4d1a-4d0c-9add-92bf73cd05e2", 0, "784155e5-beeb-4c3e-afc7-74a8d5e7a376", "admin@gmail.com", false, false, null, "PQH.CNTT@GMAIL.COM", "PQH.CNTT@GMAIL.COM", "AQAAAAEAACcQAAAAEAvuIwRUXvtj0fzddzb9Ncpd99qODY9Qj2UEXQ92HjUPpGfxBWyTa3Pj3xw7+ZWkVg==", null, false, "0973ffc3-31c2-435a-a5ee-ff57cd39a9a8", false, "pqh.cntt@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c0d657f6-7a63-4352-bc82-1680af90a365", "0d9a1b5f-3b04-434c-9a17-15b0f1538aee" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "61b2c913-f480-41d3-a6f1-f379e2b8a11f", "76d04124-4d1a-4d0c-9add-92bf73cd05e2" });
        }
    }
}
