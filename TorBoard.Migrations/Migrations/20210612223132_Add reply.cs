using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorBoard.Migrations.Migrations
{
    public partial class Addreply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReplyToId",
                table: "Posts",
                type: "TEXT",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Posts_ReplyToId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ReplyToId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ReplyToId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
