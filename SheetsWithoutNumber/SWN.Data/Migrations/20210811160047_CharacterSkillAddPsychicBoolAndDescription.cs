using Microsoft.EntityFrameworkCore.Migrations;

namespace SWN.Data.Migrations
{
    public partial class CharacterSkillAddPsychicBoolAndDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSkillPsychic",
                table: "CharactersSkills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SkillDescription",
                table: "CharactersSkills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSkillPsychic",
                table: "CharactersSkills");

            migrationBuilder.DropColumn(
                name: "SkillDescription",
                table: "CharactersSkills");
        }
    }
}
