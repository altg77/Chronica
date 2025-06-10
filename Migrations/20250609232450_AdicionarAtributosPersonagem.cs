using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chronica.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarAtributosPersonagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_ClaOuFamilias_ClaOuFamiliaId",
                table: "Personagens");

            migrationBuilder.DropTable(
                name: "ClaOuFamilias");

            migrationBuilder.RenameColumn(
                name: "ClaOuFamiliaId",
                table: "Personagens",
                newName: "OrigemId");

            migrationBuilder.RenameIndex(
                name: "IX_Personagens_ClaOuFamiliaId",
                table: "Personagens",
                newName: "IX_Personagens_OrigemId");

            migrationBuilder.AddColumn<int>(
                name: "Agilidade",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Carisma",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Constituicao",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Espirito",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Forca",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intelecto",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vida",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Origem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origem", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_Origem_OrigemId",
                table: "Personagens",
                column: "OrigemId",
                principalTable: "Origem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_Origem_OrigemId",
                table: "Personagens");

            migrationBuilder.DropTable(
                name: "Origem");

            migrationBuilder.DropColumn(
                name: "Agilidade",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Carisma",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Constituicao",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Espirito",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Forca",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Intelecto",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vida",
                table: "Personagens");

            migrationBuilder.RenameColumn(
                name: "OrigemId",
                table: "Personagens",
                newName: "ClaOuFamiliaId");

            migrationBuilder.RenameIndex(
                name: "IX_Personagens_OrigemId",
                table: "Personagens",
                newName: "IX_Personagens_ClaOuFamiliaId");

            migrationBuilder.CreateTable(
                name: "ClaOuFamilias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaOuFamilias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_ClaOuFamilias_ClaOuFamiliaId",
                table: "Personagens",
                column: "ClaOuFamiliaId",
                principalTable: "ClaOuFamilias",
                principalColumn: "Id");
        }
    }
}
