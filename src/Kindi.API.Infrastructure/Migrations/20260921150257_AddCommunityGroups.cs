using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kindi.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCommunityGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApprovalStatus",
                table: "BusinessGroups",
                type: "integer",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "RejectedReason",
                table: "BusinessGroups",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Topic",
                table: "BusinessGroups",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "BusinessGroups",
                type: "integer",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroups_ApprovalStatus",
                table: "BusinessGroups",
                column: "ApprovalStatus");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroups_Type",
                table: "BusinessGroups",
                column: "Type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BusinessGroups_ApprovalStatus",
                table: "BusinessGroups");

            migrationBuilder.DropIndex(
                name: "IX_BusinessGroups_Type",
                table: "BusinessGroups");

            migrationBuilder.DropColumn(
                name: "ApprovalStatus",
                table: "BusinessGroups");

            migrationBuilder.DropColumn(
                name: "RejectedReason",
                table: "BusinessGroups");

            migrationBuilder.DropColumn(
                name: "Topic",
                table: "BusinessGroups");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "BusinessGroups");
        }
    }
}
