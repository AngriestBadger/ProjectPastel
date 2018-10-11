using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPastel.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SponsoredProject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Contacts = table.Column<string>(nullable: true),
                    InScope = table.Column<string>(nullable: true),
                    OutOfScope = table.Column<string>(nullable: true),
                    SkillRequirements = table.Column<string>(nullable: true),
                    RelatedProjects = table.Column<string>(nullable: true),
                    TeamSize = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    AllocatedStudent = table.Column<string>(nullable: true),
                    IsAllocated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsoredProject", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SponsoredProject");
        }
    }
}
