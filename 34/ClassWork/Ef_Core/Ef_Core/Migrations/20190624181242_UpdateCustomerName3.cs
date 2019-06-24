using Microsoft.EntityFrameworkCore.Migrations;

namespace Ef_Core.Migrations
{
    public partial class UpdateCustomerName3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "UQ_Customers_Name",
                schema: "dbo",
                table: "Customers",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "UQ_Customers_Name",
                schema: "dbo",
                table: "Customers");
        }
    }
}
