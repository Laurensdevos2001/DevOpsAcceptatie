using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oogarts.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_desc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Staffs");
        }
    }
}
