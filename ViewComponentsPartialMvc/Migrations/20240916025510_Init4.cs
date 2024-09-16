using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ViewComponentsPartialMvc.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Headers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Headers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MascotFurnitureImgUrl",
                table: "Headers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Headers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Headers");

            migrationBuilder.DropColumn(
                name: "MascotFurnitureImgUrl",
                table: "Headers");
        }
    }
}
