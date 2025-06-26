using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BalatroWikiApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "blinds",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameBlind = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    anteBlind = table.Column<int>(type: "integer", nullable: false),
                    descriptionBlind = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    effectBlind = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    rewardBlind = table.Column<int>(type: "integer", nullable: false),
                    imageBlind = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blinds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "decks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameDeck = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    descriptionDeck = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    imageDeck = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_decks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "editions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameEdition = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    effectEdition = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    imageEdition = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_editions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "enhancedcards",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameEnhanced = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    effectEnhanced = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    typeEnhanced = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    imageEnhancedcard = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enhancedcards", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hands",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameHand = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    baseChips = table.Column<int>(type: "integer", nullable: false),
                    baseMult = table.Column<int>(type: "integer", nullable: false),
                    imageHand = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "jokers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameJoker = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    numberJoker = table.Column<int>(type: "integer", nullable: false),
                    rarityJoker = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    priceJoker = table.Column<int>(type: "integer", nullable: false),
                    typeJoker = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    descriptionJoker = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    sizeJoker = table.Column<decimal>(type: "numeric(3,2)", precision: 3, scale: 2, nullable: true),
                    hasFaceJoker = table.Column<bool>(type: "boolean", nullable: false),
                    imageJoker = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jokers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "otherEffects",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    money = table.Column<int>(type: "integer", nullable: false),
                    creation = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    copy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    imageOtherEffect = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_otherEffects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "seals",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameSeal = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    effectSeal = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    typeSeal = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    imageSeal = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sticker",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameSticker = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    descriptionSticker = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    effectSticker = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    imageSticker = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sticker", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameTag = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    effectTag = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    imageTag = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameVoucher = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    descriptionVoucher = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    priceVoucher = table.Column<int>(type: "integer", nullable: false),
                    stateVoucher = table.Column<bool>(type: "boolean", nullable: false),
                    imageVoucher = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cards",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idEnhancedcard = table.Column<int>(type: "integer", nullable: true),
                    nameCard = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    familyCard = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    isEnhanced = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cards", x => x.id);
                    table.ForeignKey(
                        name: "FK_cards_enhancedcards_idEnhancedcard",
                        column: x => x.idEnhancedcard,
                        principalTable: "enhancedcards",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "consumables",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idHand = table.Column<int>(type: "integer", nullable: true),
                    nameConsumable = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    typeConsumable = table.Column<int>(type: "integer", nullable: false),
                    effectConsumable = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    imageConsumable = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumables", x => x.id);
                    table.ForeignKey(
                        name: "FK_consumables_hands_idHand",
                        column: x => x.idHand,
                        principalTable: "hands",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "boosterpack",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idJoker = table.Column<int>(type: "integer", nullable: true),
                    idTarot = table.Column<int>(type: "integer", nullable: true),
                    idSpectral = table.Column<int>(type: "integer", nullable: true),
                    idCard = table.Column<int>(type: "integer", nullable: true),
                    namePack = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    typePack = table.Column<int>(type: "integer", maxLength: 50, nullable: false),
                    numberPack = table.Column<int>(type: "integer", nullable: false),
                    numberChoices = table.Column<int>(type: "integer", nullable: false),
                    numberProposition = table.Column<int>(type: "integer", nullable: false),
                    descriptionPack = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    pricePack = table.Column<int>(type: "integer", nullable: false),
                    imageBoosterpack = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TypeBoosterpack = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boosterpack", x => x.id);
                    table.ForeignKey(
                        name: "FK_boosterpack_cards_idCard",
                        column: x => x.idCard,
                        principalTable: "cards",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_boosterpack_jokers_idJoker",
                        column: x => x.idJoker,
                        principalTable: "jokers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_boosterpack_idCard",
                table: "boosterpack",
                column: "idCard");

            migrationBuilder.CreateIndex(
                name: "IX_boosterpack_idJoker",
                table: "boosterpack",
                column: "idJoker");

            migrationBuilder.CreateIndex(
                name: "IX_cards_idEnhancedcard",
                table: "cards",
                column: "idEnhancedcard");

            migrationBuilder.CreateIndex(
                name: "IX_consumables_idHand",
                table: "consumables",
                column: "idHand",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "blinds");

            migrationBuilder.DropTable(
                name: "boosterpack");

            migrationBuilder.DropTable(
                name: "consumables");

            migrationBuilder.DropTable(
                name: "decks");

            migrationBuilder.DropTable(
                name: "editions");

            migrationBuilder.DropTable(
                name: "otherEffects");

            migrationBuilder.DropTable(
                name: "seals");

            migrationBuilder.DropTable(
                name: "sticker");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "cards");

            migrationBuilder.DropTable(
                name: "jokers");

            migrationBuilder.DropTable(
                name: "hands");

            migrationBuilder.DropTable(
                name: "enhancedcards");
        }
    }
}
