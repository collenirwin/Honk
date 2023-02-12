using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Honk.Server.Migrations;

public partial class Friends2 : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "ProfilePhotoPath",
            table: "AspNetUsers",
            type: "text",
            nullable: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "ProfilePhotoPath",
            table: "AspNetUsers");
    }
}
