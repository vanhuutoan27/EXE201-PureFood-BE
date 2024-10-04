using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCreatedAtOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Orders",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Orders",
                newName: "createdAt");
        }
    }
}
