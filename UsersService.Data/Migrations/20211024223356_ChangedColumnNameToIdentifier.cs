using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class ChangedColumnNameToIdentifier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserIdentifier",
                table: "Customers",
                newName: "Identifier");

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "UserCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "ProfilePics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "Businesses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "AuthLevels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "ProfilePics");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "AuthLevels");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "Identifier",
                table: "Customers",
                newName: "UserIdentifier");
        }
    }
}
