using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mock.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Messages_LastMessageId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_LastMessageId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "LastMessageId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "NumResponses",
                table: "Topics");

            migrationBuilder.AddColumn<string>(
                name: "ImageProfileUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageProfileUrl",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "LastMessageId",
                table: "Topics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumResponses",
                table: "Topics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_LastMessageId",
                table: "Topics",
                column: "LastMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Messages_LastMessageId",
                table: "Topics",
                column: "LastMessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
