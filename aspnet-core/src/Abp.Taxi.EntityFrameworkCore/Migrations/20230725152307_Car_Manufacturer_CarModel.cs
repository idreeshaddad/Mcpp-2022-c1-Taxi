using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abp.Taxi.Migrations
{
    /// <inheritdoc />
    public partial class CarManufacturerCarModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppManufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppManufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppCarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCarModels_AppManufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "AppManufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelType = table.Column<int>(type: "int", nullable: false),
                    CarModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCars_AppCarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "AppCarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppCarModels_ManufacturerId",
                table: "AppCarModels",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCars_CarModelId",
                table: "AppCars",
                column: "CarModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCars");

            migrationBuilder.DropTable(
                name: "AppCarModels");

            migrationBuilder.DropTable(
                name: "AppManufacturers");
        }
    }
}
