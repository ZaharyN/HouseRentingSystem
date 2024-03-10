using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98263b9b-a1ca-4fd7-9433-62359e84a1f3", "AQAAAAEAACcQAAAAEJswvaqPH3CkE0ZVUqGrJouoFa56Uludkrdv7O1/kUQNSIF+toaie9GrV2sNCQWUeg==", "acf2048e-890b-450c-b273-eb6d00087d63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a39167ec-b6df-4dac-a686-0fd4e659afed", "AQAAAAEAACcQAAAAEPDRpPNZZZAybcx4o2IZ5ka2r36DG9CVPsfCwCAcTmo03OFZ2oMCNyeygIgm8oMNeg==", "0427e8d0-8c21-40f8-9445-8f36481e739c" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d66e2143-7359-4bd2-b56d-8e4fc3cfb66f", "AQAAAAEAACcQAAAAEPgRO7+4m5RtpYMf2/UAj04SU7PqjLUZYDKqj8xTR1eEPs0xlf+d3DNYtmZSnwLF8g==", "94774af1-45ea-4eea-bba8-aa9747e47fd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf5434d9-5bb4-43aa-bfbf-0cf26f1a9568", "AQAAAAEAACcQAAAAENPQ7OG3yCBPchYGRhgaAWkLUpKqkI4WnFTl+FoXUiI/Ip/uxfvedAvOdOja+0AFTQ==", "06af815c-64e9-4cd2-93b5-a945a7086448" });
        }
    }
}
