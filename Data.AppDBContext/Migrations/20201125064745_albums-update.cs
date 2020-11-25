using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.AppDBContext.Migrations
{
    public partial class albumsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlbumId",
                table: "Performers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Performers_AlbumId",
                table: "Performers",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performers_Albums_AlbumId",
                table: "Performers",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performers_Albums_AlbumId",
                table: "Performers");

            migrationBuilder.DropIndex(
                name: "IX_Performers_AlbumId",
                table: "Performers");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Performers");
        }
    }
}
