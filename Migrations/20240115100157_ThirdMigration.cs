using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pre_emince.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankDetails_Users_UserID",
                table: "BankDetails");

            migrationBuilder.DropIndex(
                name: "IX_BankDetails_UserID",
                table: "BankDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BankDetails_UserID",
                table: "BankDetails",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_Users_UserID",
                table: "BankDetails",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
