using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapLonNhom02.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Cathi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cathis",
                columns: table => new
                {
                    MaCathi = table.Column<string>(type: "TEXT", nullable: false),
                    TenCathi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cathis", x => x.MaCathi);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cathis");
        }
    }
}
