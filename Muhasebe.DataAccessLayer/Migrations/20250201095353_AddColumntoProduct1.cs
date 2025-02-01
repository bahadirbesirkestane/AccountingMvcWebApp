using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muhasebe.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddColumntoProduct1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ProductStatus",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductStatus",
                table: "Products");
        }
    }
}
