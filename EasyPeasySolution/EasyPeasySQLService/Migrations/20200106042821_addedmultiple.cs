using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyPeasySQLService.Migrations
{
    public partial class addedmultiple : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fax_Number",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fax_Prefix",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneMobile_Number",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneMobile_Prefix",
                table: "Addresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Fax_Number",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Fax_Prefix",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PhoneMobile_Number",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PhoneMobile_Prefix",
                table: "Addresses");
        }
    }
}
