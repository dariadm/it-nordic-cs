using Microsoft.EntityFrameworkCore.Migrations;

namespace Ef_Core.Migrations
{
    public partial class UpdateCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "UQ_Customers_Name",
                schema: "dbo",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Name",
                schema: "dbo",
                table: "Customers",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_Name",
                schema: "dbo",
                table: "Customers");

            migrationBuilder.AddUniqueConstraint(
                name: "UQ_Customers_Name",
                schema: "dbo",
                table: "Customers",
                column: "Name");
        }
    }
}
