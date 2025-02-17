using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    internal class ITIClasses
    {
        public class Student
        {
            public int ID { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }
            public int Dep_Id { get; set; }
        }

        public class Course
        {
            public int ID { get; set; }
            public int Duration { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Top_Id { get; set; }
        }
        public class Topic
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public class CourseInstructor
        {
            public int InsID { get; set; }
            public int CourseId { get; set; }
            public string Evaluate { get; set; }
        }
        public class StudentCourse
        {
            public int StudID { get; set; }
            public int CourseId { get; set; }
            public double Grade { get; set; }
        }
        public class Department
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime HiringDate { get; set; }
            public int Ins_Id { get; set; }
        }

        public class Instructor
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Bonus { get; set; }
            public int HourRate {  get; set; }
            public string Address { get; set; }
            public int Salary { get; set; }
            public int DeptID { get; set; }
        }


    }
}
