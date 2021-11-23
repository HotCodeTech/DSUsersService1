using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class removedUsercategoryDependencyFromCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_UserCategories_UserCategoryId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserCategoryId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "UserCategoryId",
                table: "Customers",
                newName: "UserCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserCategory",
                table: "Customers",
                newName: "UserCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserCategoryId",
                table: "Customers",
                column: "UserCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_UserCategories_UserCategoryId",
                table: "Customers",
                column: "UserCategoryId",
                principalTable: "UserCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
