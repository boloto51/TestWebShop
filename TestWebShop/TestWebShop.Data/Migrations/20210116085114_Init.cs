using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWebShop.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "goodtype",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goodtype", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "producer",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producer", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "good",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Articul = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodTypeCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProducerCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_good", x => x.Id);
                    table.ForeignKey(
                        name: "FK_good_goodtype_GoodTypeCode",
                        column: x => x.GoodTypeCode,
                        principalTable: "goodtype",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_good_producer_ProducerCode",
                        column: x => x.ProducerCode,
                        principalTable: "producer",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_good_GoodTypeCode",
                table: "good",
                column: "GoodTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_good_ProducerCode",
                table: "good",
                column: "ProducerCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "good");

            migrationBuilder.DropTable(
                name: "goodtype");

            migrationBuilder.DropTable(
                name: "producer");
        }
    }
}
