using Microsoft.EntityFrameworkCore.Migrations;

namespace TorBoard.Migrations.Migrations
{
    public partial class AddParentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Posts_ReplyToId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ReplyToId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "ReplyToId",
                table: "Posts",
                newName: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Posts",
                newName: "ReplyToId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ReplyToId",
                table: "Posts",
                column: "ReplyToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Posts_ReplyToId",
                table: "Posts",
                column: "ReplyToId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
