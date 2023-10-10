using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityAPIWorkshop.Data.Migrations
{
    /// <inheritdoc />
    public partial class addnickname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nick",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nick",
                table: "AspNetUsers");
        }
    }
}
