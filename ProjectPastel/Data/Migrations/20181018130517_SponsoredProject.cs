using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPastel.Data.Migrations
{
    public partial class SponsoredProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllocatedStudent",
                table: "SponsoredProject");

            migrationBuilder.AddColumn<int>(
                name: "GroupPreferencesId",
                table: "SponsoredProject",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupPreferencesId1",
                table: "SponsoredProject",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupPreferencesId2",
                table: "SponsoredProject",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GroupPreferences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPreferences", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SponsoredProject_GroupPreferencesId",
                table: "SponsoredProject",
                column: "GroupPreferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsoredProject_GroupPreferencesId1",
                table: "SponsoredProject",
                column: "GroupPreferencesId1");

            migrationBuilder.CreateIndex(
                name: "IX_SponsoredProject_GroupPreferencesId2",
                table: "SponsoredProject",
                column: "GroupPreferencesId2");

            migrationBuilder.AddForeignKey(
                name: "FK_SponsoredProject_GroupPreferences_GroupPreferencesId",
                table: "SponsoredProject",
                column: "GroupPreferencesId",
                principalTable: "GroupPreferences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SponsoredProject_GroupPreferences_GroupPreferencesId1",
                table: "SponsoredProject",
                column: "GroupPreferencesId1",
                principalTable: "GroupPreferences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SponsoredProject_GroupPreferences_GroupPreferencesId2",
                table: "SponsoredProject",
                column: "GroupPreferencesId2",
                principalTable: "GroupPreferences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SponsoredProject_GroupPreferences_GroupPreferencesId",
                table: "SponsoredProject");

            migrationBuilder.DropForeignKey(
                name: "FK_SponsoredProject_GroupPreferences_GroupPreferencesId1",
                table: "SponsoredProject");

            migrationBuilder.DropForeignKey(
                name: "FK_SponsoredProject_GroupPreferences_GroupPreferencesId2",
                table: "SponsoredProject");

            migrationBuilder.DropTable(
                name: "GroupPreferences");

            migrationBuilder.DropIndex(
                name: "IX_SponsoredProject_GroupPreferencesId",
                table: "SponsoredProject");

            migrationBuilder.DropIndex(
                name: "IX_SponsoredProject_GroupPreferencesId1",
                table: "SponsoredProject");

            migrationBuilder.DropIndex(
                name: "IX_SponsoredProject_GroupPreferencesId2",
                table: "SponsoredProject");

            migrationBuilder.DropColumn(
                name: "GroupPreferencesId",
                table: "SponsoredProject");

            migrationBuilder.DropColumn(
                name: "GroupPreferencesId1",
                table: "SponsoredProject");

            migrationBuilder.DropColumn(
                name: "GroupPreferencesId2",
                table: "SponsoredProject");

            migrationBuilder.AddColumn<string>(
                name: "AllocatedStudent",
                table: "SponsoredProject",
                nullable: true);
        }
    }
}
