using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4_Entity_v4.Migrations
{
    public partial class takeoutExtraaccessory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraAccessory",
                table: "UserWorkouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExtraAccessory",
                table: "UserWorkouts",
                nullable: true);
        }
    }
}
