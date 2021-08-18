
namespace SWN.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class CharacterTableBioColumnAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Characters");
        }
    }
}
