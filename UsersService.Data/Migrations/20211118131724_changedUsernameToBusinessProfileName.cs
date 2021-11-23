using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class changedUsernameToBusinessProfileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "BusinessProfiles",
                newName: "BusinessProfileName");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessProfiles_Email_Password_Username",
                table: "BusinessProfiles",
                newName: "IX_BusinessProfiles_Email_Password_BusinessProfileName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BusinessProfileName",
                table: "BusinessProfiles",
                newName: "Username");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessProfiles_Email_Password_BusinessProfileName",
                table: "BusinessProfiles",
                newName: "IX_BusinessProfiles_Email_Password_Username");
        }
    }
}
