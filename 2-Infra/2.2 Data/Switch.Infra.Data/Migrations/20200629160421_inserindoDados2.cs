using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class inserindoDados2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 4,
                column: "Descricao",
                value: "EmRelacionamentoSerio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 4,
                column: "Descricao",
                value: "EmrelacionamentoSerio");
        }
    }
}
