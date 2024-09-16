using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ViewComponentsPartialMvc.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLink",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacebookLink",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Informations",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LinkedinLink",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TwitterLink",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YoutubeLink",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLink",
                table: "Footers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Footers");

            migrationBuilder.DropColumn(
                name: "FacebookLink",
                table: "Footers");

            migrationBuilder.DropColumn(
                name: "Informations",
                table: "Footers");

            migrationBuilder.DropColumn(
                name: "LinkedinLink",
                table: "Footers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Footers");

            migrationBuilder.DropColumn(
                name: "TwitterLink",
                table: "Footers");

            migrationBuilder.DropColumn(
                name: "YoutubeLink",
                table: "Footers");
        }
    }
}
