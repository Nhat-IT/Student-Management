using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_3Layer
{
    class Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }

        public Class(DataRow clas)
        {
            this.ClassID = Convert.ToInt32(clas["ClassID"]);
            this.ClassName = clas["ClassName"].ToString();
        }

        public Class(int ID, String Name)
        {
            this.ClassID = ID;
            this.ClassName = Name;
        }
    }
}
