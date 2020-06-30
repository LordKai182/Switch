using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Switch.Infra.Data.Migrations
{
    public partial class RelacionamentoDBdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagem_Grupos_GrupoId",
                table: "Postagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Postagem_Usuarios_UsuarioId",
                table: "Postagem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postagem",
                table: "Postagem");

            migrationBuilder.RenameTable(
                name: "Postagem",
                newName: "Postagens");

            migrationBuilder.RenameIndex(
                name: "IX_Postagem_UsuarioId",
                table: "Postagens",
                newName: "IX_Postagens_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Postagem_GrupoId",
                table: "Postagens",
                newName: "IX_Postagens_GrupoId");

            migrationBuilder.AddColumn<int>(
                name: "ProcurandoPorId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusRelacionamentoId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlConteudo",
                table: "Postagens",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postagens",
                table: "Postagens",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Amigos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false),
                    UsuarioAmigoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigos", x => new { x.UsuarioId, x.UsuarioAmigoId });
                    table.ForeignKey(
                        name: "FK_Amigos_Usuarios_UsuarioAmigoId",
                        column: x => x.UsuarioAmigoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Amigos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataPublicacao = table.Column<DateTime>(nullable: false),
                    Texto = table.Column<string>(maxLength: 600, nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstituicoesEnsino",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    AnoFormacao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicoesEnsino", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstituicoesEnsino_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocaisTrabalho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    DataAdmissao = table.Column<DateTime>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: true),
                    EmpresaAtual = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocaisTrabalho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocaisTrabalho_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcurandoPor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurandoPor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusRelacionamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusRelacionamento", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ProcurandoPorId",
                table: "Usuarios",
                column: "ProcurandoPorId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_StatusRelacionamentoId",
                table: "Usuarios",
                column: "StatusRelacionamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Amigos_UsuarioAmigoId",
                table: "Amigos",
                column: "UsuarioAmigoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstituicoesEnsino_UsuarioId",
                table: "InstituicoesEnsino",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_LocaisTrabalho_UsuarioId",
                table: "LocaisTrabalho",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_ProcurandoPor_ProcurandoPorId",
                table: "Usuarios",
                column: "ProcurandoPorId",
                principalTable: "ProcurandoPor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_StatusRelacionamento_StatusRelacionamentoId",
                table: "Usuarios",
                column: "StatusRelacionamentoId",
                principalTable: "StatusRelacionamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_ProcurandoPor_ProcurandoPorId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_StatusRelacionamento_StatusRelacionamentoId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Amigos");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "InstituicoesEnsino");

            migrationBuilder.DropTable(
                name: "LocaisTrabalho");

            migrationBuilder.DropTable(
                name: "ProcurandoPor");

            migrationBuilder.DropTable(
                name: "StatusRelacionamento");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ProcurandoPorId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_StatusRelacionamentoId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postagens",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "ProcurandoPorId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "StatusRelacionamentoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UrlConteudo",
                table: "Postagens");

            migrationBuilder.RenameTable(
                name: "Postagens",
                newName: "Postagem");

            migrationBuilder.RenameIndex(
                name: "IX_Postagens_UsuarioId",
                table: "Postagem",
                newName: "IX_Postagem_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagem",
                newName: "IX_Postagem_GrupoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postagem",
                table: "Postagem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagem_Grupos_GrupoId",
                table: "Postagem",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postagem_Usuarios_UsuarioId",
                table: "Postagem",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
