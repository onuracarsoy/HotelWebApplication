using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class updatetestimonialname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimpnials",
                table: "Testimpnials");

            migrationBuilder.RenameTable(
                name: "Testimpnials",
                newName: "Testimonials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "TestimonialID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.RenameTable(
                name: "Testimonials",
                newName: "Testimpnials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimpnials",
                table: "Testimpnials",
                column: "TestimonialID");
        }
    }
}
