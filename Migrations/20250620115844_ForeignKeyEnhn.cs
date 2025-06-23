using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BalatroWikiApp.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyEnhn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idEnhancedcard",
                table: "cards",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cards_idEnhancedcard",
                table: "cards",
                column: "idEnhancedcard");

            migrationBuilder.AddForeignKey(
                name: "FK_cards_enhancedcards_idEnhancedcard",
                table: "cards",
                column: "idEnhancedcard",
                principalTable: "enhancedcards",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cards_enhancedcards_idEnhancedcard",
                table: "cards");

            migrationBuilder.DropIndex(
                name: "IX_cards_idEnhancedcard",
                table: "cards");

            migrationBuilder.DropColumn(
                name: "idEnhancedcard",
                table: "cards");
        }
    }
}
