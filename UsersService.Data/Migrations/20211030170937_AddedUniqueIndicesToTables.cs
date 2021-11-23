using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersService.Data.Migrations
{
    public partial class AddedUniqueIndicesToTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VIN_RegistrationNumber",
                table: "Vehicles",
                columns: new[] { "VIN", "RegistrationNumber" },
                unique: true,
                filter: "[VIN] IS NOT NULL AND [RegistrationNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_Email_Password_Username",
                table: "Profiles",
                columns: new[] { "Email", "Password", "Username" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email_PhoneNumber",
                table: "Customers",
                columns: new[] { "Email", "PhoneNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_Name_PhoneNumber",
                table: "Businesses",
                columns: new[] { "Name", "PhoneNumber" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VIN_RegistrationNumber",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_Email_Password_Username",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Email_PhoneNumber",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Businesses_Name_PhoneNumber",
                table: "Businesses");
        }
    }
}
