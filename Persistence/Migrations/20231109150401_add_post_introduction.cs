using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oogarts.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_post_introduction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "Posts");
        }
    }
}
