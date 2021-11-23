using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class RemovedCustomerFromUserCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_Customers_CustomerId",
                table: "UserCategories");

            migrationBuilder.DropIndex(
                name: "IX_UserCategories_CustomerId",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "UserCategories");

            migrationBuilder.AddColumn<int>(
                name: "UserCategoryId",
                table: "Customers",
                type: "int",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_UserCategories_UserCategoryId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserCategoryId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserCategoryId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "UserCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_CustomerId",
                table: "UserCategories",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategories_Customers_CustomerId",
                table: "UserCategories",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
