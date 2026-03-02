using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StepWise.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FollowedAt",
                table: "UserCareerPaths",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 2, 27, 14, 54, 14, 698, DateTimeKind.Utc).AddTicks(6204),
                comment: "When the user bookmarked this career path",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 7, 28, 14, 35, 22, 497, DateTimeKind.Utc).AddTicks(6982),
                oldComment: "When the user bookmarked this career path");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc2184a7-2b84-4f22-917c-da171971ac6d", "AQAAAAIAAYagAAAAEDczdKK7ly6aM3Rx56//9Q0LVN4B8qn22eX+JJm+fYpK+ojK++vScp7qocqQG6im6w==", "faa5bc00-a26a-4438-9873-792be921abd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cbc3746-09be-4653-a1ad-b99a028da346", "AQAAAAIAAYagAAAAEDO48V3cqy5qvreLXFTrXK/56TDzj5aMRctWOGrFa5oGp5njIEjCxbn72dEan7DJNQ==", "274f901c-5a12-4b9d-a682-bd75918e42fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a92d0391-0d18-4570-8cfb-aead31d44fd2", "AQAAAAIAAYagAAAAEK+ReF/japDaGyRsXZVZOnnzjuWxQkDquYszlOqXdnzspc1tvMnHQ4xo56xohsMLHg==", "e506bcc7-44cd-4c6c-898f-dfee710ca85c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0a7b690-b383-4102-acbf-25e6ee2c9ebc", "AQAAAAIAAYagAAAAEDLX5blCQoY0OvzxLHwfsYe8ZjFXBtOmMQZKq+SJfQ/FBymxJq13kTRDRgn44ZbFBg==", "47ce5ec6-3192-4706-95c5-71fa8d861078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c85965e-105d-4277-8176-79ec19676c34", "AQAAAAIAAYagAAAAEMC9wKK1IClJi8E1P+sFbxGqv8Ho1QsYzlHEny4s07gKYAKNy/E+aE5hi6Ss5t6dFg==", "15cd452c-37cc-45f3-8750-f911bc830912" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8494fd89-a96d-4c3f-bdf7-749a45bae417", "AQAAAAIAAYagAAAAEGKgCDhA+yVEP/SEwsvGHSTRAum+WsXPg0OW/bhIjtfjf2flZYh82NOr0uZ1Mlxnuw==", "99496512-4ecd-46ec-8c8a-14c56b871907" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FollowedAt",
                table: "UserCareerPaths",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 7, 28, 14, 35, 22, 497, DateTimeKind.Utc).AddTicks(6982),
                comment: "When the user bookmarked this career path",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 2, 27, 14, 54, 14, 698, DateTimeKind.Utc).AddTicks(6204),
                oldComment: "When the user bookmarked this career path");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aa837cb-48a8-47b4-8e0e-74c57fa25b0f", "AQAAAAIAAYagAAAAEEPkMvXWLwFS24sCFleJRp7/Hdzd2aAJrQzbhJgVDOywM9B5WmFQqbL/ifNQaOwJzQ==", "d7931b28-c96a-4164-afff-c138ed8a3ac1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6731bd9a-a68f-4412-a576-c9c6895d51bc", "AQAAAAIAAYagAAAAEHyNyZ76meR0IvzAaMqT1ELUOsG7qM2Hg73cuYlq29lbXyKno8zoZ1FLKqXkPhUXKw==", "3cdec087-5442-4470-a782-44f84f2d3d8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a805a90-9fea-4649-aa34-ce53a0a19786", "AQAAAAIAAYagAAAAECCQ9ZxY9XZwI2Cl4H0dsmz4wv+kfMf2jjTOFzScftwEVn/ao1n3Pe6/5uVDNKJfoA==", "61695034-2191-4293-97ed-060d9d7f13c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78471f08-f570-4440-bec9-cec8cae3e518", "AQAAAAIAAYagAAAAEDiTVHX619tWWTH2saUQ07aebnKLGNenS3JoPHjmjSzUDEGlOY55wmVI11cROZFm4Q==", "751b4972-5450-4877-97bd-378bc4131473" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc5cc232-a41f-4f36-b44b-60188aeba142", "AQAAAAIAAYagAAAAEOXJ5db/wMrKoXHvM5XV4KWY9cZ2dux0/XjkpsoRoFZ+sT2mLtbKH1/3pqeTelR0+A==", "56d1c07d-3793-4632-8c36-1f69c21d3b1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f940be7-54ed-4a92-b74b-35460fc293d9", "AQAAAAIAAYagAAAAEIhr4hr1AumOgqN2gIOhlTZ1dtLHVi7UtBIZK7QSGATMm5QO7ef8NMlKGmk0tFi//Q==", "37ecccb7-8076-4eea-8cf9-52047c7c06c9" });
        }
    }
}
