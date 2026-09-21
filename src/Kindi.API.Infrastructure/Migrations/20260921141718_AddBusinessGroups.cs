using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kindi.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBusinessGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BusinessGroupCode = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    BusinessFieldId = table.Column<Guid>(type: "uuid", nullable: true),
                    BusinessFieldName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    CoverImageUrl = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    RequiresApproval = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    MembersCount = table.Column<int>(type: "integer", nullable: false),
                    PostsCount = table.Column<int>(type: "integer", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessGroups_BusinessFields_BusinessFieldId",
                        column: x => x.BusinessFieldId,
                        principalTable: "BusinessFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_BusinessGroups_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "BusinessGroupMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BusinessGroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Zalo = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Note = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    IsGuestAccount = table.Column<bool>(type: "boolean", nullable: false),
                    JoinedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ApprovedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ApprovedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    RejectionReason = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessGroupMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessGroupMembers_BusinessGroups_BusinessGroupId",
                        column: x => x.BusinessGroupId,
                        principalTable: "BusinessGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessGroupMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessGroupPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BusinessGroupPostCode = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    BusinessGroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Content = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    RefId = table.Column<Guid>(type: "uuid", nullable: true),
                    RefCode = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    IsPrivateToAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    IsPinned = table.Column<bool>(type: "boolean", nullable: false),
                    IsHidden = table.Column<bool>(type: "boolean", nullable: false),
                    CommentsCount = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessGroupPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessGroupPosts_BusinessGroups_BusinessGroupId",
                        column: x => x.BusinessGroupId,
                        principalTable: "BusinessGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessGroupPosts_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessGroupComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BusinessGroupPostId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    ParentCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsHidden = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessGroupComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessGroupComments_BusinessGroupComments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "BusinessGroupComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessGroupComments_BusinessGroupPosts_BusinessGroupPostId",
                        column: x => x.BusinessGroupPostId,
                        principalTable: "BusinessGroupPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessGroupComments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroupComments_BusinessGroupPostId_CreatedAt",
                table: "BusinessGroupComments",
                columns: new[] { "BusinessGroupPostId", "CreatedAt" });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroupComments_ParentCommentId",
                table: "BusinessGroupComments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroupComments_UserId",
                table: "BusinessGroupComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroupMembers_BusinessGroupId_UserId",
                table: "BusinessGroupMembers",
                columns: new[] { "BusinessGroupId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroupMembers_Status",
                table: "BusinessGroupMembers",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroupMembers_UserId",
                table: "BusinessGroupMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroupPosts_AuthorId",
                table: "BusinessGroupPosts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroupPosts_BusinessGroupId_CreatedAt",
                table: "BusinessGroupPosts",
                columns: new[] { "BusinessGroupId", "CreatedAt" });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroupPosts_IsPrivateToAdmin",
                table: "BusinessGroupPosts",
                column: "IsPrivateToAdmin");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroups_BusinessFieldId",
                table: "BusinessGroups",
                column: "BusinessFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroups_BusinessGroupCode",
                table: "BusinessGroups",
                column: "BusinessGroupCode",
                unique: true,
                filter: "\"BusinessGroupCode\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessGroups_CreatedByUserId",
                table: "BusinessGroups",
                column: "CreatedByUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessGroupComments");

            migrationBuilder.DropTable(
                name: "BusinessGroupMembers");

            migrationBuilder.DropTable(
                name: "BusinessGroupPosts");

            migrationBuilder.DropTable(
                name: "BusinessGroups");
        }
    }
}
