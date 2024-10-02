using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daolibrary.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionDelRepoCompleto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Filees_FileeId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Filees");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Persons",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FileeId",
                table: "Persons",
                newName: "FileId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_FileeId",
                table: "Persons",
                newName: "IX_Persons_FileId");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Mail",
                keyValue: null,
                column: "Mail",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Persons",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Persons",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Path2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FileTypeId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_FileTypes_FileTypeId",
                        column: x => x.FileTypeId,
                        principalTable: "FileTypes",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FileTypeId",
                table: "Files",
                column: "FileTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Files_FileId",
                table: "Persons",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Files_FileId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Persons",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "FileId",
                table: "Persons",
                newName: "FileeId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_FileId",
                table: "Persons",
                newName: "IX_Persons_FileeId");

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Persons",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Filees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FileTypeId = table.Column<long>(type: "bigint", nullable: true),
                    Path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filees_FileTypes_FileTypeId",
                        column: x => x.FileTypeId,
                        principalTable: "FileTypes",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Filees_FileTypeId",
                table: "Filees",
                column: "FileTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Filees_FileeId",
                table: "Persons",
                column: "FileeId",
                principalTable: "Filees",
                principalColumn: "Id");
        }
    }
}
