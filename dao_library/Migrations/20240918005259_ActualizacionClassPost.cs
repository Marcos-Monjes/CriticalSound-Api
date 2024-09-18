using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daolibrary.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionClassPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "Posts",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Tittle",
                table: "Posts",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Posts",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Posts",
                newName: "Tittle");
        }
    }
}
