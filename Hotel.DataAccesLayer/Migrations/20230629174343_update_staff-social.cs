using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class update_staffsocial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocaialMedia13",
                table: "Staffs",
                newName: "SocaialMedia3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocaialMedia3",
                table: "Staffs",
                newName: "SocaialMedia13");
        }
    }
}
