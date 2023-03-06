using Microsoft.AspNetCore.Mvc;

namespace Student.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}