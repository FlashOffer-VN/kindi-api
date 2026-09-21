using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kindi.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMustChangeCredentialsToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MustChangeCredentials",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MustChangeCredentials",
                table: "Users");
        }
    }
}
