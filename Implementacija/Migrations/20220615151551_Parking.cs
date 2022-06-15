using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekat___Parking.Migrations
{
    public partial class Parking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankovniRacun",
                columns: table => new
                {
                    brojRacuna = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jmbgVlasnikaRacuna = table.Column<int>(type: "int", nullable: false),
                    raspolozivaSredstva = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankovniRacun", x => x.brojRacuna);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    postanskiBroj = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imeGrada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brojStanovnika = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.postanskiBroj);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    jmbg = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prezime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.jmbg);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    tabliceVozila = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tipVozila = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.tabliceVozila);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Korisnik",
                columns: table => new
                {
                    jmbg = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    vozilotabliceVozila = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    racunbrojRacuna = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.jmbg);
                    table.ForeignKey(
                        name: "FK_Korisnik_BankovniRacun_racunbrojRacuna",
                        column: x => x.racunbrojRacuna,
                        principalTable: "BankovniRacun",
                        principalColumn: "brojRacuna",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korisnik_Osoba_jmbg",
                        column: x => x.jmbg,
                        principalTable: "Osoba",
                        principalColumn: "jmbg");
                    table.ForeignKey(
                        name: "FK_Korisnik_Vozilo_vozilotabliceVozila",
                        column: x => x.vozilotabliceVozila,
                        principalTable: "Vozilo",
                        principalColumn: "tabliceVozila",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parking",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivParkinga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kapacitetParkinga = table.Column<int>(type: "int", nullable: false),
                    cijenaParkinga = table.Column<double>(type: "float", nullable: false),
                    brojZauzetihMjesta = table.Column<int>(type: "int", nullable: false),
                    brojRezervisanihMjesta = table.Column<int>(type: "int", nullable: false),
                    Vlasnik = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Grad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.id);
                    table.ForeignKey(
                        name: "FK_Parking_Grad_Grad",
                        column: x => x.Grad,
                        principalTable: "Grad",
                        principalColumn: "postanskiBroj",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Radnik",
                columns: table => new
                {
                    jmbg = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Parking = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnik", x => x.jmbg);
                    table.ForeignKey(
                        name: "FK_Radnik_Osoba_jmbg",
                        column: x => x.jmbg,
                        principalTable: "Osoba",
                        principalColumn: "jmbg");
                    table.ForeignKey(
                        name: "FK_Radnik_Parking_Parking",
                        column: x => x.Parking,
                        principalTable: "Parking",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VIPKorisnik",
                columns: table => new
                {
                    jmbg = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Parking = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPKorisnik", x => x.jmbg);
                    table.ForeignKey(
                        name: "FK_VIPKorisnik_Korisnik_jmbg",
                        column: x => x.jmbg,
                        principalTable: "Korisnik",
                        principalColumn: "jmbg");
                    table.ForeignKey(
                        name: "FK_VIPKorisnik_Parking_Parking",
                        column: x => x.Parking,
                        principalTable: "Parking",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vlasnik",
                columns: table => new
                {
                    jmbg = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Parking = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vlasnik", x => x.jmbg);
                    table.ForeignKey(
                        name: "FK_Vlasnik_Osoba_jmbg",
                        column: x => x.jmbg,
                        principalTable: "Osoba",
                        principalColumn: "jmbg");
                    table.ForeignKey(
                        name: "FK_Vlasnik_Parking_Parking",
                        column: x => x.Parking,
                        principalTable: "Parking",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_racunbrojRacuna",
                table: "Korisnik",
                column: "racunbrojRacuna");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_vozilotabliceVozila",
                table: "Korisnik",
                column: "vozilotabliceVozila");

            migrationBuilder.CreateIndex(
                name: "IX_Parking_Grad",
                table: "Parking",
                column: "Grad");

            migrationBuilder.CreateIndex(
                name: "IX_Parking_Vlasnik",
                table: "Parking",
                column: "Vlasnik");

            migrationBuilder.CreateIndex(
                name: "IX_Radnik_Parking",
                table: "Radnik",
                column: "Parking");

            migrationBuilder.CreateIndex(
                name: "IX_VIPKorisnik_Parking",
                table: "VIPKorisnik",
                column: "Parking");

            migrationBuilder.CreateIndex(
                name: "IX_Vlasnik_Parking",
                table: "Vlasnik",
                column: "Parking");

            migrationBuilder.AddForeignKey(
                name: "FK_Parking_Vlasnik_Vlasnik",
                table: "Parking",
                column: "Vlasnik",
                principalTable: "Vlasnik",
                principalColumn: "jmbg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vlasnik_Osoba_jmbg",
                table: "Vlasnik");

            migrationBuilder.DropForeignKey(
                name: "FK_Parking_Grad_Grad",
                table: "Parking");

            migrationBuilder.DropForeignKey(
                name: "FK_Parking_Vlasnik_Vlasnik",
                table: "Parking");

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
                name: "Radnik");

            migrationBuilder.DropTable(
                name: "VIPKorisnik");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "BankovniRacun");

            migrationBuilder.DropTable(
                name: "Vozilo");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Vlasnik");

            migrationBuilder.DropTable(
                name: "Parking");
        }
    }
}
