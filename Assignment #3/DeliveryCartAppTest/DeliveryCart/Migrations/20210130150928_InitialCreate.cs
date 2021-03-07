using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryCart.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Driver_ShopperID",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "Order",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "ShopperID",
                table: "Order",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Shopper_ShopperID",
                table: "Order",
                column: "ShopperID",
                principalTable: "Shopper",
                principalColumn: "ShopperID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Shopper_ShopperID",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "ShopperID",
                table: "Order",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "Order",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "ShopperID");

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    TempId1 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.UniqueConstraint("AK_Driver_TempId1", x => x.TempId1);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Driver_ShopperID",
                table: "Order",
                column: "ShopperID",
                principalTable: "Driver",
                principalColumn: "TempId1",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
