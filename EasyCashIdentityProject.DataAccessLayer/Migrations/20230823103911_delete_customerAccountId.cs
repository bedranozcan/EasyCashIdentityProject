using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class delete_customerAccountId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_CustomerAccountID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_CustomerAccountID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "CustomerAccountID",
                table: "CustomerAccountProcesses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerAccountID",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_CustomerAccountID",
                table: "CustomerAccountProcesses",
                column: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_CustomerAccountID",
                table: "CustomerAccountProcesses",
                column: "CustomerAccountID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
