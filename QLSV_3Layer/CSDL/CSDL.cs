using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3Layer
{
    class CSDL
    {
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static CSDL _Instance;
        private CSDL()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn( "StudentID", typeof(string)),
                new DataColumn( "Name", typeof(string)),
                new DataColumn( "Gender", typeof(bool)),
                new DataColumn( "DateOfBirth", typeof(DateTime)),
                new DataColumn( "ClassID", typeof(int))
            });
            DataRow dr = DTSV.NewRow();
            dr = dataStudent("102190130","VA",true,DateTime.Now,1);
            DTSV.Rows.Add(dr);

            dr = dataStudent("102190128", "VB", false, DateTime.Now, 1);
            DTSV.Rows.Add(dr);

            dr = dataStudent("103", "VC", true, DateTime.Now, 2);
            DTSV.Rows.Add(dr);

            dr = dataStudent("106", "VD", true, DateTime.Now, 1);
            DTSV.Rows.Add(dr);

            dr = dataStudent("107", "VE", false, DateTime.Now, 1);
            DTSV.Rows.Add(dr);

            DTLSH = new DataTable();
            DTLSH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ClassID", typeof(int)),
                new DataColumn("ClassName", typeof(string)),
            });

            DataRow dr1 = DTLSH.NewRow();
            dr1 = dataClass(0, "ALL");
            DTLSH.Rows.Add(dr1);

            dr1 = dataClass(1, "DT1");
            DTLSH.Rows.Add(dr1);

            dr1 = dataClass(2, "DT2");
            DTLSH.Rows.Add(dr1);

        }
        public DataRow dataClass(int ID, String Name)
        {
            DataRow dr = DTLSH.NewRow();
            dr["ClassID"] = ID;
            dr["ClassName"] = Name;
            return dr;
        }
        public DataRow dataStudent(String StuID, String Name, bool Gender, DateTime date, int ClassID)
        {
            DataRow dr7 = DTSV.NewRow();
            dr7["StudentID"] = StuID;
            dr7["Name"] = Name;
            dr7["Gender"] = Gender;
            dr7["DateOfBirth"] = date;
            dr7["ClassID"] = ClassID;
            return dr7;
        }
    }
}
