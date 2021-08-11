using Microsoft.EntityFrameworkCore.Migrations;

namespace SWN.Data.Migrations
{
    public partial class CharacterSkillAddSkillName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SkillName",
                table: "CharactersSkills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillName",
                table: "CharactersSkills");
        }
    }
}
