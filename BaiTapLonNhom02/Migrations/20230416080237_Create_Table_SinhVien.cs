using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTapLonNhom02.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_SinhVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    MaSV = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    TenSV = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    MaNhom = table.Column<string>(type: "TEXT", nullable: true),
                    MaCathi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_SinhViens_Cathis_MaCathi",
                        column: x => x.MaCathi,
                        principalTable: "Cathis",
                        principalColumn: "MaCathi");
                    table.ForeignKey(
                        name: "FK_SinhViens_Nhoms_MaNhom",
                        column: x => x.MaNhom,
                        principalTable: "Nhoms",
                        principalColumn: "MaNhom");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_MaCathi",
                table: "SinhViens",
                column: "MaCathi");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_MaNhom",
                table: "SinhViens",
                column: "MaNhom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhViens");
        }
    }
}
