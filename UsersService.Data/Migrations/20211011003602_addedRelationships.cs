using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class addedRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_Addresses_BusinessAddressId",
                table: "Businesses");

            migrationBuilder.RenameColumn(
                name: "BusinessAddressId",
                table: "Businesses",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Businesses_BusinessAddressId",
                table: "Businesses",
                newName: "IX_Businesses_AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Businesses_Addresses_AddressId",
                table: "Businesses",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_Addresses_AddressId",
                table: "Businesses");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Businesses",
                newName: "BusinessAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Businesses_AddressId",
                table: "Businesses",
                newName: "IX_Businesses_BusinessAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Businesses_Addresses_BusinessAddressId",
                table: "Businesses",
                column: "BusinessAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
