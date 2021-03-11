using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxSignalR.Models
{
    public class StudentData
    {
        public static List<Student> GetStudents()
        {
            var students = new List<Student>(
                new Student[] {
                new Student(){ Id=1, Name ="Ricardo" },
                new Student() { Id=2, Name = "Antonio" }
                }
            );
            return students;
        }
    }
}