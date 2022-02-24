using Microsoft.EntityFrameworkCore.Migrations;

namespace car_rental.Migrations
{
    public partial class carrental3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pesel",
                table: "Rental");

            migrationBuilder.AddColumn<string>(
                name: "AddressEmail",
                table: "Rental",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressEmail",
                table: "Rental");

            migrationBuilder.AddColumn<int>(
                name: "Pesel",
                table: "Rental",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
