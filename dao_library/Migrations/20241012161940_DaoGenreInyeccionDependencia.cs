using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daolibrary.Migrations
{
    /// <inheritdoc />
    public partial class DaoGenreInyeccionDependencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "genretype",
                table: "Genres",
                newName: "genreType");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Genres",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Genres");

            migrationBuilder.RenameColumn(
                name: "genreType",
                table: "Genres",
                newName: "genretype");
        }
    }
}
