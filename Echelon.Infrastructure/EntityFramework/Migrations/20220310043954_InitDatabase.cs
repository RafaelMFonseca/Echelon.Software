using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Echelon.Infrastructure.EntityFramework.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    area = table.Column<int>(type: "INTEGER", nullable: false),
                    bedrooms = table.Column<int>(type: "INTEGER", nullable: false),
                    suites = table.Column<int>(type: "INTEGER", nullable: false),
                    bathrooms = table.Column<int>(type: "INTEGER", nullable: false),
                    parking_spaces = table.Column<int>(type: "INTEGER", nullable: false),
                    floor = table.Column<int>(type: "INTEGER", nullable: false),
                    accepts_pets = table.Column<bool>(type: "INTEGER", nullable: false),
                    has_furniture = table.Column<bool>(type: "INTEGER", nullable: false),
                    is_near_subway = table.Column<bool>(type: "INTEGER", nullable: false),
                    for_rent = table.Column<bool>(type: "INTEGER", nullable: false),
                    for_sale = table.Column<bool>(type: "INTEGER", nullable: false),
                    sale_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    rent_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    condominium_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    iptu_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    home_protection_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    tenant_service_fee_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "House");
        }
    }
}
