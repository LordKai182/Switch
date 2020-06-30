using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class RelacionamentoPostagemConfigurationUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Postagem",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Postagem",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400);
        }
    }
}
