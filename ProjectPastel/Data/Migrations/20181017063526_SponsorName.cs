using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPastel.Data.Migrations
{
    public partial class SponsorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SponsorName",
                table: "SponsoredProject",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SponsorName",
                table: "SponsoredProject");
        }
    }
}
