using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daolibrary.Migrations
{
    /// <inheritdoc />
    public partial class CambioEnTodoElRepoPostPorSong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billboards_Posts_PostId",
                table: "Billboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Posts_PostId",
                table: "Reactions");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Reactions",
                newName: "SongId");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_PostId",
                table: "Reactions",
                newName: "IX_Reactions_SongId");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Comments",
                newName: "SongId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                newName: "IX_Comments_SongId");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Billboards",
                newName: "SongId");

            migrationBuilder.RenameIndex(
                name: "IX_Billboards_PostId",
                table: "Billboards",
                newName: "IX_Billboards_SongId");

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrlImage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Persons_UserId",
                        column: x => x.UserId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_UserId",
                table: "Songs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Billboards_Songs_SongId",
                table: "Billboards",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Songs_SongId",
                table: "Comments",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Songs_SongId",
                table: "Reactions",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "SongId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billboards_Songs_SongId",
                table: "Billboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Songs_SongId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Songs_SongId",
                table: "Reactions");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "Reactions",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_SongId",
                table: "Reactions",
                newName: "IX_Reactions_PostId");

            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "Comments",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_SongId",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "Billboards",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Billboards_SongId",
                table: "Billboards",
                newName: "IX_Billboards_PostId");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrlImage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Persons_UserId",
                        column: x => x.UserId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Billboards_Posts_PostId",
                table: "Billboards",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Posts_PostId",
                table: "Reactions",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId");
        }
    }
}
