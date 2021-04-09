using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_3Layer.DAO
{
    class StudentDAO
    {
        private static StudentDAO instance;

        public static StudentDAO Instance {
            get
            {
                if (instance == null) instance = new StudentDAO();
                return instance;
            }
            private set { }
        }

        private StudentDAO() { }

        public List<Student> loadStudent(int s1)
        {
            List<Student> listStu = new List<Student>();
            foreach(DataRow stu in CSDL.Instance.DTSV.Rows)
            {
                if (s1 == 0)
                {
                    Student s = new Student(stu);
                    listStu.Add(s);
                }
                else if (Convert.ToInt32(stu["ClassID"]) == s1)
                {
                    Student s = new Student(stu);
                    listStu.Add(s);
                }
            }
            return listStu;
        }

        public List<String> loadNameColumn()
        {
            List<String> listString = new List<String>();
            int count = 0;
            foreach(DataColumn property in CSDL.Instance.DTSV.Columns)
            {
                String s = property.ColumnName;
                listString.Add(s);
            }
            return listString;
        }
    }
}
