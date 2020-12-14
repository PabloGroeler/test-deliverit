using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test_deliverit.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    ValorOriginal = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorCorrigido = table.Column<decimal>(type: "numeric", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DiasAtraso = table.Column<int>(type: "integer", nullable: false),
                    PercentualMulta = table.Column<decimal>(type: "numeric", nullable: false),
                    PercentualJuroDia = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItems");
        }
    }
}
