using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapLonNhom02.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Nhom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nhoms",
                columns: table => new
                {
                    MaNhom = table.Column<string>(type: "TEXT", nullable: false),
                    TenNhom = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhoms", x => x.MaNhom);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nhoms");
        }
    }
}
