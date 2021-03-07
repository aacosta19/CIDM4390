using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryCart.Migrations
{
    public partial class InitialCreateTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustID = table.Column<string>(type: "TEXT", nullable: false),
                    CustPassword = table.Column<string>(type: "TEXT", nullable: false),
                    CustName = table.Column<string>(type: "TEXT", nullable: false),
                    CustAddress = table.Column<string>(type: "TEXT", nullable: false),
                    CustEmail = table.Column<string>(type: "TEXT", nullable: false),
                    CustPhone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    StoreID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shopper",
                columns: table => new
                {
                    ShopperID = table.Column<string>(type: "TEXT", nullable: false),
                    ShopperPassword = table.Column<string>(type: "TEXT", nullable: false),
                    ShopperName = table.Column<string>(type: "TEXT", nullable: false),
                    ShopperPhone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopper", x => x.ShopperID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Shopper");
        }
    }
}
