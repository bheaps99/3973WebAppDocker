using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApi.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "City", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[,]
                {
                    { "A01125311", "Vancouver", "jim.potter@bcit.ca", "Jim", "Potter", "604-453-3241", "Science" },
                    { "A01111513", "Burnaby", "jane.douglas@bcit.ca", "Jane", "Douglas", "604-153-1884", "Arts" },
                    { "A01213451", "Surrey", "tom.gardner@bcit.ca", "Tom", "Gardner", "604-976-3231", "Computing" },
                    { "A01222311", "Surrey", "ann.lee@bcit.ca", "Ann", "Lee", "604-813-5511", "Computing" },
                    { "A01131241", "Vancouver", "james.jones@bcit.ca", "James", "Jones", "604-113-4512", "Nursing" },
                    { "A01312315", "Surrey", "susan.taylor@bcit.ca", "Susan", "Taylor", "604-813-4199", "Dental" },
                    { "A01399311", "Burnaby", "peter.white@bcit.ca", "Peter", "White", "604-333-5555", "Computing" },
                    { "A01255441", "Delta", "philip.fox@bcit.ca", "Philip", "Fox", "604-813-5511", "Aerospace" },
                    { "A01222399", "North Vancouver", "donna.ray@bcit.ca", "Donna", "Ray", "604-813-5599", "Engineering" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
