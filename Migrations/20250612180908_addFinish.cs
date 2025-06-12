using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chronica.Migrations
{
    /// <inheritdoc />
    public partial class addFinish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemTipo_ItemTipoId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemHabilidade_Personagens_PersonagemId",
                table: "PersonagemHabilidade");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemHabilidade_SubHabilidades_HabilidadeId",
                table: "PersonagemHabilidade");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemItem_Item_ItemId",
                table: "PersonagemItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemItem_Personagens_PersonagemId",
                table: "PersonagemItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemPericia_Pericia_PericiaId",
                table: "PersonagemPericia");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemPericia_Personagens_PersonagemId",
                table: "PersonagemPericia");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemTipoHabilidade_HabilidadeTipos_HabilidadeTipoId",
                table: "PersonagemTipoHabilidade");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemTipoHabilidade_Personagens_PersonagemId",
                table: "PersonagemTipoHabilidade");

            migrationBuilder.DropForeignKey(
                name: "FK_SubHabilidades_HabilidadeTipos_HabilidadeTipoId",
                table: "SubHabilidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubHabilidades",
                table: "SubHabilidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonagemTipoHabilidade",
                table: "PersonagemTipoHabilidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonagemPericia",
                table: "PersonagemPericia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonagemItem",
                table: "PersonagemItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonagemHabilidade",
                table: "PersonagemHabilidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemTipo",
                table: "ItemTipo");

            migrationBuilder.RenameTable(
                name: "SubHabilidades",
                newName: "Habilidades");

            migrationBuilder.RenameTable(
                name: "PersonagemTipoHabilidade",
                newName: "PersonagemTipoHabilidades");

            migrationBuilder.RenameTable(
                name: "PersonagemPericia",
                newName: "PersonagemPericias");

            migrationBuilder.RenameTable(
                name: "PersonagemItem",
                newName: "PersonagemItens");

            migrationBuilder.RenameTable(
                name: "PersonagemHabilidade",
                newName: "PersonagemHabilidades");

            migrationBuilder.RenameTable(
                name: "ItemTipo",
                newName: "ItemTipos");

            migrationBuilder.RenameColumn(
                name: "TipoAmeaca",
                table: "Personagens",
                newName: "Vulnerabilidades");

            migrationBuilder.RenameColumn(
                name: "NivelDificuldade",
                table: "Personagens",
                newName: "Resistencia");

            migrationBuilder.RenameColumn(
                name: "Jogador",
                table: "Personagens",
                newName: "Imunidade");

            migrationBuilder.RenameIndex(
                name: "IX_SubHabilidades_HabilidadeTipoId",
                table: "Habilidades",
                newName: "IX_Habilidades_HabilidadeTipoId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemTipoHabilidade_HabilidadeTipoId",
                table: "PersonagemTipoHabilidades",
                newName: "IX_PersonagemTipoHabilidades_HabilidadeTipoId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemPericia_PericiaId",
                table: "PersonagemPericias",
                newName: "IX_PersonagemPericias_PericiaId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemItem_ItemId",
                table: "PersonagemItens",
                newName: "IX_PersonagemItens_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemHabilidade_HabilidadeId",
                table: "PersonagemHabilidades",
                newName: "IX_PersonagemHabilidades_HabilidadeId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "VariantesRaciais",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "VariantesRaciais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Personalidade",
                table: "Personagens",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Objetivos",
                table: "Personagens",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Historia",
                table: "Personagens",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Aparencia",
                table: "Personagens",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Caractere",
                table: "Personagens",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Defesa",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Personagens",
                type: "TEXT",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Deslocamento",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoAmeacaId",
                table: "Personagens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Pericia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Origem",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Origem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "HabilidadeTipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Classes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Habilidades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "ItemTipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habilidades",
                table: "Habilidades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonagemTipoHabilidades",
                table: "PersonagemTipoHabilidades",
                columns: new[] { "PersonagemId", "HabilidadeTipoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonagemPericias",
                table: "PersonagemPericias",
                columns: new[] { "PersonagemId", "PericiaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonagemItens",
                table: "PersonagemItens",
                columns: new[] { "PersonagemId", "ItemId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonagemHabilidades",
                table: "PersonagemHabilidades",
                columns: new[] { "PersonagemId", "HabilidadeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemTipos",
                table: "ItemTipos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SenhaHash = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Patente = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagemURL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Campanhas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagemURL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campanhas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campanhas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Desvantagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desvantagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desvantagens_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposAmeaca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposAmeaca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposAmeaca_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vantagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vantagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vantagens_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonagemCampanhas",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    CampanhaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemCampanhas", x => new { x.PersonagemId, x.CampanhaId });
                    table.ForeignKey(
                        name: "FK_PersonagemCampanhas_Campanhas_CampanhaId",
                        column: x => x.CampanhaId,
                        principalTable: "Campanhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemCampanhas_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioCampanhas",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CampanhaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioCampanhas", x => new { x.UsuarioId, x.CampanhaId });
                    table.ForeignKey(
                        name: "FK_UsuarioCampanhas_Campanhas_CampanhaId",
                        column: x => x.CampanhaId,
                        principalTable: "Campanhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioCampanhas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonagemDesvantagens",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    DesvantagemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemDesvantagens", x => new { x.PersonagemId, x.DesvantagemId });
                    table.ForeignKey(
                        name: "FK_PersonagemDesvantagens_Desvantagens_DesvantagemId",
                        column: x => x.DesvantagemId,
                        principalTable: "Desvantagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemDesvantagens_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonagemVantagens",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    VantagemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemVantagens", x => new { x.PersonagemId, x.VantagemId });
                    table.ForeignKey(
                        name: "FK_PersonagemVantagens_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemVantagens_Vantagens_VantagemId",
                        column: x => x.VantagemId,
                        principalTable: "Vantagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_VariantesRaciais_UsuarioId",
                table: "VariantesRaciais",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_TipoAmeacaId",
                table: "Personagens",
                column: "TipoAmeacaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pericia_UsuarioId",
                table: "Pericia",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Origem_UsuarioId",
                table: "Origem",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_UsuarioId",
                table: "Item",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadeTipos_UsuarioId",
                table: "HabilidadeTipos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UsuarioId",
                table: "Classes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_UsuarioId",
                table: "Habilidades",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTipos_UsuarioId",
                table: "ItemTipos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Campanhas_UsuarioId",
                table: "Campanhas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Desvantagens_UsuarioId",
                table: "Desvantagens",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemCampanhas_CampanhaId",
                table: "PersonagemCampanhas",
                column: "CampanhaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemDesvantagens_DesvantagemId",
                table: "PersonagemDesvantagens",
                column: "DesvantagemId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemVantagens_VantagemId",
                table: "PersonagemVantagens",
                column: "VantagemId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposAmeaca_UsuarioId",
                table: "TiposAmeaca",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioCampanhas_CampanhaId",
                table: "UsuarioCampanhas",
                column: "CampanhaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vantagens_UsuarioId",
                table: "Vantagens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Usuarios_UsuarioId",
                table: "Classes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Habilidades_HabilidadeTipos_HabilidadeTipoId",
                table: "Habilidades",
                column: "HabilidadeTipoId",
                principalTable: "HabilidadeTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Habilidades_Usuarios_UsuarioId",
                table: "Habilidades",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HabilidadeTipos_Usuarios_UsuarioId",
                table: "HabilidadeTipos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemTipos_ItemTipoId",
                table: "Item",
                column: "ItemTipoId",
                principalTable: "ItemTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Usuarios_UsuarioId",
                table: "Item",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTipos_Usuarios_UsuarioId",
                table: "ItemTipos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Origem_Usuarios_UsuarioId",
                table: "Origem",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pericia_Usuarios_UsuarioId",
                table: "Pericia",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId",
                principalTable: "Habilidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                table: "PersonagemHabilidades",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemItens_Item_ItemId",
                table: "PersonagemItens",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemItens_Personagens_PersonagemId",
                table: "PersonagemItens",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemPericias_Pericia_PericiaId",
                table: "PersonagemPericias",
                column: "PericiaId",
                principalTable: "Pericia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemPericias_Personagens_PersonagemId",
                table: "PersonagemPericias",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemTipoHabilidades_HabilidadeTipos_HabilidadeTipoId",
                table: "PersonagemTipoHabilidades",
                column: "HabilidadeTipoId",
                principalTable: "HabilidadeTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemTipoHabilidades_Personagens_PersonagemId",
                table: "PersonagemTipoHabilidades",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_TiposAmeaca_TipoAmeacaId",
                table: "Personagens",
                column: "TipoAmeacaId",
                principalTable: "TiposAmeaca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VariantesRaciais_Usuarios_UsuarioId",
                table: "VariantesRaciais",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Usuarios_UsuarioId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Habilidades_HabilidadeTipos_HabilidadeTipoId",
                table: "Habilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Habilidades_Usuarios_UsuarioId",
                table: "Habilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_HabilidadeTipos_Usuarios_UsuarioId",
                table: "HabilidadeTipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemTipos_ItemTipoId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Usuarios_UsuarioId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemTipos_Usuarios_UsuarioId",
                table: "ItemTipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Origem_Usuarios_UsuarioId",
                table: "Origem");

            migrationBuilder.DropForeignKey(
                name: "FK_Pericia_Usuarios_UsuarioId",
                table: "Pericia");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                table: "PersonagemHabilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                table: "PersonagemHabilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemItens_Item_ItemId",
                table: "PersonagemItens");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemItens_Personagens_PersonagemId",
                table: "PersonagemItens");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemPericias_Pericia_PericiaId",
                table: "PersonagemPericias");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemPericias_Personagens_PersonagemId",
                table: "PersonagemPericias");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemTipoHabilidades_HabilidadeTipos_HabilidadeTipoId",
                table: "PersonagemTipoHabilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonagemTipoHabilidades_Personagens_PersonagemId",
                table: "PersonagemTipoHabilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_TiposAmeaca_TipoAmeacaId",
                table: "Personagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropForeignKey(
                name: "FK_VariantesRaciais_Usuarios_UsuarioId",
                table: "VariantesRaciais");

            migrationBuilder.DropTable(
                name: "PersonagemCampanhas");

            migrationBuilder.DropTable(
                name: "PersonagemDesvantagens");

            migrationBuilder.DropTable(
                name: "PersonagemVantagens");

            migrationBuilder.DropTable(
                name: "TiposAmeaca");

            migrationBuilder.DropTable(
                name: "UsuarioCampanhas");

            migrationBuilder.DropTable(
                name: "Desvantagens");

            migrationBuilder.DropTable(
                name: "Vantagens");

            migrationBuilder.DropTable(
                name: "Campanhas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_VariantesRaciais_UsuarioId",
                table: "VariantesRaciais");

            migrationBuilder.DropIndex(
                name: "IX_Personagens_TipoAmeacaId",
                table: "Personagens");

            migrationBuilder.DropIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropIndex(
                name: "IX_Pericia_UsuarioId",
                table: "Pericia");

            migrationBuilder.DropIndex(
                name: "IX_Origem_UsuarioId",
                table: "Origem");

            migrationBuilder.DropIndex(
                name: "IX_Item_UsuarioId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_HabilidadeTipos_UsuarioId",
                table: "HabilidadeTipos");

            migrationBuilder.DropIndex(
                name: "IX_Classes_UsuarioId",
                table: "Classes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonagemTipoHabilidades",
                table: "PersonagemTipoHabilidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonagemPericias",
                table: "PersonagemPericias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonagemItens",
                table: "PersonagemItens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonagemHabilidades",
                table: "PersonagemHabilidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemTipos",
                table: "ItemTipos");

            migrationBuilder.DropIndex(
                name: "IX_ItemTipos_UsuarioId",
                table: "ItemTipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habilidades",
                table: "Habilidades");

            migrationBuilder.DropIndex(
                name: "IX_Habilidades_UsuarioId",
                table: "Habilidades");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "VariantesRaciais");

            migrationBuilder.DropColumn(
                name: "Caractere",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Defesa",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Deslocamento",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "TipoAmeacaId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Pericia");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Origem");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "HabilidadeTipos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "ItemTipos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Habilidades");

            migrationBuilder.RenameTable(
                name: "PersonagemTipoHabilidades",
                newName: "PersonagemTipoHabilidade");

            migrationBuilder.RenameTable(
                name: "PersonagemPericias",
                newName: "PersonagemPericia");

            migrationBuilder.RenameTable(
                name: "PersonagemItens",
                newName: "PersonagemItem");

            migrationBuilder.RenameTable(
                name: "PersonagemHabilidades",
                newName: "PersonagemHabilidade");

            migrationBuilder.RenameTable(
                name: "ItemTipos",
                newName: "ItemTipo");

            migrationBuilder.RenameTable(
                name: "Habilidades",
                newName: "SubHabilidades");

            migrationBuilder.RenameColumn(
                name: "Vulnerabilidades",
                table: "Personagens",
                newName: "TipoAmeaca");

            migrationBuilder.RenameColumn(
                name: "Resistencia",
                table: "Personagens",
                newName: "NivelDificuldade");

            migrationBuilder.RenameColumn(
                name: "Imunidade",
                table: "Personagens",
                newName: "Jogador");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemTipoHabilidades_HabilidadeTipoId",
                table: "PersonagemTipoHabilidade",
                newName: "IX_PersonagemTipoHabilidade_HabilidadeTipoId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemPericias_PericiaId",
                table: "PersonagemPericia",
                newName: "IX_PersonagemPericia_PericiaId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemItens_ItemId",
                table: "PersonagemItem",
                newName: "IX_PersonagemItem_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidade",
                newName: "IX_PersonagemHabilidade_HabilidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Habilidades_HabilidadeTipoId",
                table: "SubHabilidades",
                newName: "IX_SubHabilidades_HabilidadeTipoId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "VariantesRaciais",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Personalidade",
                keyValue: null,
                column: "Personalidade",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Personalidade",
                table: "Personagens",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Objetivos",
                keyValue: null,
                column: "Objetivos",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Objetivos",
                table: "Personagens",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Historia",
                keyValue: null,
                column: "Historia",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Historia",
                table: "Personagens",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Aparencia",
                keyValue: null,
                column: "Aparencia",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Aparencia",
                table: "Personagens",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Origem",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Classes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonagemTipoHabilidade",
                table: "PersonagemTipoHabilidade",
                columns: new[] { "PersonagemId", "HabilidadeTipoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonagemPericia",
                table: "PersonagemPericia",
                columns: new[] { "PersonagemId", "PericiaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonagemItem",
                table: "PersonagemItem",
                columns: new[] { "PersonagemId", "ItemId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonagemHabilidade",
                table: "PersonagemHabilidade",
                columns: new[] { "PersonagemId", "HabilidadeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemTipo",
                table: "ItemTipo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubHabilidades",
                table: "SubHabilidades",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemTipo_ItemTipoId",
                table: "Item",
                column: "ItemTipoId",
                principalTable: "ItemTipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemHabilidade_Personagens_PersonagemId",
                table: "PersonagemHabilidade",
                column: "PersonagemId",
                principalTable: "Personagens",
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
                name: "FK_PersonagemItem_Item_ItemId",
                table: "PersonagemItem",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemItem_Personagens_PersonagemId",
                table: "PersonagemItem",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemPericia_Pericia_PericiaId",
                table: "PersonagemPericia",
                column: "PericiaId",
                principalTable: "Pericia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemPericia_Personagens_PersonagemId",
                table: "PersonagemPericia",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemTipoHabilidade_HabilidadeTipos_HabilidadeTipoId",
                table: "PersonagemTipoHabilidade",
                column: "HabilidadeTipoId",
                principalTable: "HabilidadeTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonagemTipoHabilidade_Personagens_PersonagemId",
                table: "PersonagemTipoHabilidade",
                column: "PersonagemId",
                principalTable: "Personagens",
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
    }
}
