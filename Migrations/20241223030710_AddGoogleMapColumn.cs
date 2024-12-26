using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookBookWebSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddGoogleMapColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleMap",
                table: "Restaurants",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleMap",
                table: "Restaurants");
        }
    }
}
