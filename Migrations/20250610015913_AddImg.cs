using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chronica.Migrations
{
    /// <inheritdoc />
    public partial class AddImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubHabilidades_Habilidade_HabilidadeTipoId",
                table: "SubHabilidades");

            migrationBuilder.RenameColumn(
                name: "HabilidadeTipoId",
                table: "SubHabilidades",
                newName: "HabilidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_SubHabilidades_HabilidadeTipoId",
                table: "SubHabilidades",
                newName: "IX_SubHabilidades_HabilidadeId");

            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "VariantesRaciais",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "SubHabilidades",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Aparencia",
                table: "Personagens",
                type: "TEXT",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Historia",
                table: "Personagens",
                type: "TEXT",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "Personagens",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Objetivos",
                table: "Personagens",
                type: "TEXT",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Personalidade",
                table: "Personagens",
                type: "TEXT",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PontosAtributo",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "Origem",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "Item",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "Classes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_SubHabilidades_Habilidade_HabilidadeId",
                table: "SubHabilidades",
                column: "HabilidadeId",
                principalTable: "Habilidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubHabilidades_Habilidade_HabilidadeId",
                table: "SubHabilidades");

            migrationBuilder.DropColumn(
                name: "ImagemURL",
                table: "VariantesRaciais");

            migrationBuilder.DropColumn(
                name: "ImagemURL",
                table: "SubHabilidades");

            migrationBuilder.DropColumn(
                name: "Aparencia",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Historia",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "ImagemURL",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Objetivos",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Personalidade",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "PontosAtributo",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "ImagemURL",
                table: "Origem");

            migrationBuilder.DropColumn(
                name: "ImagemURL",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ImagemURL",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "HabilidadeId",
                table: "SubHabilidades",
                newName: "HabilidadeTipoId");

            migrationBuilder.RenameIndex(
                name: "IX_SubHabilidades_HabilidadeId",
                table: "SubHabilidades",
                newName: "IX_SubHabilidades_HabilidadeTipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubHabilidades_Habilidade_HabilidadeTipoId",
                table: "SubHabilidades",
                column: "HabilidadeTipoId",
                principalTable: "Habilidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
