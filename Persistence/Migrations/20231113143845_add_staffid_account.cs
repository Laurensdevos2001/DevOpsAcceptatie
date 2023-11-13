using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oogarts.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_staffid_account : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Accounts");
        }
    }
}
