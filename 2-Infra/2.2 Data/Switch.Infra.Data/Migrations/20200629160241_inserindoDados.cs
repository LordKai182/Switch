using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class inserindoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProcurandoPor",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "NaoDefinido" },
                    { 2, "Namoro" },
                    { 3, "Amizade" },
                    { 4, "RelacionamentoSerio" }
                });

            migrationBuilder.InsertData(
                table: "StatusRelacionamento",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "NaoDefinido" },
                    { 2, "Solteiro" },
                    { 3, "Casado" },
                    { 4, "EmrelacionamentoSerio" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProcurandoPor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProcurandoPor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProcurandoPor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProcurandoPor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
