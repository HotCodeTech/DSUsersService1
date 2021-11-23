using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class addedVehicleDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleEntity_Customers_CustomerEntityId",
                table: "VehicleEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleEntity",
                table: "VehicleEntity");

            migrationBuilder.RenameTable(
                name: "VehicleEntity",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleEntity_CustomerEntityId",
                table: "Vehicles",
                newName: "IX_Vehicles_CustomerEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Customers_CustomerEntityId",
                table: "Vehicles",
                column: "CustomerEntityId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Customers_CustomerEntityId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "VehicleEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_CustomerEntityId",
                table: "VehicleEntity",
                newName: "IX_VehicleEntity_CustomerEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleEntity",
                table: "VehicleEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleEntity_Customers_CustomerEntityId",
                table: "VehicleEntity",
                column: "CustomerEntityId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
