using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Switch.Infra.Data.Migrations
{
    public partial class RelacionamentoPostagemConfigurationUsuario4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioGrupo_UsuarioId",
                table: "UsuarioGrupo");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UsuarioGrupo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo",
                columns: new[] { "UsuarioId", "GrupoId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UsuarioGrupo",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioGrupo_UsuarioId",
                table: "UsuarioGrupo",
                column: "UsuarioId");
        }
    }
}
