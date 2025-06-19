using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BalatroWikiApp.Migrations
{
    /// <inheritdoc />
    public partial class FixIdAndForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_card",
                table: "boosterpack");

            migrationBuilder.DropForeignKey(
                name: "fk_joker",
                table: "boosterpack");

            migrationBuilder.DropForeignKey(
                name: "fk_spectral",
                table: "boosterpack");

            migrationBuilder.DropForeignKey(
                name: "fk_tarot",
                table: "boosterpack");

            migrationBuilder.RenameColumn(
                name: "idVoucher",
                table: "vouchers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idTarot",
                table: "tarotcard",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idTag",
                table: "tags",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idSticker",
                table: "sticker",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idSpectral",
                table: "spectralcard",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idSeal",
                table: "seals",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idPlanet",
                table: "planetcard",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idJoker",
                table: "jokers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idEnhanced",
                table: "enhancedcards",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idEdition",
                table: "editions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idDeck",
                table: "decks",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idCard",
                table: "cards",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "idBoosterpack",
                table: "boosterpack",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "fk_tarot",
                table: "boosterpack",
                newName: "IX_boosterpack_idTarot");

            migrationBuilder.RenameIndex(
                name: "fk_spectral",
                table: "boosterpack",
                newName: "IX_boosterpack_idSpectral");

            migrationBuilder.RenameIndex(
                name: "fk_joker",
                table: "boosterpack",
                newName: "IX_boosterpack_idJoker");

            migrationBuilder.RenameIndex(
                name: "fk_card",
                table: "boosterpack",
                newName: "IX_boosterpack_idCard");

            migrationBuilder.RenameColumn(
                name: "idBlind",
                table: "blinds",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "idTarot",
                table: "boosterpack",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "idSpectral",
                table: "boosterpack",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "idJoker",
                table: "boosterpack",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "idCard",
                table: "boosterpack",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_boosterpack_cards_idCard",
                table: "boosterpack",
                column: "idCard",
                principalTable: "cards",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_boosterpack_jokers_idJoker",
                table: "boosterpack",
                column: "idJoker",
                principalTable: "jokers",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_boosterpack_spectralcard_idSpectral",
                table: "boosterpack",
                column: "idSpectral",
                principalTable: "spectralcard",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_boosterpack_tarotcard_idTarot",
                table: "boosterpack",
                column: "idTarot",
                principalTable: "tarotcard",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_boosterpack_cards_idCard",
                table: "boosterpack");

            migrationBuilder.DropForeignKey(
                name: "FK_boosterpack_jokers_idJoker",
                table: "boosterpack");

            migrationBuilder.DropForeignKey(
                name: "FK_boosterpack_spectralcard_idSpectral",
                table: "boosterpack");

            migrationBuilder.DropForeignKey(
                name: "FK_boosterpack_tarotcard_idTarot",
                table: "boosterpack");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "vouchers",
                newName: "idVoucher");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tarotcard",
                newName: "idTarot");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tags",
                newName: "idTag");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "sticker",
                newName: "idSticker");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "spectralcard",
                newName: "idSpectral");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "seals",
                newName: "idSeal");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "planetcard",
                newName: "idPlanet");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "jokers",
                newName: "idJoker");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "enhancedcards",
                newName: "idEnhanced");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "editions",
                newName: "idEdition");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "decks",
                newName: "idDeck");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "cards",
                newName: "idCard");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "boosterpack",
                newName: "idBoosterpack");

            migrationBuilder.RenameIndex(
                name: "IX_boosterpack_idTarot",
                table: "boosterpack",
                newName: "fk_tarot");

            migrationBuilder.RenameIndex(
                name: "IX_boosterpack_idSpectral",
                table: "boosterpack",
                newName: "fk_spectral");

            migrationBuilder.RenameIndex(
                name: "IX_boosterpack_idJoker",
                table: "boosterpack",
                newName: "fk_joker");

            migrationBuilder.RenameIndex(
                name: "IX_boosterpack_idCard",
                table: "boosterpack",
                newName: "fk_card");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "blinds",
                newName: "idBlind");

            migrationBuilder.AlterColumn<int>(
                name: "idTarot",
                table: "boosterpack",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idSpectral",
                table: "boosterpack",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idJoker",
                table: "boosterpack",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idCard",
                table: "boosterpack",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_card",
                table: "boosterpack",
                column: "idCard",
                principalTable: "cards",
                principalColumn: "idCard");

            migrationBuilder.AddForeignKey(
                name: "fk_joker",
                table: "boosterpack",
                column: "idJoker",
                principalTable: "jokers",
                principalColumn: "idJoker");

            migrationBuilder.AddForeignKey(
                name: "fk_spectral",
                table: "boosterpack",
                column: "idSpectral",
                principalTable: "spectralcard",
                principalColumn: "idSpectral");

            migrationBuilder.AddForeignKey(
                name: "fk_tarot",
                table: "boosterpack",
                column: "idTarot",
                principalTable: "tarotcard",
                principalColumn: "idTarot");
        }
    }
}
