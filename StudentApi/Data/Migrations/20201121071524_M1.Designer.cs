// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentApi.Data;

namespace StudentApi.Data.Migrations
{
    [DbContext(typeof(StudentsDbContext))]
    [Migration("20201121071524_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("StudentApi.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = "A01125311",
                            City = "Vancouver",
                            EmailAddress = "jim.potter@bcit.ca",
                            FirstName = "Jim",
                            LastName = "Potter",
                            MobileNumber = "604-453-3241",
                            Specialization = "Science"
                        },
                        new
                        {
                            StudentId = "A01111513",
                            City = "Burnaby",
                            EmailAddress = "jane.douglas@bcit.ca",
                            FirstName = "Jane",
                            LastName = "Douglas",
                            MobileNumber = "604-153-1884",
                            Specialization = "Arts"
                        },
                        new
                        {
                            StudentId = "A01213451",
                            City = "Surrey",
                            EmailAddress = "tom.gardner@bcit.ca",
                            FirstName = "Tom",
                            LastName = "Gardner",
                            MobileNumber = "604-976-3231",
                            Specialization = "Computing"
                        },
                        new
                        {
                            StudentId = "A01222311",
                            City = "Surrey",
                            EmailAddress = "ann.lee@bcit.ca",
                            FirstName = "Ann",
                            LastName = "Lee",
                            MobileNumber = "604-813-5511",
                            Specialization = "Computing"
                        },
                        new
                        {
                            StudentId = "A01131241",
                            City = "Vancouver",
                            EmailAddress = "james.jones@bcit.ca",
                            FirstName = "James",
                            LastName = "Jones",
                            MobileNumber = "604-113-4512",
                            Specialization = "Nursing"
                        },
                        new
                        {
                            StudentId = "A01312315",
                            City = "Surrey",
                            EmailAddress = "susan.taylor@bcit.ca",
                            FirstName = "Susan",
                            LastName = "Taylor",
                            MobileNumber = "604-813-4199",
                            Specialization = "Dental"
                        },
                        new
                        {
                            StudentId = "A01399311",
                            City = "Burnaby",
                            EmailAddress = "peter.white@bcit.ca",
                            FirstName = "Peter",
                            LastName = "White",
                            MobileNumber = "604-333-5555",
                            Specialization = "Computing"
                        },
                        new
                        {
                            StudentId = "A01255441",
                            City = "Delta",
                            EmailAddress = "philip.fox@bcit.ca",
                            FirstName = "Philip",
                            LastName = "Fox",
                            MobileNumber = "604-813-5511",
                            Specialization = "Aerospace"
                        },
                        new
                        {
                            StudentId = "A01222399",
                            City = "North Vancouver",
                            EmailAddress = "donna.ray@bcit.ca",
                            FirstName = "Donna",
                            LastName = "Ray",
                            MobileNumber = "604-813-5599",
                            Specialization = "Engineering"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
