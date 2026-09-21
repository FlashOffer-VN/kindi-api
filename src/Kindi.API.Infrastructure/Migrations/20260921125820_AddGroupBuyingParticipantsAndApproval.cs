using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kindi.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupBuyingParticipantsAndApproval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedAt",
                table: "GroupBuyingRequests",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApprovedByUserId",
                table: "GroupBuyingRequests",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClosedReason",
                table: "GroupBuyingRequests",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GroupBuyingParticipants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupBuyingRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Zalo = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Note = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    IsCreator = table.Column<bool>(type: "boolean", nullable: false),
                    IsGuestAccount = table.Column<bool>(type: "boolean", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupBuyingParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupBuyingParticipants_GroupBuyingRequests_GroupBuyingRequ~",
                        column: x => x.GroupBuyingRequestId,
                        principalTable: "GroupBuyingRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupBuyingParticipants_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupBuyingParticipants_GroupBuyingRequestId_UserId",
                table: "GroupBuyingParticipants",
                columns: new[] { "GroupBuyingRequestId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GroupBuyingParticipants_UserId",
                table: "GroupBuyingParticipants",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupBuyingParticipants");

            migrationBuilder.DropColumn(
                name: "ApprovedAt",
                table: "GroupBuyingRequests");

            migrationBuilder.DropColumn(
                name: "ApprovedByUserId",
                table: "GroupBuyingRequests");

            migrationBuilder.DropColumn(
                name: "ClosedReason",
                table: "GroupBuyingRequests");
        }
    }
}
