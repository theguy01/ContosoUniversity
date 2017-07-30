﻿using ContosoUnversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContosoUnversity.DAL
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student> { new Student { FirstMidName = "Carson", LastName = "Alexander",EnrollmentDate = DateTime.Parse("2005/09/01")},
                                               new Student { FirstMidName = "Meredith",LastName = "Alonso",EnrollmentDate = DateTime.Parse("2002/09/01")},
                                               new Student {FirstMidName = "Arturo",LastName = "Anand",EnrollmentDate = DateTime.Parse("2003/09/01")},
                                               new Student {FirstMidName = "Gytis",LastName = "Barzdukas",EnrollmentDate = DateTime.Parse("2002/09/01")}};
            students.ForEach(c => context.Students.Add(c));
            context.SaveChanges();
            var courses = new List<Course> { new Course { CourseID = 1050, Title = "Chemistry", Credits = 3 },
                                             new Course {CourseID = 4022,Title = "Microeconomics",Credits = 3 },
                                             new Course {CourseID = 4041,Title = "Macroeconomics",Credits = 3 },
                                             new Course {CourseID = 1045,Title = "Calculus",Credits = 4 },
                                             new Course {CourseID = 3141,Title = "Trigonometry",Credits = 4 },
                                             new Course {CourseID = 2021,Title = "Composition",Credits = 3 },
                                             new Course {CourseID = 2042,Title = "Literature",Credits = 4 }
                                            };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();
            var enrollments = new List<Enrollment> {
                                                    new Enrollment {StudentID = 1,CourseID = 1050,Grade = Grade.A },
                                                    new Enrollment {StudentID = 1,CourseID = 4022,Grade = Grade.C },
                                                    new Enrollment {StudentID = 1,CourseID = 4041,Grade = Grade.B },
                                                    new Enrollment {StudentID = 2,CourseID = 1045,Grade = Grade.A },
                                                    new Enrollment {StudentID = 2,CourseID = 3141,Grade = Grade.A },
                                                    new Enrollment {StudentID = 2,CourseID = 2021,Grade = Grade.A },
                                                    new Enrollment {StudentID = 3,CourseID = 1050 },
                                                    new Enrollment {StudentID = 4,CourseID = 1050},
                                                    new Enrollment {StudentID = 4,CourseID = 4022,Grade = Grade.F }
                                                    };
            enrollments.ForEach(c => context.Enrollments.Add(c));
            context.SaveChanges();
        }
    }
}