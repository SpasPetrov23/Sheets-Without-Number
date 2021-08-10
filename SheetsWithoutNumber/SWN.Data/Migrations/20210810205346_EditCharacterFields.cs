using Microsoft.EntityFrameworkCore.Migrations;

namespace SWN.Data.Migrations
{
    public partial class EditCharacterFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinimumXP",
                table: "Characters",
                newName: "SavingThrowPhysical");

            migrationBuilder.RenameColumn(
                name: "MaximumXP",
                table: "Characters",
                newName: "SavingThrowMental");

            migrationBuilder.AddColumn<int>(
                name: "SavingThrowEvasion",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SavingThrowEvasion",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "SavingThrowPhysical",
                table: "Characters",
                newName: "MinimumXP");

            migrationBuilder.RenameColumn(
                name: "SavingThrowMental",
                table: "Characters",
                newName: "MaximumXP");
        }
    }
}
