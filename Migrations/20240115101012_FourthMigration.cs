using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pre_emince.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactNumbers_Users_UserID",
                table: "ContactNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitOrderInstructions_Users_UserID",
                table: "DebitOrderInstructions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmploymentDetails_Users_UserID",
                table: "EmploymentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanBalances_LoanApplications_LoanID",
                table: "LoanBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_NextOfKins_Users_UserID",
                table: "NextOfKins");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Admins_AdminID",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_LoanApplications_LoanID",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_AdminID",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_LoanID",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_NextOfKins_UserID",
                table: "NextOfKins");

            migrationBuilder.DropIndex(
                name: "IX_LoanBalances_LoanID",
                table: "LoanBalances");

            migrationBuilder.DropIndex(
                name: "IX_EmploymentDetails_UserID",
                table: "EmploymentDetails");

            migrationBuilder.DropIndex(
                name: "IX_DebitOrderInstructions_UserID",
                table: "DebitOrderInstructions");

            migrationBuilder.DropIndex(
                name: "IX_ContactNumbers_UserID",
                table: "ContactNumbers");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AdminID",
                table: "Payments",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_LoanID",
                table: "Payments",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKins_UserID",
                table: "NextOfKins",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanBalances_LoanID",
                table: "LoanBalances",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentDetails_UserID",
                table: "EmploymentDetails",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_DebitOrderInstructions_UserID",
                table: "DebitOrderInstructions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactNumbers_UserID",
                table: "ContactNumbers",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactNumbers_Users_UserID",
                table: "ContactNumbers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitOrderInstructions_Users_UserID",
                table: "DebitOrderInstructions",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmploymentDetails_Users_UserID",
                table: "EmploymentDetails",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanBalances_LoanApplications_LoanID",
                table: "LoanBalances",
                column: "LoanID",
                principalTable: "LoanApplications",
                principalColumn: "LoanID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NextOfKins_Users_UserID",
                table: "NextOfKins",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Admins_AdminID",
                table: "Payments",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_LoanApplications_LoanID",
                table: "Payments",
                column: "LoanID",
                principalTable: "LoanApplications",
                principalColumn: "LoanID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
