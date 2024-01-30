using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pre_emince.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanApplications_Admins_AdminID",
                table: "LoanApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanApplications_DebitOrderInstructions_InstructionID",
                table: "LoanApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanApplications_Users_UserID",
                table: "LoanApplications");

            migrationBuilder.DropIndex(
                name: "IX_LoanApplications_AdminID",
                table: "LoanApplications");

            migrationBuilder.DropIndex(
                name: "IX_LoanApplications_InstructionID",
                table: "LoanApplications");

            migrationBuilder.DropIndex(
                name: "IX_LoanApplications_UserID",
                table: "LoanApplications");

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "LoanApplications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "LoanApplications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplications_AdminID",
                table: "LoanApplications",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplications_InstructionID",
                table: "LoanApplications",
                column: "InstructionID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplications_UserID",
                table: "LoanApplications",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanApplications_Admins_AdminID",
                table: "LoanApplications",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanApplications_DebitOrderInstructions_InstructionID",
                table: "LoanApplications",
                column: "InstructionID",
                principalTable: "DebitOrderInstructions",
                principalColumn: "InstructionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanApplications_Users_UserID",
                table: "LoanApplications",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
