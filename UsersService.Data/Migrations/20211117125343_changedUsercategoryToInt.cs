using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class changedUsercategoryToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_AuthLevels_AuthLevelId",
                table: "UserCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserCategories_UserCategoryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserCategoryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_UserCategories_AuthLevelId",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "UserCategoryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AuthLevelId",
                table: "UserCategories");

            migrationBuilder.AddColumn<int>(
                name: "UserCategory",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthLevel",
                table: "UserCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AuthLevels",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCategory",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AuthLevel",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AuthLevels");

            migrationBuilder.AddColumn<int>(
                name: "UserCategoryId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthLevelId",
                table: "UserCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCategoryId",
                table: "Users",
                column: "UserCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_AuthLevelId",
                table: "UserCategories",
                column: "AuthLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategories_AuthLevels_AuthLevelId",
                table: "UserCategories",
                column: "AuthLevelId",
                principalTable: "AuthLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserCategories_UserCategoryId",
                table: "Users",
                column: "UserCategoryId",
                principalTable: "UserCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
