using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chronica.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarSchemaModelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemHabilidade_Habilidade_HabilidadeTipoId",
                table: "PersonagemHabilidade");

            migrationBuilder.DropForeignKey(
                name: "FK_SubHabilidades_Habilidade_HabilidadeId",
                table: "SubHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidade");

            migrationBuilder.DropTable(
                name: "PersonagemSubHabilidade");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "HabilidadeId",
                table: "SubHabilidades",
                newName: "HabilidadeTipoId");

            migrationBuilder.RenameIndex(
                name: "IX_SubHabilidades_HabilidadeId",
                table: "SubHabilidades",
                newName: "IX_SubHabilidades_HabilidadeTipoId");

            migrationBuilder.RenameColumn(
                name: "HabilidadeTipoId",
                table: "PersonagemHabilidade",
                newName: "HabilidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemHabilidade_HabilidadeTipoId",
                table: "PersonagemHabilidade",
                newName: "IX_PersonagemHabilidade_HabilidadeId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "SubHabilidades",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Pericia",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Atributo",
                table: "Pericia",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Item",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ItemTipoId",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HabilidadeTipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadeTipos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemTipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTipo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonagemTipoHabilidade",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeTipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemTipoHabilidade", x => new { x.PersonagemId, x.HabilidadeTipoId });
                    table.ForeignKey(
                        name: "FK_PersonagemTipoHabilidade_HabilidadeTipos_HabilidadeTipoId",
                        column: x => x.HabilidadeTipoId,
                        principalTable: "HabilidadeTipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemTipoHabilidade_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemTipoId",
                table: "Item",
                column: "ItemTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemTipoHabilidade_HabilidadeTipoId",
                table: "PersonagemTipoHabilidade",
                column: "HabilidadeTipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemTipo_ItemTipoId",
                table: "Item",
                column: "ItemTipoId",
                principalTable: "ItemTipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemHabilidade_SubHabilidades_HabilidadeId",
                table: "PersonagemHabilidade",
                column: "HabilidadeId",
                principalTable: "SubHabilidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubHabilidades_HabilidadeTipos_HabilidadeTipoId",
                table: "SubHabilidades",
                column: "HabilidadeTipoId",
                principalTable: "HabilidadeTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemTipo_ItemTipoId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemHabilidade_SubHabilidades_HabilidadeId",
                table: "PersonagemHabilidade");

            migrationBuilder.DropForeignKey(
                name: "FK_SubHabilidades_HabilidadeTipos_HabilidadeTipoId",
                table: "SubHabilidades");

            migrationBuilder.DropTable(
                name: "ItemTipo");

            migrationBuilder.DropTable(
                name: "PersonagemTipoHabilidade");

            migrationBuilder.DropTable(
                name: "HabilidadeTipos");

            migrationBuilder.DropIndex(
                name: "IX_Item_ItemTipoId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Atributo",
                table: "Pericia");

            migrationBuilder.DropColumn(
                name: "ItemTipoId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "HabilidadeTipoId",
                table: "SubHabilidades",
                newName: "HabilidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_SubHabilidades_HabilidadeTipoId",
                table: "SubHabilidades",
                newName: "IX_SubHabilidades_HabilidadeId");

            migrationBuilder.RenameColumn(
                name: "HabilidadeId",
                table: "PersonagemHabilidade",
                newName: "HabilidadeTipoId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemHabilidade_HabilidadeId",
                table: "PersonagemHabilidade",
                newName: "IX_PersonagemHabilidade_HabilidadeTipoId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "SubHabilidades",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Pericia",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Item",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Item",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Habilidade",
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
                    table.PrimaryKey("PK_Habilidade", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonagemSubHabilidade",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    SubHabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemSubHabilidade", x => new { x.PersonagemId, x.SubHabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemSubHabilidade_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemSubHabilidade_SubHabilidades_SubHabilidadeId",
                        column: x => x.SubHabilidadeId,
                        principalTable: "SubHabilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemSubHabilidade_SubHabilidadeId",
                table: "PersonagemSubHabilidade",
                column: "SubHabilidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemHabilidade_Habilidade_HabilidadeTipoId",
                table: "PersonagemHabilidade",
                column: "HabilidadeTipoId",
                principalTable: "Habilidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubHabilidades_Habilidade_HabilidadeId",
                table: "SubHabilidades",
                column: "HabilidadeId",
                principalTable: "Habilidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
