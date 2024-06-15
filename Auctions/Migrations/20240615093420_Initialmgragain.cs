using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auctions.Migrations
{
    /// <inheritdoc />
    public partial class Initialmgragain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bids_AspNetUsers_IdentityUser",
                table: "Bids");

            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Listings_ListingId",
                table: "Bids");

            migrationBuilder.RenameColumn(
                name: "IdentityUser",
                table: "Bids",
                newName: "IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Bids_IdentityUser",
                table: "Bids",
                newName: "IX_Bids_IdentityUserId");

            migrationBuilder.AlterColumn<int>(
                name: "ListingId",
                table: "Bids",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_AspNetUsers_IdentityUserId",
                table: "Bids",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Listings_ListingId",
                table: "Bids",
                column: "ListingId",
                principalTable: "Listings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bids_AspNetUsers_IdentityUserId",
                table: "Bids");

            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Listings_ListingId",
                table: "Bids");

            migrationBuilder.RenameColumn(
                name: "IdentityUserId",
                table: "Bids",
                newName: "IdentityUser");

            migrationBuilder.RenameIndex(
                name: "IX_Bids_IdentityUserId",
                table: "Bids",
                newName: "IX_Bids_IdentityUser");

            migrationBuilder.AlterColumn<int>(
                name: "ListingId",
                table: "Bids",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_AspNetUsers_IdentityUser",
                table: "Bids",
                column: "IdentityUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Listings_ListingId",
                table: "Bids",
                column: "ListingId",
                principalTable: "Listings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
