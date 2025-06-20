using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BalatroWikiApp.Migrations
{
    /// <inheritdoc />
    public partial class NumberJoker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numberJoker",
                table: "jokers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numberJoker",
                table: "jokers");
        }
    }
}
