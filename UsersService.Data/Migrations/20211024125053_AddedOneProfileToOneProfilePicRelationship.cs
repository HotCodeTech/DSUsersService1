using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class AddedOneProfileToOneProfilePicRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_ProfilePics_ProfilePicId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_ProfilePicId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "ProfilePicId",
                table: "Profiles");

            migrationBuilder.AddColumn<int>(
                name: "UserProfileId",
                table: "ProfilePics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePics_UserProfileId",
                table: "ProfilePics",
                column: "UserProfileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfilePics_Profiles_UserProfileId",
                table: "ProfilePics",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfilePics_Profiles_UserProfileId",
                table: "ProfilePics");

            migrationBuilder.DropIndex(
                name: "IX_ProfilePics_UserProfileId",
                table: "ProfilePics");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "ProfilePics");

            migrationBuilder.AddColumn<int>(
                name: "ProfilePicId",
                table: "Profiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_ProfilePicId",
                table: "Profiles",
                column: "ProfilePicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_ProfilePics_ProfilePicId",
                table: "Profiles",
                column: "ProfilePicId",
                principalTable: "ProfilePics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
