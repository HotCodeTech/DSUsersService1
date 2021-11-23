using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class AddedOneCustomerToMAnyProfileManyCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Profiles_UserProfileId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_UserCategories_UserCategoryId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserCategoryId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserProfileId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserCategoryId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "UserCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_CustomerId",
                table: "UserCategories",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Customers_CustomerId",
                table: "Profiles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategories_Customers_CustomerId",
                table: "UserCategories",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Customers_CustomerId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_Customers_CustomerId",
                table: "UserCategories");

            migrationBuilder.DropIndex(
                name: "IX_UserCategories_CustomerId",
                table: "UserCategories");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Profiles");

            migrationBuilder.AddColumn<int>(
                name: "UserCategoryId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserProfileId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserCategoryId",
                table: "Customers",
                column: "UserCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserProfileId",
                table: "Customers",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Profiles_UserProfileId",
                table: "Customers",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_UserCategories_UserCategoryId",
                table: "Customers",
                column: "UserCategoryId",
                principalTable: "UserCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
