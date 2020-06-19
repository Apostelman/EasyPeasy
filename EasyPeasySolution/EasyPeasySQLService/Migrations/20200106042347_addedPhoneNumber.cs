using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyPeasySQLService.Migrations
{
    public partial class addedPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneLandline_Number",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneLandline_Prefix",
                table: "Addresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneLandline_Number",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PhoneLandline_Prefix",
                table: "Addresses");
        }
    }
}
