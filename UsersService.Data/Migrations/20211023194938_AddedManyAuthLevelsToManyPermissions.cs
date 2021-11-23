using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class AddedManyAuthLevelsToManyPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_AuthLevels_AuthorizationLevelEntityId",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_AuthorizationLevelEntityId",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "AuthorizationLevelEntityId",
                table: "Permissions");

            migrationBuilder.CreateTable(
                name: "AuthorizationLevelEntityPermissionEntity",
                columns: table => new
                {
                    AuthLevelsId = table.Column<int>(type: "int", nullable: false),
                    PermissionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationLevelEntityPermissionEntity", x => new { x.AuthLevelsId, x.PermissionsId });
                    table.ForeignKey(
                        name: "FK_AuthorizationLevelEntityPermissionEntity_AuthLevels_AuthLevelsId",
                        column: x => x.AuthLevelsId,
                        principalTable: "AuthLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorizationLevelEntityPermissionEntity_Permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationLevelEntityPermissionEntity_PermissionsId",
                table: "AuthorizationLevelEntityPermissionEntity",
                column: "PermissionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorizationLevelEntityPermissionEntity");

            migrationBuilder.AddColumn<int>(
                name: "AuthorizationLevelEntityId",
                table: "Permissions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_AuthorizationLevelEntityId",
                table: "Permissions",
                column: "AuthorizationLevelEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_AuthLevels_AuthorizationLevelEntityId",
                table: "Permissions",
                column: "AuthorizationLevelEntityId",
                principalTable: "AuthLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
