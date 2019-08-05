using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandCircusUniversity.Models;

namespace GrandCircusUniversity.Data
{
    public class DbInitializer
    {
        public static void Initialize(GrandCircusUniversityContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student { ID= 1, FirstName = "Hanna", LastName = "Green", Address = "150 Rock rd", PhoneNumber = "3128121332", Email = "hgreen@gcu.edu", Password = "P@$$w0rd" },
                new Student { ID= 2,FirstName = "Jordie", LastName = "Dang", Address = "232 Aspen rd", PhoneNumber = "3138029845", Email = "jdang@gcu.edu", Password = "P@$$w0rd" },
                new Student { ID= 3,FirstName = "Tom", LastName = "Handling", Address = "8099 Hillside rd", PhoneNumber = "6188720085", Email = "thandling@gcu.edu", Password = "P@$$w0rd" },
                new Student { ID= 4,FirstName = "Jamie", LastName = "Miller", Address = "51st st", PhoneNumber = "3127543232", Email = "jmiller@gcu.edu", Password = "P@$$w0rd" }
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=100,Name="Chemistry",Category="Natural Science"},
            new Course{CourseID=200,Name="Mathmatics",Category="Math"},
            new Course{CourseID=300,Name="Computer Programming",Category="Technology"},
            new Course{CourseID=400,Name="Electrical Engineering",Category="Technology"},
            new Course{CourseID=500,Name="Walking",Category="Physical Education"},
            new Course{CourseID=600,Name="English",Category= "Arts and Literature"},
            new Course{CourseID=700,Name="African American Studies",Category= "Arts and Literature"}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=100,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=400,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=500,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=100,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=300,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=200,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=100},
            new Enrollment{StudentID=4,CourseID=700},
            new Enrollment{StudentID=4,CourseID=400,Grade=Grade.F},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
