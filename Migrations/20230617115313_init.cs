using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiketApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tikets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaktuSkrg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NamaPenumpang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomorPenumpang = table.Column<long>(type: "bigint", nullable: false),
                    Dari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HargaTiket = table.Column<int>(type: "int", nullable: false),
                    WaktuBuat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WaktuUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tikets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tikets");
        }
    }
}
