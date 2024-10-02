using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daolibrary.Migrations
{
    /// <inheritdoc />
    public partial class DAOSFileFileTypeYGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billboards_Posts_PostId",
                table: "Billboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Persons_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Reports_ReportUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_UserBans_UserBanId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Filees_FileTypes_FileTypeId",
                table: "Filees");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Filees_FileeId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Persons_UserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Persons_UserId",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Posts_PostId",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBans_Persons_UserId",
                table: "UserBans");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBans",
                table: "UserBans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reactions",
                table: "Reactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileTypes",
                table: "FileTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filees",
                table: "Filees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ReportUserId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Billboards",
                table: "Billboards");

            migrationBuilder.DropColumn(
                name: "ReportUserId",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "UserBans",
                newName: "UserBan");

            migrationBuilder.RenameTable(
                name: "Reactions",
                newName: "Reaction");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.RenameTable(
                name: "FileTypes",
                newName: "FileType");

            migrationBuilder.RenameTable(
                name: "Filees",
                newName: "Filee");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameTable(
                name: "Billboards",
                newName: "Billboard");

            migrationBuilder.RenameIndex(
                name: "IX_UserBans_UserId",
                table: "UserBan",
                newName: "IX_UserBan_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_UserId",
                table: "Reaction",
                newName: "IX_Reaction_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_PostId",
                table: "Reaction",
                newName: "IX_Reaction_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_UserId",
                table: "Post",
                newName: "IX_Post_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_FileeId",
                table: "Person",
                newName: "IX_Person_FileeId");

            migrationBuilder.RenameIndex(
                name: "IX_Filees_FileTypeId",
                table: "Filee",
                newName: "IX_Filee_FileTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comment",
                newName: "IX_Comment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserBanId",
                table: "Comment",
                newName: "IX_Comment_UserBanId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Comment",
                newName: "IX_Comment_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Billboards_PostId",
                table: "Billboard",
                newName: "IX_Billboard_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBan",
                table: "UserBan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reaction",
                table: "Reaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileType",
                table: "FileType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filee",
                table: "Filee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Billboard",
                table: "Billboard",
                column: "BillboardId");

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    genretype = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Billboard_Post_PostId",
                table: "Billboard",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Person_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_UserBan_UserBanId",
                table: "Comment",
                column: "UserBanId",
                principalTable: "UserBan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filee_FileType_FileTypeId",
                table: "Filee",
                column: "FileTypeId",
                principalTable: "FileType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Filee_FileeId",
                table: "Person",
                column: "FileeId",
                principalTable: "Filee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Person_UserId",
                table: "Post",
                column: "UserId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reaction_Person_UserId",
                table: "Reaction",
                column: "UserId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reaction_Post_PostId",
                table: "Reaction",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBan_Person_UserId",
                table: "UserBan",
                column: "UserId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billboard_Post_PostId",
                table: "Billboard");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Person_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_UserBan_UserBanId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Filee_FileType_FileTypeId",
                table: "Filee");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Filee_FileeId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Person_UserId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Reaction_Person_UserId",
                table: "Reaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Reaction_Post_PostId",
                table: "Reaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBan_Person_UserId",
                table: "UserBan");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBan",
                table: "UserBan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reaction",
                table: "Reaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileType",
                table: "FileType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filee",
                table: "Filee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Billboard",
                table: "Billboard");

            migrationBuilder.RenameTable(
                name: "UserBan",
                newName: "UserBans");

            migrationBuilder.RenameTable(
                name: "Reaction",
                newName: "Reactions");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "FileType",
                newName: "FileTypes");

            migrationBuilder.RenameTable(
                name: "Filee",
                newName: "Filees");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameTable(
                name: "Billboard",
                newName: "Billboards");

            migrationBuilder.RenameIndex(
                name: "IX_UserBan_UserId",
                table: "UserBans",
                newName: "IX_UserBans_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reaction_UserId",
                table: "Reactions",
                newName: "IX_Reactions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reaction_PostId",
                table: "Reactions",
                newName: "IX_Reactions_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_UserId",
                table: "Posts",
                newName: "IX_Posts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_FileeId",
                table: "Persons",
                newName: "IX_Persons_FileeId");

            migrationBuilder.RenameIndex(
                name: "IX_Filee_FileTypeId",
                table: "Filees",
                newName: "IX_Filees_FileTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UserBanId",
                table: "Comments",
                newName: "IX_Comments_UserBanId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostId",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Billboard_PostId",
                table: "Billboards",
                newName: "IX_Billboards_PostId");

            migrationBuilder.AddColumn<long>(
                name: "ReportUserId",
                table: "Comments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBans",
                table: "UserBans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reactions",
                table: "Reactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileTypes",
                table: "FileTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filees",
                table: "Filees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Billboards",
                table: "Billboards",
                column: "BillboardId");

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Reason = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReportStatus = table.Column<int>(type: "int", nullable: false),
                    ReportedUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Persons_ReportedUserId",
                        column: x => x.ReportedUserId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_Persons_UserId",
                        column: x => x.UserId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReportUserId",
                table: "Comments",
                column: "ReportUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportedUserId",
                table: "Reports",
                column: "ReportedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UserId",
                table: "Reports",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Billboards_Posts_PostId",
                table: "Billboards",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Persons_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Reports_ReportUserId",
                table: "Comments",
                column: "ReportUserId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_UserBans_UserBanId",
                table: "Comments",
                column: "UserBanId",
                principalTable: "UserBans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filees_FileTypes_FileTypeId",
                table: "Filees",
                column: "FileTypeId",
                principalTable: "FileTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Filees_FileeId",
                table: "Persons",
                column: "FileeId",
                principalTable: "Filees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Persons_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Persons_UserId",
                table: "Reactions",
                column: "UserId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Posts_PostId",
                table: "Reactions",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBans_Persons_UserId",
                table: "UserBans",
                column: "UserId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
