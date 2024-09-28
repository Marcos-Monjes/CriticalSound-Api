using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daolibrary.Migrations
{
    /// <inheritdoc />
    public partial class DaosInyeccionDepYconeccionBDlogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FileeId",
                table: "Persons",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_FileeId",
                table: "Persons",
                column: "FileeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Filees_FileeId",
                table: "Persons",
                column: "FileeId",
                principalTable: "Filees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Filees_FileeId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_FileeId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "FileeId",
                table: "Persons");
        }
    }
}
