using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VMS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    VolunteerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CentersPreferredToWork = table.Column<string>(nullable: true),
                    SkillsInterests = table.Column<string>(nullable: true),
                    AvailabilityTimes = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    HomeWorkCellPhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EducationalBackground = table.Column<string>(nullable: true),
                    CurrentLicenses = table.Column<string>(nullable: true),
                    EmergencyContactName = table.Column<string>(nullable: true),
                    EmergencyContactHomeWorkPhone = table.Column<string>(nullable: true),
                    EmergencyContactEmail = table.Column<string>(nullable: true),
                    EmergencyContactAddress = table.Column<string>(nullable: true),
                    CopyOfVolunteerDriverLicenseOnFile = table.Column<bool>(nullable: false),
                    CopyOfVolunteerSocialSecurityCardOnFile = table.Column<bool>(nullable: false),
                    ApprovalStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.VolunteerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteers");
        }
    }
}
