using Microsoft.EntityFrameworkCore.Migrations;

namespace DL.Migrations
{
    public partial class BucketDBMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Bucketlists",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bucketlists_UserId",
                table: "Bucketlists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bucketlists_User_UserId",
                table: "Bucketlists",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bucketlists_User_UserId",
                table: "Bucketlists");

            migrationBuilder.DropIndex(
                name: "IX_Bucketlists_UserId",
                table: "Bucketlists");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bucketlists");
        }
    }
}
