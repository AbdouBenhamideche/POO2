using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_POO2.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationVinDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Civilite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "OEnologues",
                columns: table => new
                {
                    IdOEnologue = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Civilite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OEnologues", x => x.IdOEnologue);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    IdPerformance = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TauxReconnaissance = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.IdPerformance);
                });

            migrationBuilder.CreateTable(
                name: "ProprietaireVignobles",
                columns: table => new
                {
                    IdProprietaire = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Civilite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProprietaireVignobles", x => x.IdProprietaire);
                });

            migrationBuilder.CreateTable(
                name: "Qualites",
                columns: table => new
                {
                    IdQualite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valeur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualites", x => x.IdQualite);
                });

            migrationBuilder.CreateTable(
                name: "Terrains",
                columns: table => new
                {
                    _idTerrain = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _surface = table.Column<float>(type: "real", nullable: false),
                    _emplacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emplacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surface = table.Column<float>(type: "real", nullable: false),
                    VerifierTerrain = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terrains", x => x._idTerrain);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    IdUtilisateur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeNaissance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Civilite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.IdUtilisateur);
                });

            migrationBuilder.CreateTable(
                name: "VinBlancs",
                columns: table => new
                {
                    IdVinBlanc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Concentration = table.Column<float>(type: "real", nullable: false),
                    IntensitéArômes = table.Column<float>(type: "real", nullable: false),
                    Alcohol = table.Column<double>(type: "float", nullable: false),
                    Sulphates = table.Column<double>(type: "float", nullable: false),
                    CitricAcid = table.Column<double>(type: "float", nullable: false),
                    VolatileAcidity = table.Column<double>(type: "float", nullable: false),
                    Quality = table.Column<int>(type: "int", nullable: false),
                    QualiteIdQualite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinBlancs", x => x.IdVinBlanc);
                    table.ForeignKey(
                        name: "FK_VinBlancs_Qualites_QualiteIdQualite",
                        column: x => x.QualiteIdQualite,
                        principalTable: "Qualites",
                        principalColumn: "IdQualite",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VinMousseuxes",
                columns: table => new
                {
                    IdVinMousseux = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantiteDioxydeDeCarbone = table.Column<float>(type: "real", nullable: false),
                    PressionGazCarbonique = table.Column<float>(type: "real", nullable: false),
                    Alcohol = table.Column<double>(type: "float", nullable: false),
                    Sulphates = table.Column<double>(type: "float", nullable: false),
                    CitricAcid = table.Column<double>(type: "float", nullable: false),
                    VolatileAcidity = table.Column<double>(type: "float", nullable: false),
                    Quality = table.Column<int>(type: "int", nullable: false),
                    QualiteIdQualite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinMousseuxes", x => x.IdVinMousseux);
                    table.ForeignKey(
                        name: "FK_VinMousseuxes_Qualites_QualiteIdQualite",
                        column: x => x.QualiteIdQualite,
                        principalTable: "Qualites",
                        principalColumn: "IdQualite",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VinRoses",
                columns: table => new
                {
                    IdVinRose = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Arôme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alcohol = table.Column<double>(type: "float", nullable: false),
                    Sulphates = table.Column<double>(type: "float", nullable: false),
                    CitricAcid = table.Column<double>(type: "float", nullable: false),
                    VolatileAcidity = table.Column<double>(type: "float", nullable: false),
                    Quality = table.Column<int>(type: "int", nullable: false),
                    QualiteIdQualite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinRoses", x => x.IdVinRose);
                    table.ForeignKey(
                        name: "FK_VinRoses_Qualites_QualiteIdQualite",
                        column: x => x.QualiteIdQualite,
                        principalTable: "Qualites",
                        principalColumn: "IdQualite",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VinRouges",
                columns: table => new
                {
                    IdVinRouge = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cépage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alcohol = table.Column<double>(type: "float", nullable: false),
                    Sulphates = table.Column<double>(type: "float", nullable: false),
                    CitricAcid = table.Column<double>(type: "float", nullable: false),
                    VolatileAcidity = table.Column<double>(type: "float", nullable: false),
                    Quality = table.Column<int>(type: "int", nullable: false),
                    QualiteIdQualite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinRouges", x => x.IdVinRouge);
                    table.ForeignKey(
                        name: "FK_VinRouges_Qualites_QualiteIdQualite",
                        column: x => x.QualiteIdQualite,
                        principalTable: "Qualites",
                        principalColumn: "IdQualite",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vins",
                columns: table => new
                {
                    _idVin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualityIdQualite = table.Column<int>(type: "int", nullable: false),
                    IdVin = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alcohol = table.Column<float>(type: "real", nullable: false),
                    CitricAcid = table.Column<float>(type: "real", nullable: false),
                    Sulphates = table.Column<float>(type: "real", nullable: false),
                    VolatileAcidity = table.Column<float>(type: "real", nullable: false),
                    Qualite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vins", x => x._idVin);
                    
                });

            migrationBuilder.CreateTable(
                name: "Vignobles",
                columns: table => new
                {
                    _idVignoble = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _surface = table.Column<float>(type: "real", nullable: false),
                    _emplacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _idTerrain = table.Column<int>(type: "int", nullable: false),
                    _terrain_idTerrain = table.Column<int>(type: "int", nullable: false),
                    _idProprietaireVignoble = table.Column<int>(type: "int", nullable: false),
                    _proprietaireVignobleIdProprietaire = table.Column<int>(type: "int", nullable: false),
                    IdVignoble = table.Column<int>(type: "int", nullable: false),
                    Surface = table.Column<float>(type: "real", nullable: false),
                    Emplacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTerrain = table.Column<int>(type: "int", nullable: false),
                    IdProprietaireVignoble = table.Column<int>(type: "int", nullable: false),
                    VerifierVignoble = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vignobles", x => x._idVignoble);
                    table.ForeignKey(
                        name: "FK_Vignobles_ProprietaireVignobles__proprietaireVignobleIdProprietaire",
                        column: x => x._proprietaireVignobleIdProprietaire,
                        principalTable: "ProprietaireVignobles",
                        principalColumn: "IdProprietaire",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vignobles_Terrains__terrain_idTerrain",
                        column: x => x._terrain_idTerrain,
                        principalTable: "Terrains",
                        principalColumn: "_idTerrain",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vin_idVin = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.IdTest);
                    table.ForeignKey(
                        name: "FK_Tests_Vins_Vin_idVin",
                        column: x => x.Vin_idVin,
                        principalTable: "Vins",
                        principalColumn: "_idVin");
                });

            migrationBuilder.CreateTable(
                name: "TestVins",
                columns: table => new
                {
                    IdTestVin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTest = table.Column<int>(type: "int", nullable: false),
                    IdVin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestVins", x => x.IdTestVin);
                    table.ForeignKey(
                        name: "FK_TestVins_Tests_IdTest",
                        column: x => x.IdTest,
                        principalTable: "Tests",
                        principalColumn: "IdTest",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestVins_Vins_IdVin",
                        column: x => x.IdVin,
                        principalTable: "Vins",
                        principalColumn: "_idVin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Qualites",
                columns: new[] { "IdQualite", "Valeur" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 6 },
                    { 3, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_Vin_idVin",
                table: "Tests",
                column: "Vin_idVin");

            migrationBuilder.CreateIndex(
                name: "IX_TestVins_IdTest",
                table: "TestVins",
                column: "IdTest");

            migrationBuilder.CreateIndex(
                name: "IX_TestVins_IdVin",
                table: "TestVins",
                column: "IdVin");

            migrationBuilder.CreateIndex(
                name: "IX_Vignobles__proprietaireVignobleIdProprietaire",
                table: "Vignobles",
                column: "_proprietaireVignobleIdProprietaire");

            migrationBuilder.CreateIndex(
                name: "IX_Vignobles__terrain_idTerrain",
                table: "Vignobles",
                column: "_terrain_idTerrain");

            migrationBuilder.CreateIndex(
                name: "IX_VinBlancs_QualiteIdQualite",
                table: "VinBlancs",
                column: "QualiteIdQualite");

            migrationBuilder.CreateIndex(
                name: "IX_VinMousseuxes_QualiteIdQualite",
                table: "VinMousseuxes",
                column: "QualiteIdQualite");

            migrationBuilder.CreateIndex(
                name: "IX_VinRoses_QualiteIdQualite",
                table: "VinRoses",
                column: "QualiteIdQualite");

            migrationBuilder.CreateIndex(
                name: "IX_VinRouges_QualiteIdQualite",
                table: "VinRouges",
                column: "QualiteIdQualite");

            migrationBuilder.CreateIndex(
                name: "IX_Vins_QualityIdQualite",
                table: "Vins",
                column: "QualityIdQualite");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "OEnologues");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "TestVins");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Vignobles");

            migrationBuilder.DropTable(
                name: "VinBlancs");

            migrationBuilder.DropTable(
                name: "VinMousseuxes");

            migrationBuilder.DropTable(
                name: "VinRoses");

            migrationBuilder.DropTable(
                name: "VinRouges");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "ProprietaireVignobles");

            migrationBuilder.DropTable(
                name: "Terrains");

            migrationBuilder.DropTable(
                name: "Vins");

            migrationBuilder.DropTable(
                name: "Qualites");
        }
    }
}
