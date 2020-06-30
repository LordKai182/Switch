using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Switch.Infra.Data.Migrations
{
    public partial class RelacionamentoPostagemConfigurationUsuario3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Postagem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    UrlFoto = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioGrupo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    EhAdministrador = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    GrupoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioGrupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioGrupo_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Postagem_GrupoId",
                table: "Postagem",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioGrupo_GrupoId",
                table: "UsuarioGrupo",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioGrupo_UsuarioId",
                table: "UsuarioGrupo",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagem_Grupo_GrupoId",
                table: "Postagem",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagem_Grupo_GrupoId",
                table: "Postagem");

            migrationBuilder.DropTable(
                name: "UsuarioGrupo");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropIndex(
                name: "IX_Postagem_GrupoId",
                table: "Postagem");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Postagem");
        }
    }
}
