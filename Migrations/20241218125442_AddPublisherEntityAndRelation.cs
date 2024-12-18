using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BledeaIuliana_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class AddPublisherEntityAndRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PublishingID",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Book",
                newName: "PublisherID");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                newName: "IX_Book_PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherID",
                table: "Book",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherID",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "PublisherID",
                table: "Book",
                newName: "PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PublisherID",
                table: "Book",
                newName: "IX_Book_PublisherId");

            migrationBuilder.AddColumn<int>(
                name: "PublishingID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id");
        }
    }
}
