using Microsoft.EntityFrameworkCore.Migrations;

namespace car_rental.Migrations
{
    public partial class carrental2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarRental_Cars_CarsCarId",
                table: "CarRental");

            migrationBuilder.DropIndex(
                name: "IX_CarRental_CarsCarId",
                table: "CarRental");

            migrationBuilder.DropColumn(
                name: "CarsCarId",
                table: "CarRental");

            migrationBuilder.CreateIndex(
                name: "IX_CarRental_CarId",
                table: "CarRental",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarRental_Cars_CarId",
                table: "CarRental",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarRental_Cars_CarId",
                table: "CarRental");

            migrationBuilder.DropIndex(
                name: "IX_CarRental_CarId",
                table: "CarRental");

            migrationBuilder.AddColumn<int>(
                name: "CarsCarId",
                table: "CarRental",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarRental_CarsCarId",
                table: "CarRental",
                column: "CarsCarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarRental_Cars_CarsCarId",
                table: "CarRental",
                column: "CarsCarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
