using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class RelacionamentoPostagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Postagem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Postagem_UsuarioId",
                table: "Postagem",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagem_Usuarios_UsuarioId",
                table: "Postagem",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagem_Usuarios_UsuarioId",
                table: "Postagem");

            migrationBuilder.DropIndex(
                name: "IX_Postagem_UsuarioId",
                table: "Postagem");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Postagem");
        }
    }
}
