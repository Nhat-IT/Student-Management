using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_3Layer
{
    class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ClassID { get; set; }

        public Student(DataRow student)
        {
            this.StudentID = student["StudentID"].ToString();
            this.Name = student["Name"].ToString();
            this.DateOfBirth = Convert.ToDateTime(student["DateOfBirth"]);
            this.Gender = Convert.ToBoolean(student["Gender"]);
            this.ClassID = Convert.ToInt32(student["ClassID"]);
        }

        public Student(String StuID,String Name,bool Gender,DateTime date,int ClassID)
        {
            this.StudentID = StuID;
            this.Name = Name;
            this.Gender = Gender;
            this.DateOfBirth = date;
            this.ClassID = ClassID;
        }
    }
}
