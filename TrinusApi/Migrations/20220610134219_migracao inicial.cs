using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrinusApi.Migrations
{
    public partial class migracaoinicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cotistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CotistaId = table.Column<int>(type: "int", nullable: false),
                    DataOperacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoOperacao = table.Column<int>(type: "int", nullable: false),
                    Cotas = table.Column<int>(type: "int", nullable: false),
                    ValorCota = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operacoes_Cotistas_CotistaId",
                        column: x => x.CotistaId,
                        principalTable: "Cotistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operacoes_CotistaId",
                table: "Operacoes",
                column: "CotistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operacoes");

            migrationBuilder.DropTable(
                name: "Cotistas");
        }
    }
}
