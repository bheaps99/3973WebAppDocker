using Microsoft.EntityFrameworkCore;
using StudentLibrary;

namespace StudentApi.Data
{

    public class StudentsDbContext : DbContext {
    public DbSet<Student> Students { get; set; }

    public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);

        builder.Entity<Student>().HasData(
        new {
            FirstName = "Jim",
            LastName = "Potter",
            StudentId = "A01125311",
            MobileNumber="604-453-3241",
            EmailAddress = "jim.potter@bcit.ca",
            City = "Vancouver",
            Specialization = "Science"
        }, new {
            FirstName = "Jane",
            LastName = "Douglas",
            StudentId = "A01111513",
            MobileNumber="604-153-1884",
            EmailAddress = "jane.douglas@bcit.ca",
            City = "Burnaby",
            Specialization = "Arts"
        }, new {
            FirstName = "Tom",
            LastName = "Gardner",
            StudentId = "A01213451",
            MobileNumber="604-976-3231",
            EmailAddress = "tom.gardner@bcit.ca",
            City = "Surrey",
            Specialization = "Computing"
        }, new {
            FirstName = "Ann",
            LastName = "Lee",
            StudentId = "A01222311",
            MobileNumber="604-813-5511",
            EmailAddress = "ann.lee@bcit.ca",
            City = "Surrey",
            Specialization = "Computing"
        }, new {
            FirstName = "James",
            LastName = "Jones",
            StudentId = "A01131241",
            MobileNumber="604-113-4512",
            EmailAddress = "james.jones@bcit.ca",
            City = "Vancouver",
            Specialization = "Nursing"
        }, new {
            FirstName = "Susan",
            LastName = "Taylor",
            StudentId = "A01312315",
            MobileNumber="604-813-4199",
            EmailAddress = "susan.taylor@bcit.ca",
            City = "Surrey",
            Specialization = "Dental"
        }, new {
            FirstName = "Peter",
            LastName = "White",
            StudentId = "A01399311",
            MobileNumber="604-333-5555",
            EmailAddress = "peter.white@bcit.ca",
            City = "Burnaby",
            Specialization = "Computing"
        }, new {
            FirstName = "Philip",
            LastName = "Fox",
            StudentId = "A01255441",
            MobileNumber="604-813-5511",
            EmailAddress = "philip.fox@bcit.ca",
            City = "Delta",
            Specialization = "Aerospace"
        }, new {
            FirstName = "Donna",
            LastName = "Ray",
            StudentId = "A01222399",
            MobileNumber="604-813-5599",
            EmailAddress = "donna.ray@bcit.ca",
            City = "North Vancouver",
            Specialization = "Engineering"
        }
        );
    }
    }
}