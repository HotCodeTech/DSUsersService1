using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class RemamedAvatatToProfilepic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_ProfilePics_AvatarId",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "AvatarId",
                table: "Profiles",
                newName: "ProfilePicId");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_AvatarId",
                table: "Profiles",
                newName: "IX_Profiles_ProfilePicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_ProfilePics_ProfilePicId",
                table: "Profiles",
                column: "ProfilePicId",
                principalTable: "ProfilePics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_ProfilePics_ProfilePicId",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "ProfilePicId",
                table: "Profiles",
                newName: "AvatarId");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_ProfilePicId",
                table: "Profiles",
                newName: "IX_Profiles_AvatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_ProfilePics_AvatarId",
                table: "Profiles",
                column: "AvatarId",
                principalTable: "ProfilePics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
